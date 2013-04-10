using System;
using Gtk;

/// <summary>
/// Basic handling of selection, inserts, deletes, and loops in a TreeView with a ListStore model.
/// </summary>
public partial class MainWindow : Gtk.Window
{    
    private ListStore listStore1;
    private int lastCustomerID;
    
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
    
    protected void OnButtonAppendClicked(object sender, EventArgs e)
    {
        Gtk.TreeIter iter;
        iter = this.listStore1.Append();
        
        if (this.checkSelectAdded.Active)
        {
            this.treeview1.Selection.SelectIter(iter);
        }
    }
    
    protected void OnButtonAppendValuesClicked(object sender, EventArgs e)
    {
        Gtk.TreeIter iter;
        
        string[] newValues = this.BuildNewRowValues();
        
        iter = this.listStore1.AppendValues(newValues[0], newValues[1], newValues[2]);
        
        if (this.checkSelectAdded.Active)
        {
            this.treeview1.Selection.SelectIter(iter);
        }
    }
    
    protected void OnButtonClearClicked(object sender, EventArgs e)
    {
        this.listStore1.Clear();
    }
    
    protected void OnButtonForeachClicked(object sender, EventArgs e)
    {
        if (this.treeview1.Selection.CountSelectedRows() > 0)
        {
            this.textview1.Buffer.Text += "Looping over selected:\n";
            this.treeview1.Selection.SelectedForeach(new TreeSelectionForeachFunc(this.SelectedForeach));
        } 
        else
        {
            this.ListStoreForeach();
        }
    }

    protected void OnButtonInsertClicked(object sender, EventArgs e)
    {
        TreeIter iter;
        iter = this.listStore1.Insert(this.GetInsertPosition());
        this.treeview1.Selection.SelectIter(iter);
    }
    
    protected void OnButtonInsertAfterClicked(object sender, EventArgs e)
    {
        this.InsertAfter(false);
    }

    protected void OnButtonInsertAfterValuesClicked(object sender, EventArgs e)
    {
        this.InsertAfter(true);
    }

    protected void OnButtonInsertBeforeClicked(object sender, EventArgs e)
    {
        this.InsertBefore(false);
    }

    protected void OnButtonInsertBeforeValuesClicked(object sender, EventArgs e)
    {
        this.InsertBefore(true);
    }
    
    protected void OnButtonInsertWithValuesClicked(object sender, EventArgs e)
    {
        TreeIter iter;
        string[] newValues = this.BuildNewRowValues();
        iter = this.listStore1.InsertWithValues(this.GetInsertPosition(), newValues[0], newValues[1], newValues[2]);
        this.treeview1.Selection.SelectIter(iter);
    }

    protected void OnButtonIterateManuallyClicked(object sender, EventArgs e)
    {
        TreeIter iter; 
        
        if (this.listStore1.GetIterFirst(out iter))
        {
            do 
            { 
                var customerID = (string)this.listStore1.GetValue(iter, (int)Column.CustomerID);
                var firstName = (string)this.listStore1.GetValue(iter, (int)Column.FirstName);
                var lastName = (string)this.listStore1.GetValue(iter, (int)Column.LastName);
                this.textview1.Buffer.Text += string.Format("{0}, {1}, {2}\n", customerID, firstName, lastName);
            } 
            while (this.listStore1.IterNext(ref iter)); 
        }
    }
    
    protected void OnButtonPrependClicked(object sender, EventArgs e)
    {
        TreeIter iter;
        iter = this.listStore1.Prepend();
        
        if (this.checkSelectAdded.Active)
        {
            this.treeview1.Selection.SelectIter(iter);
        }
    }

    protected void OnButtonPrependValuesClicked(object sender, EventArgs e)
    {
        TreeIter iter;
        string[] newValues = this.BuildNewRowValues();

        iter = this.listStore1.Prepend();
        this.listStore1.SetValues(iter, newValues[0], newValues[1], newValues[2]);
        
        if (this.checkSelectAdded.Active)
        {
            this.treeview1.Selection.SelectIter(iter);
        }
    }
    
    protected void OnButtonRemoveClicked(object sender, EventArgs e)
    {   
        if (this.treeview1.Selection.CountSelectedRows() > 0)
        {
            this.RemoveSelectedRows();
        } 
        else
        {
            this.DisplayError("You must select one or more rows.");
        }
    }
    
    private string[] BuildNewRowValues()
    {
        this.lastCustomerID++;
        
        string customerID = this.lastCustomerID.ToString();
        string firstName = "FirstName_" + customerID;
        string lastName = "LastName_" + customerID;
        
        var values = new string[] { customerID, firstName, lastName };
        
        return values;
    }
    
    private void DisplayError(string message)
    {
        MessageDialog dialog = new MessageDialog(
            this, 
            DialogFlags.DestroyWithParent, 
            MessageType.Error, 
            ButtonsType.Close, 
            message);
        dialog.Run();
        dialog.Destroy();
    }
    
    private int GetInsertPosition()
    {
        int insertPosition;
        string insertPositionText = this.entryInsertPosition.Text;
        bool result = int.TryParse(insertPositionText, out insertPosition);
        if (result == false)
        {
            insertPosition = 0;
        }
        
        return insertPosition;
    }

