
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label label1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.HBox hbox2;
	private global::Gtk.VBox vbox2;
	private global::Gtk.Label label14;
	private global::Gtk.Label labelTreeEvent;
	private global::Gtk.Label label8;
	private global::Gtk.Label labelCustomerID;
	private global::Gtk.Label label10;
	private global::Gtk.Label labelFirstName;
	private global::Gtk.Label label12;
	private global::Gtk.Label labelLastName;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeview1;
	private global::Gtk.HButtonBox hbuttonbox1;
	private global::Gtk.Button buttonCreate;
	private global::Gtk.Button buttonDelete;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.BorderWidth = ((uint)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("BasicCrud");
		this.vbox1.Add (this.label1);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.label1]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label14 = new global::Gtk.Label ();
		this.label14.Name = "label14";
		this.label14.Xalign = 0F;
		this.label14.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Tree Event</b>");
		this.label14.UseMarkup = true;
		this.vbox2.Add (this.label14);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label14]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelTreeEvent = new global::Gtk.Label ();
		this.labelTreeEvent.Name = "labelTreeEvent";
		this.labelTreeEvent.Xalign = 0F;
		this.labelTreeEvent.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
		this.vbox2.Add (this.labelTreeEvent);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelTreeEvent]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.Xalign = 0F;
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Customer ID</b>");
		this.label8.UseMarkup = true;
		this.vbox2.Add (this.label8);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label8]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelCustomerID = new global::Gtk.Label ();
		this.labelCustomerID.Name = "labelCustomerID";
		this.labelCustomerID.Xalign = 0F;
		this.labelCustomerID.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
		this.vbox2.Add (this.labelCustomerID);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelCustomerID]));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.Xalign = 0F;
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>First Name</b>");
		this.label10.UseMarkup = true;
		this.vbox2.Add (this.label10);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label10]));
		w6.Position = 4;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelFirstName = new global::Gtk.Label ();
		this.labelFirstName.Name = "labelFirstName";
		this.labelFirstName.Xalign = 0F;
		this.labelFirstName.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
		this.vbox2.Add (this.labelFirstName);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelFirstName]));
		w7.Position = 5;
		w7.Expand = false;
		w7.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.Xalign = 0F;
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>LastName</b>");
		this.label12.UseMarkup = true;
		this.vbox2.Add (this.label12);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.label12]));
		w8.Position = 6;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.labelLastName = new global::Gtk.Label ();
		this.labelLastName.Name = "labelLastName";
		this.labelLastName.Xalign = 0F;
		this.labelLastName.LabelProp = global::Mono.Unix.Catalog.GetString ("None");
		this.vbox2.Add (this.labelLastName);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.labelLastName]));
		w9.Position = 7;
		w9.Expand = false;
		w9.Fill = false;
		this.hbox2.Add (this.vbox2);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.vbox2]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add (this.treeview1);
		this.hbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.GtkScrolledWindow]));
		w12.Position = 1;
		this.hbox1.Add (this.hbox2);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox2]));
		w13.Position = 0;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w14.Position = 1;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox ();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(1));
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonCreate = new global::Gtk.Button ();
		this.buttonCreate.CanFocus = true;
		this.buttonCreate.Name = "buttonCreate";
		this.buttonCreate.UseUnderline = true;
		this.buttonCreate.Label = global::Mono.Unix.Catalog.GetString ("Create");
		this.hbuttonbox1.Add (this.buttonCreate);
		global::Gtk.ButtonBox.ButtonBoxChild w15 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonCreate]));
		w15.Expand = false;
		w15.Fill = false;
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonDelete = new global::Gtk.Button ();
		this.buttonDelete.CanFocus = true;
		this.buttonDelete.Name = "buttonDelete";
		this.buttonDelete.UseUnderline = true;
		this.buttonDelete.Label = global::Mono.Unix.Catalog.GetString ("Delete");
		this.hbuttonbox1.Add (this.buttonDelete);
		global::Gtk.ButtonBox.ButtonBoxChild w16 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonDelete]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		this.vbox1.Add (this.hbuttonbox1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
		w17.Position = 2;
		w17.Expand = false;
		w17.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 556;
		this.DefaultHeight = 298;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.treeview1.RowActivated += new global::Gtk.RowActivatedHandler (this.OnTreeview1RowActivated);
		this.treeview1.CursorChanged += new global::System.EventHandler (this.OnTreeview1CursorChanged);
		this.treeview1.KeyReleaseEvent += new global::Gtk.KeyReleaseEventHandler (this.OnTreeview1KeyReleaseEvent);
		this.buttonCreate.Clicked += new global::System.EventHandler (this.OnButtonCreateClicked);
		this.buttonDelete.Clicked += new global::System.EventHandler (this.OnButtonDeleteClicked);
	}
}
