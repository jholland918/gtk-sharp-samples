using System;
using Gtk;

/// <summary>
/// A boilerplate wizard using the Notebook widget to manage switching between each step.
/// </summary>
public partial class MainWindow : Gtk.Window
{    
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();
        this.eventboxHeader.ModifyBg(Gtk.StateType.Normal, new Gdk.Color(255, 255, 255));
    }

    private enum Pages : int
    {
        Page1 = 0,
        Page2 = 1,
        Page3 = 2,
        Page4 = 3,
        Page5 = 4
    }
    
    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButtonBackClicked(object sender, EventArgs e)
    {
        this.notebook1.PrevPage();
    }

    protected void OnButtonNextClicked(object sender, EventArgs e)
    {
        bool success = this.BeforeSwitchNextPage();
        if (success)
        {
            this.notebook1.NextPage();
        } 
        else
        {
            var dialog = new MessageDialog(
                this, 
                DialogFlags.DestroyWithParent, 
                MessageType.Error, 
                ButtonsType.Close, 
                "This demonstrates where a validation error could be displayed to the user.");
            dialog.Run();
            dialog.Destroy();
        }
    }

    protected void OnButtonSkipClicked(object sender, EventArgs e)
    {
        this.notebook1.CurrentPage = this.notebook1.CurrentPage + 2;
    }

    protected void OnButtonFinishClicked(object sender, EventArgs e)
    {
        this.notebook1.CurrentPage = this.notebook1.NPages - 1;
    }

    protected void OnButtonCancelClicked(object sender, EventArgs e)
    {
        this.Destroy();
    }

    protected void OnNotebook1SwitchPage(object o, SwitchPageArgs args)
    {
        var notebook = (Notebook)o;
        int pageNum = (int)args.PageNum;
        
        Widget pageWidget = notebook.GetNthPage(pageNum);
        string tabLabelText = notebook.GetTabLabelText(pageWidget);
        this.labelHeader.Markup = string.Format("<span weight=\"bold\" size=\"xx-large\">Wizard Sample: {0}</span>", tabLabelText);
        
        this.buttonSkip.Sensitive = true;
        this.buttonBack.Sensitive = true;
        this.buttonNext.Sensitive = true;
        
        if (pageNum == 0)
        {
            this.buttonBack.Sensitive = false;
        } 
        else if (pageNum == notebook.NPages - 1)
        {
            this.buttonNext.Sensitive = false;
            this.buttonSkip.Sensitive = false;
        }
        
        // Specific page load handling
        switch (pageNum)
        {
            case (int)Pages.Page2:
                this.buttonSkip.Sensitive = false;
                break;
        }
    }

    private bool BeforeSwitchNextPage()
    {
        switch (this.notebook1.CurrentPage)
        {
            case (int)Pages.Page1: 
                Console.WriteLine(string.Format("Switching from {0}", Pages.Page1));
                break;
            case (int)Pages.Page2:
                Console.WriteLine(string.Format("Switching from {0}", Pages.Page2));
                break;
            case (int)Pages.Page3:
                Console.WriteLine(string.Format("Switching from {0}", Pages.Page3));
                return false; // Do this to reject the request to go to the next page.
                break;
        }

        return true;
    }
}
