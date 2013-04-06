using System;
using System.Collections;
using Gtk;

/// <summary>
/// A basic sortable TreeView with alternating row colors.
/// </summary>
public partial class MainWindow : Gtk.Window
{    
    private ListStore store;
    private Customer[] customers =
    {
        new Customer("1", "Bert", "Sanders"),
        new Customer("2", "Ryan", "Nieves"),
        new Customer("3", "Cruz", "Strong"),
        new Customer("4", "Basia", "Dunlap"),
        new Customer("5", "Madaline", "Durham")
    };

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();
        this.SetupTreeView();
    }

    private enum Column
    {
        CustomerID,
        FirstName,
        LastName
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    private void SetupTreeView()
    {
        {
            var cell = new CellRendererText();
            var column = new TreeViewColumn("Customer ID", cell, "text", (int)Column.CustomerID);
            column.SortColumnId = (int)Column.CustomerID;
            this.treeview1.AppendColumn(column);
        }
        
        {
            var cell = new CellRendererText();
            var column = new TreeViewColumn("First Name", cell, "text", (int)Column.FirstName);
            column.SortColumnId = (int)Column.FirstName;
            this.treeview1.AppendColumn(column);
        }
        
        {
            var cell = new CellRendererText();
            var column = new TreeViewColumn("Last Name", cell, "text", (int)Column.LastName);
            column.SortColumnId = (int)Column.LastName;
            this.treeview1.AppendColumn(column);
        }

        this.store = this.SetupTreeViewModel();
        this.treeview1.Model = this.store;
        this.treeview1.RulesHint = true;
    }

    private ListStore SetupTreeViewModel()
    {
        var store = new ListStore(typeof(string), typeof(string), typeof(string));
        
        foreach (Customer customer in this.customers)
        {
            store.AppendValues(customer.CustomerID, customer.FirstName, customer.LastName);
        }
        
        return store;
    }

    public class Customer
    {
        public Customer(string customerID, string firstName, string lastName)
        {
            this.CustomerID = customerID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        public string CustomerID { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }
}