    private void InsertAfter(bool setValues)
    {
        TreeIter iter;
        TreeIter insertedIter;
        
        TreePath[] treePaths = this.treeview1.Selection.GetSelectedRows();
        
        if (treePaths.Length > 0)
        {
            if (this.listStore1.GetIter(out iter, treePaths[treePaths.Length - 1]))
            {
                insertedIter = this.listStore1.InsertAfter(iter);
                
                if (setValues) 
                {
                    string[] newValues = this.BuildNewRowValues();
                    this.listStore1.SetValues(insertedIter, newValues[0], newValues[1], newValues[2]);
                }
                
                this.treeview1.Selection.SelectIter(insertedIter);
            }
            else
            {
                this.DisplayError("Error getting iterator.");
            }
        } 
        else
        {
            this.DisplayError("You must make a selection.");
        }
    }
    
    private void InsertBefore(bool setValues)
    {
        TreeIter iter;
        TreeIter insertedIter;
        
        TreePath[] treePaths = this.treeview1.Selection.GetSelectedRows();
        
        if (treePaths.Length > 0)
        {
            if (this.listStore1.GetIter(out iter, treePaths[0]))
            {
                insertedIter = this.listStore1.InsertBefore(iter);
                
                if (setValues) 
                {
                    string[] newValues = this.BuildNewRowValues();
                    this.listStore1.SetValues(insertedIter, newValues[0], newValues[1], newValues[2]);
                }
                
                this.treeview1.Selection.SelectIter(insertedIter);
            }
            else
            {
                this.DisplayError("Error getting iterator.");
            }
        } 
        else
        {
            this.DisplayError("You must make a selection.");
        }
    }
    
    private void ListStoreForeach()
    {
        int stopAtCustomerID;
        string stopAtCustomerIDText = this.entryStopAtCustomerID.Text;
        bool result = int.TryParse(stopAtCustomerIDText, out stopAtCustomerID);
        if (result == false)
        {
            stopAtCustomerID = 0;
        }
        
        this.listStore1.Foreach((model, path, iter) => this.ListStore1Foreach(model, path, iter, stopAtCustomerID.ToString()));
    }
    
    private bool ListStore1Foreach(TreeModel model, TreePath path, TreeIter iter, string stopAtCustomerID)
    {
        var customerID = (string)model.GetValue(iter, (int)Column.CustomerID);
        var firstName = (string)model.GetValue(iter, (int)Column.FirstName);
        var lastName = (string)model.GetValue(iter, (int)Column.LastName);
        this.textview1.Buffer.Text += string.Format("{0}, {1}, {2}\n", customerID, firstName, lastName);
        
        if (customerID == stopAtCustomerID)
        {
            this.textview1.Buffer.Text += string.Format("Found CustomerID {0}, stopping loop.\n", customerID);
            return true;
        }
        
        return false;
    }

    private void RemoveSelectedRows()
    {
        TreeIter iter;
        
        TreePath[] treePath = this.treeview1.Selection.GetSelectedRows();
        
        for (int i  = treePath.Length; i > 0; i--)
        {
            this.listStore1.GetIter(out iter, treePath[(i - 1)]);
            
            var value = (string)this.listStore1.GetValue(iter, 0);
            this.textview1.Buffer.Text += string.Format("Removing: {0}\n", value);
            
            this.listStore1.Remove(ref iter);
        }
    }

    private void SelectedForeach(TreeModel model, TreePath path, TreeIter iter)
    {
        var customerID = (string)model.GetValue(iter, (int)Column.CustomerID);
        var firstName = (string)model.GetValue(iter, (int)Column.FirstName);
        var lastName = (string)model.GetValue(iter, (int)Column.LastName);
        this.textview1.Buffer.Text += string.Format("{0}, {1}, {2}\n", customerID, firstName, lastName);
    }

    private void SetupTreeView()
    {
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = "Customer ID";
            column.PackStart(cell, true);
            column.SortColumnId = (int)Column.CustomerID;
            column.AddAttribute(cell, "text", (int)Column.CustomerID);
            this.treeview1.AppendColumn(column);
        }
        
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = "First Name";
            column.PackStart(cell, true);
            column.SortColumnId = (int)Column.FirstName;
            column.AddAttribute(cell, "text", (int)Column.FirstName);
            this.treeview1.AppendColumn(column);
        }
        
        {
            var column = new TreeViewColumn();
            var cell = new CellRendererText();
            column.Title = "Last Name";
            column.PackStart(cell, true);
            column.SortColumnId = (int)Column.LastName;
            column.AddAttribute(cell, "text", (int)Column.LastName);
            this.treeview1.AppendColumn(column);
        }
        
        this.listStore1 = (ListStore)this.SetupTreeViewModel();
        this.treeview1.Model = this.listStore1;       
        this.treeview1.Selection.Mode = SelectionMode.Multiple;
    }
    
    private TreeModel SetupTreeViewModel()
    {
        var model = new ListStore(typeof(string), typeof(string), typeof(string));
        
        model.AppendValues("1", "Bert", "Sanders");
        model.AppendValues("2", "Ryan", "Nieves");
        model.AppendValues("3", "Cruz", "Strong");
        model.AppendValues("4", "Basia", "Dunlap");
        model.AppendValues("5", "Madaline", "Durham");
        
        this.lastCustomerID = 5;
        
        return model;
    }
}
