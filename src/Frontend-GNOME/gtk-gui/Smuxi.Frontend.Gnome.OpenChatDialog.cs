
// This file has been generated by the GUI designer. Do not modify.
namespace Smuxi.Frontend.Gnome
{
	public partial class OpenChatDialog
	{
		private global::Gtk.Table table1;

		private global::Smuxi.Frontend.Gnome.ChatTypeWidget f_ChatTypeWidget;

		private global::Gtk.Entry f_NameEntry;

		private global::Gtk.Label label1;

		private global::Gtk.Label label2;

		private global::Gtk.Button f_CancelButton;

		private global::Gtk.Button f_OpenButton;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Smuxi.Frontend.Gnome.OpenChatDialog
			this.Name = "Smuxi.Frontend.Gnome.OpenChatDialog";
			this.Title = global::Mono.Unix.Catalog.GetString ("Smuxi - Open Chat");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			this.AllowGrow = false;
			// Internal child Smuxi.Frontend.Gnome.OpenChatDialog.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			this.table1.BorderWidth = ((uint)(5));
			// Container child table1.Gtk.Table+TableChild
			this.f_ChatTypeWidget = null;
			this.table1.Add (this.f_ChatTypeWidget);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table1[this.f_ChatTypeWidget]));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.f_NameEntry = new global::Gtk.Entry ();
			this.f_NameEntry.CanFocus = true;
			this.f_NameEntry.Name = "f_NameEntry";
			this.f_NameEntry.IsEditable = true;
			this.f_NameEntry.ActivatesDefault = true;
			this.f_NameEntry.InvisibleChar = '●';
			this.table1.Add (this.f_NameEntry);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.f_NameEntry]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0f;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("_Type:");
			this.label1.UseUnderline = true;
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.label1]));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0f;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("_Name:");
			this.label2.UseUnderline = true;
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.label2]));
			w5.TopAttach = ((uint)(1));
			w5.BottomAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1[this.table1]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Internal child Smuxi.Frontend.Gnome.OpenChatDialog.ActionArea
			global::Gtk.HButtonBox w7 = this.ActionArea;
			w7.Name = "dialog1_ActionArea";
			w7.Spacing = 6;
			w7.BorderWidth = ((uint)(5));
			w7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.f_CancelButton = new global::Gtk.Button ();
			this.f_CancelButton.CanFocus = true;
			this.f_CancelButton.Name = "f_CancelButton";
			this.f_CancelButton.UseStock = true;
			this.f_CancelButton.UseUnderline = true;
			this.f_CancelButton.Label = "gtk-cancel";
			this.AddActionWidget (this.f_CancelButton, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7[this.f_CancelButton]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.f_OpenButton = new global::Gtk.Button ();
			this.f_OpenButton.Sensitive = false;
			this.f_OpenButton.CanDefault = true;
			this.f_OpenButton.CanFocus = true;
			this.f_OpenButton.Name = "f_OpenButton";
			this.f_OpenButton.UseStock = true;
			this.f_OpenButton.UseUnderline = true;
			this.f_OpenButton.Label = "gtk-open";
			this.AddActionWidget (this.f_OpenButton, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7[this.f_OpenButton]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 236;
			this.DefaultHeight = 153;
			this.f_OpenButton.HasDefault = true;
			this.Show ();
		}
	}
}
