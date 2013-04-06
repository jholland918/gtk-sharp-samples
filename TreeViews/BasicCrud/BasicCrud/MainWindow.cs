using System;
using System.ComponentModel;
using Gtk;
using MyExtensions;

/// <summary>
/// Contains a TreeView that allows a user to edit rows using 
/// the TAB key to switch to the next cell for editing.
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
        [Description("Customer ID")]
        CustomerID = 0, 
        [Description("First Name")]
        FirstName = 1, 
        [Description("Last Name")]
        LastName = 2
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonCreateClicked(object sender, EventArgs e)
    {
        TreeIter iter = this.listStore1.AppendValues(string.Empty, string.Empty, string.Empty);
        
        TreePath path = this.listStore1.GetPath(iter);
        TreeViewColumn column = this.treeview1.GetColumn(0);
        this.treeview1.SetCursor(path, column, true);
    }
    
    protected void OnButtonDeleteClicked(object sender, EventArgs e)
    {
        TreeIter iter;
        TreePath[] treePath = treeview1.Selection.GetSelectedRows();
        this.listStore1.GetIter(out iter, treePath[0]);
        string value = (string)this.listStore1.GetValue(iter, 0);
        Console.WriteLine("Removing: " + value);
        this.listStore1.Remove(ref iter);
    }

    protected void OnTreeview1RowActivated(object o, RowActivatedArgs args)
    {
        this.labelTreeEvent.Text = "RowActivated";

        TreeIter iter;
        TreeModel model = ((TreeView)o).Model;
        model.GetIter(out iter, args.Path);

        this.labelCustomerID.Text = (string)model.GetValue(iter, 0);
        this.labelFirstName.Text = (string)model.GetValue(iter, 1);
        this.labelLastName.Text = (string)model.GetValue(iter, 2);
    }

    protected void OnTreeview1CursorChanged(object sender, EventArgs e)
    {
        this.labelTreeEvent.Text = "CursorChanged";

        TreeIter iter;
        TreeModel model;
        TreeSelection selection = ((TreeView)sender).Selection;

        if (selection.GetSelected(out model, out iter))
        {
            this.labelCustomerID.Text = (string)model.GetValue(iter, 0);
            this.labelFirstName.Text = (string)model.GetValue(iter, 1);
            this.labelLastName.Text = (string)model.GetValue(iter, 2);
        }
    }

    protected void OnTreeview1KeyReleaseEvent(object o, KeyReleaseEventArgs args)
    {
        if (args.Event.Key == Gdk.Key.Tab)
        {
            var treeView = (TreeView)o;
            TreeViewColumn focusColumn;
            TreePath path;
            treeView.GetCursor(out path, out focusColumn);
            TreeViewColumn[] cols = this.treeview1.Columns;
            int focusColumnPosition = Array.IndexOf(cols, focusColumn);
            int nextColumn = focusColumnPosition + 1;
            if (nextColumn < cols.Length)
            {
                treeView.SetCursor(path, treeView.Columns[nextColumn], true);
            }
        }
    }

    private void SetupTreeView()
    {
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            cell.Editable = true;
            cell.Edited += this.OnCustomerIDEdited;
            column.Title = Column.CustomerID.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.CustomerID);
            this.treeview1.AppendColumn(column);
        }
        
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            cell.Editable = true;
            cell.Edited += this.OnFirstNameEdited;
            column.Title = Column.FirstName.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.FirstName);
            this.treeview1.AppendColumn(column);
        }
        
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            cell.Editable = true;
            cell.Edited += this.OnLastNameEdited;
            column.Title = Column.LastName.GetDescription();
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.LastName);
            this.treeview1.AppendColumn(column);
        }
        
        this.listStore1 = (ListStore)this.SetupTreeViewModel();
        
        this.treeview1.Model = this.listStore1;
    }
    
    private TreeModel SetupTreeViewModel()
    {
        ListStore model = new ListStore(typeof(string), typeof(string), typeof(string));
        
        model.AppendValues("1", "Bert", "Sanders");
        model.AppendValues("2", "Ryan", "Nieves");
        model.AppendValues("3", "Cruz", "Strong");
        
        return model;
    }
    
    private void OnCustomerIDEdited(object o, Gtk.EditedArgs args)
    {
        TreeIter iter;
        this.listStore1.GetIter(out iter, new TreePath(args.Path));
        this.listStore1.SetValue(iter, 0, args.NewText);
    }
    
    private void OnFirstNameEdited(object o, Gtk.EditedArgs args)
    {
        TreeIter iter;
        this.listStore1.GetIter(out iter, new TreePath(args.Path));
        this.listStore1.SetValue(iter, 1, args.NewText);
    }
    
    private void OnLastNameEdited(object o, Gtk.EditedArgs args)
    {
        TreeIter iter;
        this.listStore1.GetIter(out iter, new TreePath(args.Path));
        this.listStore1.SetValue(iter, 2, args.NewText);
    }
}
