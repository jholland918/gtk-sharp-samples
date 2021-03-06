
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.Label label1;
	private global::Gtk.HBox hbox1;
	private global::Gtk.VBox vbox3;
	private global::Gtk.Frame frame1;
	private global::Gtk.Alignment GtkAlignment;
	private global::Gtk.VBox vbox4;
	private global::Gtk.CheckButton checkSelectAdded;
	private global::Gtk.Button buttonPrepend;
	private global::Gtk.Button buttonPrependValues;
	private global::Gtk.Button buttonAppend;
	private global::Gtk.Button buttonAppendValues;
	private global::Gtk.Label GtkLabel5;
	private global::Gtk.Frame frame3;
	private global::Gtk.Alignment GtkAlignment2;
	private global::Gtk.VBox vbox6;
	private global::Gtk.Button buttonRemove;
	private global::Gtk.Button buttonClear;
	private global::Gtk.Label GtkLabel13;
	private global::Gtk.Frame frame4;
	private global::Gtk.Alignment GtkAlignment3;
	private global::Gtk.VBox vbox7;
	private global::Gtk.Label label4;
	private global::Gtk.Entry entryStopAtCustomerID;
	private global::Gtk.Button buttonForeach;
	private global::Gtk.HSeparator hseparator2;
	private global::Gtk.Button buttonIterateManually;
	private global::Gtk.Label GtkLabel16;
	private global::Gtk.VBox vbox2;
	private global::Gtk.ScrolledWindow GtkScrolledWindow;
	private global::Gtk.TreeView treeview1;
	private global::Gtk.ScrolledWindow GtkScrolledWindow1;
	private global::Gtk.TextView textview1;
	private global::Gtk.VBox vbox8;
	private global::Gtk.Frame frame2;
	private global::Gtk.Alignment GtkAlignment1;
	private global::Gtk.VBox vbox5;
	private global::Gtk.Label label2;
	private global::Gtk.Entry entryInsertPosition;
	private global::Gtk.Button buttonInsert;
	private global::Gtk.Button buttonInsertWithValues;
	private global::Gtk.HSeparator hseparator1;
	private global::Gtk.Label label3;
	private global::Gtk.Button buttonInsertBefore;
	private global::Gtk.Button buttonInsertBeforeValues;
	private global::Gtk.Button buttonInsertAfter;
	private global::Gtk.Button buttonInsertAfterValues;
	private global::Gtk.Label GtkLabel10;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("List Manipulation");
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
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.frame1 = new global::Gtk.Frame ();
		this.frame1.Name = "frame1";
		this.frame1.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame1.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.checkSelectAdded = new global::Gtk.CheckButton ();
		this.checkSelectAdded.CanFocus = true;
		this.checkSelectAdded.Name = "checkSelectAdded";
		this.checkSelectAdded.Label = global::Mono.Unix.Catalog.GetString ("Select Added Row");
		this.checkSelectAdded.Active = true;
		this.checkSelectAdded.DrawIndicator = true;
		this.checkSelectAdded.UseUnderline = true;
		this.vbox4.Add (this.checkSelectAdded);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.checkSelectAdded]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonPrepend = new global::Gtk.Button ();
		this.buttonPrepend.CanFocus = true;
		this.buttonPrepend.Name = "buttonPrepend";
		this.buttonPrepend.UseUnderline = true;
		this.buttonPrepend.Label = global::Mono.Unix.Catalog.GetString ("Prepend");
		this.vbox4.Add (this.buttonPrepend);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonPrepend]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonPrependValues = new global::Gtk.Button ();
		this.buttonPrependValues.CanFocus = true;
		this.buttonPrependValues.Name = "buttonPrependValues";
		this.buttonPrependValues.UseUnderline = true;
		this.buttonPrependValues.Label = global::Mono.Unix.Catalog.GetString ("Prepend Values");
		this.vbox4.Add (this.buttonPrependValues);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonPrependValues]));
		w4.Position = 2;
		w4.Expand = false;
		w4.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonAppend = new global::Gtk.Button ();
		this.buttonAppend.CanFocus = true;
		this.buttonAppend.Name = "buttonAppend";
		this.buttonAppend.UseUnderline = true;
		this.buttonAppend.Label = global::Mono.Unix.Catalog.GetString ("Append");
		this.vbox4.Add (this.buttonAppend);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonAppend]));
		w5.Position = 3;
		w5.Expand = false;
		w5.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.buttonAppendValues = new global::Gtk.Button ();
		this.buttonAppendValues.CanFocus = true;
		this.buttonAppendValues.Name = "buttonAppendValues";
		this.buttonAppendValues.UseUnderline = true;
		this.buttonAppendValues.Label = global::Mono.Unix.Catalog.GetString ("Append Values");
		this.vbox4.Add (this.buttonAppendValues);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox4 [this.buttonAppendValues]));
		w6.Position = 4;
		w6.Expand = false;
		w6.Fill = false;
		this.GtkAlignment.Add (this.vbox4);
		this.frame1.Add (this.GtkAlignment);
		this.GtkLabel5 = new global::Gtk.Label ();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Adding Rows</b>");
		this.GtkLabel5.UseMarkup = true;
		this.frame1.LabelWidget = this.GtkLabel5;
		this.vbox3.Add (this.frame1);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.frame1]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.frame3 = new global::Gtk.Frame ();
		this.frame3.Name = "frame3";
		this.frame3.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame3.Gtk.Container+ContainerChild
		this.GtkAlignment2 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment2.Name = "GtkAlignment2";
		this.GtkAlignment2.LeftPadding = ((uint)(12));
		// Container child GtkAlignment2.Gtk.Container+ContainerChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.buttonRemove = new global::Gtk.Button ();
		this.buttonRemove.CanFocus = true;
		this.buttonRemove.Name = "buttonRemove";
		this.buttonRemove.UseUnderline = true;
		this.buttonRemove.Label = global::Mono.Unix.Catalog.GetString ("Remove");
		this.vbox6.Add (this.buttonRemove);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.buttonRemove]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.buttonClear = new global::Gtk.Button ();
		this.buttonClear.CanFocus = true;
		this.buttonClear.Name = "buttonClear";
		this.buttonClear.UseUnderline = true;
		this.buttonClear.Label = global::Mono.Unix.Catalog.GetString ("Clear");
		this.vbox6.Add (this.buttonClear);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox6 [this.buttonClear]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		this.GtkAlignment2.Add (this.vbox6);
		this.frame3.Add (this.GtkAlignment2);
		this.GtkLabel13 = new global::Gtk.Label ();
		this.GtkLabel13.Name = "GtkLabel13";
		this.GtkLabel13.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Deleting Rows</b>");
		this.GtkLabel13.UseMarkup = true;
		this.frame3.LabelWidget = this.GtkLabel13;
		this.vbox3.Add (this.frame3);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.frame3]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.frame4 = new global::Gtk.Frame ();
		this.frame4.Name = "frame4";
		this.frame4.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame4.Gtk.Container+ContainerChild
		this.GtkAlignment3 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment3.Name = "GtkAlignment3";
		this.GtkAlignment3.LeftPadding = ((uint)(12));
		// Container child GtkAlignment3.Gtk.Container+ContainerChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.Xalign = 0F;
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Stop at CustomerID:");
		this.vbox7.Add (this.label4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.label4]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.entryStopAtCustomerID = new global::Gtk.Entry ();
		this.entryStopAtCustomerID.CanFocus = true;
		this.entryStopAtCustomerID.Name = "entryStopAtCustomerID";
		this.entryStopAtCustomerID.IsEditable = true;
		this.entryStopAtCustomerID.InvisibleChar = '●';
		this.vbox7.Add (this.entryStopAtCustomerID);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.entryStopAtCustomerID]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.buttonForeach = new global::Gtk.Button ();
		this.buttonForeach.CanFocus = true;
		this.buttonForeach.Name = "buttonForeach";
		this.buttonForeach.UseUnderline = true;
		this.buttonForeach.Label = global::Mono.Unix.Catalog.GetString ("Foreach");
		this.vbox7.Add (this.buttonForeach);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.buttonForeach]));
		w17.Position = 2;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.vbox7.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.hseparator2]));
		w18.Position = 3;
		w18.Expand = false;
		w18.Fill = false;
		// Container child vbox7.Gtk.Box+BoxChild
		this.buttonIterateManually = new global::Gtk.Button ();
		this.buttonIterateManually.CanFocus = true;
		this.buttonIterateManually.Name = "buttonIterateManually";
		this.buttonIterateManually.UseUnderline = true;
		this.buttonIterateManually.Label = global::Mono.Unix.Catalog.GetString ("Iterate Manually");
		this.vbox7.Add (this.buttonIterateManually);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox7 [this.buttonIterateManually]));
		w19.Position = 4;
		w19.Expand = false;
		w19.Fill = false;
		this.GtkAlignment3.Add (this.vbox7);
		this.frame4.Add (this.GtkAlignment3);
		this.GtkLabel16 = new global::Gtk.Label ();
		this.GtkLabel16.Name = "GtkLabel16";
		this.GtkLabel16.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Traversing Rows</b>");
		this.GtkLabel16.UseMarkup = true;
		this.frame4.LabelWidget = this.GtkLabel16;
		this.vbox3.Add (this.frame4);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.frame4]));
		w22.Position = 2;
		w22.Expand = false;
		w22.Fill = false;
		this.hbox1.Add (this.vbox3);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox3]));
		w23.Position = 0;
		w23.Expand = false;
		w23.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.treeview1 = new global::Gtk.TreeView ();
		this.treeview1.CanFocus = true;
		this.treeview1.Name = "treeview1";
		this.GtkScrolledWindow.Add (this.treeview1);
		this.vbox2.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
		w25.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
		this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
		this.textview1 = new global::Gtk.TextView ();
		this.textview1.CanFocus = true;
		this.textview1.Name = "textview1";
		this.GtkScrolledWindow1.Add (this.textview1);
		this.vbox2.Add (this.GtkScrolledWindow1);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow1]));
		w27.Position = 1;
		this.hbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox2]));
		w28.Position = 1;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame ();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment1 = new global::Gtk.Alignment (0F, 0F, 1F, 1F);
		this.GtkAlignment1.Name = "GtkAlignment1";
		this.GtkAlignment1.LeftPadding = ((uint)(12));
		// Container child GtkAlignment1.Gtk.Container+ContainerChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.Xalign = 0F;
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Insert Position:");
		this.vbox5.Add (this.label2);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label2]));
		w29.Position = 0;
		w29.Expand = false;
		w29.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.entryInsertPosition = new global::Gtk.Entry ();
		this.entryInsertPosition.CanFocus = true;
		this.entryInsertPosition.Name = "entryInsertPosition";
		this.entryInsertPosition.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.entryInsertPosition.IsEditable = true;
		this.entryInsertPosition.InvisibleChar = '●';
		this.vbox5.Add (this.entryInsertPosition);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.entryInsertPosition]));
		w30.Position = 1;
		w30.Expand = false;
		w30.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.buttonInsert = new global::Gtk.Button ();
		this.buttonInsert.CanFocus = true;
		this.buttonInsert.Name = "buttonInsert";
		this.buttonInsert.UseUnderline = true;
		this.buttonInsert.Label = global::Mono.Unix.Catalog.GetString ("Insert");
		this.vbox5.Add (this.buttonInsert);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.buttonInsert]));
		w31.Position = 2;
		w31.Expand = false;
		w31.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.buttonInsertWithValues = new global::Gtk.Button ();
		this.buttonInsertWithValues.CanFocus = true;
		this.buttonInsertWithValues.Name = "buttonInsertWithValues";
		this.buttonInsertWithValues.UseUnderline = true;
		this.buttonInsertWithValues.Label = global::Mono.Unix.Catalog.GetString ("InsertWithValues");
		this.vbox5.Add (this.buttonInsertWithValues);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.buttonInsertWithValues]));
		w32.Position = 3;
		w32.Expand = false;
		w32.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox5.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.hseparator1]));
		w33.Position = 4;
		w33.Expand = false;
		w33.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.Xalign = 0F;
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Sibling-based inserts:");
		this.vbox5.Add (this.label3);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.label3]));
		w34.Position = 5;
		w34.Expand = false;
		w34.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.buttonInsertBefore = new global::Gtk.Button ();
		this.buttonInsertBefore.CanFocus = true;
		this.buttonInsertBefore.Name = "buttonInsertBefore";
		this.buttonInsertBefore.UseUnderline = true;
		this.buttonInsertBefore.Label = global::Mono.Unix.Catalog.GetString ("InsertBefore");
		this.vbox5.Add (this.buttonInsertBefore);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.buttonInsertBefore]));
		w35.Position = 6;
		w35.Expand = false;
		w35.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.buttonInsertBeforeValues = new global::Gtk.Button ();
		this.buttonInsertBeforeValues.CanFocus = true;
		this.buttonInsertBeforeValues.Name = "buttonInsertBeforeValues";
		this.buttonInsertBeforeValues.UseUnderline = true;
		this.buttonInsertBeforeValues.Label = global::Mono.Unix.Catalog.GetString ("InsertBeforeValues");
		this.vbox5.Add (this.buttonInsertBeforeValues);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.buttonInsertBeforeValues]));
		w36.Position = 7;
		w36.Expand = false;
		w36.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.buttonInsertAfter = new global::Gtk.Button ();
		this.buttonInsertAfter.CanFocus = true;
		this.buttonInsertAfter.Name = "buttonInsertAfter";
		this.buttonInsertAfter.UseUnderline = true;
		this.buttonInsertAfter.Label = global::Mono.Unix.Catalog.GetString ("InsertAfter");
		this.vbox5.Add (this.buttonInsertAfter);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.buttonInsertAfter]));
		w37.Position = 8;
		w37.Expand = false;
		w37.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.buttonInsertAfterValues = new global::Gtk.Button ();
		this.buttonInsertAfterValues.CanFocus = true;
		this.buttonInsertAfterValues.Name = "buttonInsertAfterValues";
		this.buttonInsertAfterValues.UseUnderline = true;
		this.buttonInsertAfterValues.Label = global::Mono.Unix.Catalog.GetString ("InsertAfterValues");
		this.vbox5.Add (this.buttonInsertAfterValues);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox5 [this.buttonInsertAfterValues]));
		w38.Position = 9;
		w38.Expand = false;
		w38.Fill = false;
		this.GtkAlignment1.Add (this.vbox5);
		this.frame2.Add (this.GtkAlignment1);
		this.GtkLabel10 = new global::Gtk.Label ();
		this.GtkLabel10.Name = "GtkLabel10";
		this.GtkLabel10.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Inserting Rows</b>");
		this.GtkLabel10.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel10;
		this.vbox8.Add (this.frame2);
		global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.vbox8 [this.frame2]));
		w41.Position = 0;
		w41.Expand = false;
		w41.Fill = false;
		this.hbox1.Add (this.vbox8);
		global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.vbox8]));
		w42.Position = 2;
		w42.Expand = false;
		w42.Fill = false;
		this.vbox1.Add (this.hbox1);
		global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
		w43.Position = 1;
		w43.Expand = false;
		w43.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 682;
		this.DefaultHeight = 464;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.buttonPrepend.Clicked += new global::System.EventHandler (this.OnButtonPrependClicked);
		this.buttonPrependValues.Clicked += new global::System.EventHandler (this.OnButtonPrependValuesClicked);
		this.buttonAppend.Clicked += new global::System.EventHandler (this.OnButtonAppendClicked);
		this.buttonAppendValues.Clicked += new global::System.EventHandler (this.OnButtonAppendValuesClicked);
		this.buttonRemove.Clicked += new global::System.EventHandler (this.OnButtonRemoveClicked);
		this.buttonClear.Clicked += new global::System.EventHandler (this.OnButtonClearClicked);
		this.buttonForeach.Clicked += new global::System.EventHandler (this.OnButtonForeachClicked);
		this.buttonIterateManually.Clicked += new global::System.EventHandler (this.OnButtonIterateManuallyClicked);
		this.buttonInsert.Clicked += new global::System.EventHandler (this.OnButtonInsertClicked);
		this.buttonInsertWithValues.Clicked += new global::System.EventHandler (this.OnButtonInsertWithValuesClicked);
		this.buttonInsertBefore.Clicked += new global::System.EventHandler (this.OnButtonInsertBeforeClicked);
		this.buttonInsertBeforeValues.Clicked += new global::System.EventHandler (this.OnButtonInsertBeforeValuesClicked);
		this.buttonInsertAfter.Clicked += new global::System.EventHandler (this.OnButtonInsertAfterClicked);
		this.buttonInsertAfterValues.Clicked += new global::System.EventHandler (this.OnButtonInsertAfterValuesClicked);
	}
}
