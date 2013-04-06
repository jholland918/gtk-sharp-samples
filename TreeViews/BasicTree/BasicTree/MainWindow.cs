using System;
using Gtk;

/// <summary>
/// A very basic TreeView with a TreeStore as the model.
/// </summary>
public partial class MainWindow : Gtk.Window
{    
    private TreeStore treeStore1;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();
        this.SetupTreeView();
    }

    public enum Column : int
    {
        CustomerID = 0, 
        FirstName = 1, 
        LastName = 2
    }
    
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void SetupTreeView()
    {
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = "Customer ID";
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.CustomerID);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = "First Name";
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.FirstName);
            this.treeview1.AppendColumn(column);
        }

        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = "Last Name";
            column.PackStart(cell, true);
            column.AddAttribute(cell, "text", (int)Column.LastName);
            this.treeview1.AppendColumn(column);
        }

        this.treeStore1 = (TreeStore)this.SetupTreeViewModel();
        
        this.treeview1.Model = this.treeStore1;
        this.treeview1.ExpandAll();
    }
    
    private TreeModel SetupTreeViewModel()
    {
        TreeIter iter;
        var model = new TreeStore(typeof(string), typeof(string), typeof(string));
        
        iter = model.AppendValues("Last Name starting with D");
        model.AppendValues(iter, "4", "Basia", "Dunlap");
        model.AppendValues(iter, "5", "Madaline", "Durham");
        
        iter = model.AppendValues("Last Name starting with N");
        model.AppendValues(iter, "2", "Ryan", "Nieves");
        
        iter = model.AppendValues("Last Name starting with S");
        model.AppendValues(iter, "1", "Bert", "Sanders");
        model.AppendValues(iter, "3", "Cruz", "Strong");
        
        return model;
    }
}
