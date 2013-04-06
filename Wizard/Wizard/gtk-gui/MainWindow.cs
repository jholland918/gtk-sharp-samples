
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;
	private global::Gtk.EventBox eventboxHeader;
	private global::Gtk.Label labelHeader;
	private global::Gtk.HSeparator hseparator2;
	private global::Gtk.Notebook notebook1;
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label labelPage1;
	private global::Gtk.Label label12;
	private global::Gtk.Label labelTab1;
	private global::Gtk.Fixed fixed2;
	private global::Gtk.Label labelPage2;
	private global::Gtk.Label labelTab2;
	private global::Gtk.Fixed fixed3;
	private global::Gtk.Label labelPage3;
	private global::Gtk.Label labelTab3;
	private global::Gtk.Fixed fixed4;
	private global::Gtk.Label labelPage4;
	private global::Gtk.Label labelTab4;
	private global::Gtk.Fixed fixed5;
	private global::Gtk.Label labelPage5;
	private global::Gtk.Label labelTab5;
	private global::Gtk.HSeparator hseparator1;
	private global::Gtk.HButtonBox hbuttonbox1;
	private global::Gtk.Button buttonBack;
	private global::Gtk.Button buttonNext;
	private global::Gtk.Button buttonSkip;
	private global::Gtk.Button buttonFinish;
	private global::Gtk.Button buttonCancel;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 500;
		this.HeightRequest = 400;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		// Container child vbox1.Gtk.Box+BoxChild
		this.eventboxHeader = new global::Gtk.EventBox ();
		this.eventboxHeader.Name = "eventboxHeader";
		// Container child eventboxHeader.Gtk.Container+ContainerChild
		this.labelHeader = new global::Gtk.Label ();
		this.labelHeader.Name = "labelHeader";
		this.labelHeader.Xpad = 12;
		this.labelHeader.Ypad = 12;
		this.labelHeader.Xalign = 0F;
		this.labelHeader.LabelProp = global::Mono.Unix.Catalog.GetString ("<span weight=\"bold\" size=\"xx-large\">Wizard Sample</span>");
		this.labelHeader.UseMarkup = true;
		this.eventboxHeader.Add (this.labelHeader);
		this.vbox1.Add (this.eventboxHeader);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.eventboxHeader]));
		w2.Position = 0;
		w2.Expand = false;
		w2.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.vbox1.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator2]));
		w3.Position = 1;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.notebook1 = new global::Gtk.Notebook ();
		this.notebook1.CanFocus = true;
		this.notebook1.Name = "notebook1";
		this.notebook1.CurrentPage = 0;
		this.notebook1.ShowBorder = false;
		this.notebook1.ShowTabs = false;
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.labelPage1 = new global::Gtk.Label ();
		this.labelPage1.Name = "labelPage1";
		this.labelPage1.Xalign = 0F;
		this.labelPage1.LabelProp = global::Mono.Unix.Catalog.GetString ("Page1");
		this.fixed1.Add (this.labelPage1);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.labelPage1]));
		w4.X = 12;
		w4.Y = 12;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.label12 = new global::Gtk.Label ();
		this.label12.Name = "label12";
		this.label12.LabelProp = global::Mono.Unix.Catalog.GetString ("Use Gtk.Notebook.ShowTabs to control tab display.");
		this.fixed1.Add (this.label12);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.label12]));
		w5.X = 12;
		w5.Y = 36;
		this.notebook1.Add (this.fixed1);
		// Notebook tab
		this.labelTab1 = new global::Gtk.Label ();
		this.labelTab1.Name = "labelTab1";
		this.labelTab1.LabelProp = global::Mono.Unix.Catalog.GetString ("page1");
		this.notebook1.SetTabLabel (this.fixed1, this.labelTab1);
		this.labelTab1.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.fixed2 = new global::Gtk.Fixed ();
		this.fixed2.Name = "fixed2";
		this.fixed2.HasWindow = false;
		// Container child fixed2.Gtk.Fixed+FixedChild
		this.labelPage2 = new global::Gtk.Label ();
		this.labelPage2.Name = "labelPage2";
		this.labelPage2.LabelProp = global::Mono.Unix.Catalog.GetString ("Page2");
		this.fixed2.Add (this.labelPage2);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed2 [this.labelPage2]));
		w7.X = 12;
		w7.Y = 12;
		this.notebook1.Add (this.fixed2);
		global::Gtk.Notebook.NotebookChild w8 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.fixed2]));
		w8.Position = 1;
		// Notebook tab
		this.labelTab2 = new global::Gtk.Label ();
		this.labelTab2.Name = "labelTab2";
		this.labelTab2.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
		this.notebook1.SetTabLabel (this.fixed2, this.labelTab2);
		this.labelTab2.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.fixed3 = new global::Gtk.Fixed ();
		this.fixed3.Name = "fixed3";
		this.fixed3.HasWindow = false;
		// Container child fixed3.Gtk.Fixed+FixedChild
		this.labelPage3 = new global::Gtk.Label ();
		this.labelPage3.Name = "labelPage3";
		this.labelPage3.LabelProp = global::Mono.Unix.Catalog.GetString ("Page3");
		this.fixed3.Add (this.labelPage3);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed3 [this.labelPage3]));
		w9.X = 12;
		w9.Y = 12;
		this.notebook1.Add (this.fixed3);
		global::Gtk.Notebook.NotebookChild w10 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.fixed3]));
		w10.Position = 2;
		// Notebook tab
		this.labelTab3 = new global::Gtk.Label ();
		this.labelTab3.Name = "labelTab3";
		this.labelTab3.LabelProp = global::Mono.Unix.Catalog.GetString ("page3");
		this.notebook1.SetTabLabel (this.fixed3, this.labelTab3);
		this.labelTab3.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.fixed4 = new global::Gtk.Fixed ();
		this.fixed4.Name = "fixed4";
		this.fixed4.HasWindow = false;
		// Container child fixed4.Gtk.Fixed+FixedChild
		this.labelPage4 = new global::Gtk.Label ();
		this.labelPage4.Name = "labelPage4";
		this.labelPage4.LabelProp = global::Mono.Unix.Catalog.GetString ("Page4");
		this.fixed4.Add (this.labelPage4);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed4 [this.labelPage4]));
		w11.X = 12;
		w11.Y = 12;
		this.notebook1.Add (this.fixed4);
		global::Gtk.Notebook.NotebookChild w12 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.fixed4]));
		w12.Position = 3;
		// Notebook tab
		this.labelTab4 = new global::Gtk.Label ();
		this.labelTab4.Name = "labelTab4";
		this.labelTab4.LabelProp = global::Mono.Unix.Catalog.GetString ("page4");
		this.notebook1.SetTabLabel (this.fixed4, this.labelTab4);
		this.labelTab4.ShowAll ();
		// Container child notebook1.Gtk.Notebook+NotebookChild
		this.fixed5 = new global::Gtk.Fixed ();
		this.fixed5.Name = "fixed5";
		this.fixed5.HasWindow = false;
		// Container child fixed5.Gtk.Fixed+FixedChild
		this.labelPage5 = new global::Gtk.Label ();
		this.labelPage5.Name = "labelPage5";
		this.labelPage5.LabelProp = global::Mono.Unix.Catalog.GetString ("Page5");
		this.fixed5.Add (this.labelPage5);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed5 [this.labelPage5]));
		w13.X = 12;
		w13.Y = 12;
		this.notebook1.Add (this.fixed5);
		global::Gtk.Notebook.NotebookChild w14 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.fixed5]));
		w14.Position = 4;
		// Notebook tab
		this.labelTab5 = new global::Gtk.Label ();
		this.labelTab5.Name = "labelTab5";
		this.labelTab5.LabelProp = global::Mono.Unix.Catalog.GetString ("page5");
		this.notebook1.SetTabLabel (this.fixed5, this.labelTab5);
		this.labelTab5.ShowAll ();
		this.vbox1.Add (this.notebook1);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.notebook1]));
		w15.Position = 2;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox1.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hseparator1]));
		w16.Position = 3;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbuttonbox1 = new global::Gtk.HButtonBox ();
		this.hbuttonbox1.Name = "hbuttonbox1";
		this.hbuttonbox1.Spacing = 5;
		this.hbuttonbox1.BorderWidth = ((uint)(6));
		this.hbuttonbox1.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonBack = new global::Gtk.Button ();
		this.buttonBack.CanFocus = true;
		this.buttonBack.Name = "buttonBack";
		this.buttonBack.UseUnderline = true;
		this.buttonBack.Label = global::Mono.Unix.Catalog.GetString ("< Back");
		this.hbuttonbox1.Add (this.buttonBack);
		global::Gtk.ButtonBox.ButtonBoxChild w17 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonBack]));
		w17.Expand = false;
		w17.Fill = false;
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonNext = new global::Gtk.Button ();
		this.buttonNext.CanFocus = true;
		this.buttonNext.Name = "buttonNext";
		this.buttonNext.UseUnderline = true;
		this.buttonNext.Label = global::Mono.Unix.Catalog.GetString ("Next >");
		this.hbuttonbox1.Add (this.buttonNext);
		global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonNext]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonSkip = new global::Gtk.Button ();
		this.buttonSkip.CanFocus = true;
		this.buttonSkip.Name = "buttonSkip";
		this.buttonSkip.UseUnderline = true;
		this.buttonSkip.Label = global::Mono.Unix.Catalog.GetString ("Skip >|");
		this.hbuttonbox1.Add (this.buttonSkip);
		global::Gtk.ButtonBox.ButtonBoxChild w19 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonSkip]));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonFinish = new global::Gtk.Button ();
		this.buttonFinish.CanFocus = true;
		this.buttonFinish.Name = "buttonFinish";
		this.buttonFinish.UseUnderline = true;
		this.buttonFinish.Label = global::Mono.Unix.Catalog.GetString ("Finish");
		this.hbuttonbox1.Add (this.buttonFinish);
		global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonFinish]));
		w20.Position = 3;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbuttonbox1.Gtk.ButtonBox+ButtonBoxChild
		this.buttonCancel = new global::Gtk.Button ();
		this.buttonCancel.CanFocus = true;
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.UseUnderline = true;
		this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Cancel");
		this.hbuttonbox1.Add (this.buttonCancel);
		global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox1 [this.buttonCancel]));
		w21.Position = 4;
		w21.Expand = false;
		w21.Fill = false;
		this.vbox1.Add (this.hbuttonbox1);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbuttonbox1]));
		w22.Position = 4;
		w22.Expand = false;
		w22.Fill = false;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 500;
		this.DefaultHeight = 400;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.notebook1.SwitchPage += new global::Gtk.SwitchPageHandler (this.OnNotebook1SwitchPage);
		this.buttonBack.Clicked += new global::System.EventHandler (this.OnButtonBackClicked);
		this.buttonNext.Clicked += new global::System.EventHandler (this.OnButtonNextClicked);
		this.buttonSkip.Clicked += new global::System.EventHandler (this.OnButtonSkipClicked);
		this.buttonFinish.Clicked += new global::System.EventHandler (this.OnButtonFinishClicked);
		this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
	}
}