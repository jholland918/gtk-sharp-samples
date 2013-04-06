using System;
using Gtk;

/// <summary>
/// A very basic TreeView with a ListStore as the model.
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

        this.listStore1 = (ListStore)this.SetupTreeViewModel();
        
        this.treeview1.Model = this.listStore1;
    }
    
    private TreeModel SetupTreeViewModel()
    {
        var model = new ListStore(typeof(string), typeof(string), typeof(string));
        
        model.AppendValues("1", "Bert", "Sanders");
        model.AppendValues("2", "Ryan", "Nieves");
        model.AppendValues("3", "Cruz", "Strong");
        model.AppendValues("4", "Basia", "Dunlap");
        model.AppendValues("5", "Madaline", "Durham");
        
        return model;
    }
}
