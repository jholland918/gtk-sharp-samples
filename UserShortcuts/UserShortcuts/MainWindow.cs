using System;
using Gtk;

using UserShortcuts;

public partial class MainWindow : Gtk.Window
{    
    private Gtk.Action specialAction1;

    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        this.Build();
        this.SetupSpecialActions();
        MyAccelMap.Initialize();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void SetupSpecialActions()
    {
        // This demonstrates a shortcut assigned to an action that is 
        // not attached to a menu widget. This particular one is assigned 
        // to a textbox entry. I'm not sure that this is the best way
        // to do this, but it seems to work. :)
        Gtk.ActionGroup specialActions = new Gtk.ActionGroup("Special");
        this.specialAction1 = new Gtk.Action("specialAction1", "Special Action 1");
        string accelerator = Gtk.Accelerator.Name((uint)Gdk.Key.j, Gdk.ModifierType.ControlMask);
        specialActions.Add(this.specialAction1, accelerator);
        this.entry1.SetAccelPath(this.specialAction1.AccelPath, this.UIManager.AccelGroup);
        this.entry1.Activated += new System.EventHandler(this.OnSpecialAction1Activated);
        this.UIManager.InsertActionGroup(specialActions, -1);
    }

    protected void OnSpecialAction1Activated(object sender, EventArgs e)
    {
        this.entry1.Text = "Activated!";
        this.entry1.GrabFocus();
    }

    protected void OnNewActionActivated(object sender, EventArgs e)
    {
        this.textview1.Buffer.Text += "New\n";
    }

    protected void OnPreferencesActionActivated(object sender, EventArgs e)
    {
        new UserShortcuts.ShortcutDialog(this.UIManager);
    }
    
    protected void OnRedoActionActivated(object sender, EventArgs e)
    {
        this.textview1.Buffer.Text += "Redo\n";
    }
    
    protected void OnUndoActionActivated(object sender, EventArgs e)
    {
        this.textview1.Buffer.Text += "Undo\n";
    }
    
    protected void OnQuitActionActivated(object sender, EventArgs e)
    {
        this.textview1.Buffer.Text += "Quit\n";
    }
    
    protected void OnOpenActionActivated(object sender, EventArgs e)
    {
        this.textview1.Buffer.Text += "Open\n";
    }
}
