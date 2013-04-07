using System;
using System.ComponentModel;
using GLib;
using Gtk;

using MyExtensions;

/// <summary>
/// Contains basic examples of TreeView CellRenderers
/// </summary>
public partial class MainWindow : Gtk.Window
{    
    private ListStore listStore1;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();
        this.SetupTreeView();
    }

    public enum Column : int
    {
        [Description("Text String")]
        TextString, 
        [Description("Text Double")]
        TextDouble, 
        [Description("Text Bool")]
        TextBool,
        [Description("Toggle Check Box")]
        ToggleCheckBox,
        [Description("Toggle Radio Button")]
        ToggleRadioButton,
        [Description("Spin")]
        Spin,
        [Description("Combo")]
        Combo,
        [Description("Accel")]
        Accel,
        [Description("Progress")]
        Progress,
        ProgressText,
        [Description("Pixbuf Stock Label")]
        PixbufStockLabel,
        [Description("Pixbuf Stock Icon")]
        PixbufStockIcon,
        [Description("Pixbuf Custom")]
        PixbufCustom,
        Count
    }
    
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void SetupTreeView()
    {
        this.listStore1 = this.CreateModel();
        this.treeview1.Model = this.listStore1;
        this.AddColumns(this.treeview1);
    }

    private ListStore CreateModel()
    {
        System.Type[] types = new System.Type[(int)Column.Count];
        types[(int)Column.TextString] = typeof(string);
        types[(int)Column.TextDouble] = typeof(double);
        types[(int)Column.TextBool] = typeof(bool);
        types[(int)Column.ToggleCheckBox] = typeof(bool);
        types[(int)Column.ToggleRadioButton] = typeof(bool);
        types[(int)Column.Spin] = typeof(float);
        types[(int)Column.Combo] = typeof(string);
        types[(int)Column.Accel] = typeof(string);
        types[(int)Column.Progress] = typeof(int);
        types[(int)Column.ProgressText] = typeof(string);
        types[(int)Column.PixbufStockLabel] = typeof(string);
        types[(int)Column.PixbufStockIcon] = typeof(string);
        types[(int)Column.PixbufCustom] = typeof(Gdk.Pixbuf);

        ListStore model = new ListStore(types);

        string[] accels = new string[3];
        accels[0] = Gtk.Accelerator.GetLabel((uint)Gdk.Key.x, Gdk.ModifierType.ControlMask);
        accels[1] = Gtk.Accelerator.GetLabel((uint)Gdk.Key.c, Gdk.ModifierType.ControlMask);
        accels[2] = Gtk.Accelerator.GetLabel((uint)Gdk.Key.v, Gdk.ModifierType.ControlMask);

        string[] stockIcons = new string[3];
        stockIcons[0] = Gtk.Stock.Yes;
        stockIcons[1] = Gtk.Stock.No;
        stockIcons[2] = Gtk.Stock.Edit;

        string[] stockLabels = new string[3];
        stockLabels[0] = Gtk.Stock.Lookup(stockIcons[0]).Label;
        stockLabels[1] = Gtk.Stock.Lookup(stockIcons[1]).Label;
        stockLabels[2] = Gtk.Stock.Lookup(stockIcons[2]).Label;

        Gdk.Pixbuf[] pixbufs = new Gdk.Pixbuf[3];
        pixbufs[0] = Gdk.Pixbuf.LoadFromResource("CellRenderers.Pixbuf.dialog-fewer.png");
        pixbufs[1] = Gdk.Pixbuf.LoadFromResource("CellRenderers.Pixbuf.dialog-more.png");
        pixbufs[2] = Gdk.Pixbuf.LoadFromResource("CellRenderers.Pixbuf.dialog-fewer.png");

        model.AppendValues("String1", 1.11, true, true, false, float.Parse("1.1"), "Value2", accels[0], 25, "25%", stockLabels[0], stockIcons[0], pixbufs[0]);
        model.AppendValues("String2", 2.22, false, false, true, float.Parse("2.2"), "Value2", accels[1], 50, "50%", stockLabels[1], stockIcons[1], pixbufs[1]);
        model.AppendValues("String3", 3.33, true, true, false, float.Parse("3.3"), "Value1", accels[2], 75, "75%", stockLabels[2], stockIcons[2], pixbufs[2]);
        
        return model;
    }

    private void AddColumns(TreeView treeView)
    {
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            cell.Editable = true;
            cell.Edited += this.TextStringEdited;
            column.Title = Column.TextString.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.TextString);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            cell.Editable = true;
            cell.Edited += this.TextDoubleEdited;
            column.Title = Column.TextDouble.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.TextDouble);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = Column.TextBool.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.TextBool);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererToggle();
            cell.Toggled += this.ToggleCheckBoxToggled;
            cell.Active = true;
            cell.Activatable = true;
            column.Title = Column.ToggleCheckBox.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "active", (int)Column.ToggleCheckBox);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererToggle();
            cell.Toggled += this.ToggleRadioButtonToggled;
            cell.Active = true;
            cell.Activatable = true;
            cell.Radio = true;
            column.Title = Column.ToggleRadioButton.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "active", (int)Column.ToggleRadioButton);
            this.treeview1.AppendColumn(column);
        }

        {
            // Note: the text in this renderer has to be parseable as a floating point number
            var column = new TreeViewColumn();
            var cell = new CellRendererSpin();
            cell.Editable = true;
            cell.Edited += this.SpinTest1Edited;

            // Adjustment - Contains the range information for the cell. 
            // Value: Must be non-null for the cell to be editable.
            cell.Adjustment = new Adjustment(0, 0, float.MaxValue, 1, 2, 0);

            // ClimbRate - Provides the acceleration rate for when the button is held down. 
            // Value: Defaults to 0, must be greater than or equal to 0. 
            cell.ClimbRate = 0; 

            // Digits - Number of decimal places to display (seems to only work while editing the cell?!?). 
            // Value: An integer between 0 and 20, default value is 0.
            cell.Digits = 3;

            column.Title = Column.Spin.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.Spin);
            this.treeview1.AppendColumn(column);
        }

        {
            ListStore model = new ListStore(typeof(string));
            
            model.AppendValues("Value1");
            model.AppendValues("Value2");
            model.AppendValues("Value3");

            var column = new TreeViewColumn();
            var cell = new CellRendererCombo();
            cell.Width = 75;
            cell.Editable = true;
            cell.Edited += this.ComboEdited;

            // bool. Whether to use an entry.
            // If true, the cell renderer will include an entry and allow to 
            // enter values other than the ones in the popup list.
            cell.HasEntry = true;

            // TreeModel. Holds a tree model containing the possible values for the combo box.
            // Use the CellRendererCombo.TextColumn property to specify the column holding the values.
            cell.Model = model; 

            // int. Specifies the model column which holds the possible values for the combo box.
            // Note: this refers to the model specified in the model property, not the model 
            // backing the tree view to which this cell renderer is attached.
            cell.TextColumn = 0;

            column.Title = Column.Combo.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.Combo);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererAccel();
            cell.AccelMode = CellRendererAccelMode.Other;
            cell.Editable = true;
            cell.AccelEdited += new AccelEditedHandler(this.OnAccelEdited);
            cell.AccelCleared += new AccelClearedHandler(this.OnAccelCleared);
            column.Title = Column.Accel.ToString();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.Accel);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererProgress();
            column.Title = Column.Progress.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.ProgressText);
            column.AddAttribute(cell, "value", (int)Column.Progress);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = Column.PixbufStockLabel.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.PixbufStockLabel);
            treeview1.AppendColumn(column);
        }
        
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererPixbuf();
            column.Title = Column.PixbufStockIcon.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "stock-id", (int)Column.PixbufStockIcon);
            treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererPixbuf();
            column.Title = Column.PixbufCustom.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "pixbuf", (int)Column.PixbufCustom);
            treeview1.AppendColumn(column);
        }
    }

    private void OnAccelCleared(object o, AccelClearedArgs args)
    {
        Console.WriteLine("OnAccelCleared()");
        TreeIter iter;
        this.listStore1.GetIterFromString(out iter, args.PathString);
        this.listStore1.SetValue(iter, (int)Column.Accel, string.Empty);
    }
    
    private void OnAccelEdited(object o, AccelEditedArgs args)
    {
        Console.WriteLine("OnAccelEdited()");
        TreeIter iter;
        uint accelKey = args.AccelKey;
        Gdk.ModifierType accelMods = args.AccelMods;
        
        if (Gtk.Accelerator.Valid(accelKey, accelMods))
        {
            if (this.listStore1.GetIterFromString(out iter, args.PathString))
            {
                string accel = Gtk.Accelerator.GetLabel(accelKey, accelMods);
                this.listStore1.SetValue(iter, (int)Column.Accel, accel);
            }
        }
        else
        {
            this.StartOrContinueAccelEditing(new Gtk.TreePath(args.PathString));
            return;
        }
    }

    private void StartOrContinueAccelEditing(Gtk.TreePath treePath)
    {
        this.treeview1.GrabFocus();
        this.treeview1.SetCursor(treePath, this.treeview1.GetColumn((int)Column.Accel), true);
    }

    private void ComboEdited(object o, EditedArgs args)
    {
        Console.WriteLine("ComboEdited()");
        TreeIter iter;
        this.listStore1.GetIterFromString(out iter, args.Path);
        this.listStore1.SetValue(iter, (int)Column.Combo, args.NewText);
    }

    private void SpinTest1Edited(object o, EditedArgs args)
    {
        Console.WriteLine("SpinTest1Edited()");

        // Note: The args.NewText value must be parsed into the same 
        // data type specified for the column in the model. If it isn't then
        // the model's SetValue() method will not work.
        float val;
        if (!float.TryParse(args.NewText, out val))
        {
            // Maybe alert the user of invalid data entered here.
            return;
        }

        TreeIter iter;
        this.listStore1.GetIterFromString(out iter, args.Path);
        this.listStore1.SetValue(iter, (int)Column.Spin, val);
    }

    private void TextStringEdited(object o, EditedArgs args)
    {
        Console.WriteLine("TextStringEdited()");
        TreeIter iter;
        this.listStore1.GetIterFromString(out iter, args.Path);
        this.listStore1.SetValue(iter, (int)Column.TextString, args.NewText);
    }

    private void TextDoubleEdited(object o, EditedArgs args)
    {
        Console.WriteLine("TextDoubleEdited()");
        TreeIter iter;
        this.listStore1.GetIterFromString(out iter, args.Path);
        this.listStore1.SetValue(iter, (int)Column.TextDouble, args.NewText);
    }

    private void ToggleCheckBoxToggled(object o, ToggledArgs args)
    {
        Console.WriteLine("ToggleCheckBoxToggled()");
        TreeIter iter;
        if (this.listStore1.GetIterFromString(out iter, args.Path))
        {
            bool value = (bool)this.listStore1.GetValue(iter, (int)Column.ToggleCheckBox);
            this.listStore1.SetValue(iter, (int)Column.ToggleCheckBox, !value);
        }
    }

    private void ToggleRadioButtonToggled(object o, ToggledArgs args)
    {
        Console.WriteLine("ToggleRadioButtonToggled()");
        TreeIter iter;

        // Radio button "group" behavior must be manually implemneted with something like this:
        if (this.listStore1.GetIterFirst(out iter))
        {
            do
            { 
                this.listStore1.SetValue(iter, (int)Column.ToggleRadioButton, false);
            } 
            while (this.listStore1.IterNext(ref iter)); 
        }

        if (this.listStore1.GetIterFromString(out iter, args.Path))
        {
            this.listStore1.SetValue(iter, (int)Column.ToggleRadioButton, true);
        }
    }
}
