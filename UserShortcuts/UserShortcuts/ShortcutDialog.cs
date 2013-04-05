namespace UserShortcuts
{
    using System;
    using System.Collections.Generic;
    using Gtk;

    public partial class ShortcutDialog : Gtk.Dialog
    {
        private string actionConflict;
        private TreeStore treeStore1;
        private UIManager uiManager;

        public ShortcutDialog(UIManager uiManager)
        {
            this.Build();
            this.uiManager = uiManager;
            MyAccelMap.AccelMapChanges.Clear();
            this.SetupTreeView();
        }

        private enum Column : int
        {
            Action = 0, 
            Shortcut = 1,
            AccelPath = 2, 
            AccelKey = 3,
            AccelMods = 4
        }

        private void CancelChanges()
        {
            try
            {
                MyAccelMap.UndoChanges();
            } 
            catch (Exception ex)
            {
                this.ShowErrorMessage(ex.Message);
            }
        }

        private bool GetActionByAccel(TreeModel model, TreePath path, TreeIter iter, uint accelKey, Gdk.ModifierType accelMods)
        {
            var rowAccelKey = (uint)model.GetValue(iter, (int)Column.AccelKey);
            var rowAccelMods = (Gdk.ModifierType)model.GetValue(iter, (int)Column.AccelMods);
            
            if (rowAccelKey == accelKey && rowAccelMods == accelMods)
            {
                this.actionConflict = (string)model.GetValue(iter, (int)Column.Action);
                return true;
            }
            
            return false;
        }

        private bool GetActionConflict(uint accelKey, Gdk.ModifierType accelMods)
        {
            this.actionConflict = null;
            this.treeview1.Model.Foreach((model, path, iter) => this.GetActionByAccel(model, path, iter, accelKey, accelMods));
            
            if (this.actionConflict != null)
            {
                return true;
            }
            
            return false;
        }
        
        private void OnAccelCleared(object o, AccelClearedArgs args)
        {
            Gtk.TreeIter iter;
            Gtk.TreeStore store = (Gtk.TreeStore)this.treeview1.Model;
            store.GetIter(out iter, new TreePath(args.PathString));
            string accelPath = (string)store.GetValue(iter, (int)Column.AccelPath);

            if (!MyAccelMap.ChangeEntry(accelPath, 0, 0, false))
            {
                this.ShowErrorMessage("Removing shortcut failed.");
            }
        }

        private void OnAccelEdited(object o, AccelEditedArgs args)
        {
            Gtk.TreeIter iter;
            Gtk.TreeStore store;
            store = (Gtk.TreeStore)this.treeview1.Model;
            store.GetIter(out iter, new TreePath(args.PathString));
            string accelPath = (string)store.GetValue(iter, (int)Column.AccelPath);
            uint accelKey = args.AccelKey;
            Gdk.ModifierType accelMods = args.AccelMods;
            
            if (Gtk.Accelerator.Valid(accelKey, accelMods))
            {
                if (MyAccelMap.ChangeEntry(accelPath, accelKey, accelMods, false))
                {
                    this.treeview1.Model.Foreach((model, path, treeiter) => this.UpdateModelChangedAccelerators(model, path, treeiter, accelPath, accelKey, accelMods));
                } 
                else if (this.ReassignShortcutOk(accelKey, accelMods))
                {
                    if (MyAccelMap.ChangeEntry(accelPath, accelKey, accelMods, true))
                    {
                        this.treeview1.Model.Foreach((model, path, treeiter) => this.UpdateModelChangedAccelerators(model, path, treeiter, accelPath, accelKey, accelMods));
                    } 
                    else
                    {
                        this.ShowErrorMessage("Changing shortcut failed.");
                    }
                }
            }
            else
            {
                this.StartOrContinueAccelEditing(new Gtk.TreePath(args.PathString));
                return;
            }
        }

        private void OnButtonCancelClicked(object sender, EventArgs e)
        {
            this.CancelChanges();
            this.Destroy();
        }

        private void OnButtonOkClicked(object sender, EventArgs e)
        {
            MyAccelMap.SaveChanges();
            this.Destroy();
        }

        [GLib.ConnectBefore]
        private void OnButtonPress(object o, ButtonPressEventArgs args)
        {
            TreePath path;
            if (!args.Event.Window.Equals(this.treeview1.BinWindow))
            {
                return;
            }
            
            if (this.treeview1.GetPathAtPos((int)args.Event.X, (int)args.Event.Y, out path))
            {
                this.StartOrContinueAccelEditing(path);
            }                
        }

        private void OnButtonRestoreDefaultShortcutsClicked(object sender, EventArgs e)
        {
            MyAccelMap.LoadDefaultShortcuts();
            this.treeview1.Model.Foreach((model, path, treeiter) => this.UpdateModelDefaultAccelerators(model, path, treeiter));
        }

        private void OnDeleteEvent(object o, DeleteEventArgs args)
        {
            this.CancelChanges();
        }

        private void OnRowActivated(object o, RowActivatedArgs args)
        {
            this.StartOrContinueAccelEditing(args.Path);
        }

        private bool ReassignShortcutOk(uint accelKey, Gdk.ModifierType accelMods)
        {
            if (!this.GetActionConflict(accelKey, accelMods))
            {
                return false;
            }
            
            string shortcut = Gtk.Accelerator.GetLabel(accelKey, accelMods);
            string text = string.Format("Shortcut <b>\"{0}\"</b> is already taken by <b>\"{1}\"</b>. ", shortcut, this.actionConflict);
            text += string.Format("Reassigning the shortcut will remove it from <b>\"{0}\"</b>.", this.actionConflict);

            var dialog = new MessageDialog(
                this, 
                DialogFlags.DestroyWithParent, 
                MessageType.Question, 
                ButtonsType.OkCancel, 
                true,
                text);

            dialog.SecondaryText = "Would you like to reassign this shortcut?";

            var result = (ResponseType)dialog.Run();
            dialog.Destroy();

            if (result == ResponseType.Ok)
            {
                return true;
            }

            return false;
        }

        private void SetupTreeView()
        {
            {
                var column = new TreeViewColumn();
                var cell = new CellRendererText();
                column.Title = Column.Action.ToString();
                column.PackStart(cell, true);
                column.AddAttribute(cell, "text", (int)Column.Action);
                this.treeview1.AppendColumn(column);
            }

            {
                var column = new TreeViewColumn();
                var cell = new CellRendererAccel();
                cell.AccelMode = CellRendererAccelMode.Other;
                cell.Editable = true;
                cell.AccelEdited += new AccelEditedHandler(this.OnAccelEdited);
                cell.AccelCleared += new AccelClearedHandler(this.OnAccelCleared);
                column.Title = Column.Shortcut.ToString();
                column.PackStart(cell, true);
                column.AddAttribute(cell, "text", (int)Column.Shortcut);
                this.treeview1.AppendColumn(column);
            }

            this.treeview1.RowActivated += new RowActivatedHandler(this.OnRowActivated);
            this.treeview1.ButtonPressEvent += new ButtonPressEventHandler(this.OnButtonPress);
            
            this.treeStore1 = (TreeStore)this.SetupTreeViewModel();
            this.treeview1.Model = this.treeStore1;
            this.treeview1.ExpandAll();
            this.treeview1.Selection.SelectPath(TreePath.NewFirst());
        }

        private TreeModel SetupTreeViewModel()
        {
            TreeIter iter;

            var model = new TreeStore(typeof(string), typeof(string), typeof(string), typeof(uint), typeof(Gdk.ModifierType));

            Comparison<Gtk.ActionGroup> actionGroupComparison = (x, y) => x.Name.CompareTo(y.Name);
            Comparison<Gtk.Action> actionComparison = (x, y) => x.Name.CompareTo(y.Name);

            Gtk.ActionGroup[] actionGroupArray = this.uiManager.ActionGroups;
            var actionGroups = new List<Gtk.ActionGroup>(actionGroupArray);
            actionGroups.Sort(actionGroupComparison);

            foreach (var actionGroup in actionGroups)
            {
                if (actionGroup.Name == "RootMenuItem")
                {
                    continue;
                }

                Gtk.Action[] actionArray = actionGroup.ListActions();
                var actions = new List<Gtk.Action>(actionArray);
                actions.Sort(actionComparison);

                if (actions.Count == 0)
                {
                    continue;
                }

                iter = model.AppendValues(actionGroup.Name);

                foreach (var action in actions)
                {
                    string accelPath = action.AccelPath;
                    string actionLabel = action.Label.Replace("_", string.Empty);

                    Gtk.AccelKey accel = new Gtk.AccelKey();
                    string shortcut = string.Empty;
                    if (MyAccelMap.LookupActiveEntry(accelPath, out accel))
                    {
                        shortcut = Gtk.Accelerator.GetLabel((uint)accel.Key, accel.AccelMods);
                    }

                    model.AppendValues(iter, actionLabel, shortcut, accelPath, (uint)accel.Key, accel.AccelMods);
                }
            }
            
            return model;
        }

        private void ShowErrorMessage(string error)
        {
            Gtk.MessageDialog dialog = new Gtk.MessageDialog(
                this, 
                Gtk.DialogFlags.DestroyWithParent, 
                Gtk.MessageType.Error, 
                Gtk.ButtonsType.Close, 
                error);
            dialog.Run();
            dialog.Destroy();
        }

        private void StartOrContinueAccelEditing(Gtk.TreePath treePath)
        {
            this.treeview1.GrabFocus();
            this.treeview1.SetCursor(treePath, this.treeview1.GetColumn((int)Column.Shortcut), true);
        }

        private bool UpdateModelChangedAccelerators(TreeModel model, TreePath path, TreeIter treeiter, string newAccelPath, uint newAccelKey, Gdk.ModifierType newAccelMods)
        {
            var rowAccelPath = (string)model.GetValue(treeiter, (int)Column.AccelPath);
            var rowAccelKey = (uint)model.GetValue(treeiter, (int)Column.AccelKey);
            var rowAccelMods = (Gdk.ModifierType)model.GetValue(treeiter, (int)Column.AccelMods);

            if (rowAccelPath == newAccelPath)
            {
                string shortcut = Gtk.Accelerator.GetLabel(newAccelKey, newAccelMods);
                model.SetValue(treeiter, (int)Column.AccelKey, newAccelKey);
                model.SetValue(treeiter, (int)Column.AccelMods, newAccelMods);
                model.SetValue(treeiter, (int)Column.Shortcut, shortcut);
            } 
            else
            {
                if (rowAccelKey == newAccelKey && rowAccelMods == newAccelMods)
                {
                    model.SetValue(treeiter, (int)Column.AccelKey, null);
                    model.SetValue(treeiter, (int)Column.AccelMods, null);
                    model.SetValue(treeiter, (int)Column.Shortcut, null);
                }
            }

            return false;
        }

        private bool UpdateModelDefaultAccelerators(TreeModel model, TreePath path, TreeIter treeiter)
        {
            var accelPath = (string)model.GetValue(treeiter, (int)Column.AccelPath);

            if (!MyAccelMap.AccelMapChanges.Contains(accelPath))
            {
                return false;
            }

            Gtk.AccelKey accel = new Gtk.AccelKey();
            
            if (MyAccelMap.LookupPendingEntry(accelPath, out accel))
            {
                string shortcut = Gtk.Accelerator.GetLabel((uint)accel.Key, accel.AccelMods);
                model.SetValue(treeiter, (int)Column.AccelKey, (uint)accel.Key);
                model.SetValue(treeiter, (int)Column.AccelMods, accel.AccelMods);
                model.SetValue(treeiter, (int)Column.Shortcut, shortcut);
            }
            
            return false;
        }
    }
}
