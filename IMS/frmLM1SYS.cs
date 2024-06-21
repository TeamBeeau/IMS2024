using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using IMS.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IMS
{
	[DesignerGenerated]
	public class frmLM1SYS : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnSAVE")]
		private Button _btnSAVE;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		private OleDbCommand Cmd;

		private SqlDataAdapter Da;

		private SqlDataReader Dr;

		private string strMessage;

		[field: AccessedThroughProperty("details")]
		internal virtual TableLayoutPanel details
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSYSCD")]
		internal virtual Label lblSYSCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSYSNM")]
		internal virtual Label lblSYSNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblEMAIL")]
		internal virtual Label lblEMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblREMRK")]
		internal virtual Label lblREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblADDR")]
		internal virtual Label lblADDR
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL01")]
		internal virtual Label lblTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblFAXNO")]
		internal virtual Label lblFAXNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblTEL02")]
		internal virtual Label lblTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREMRK")]
		internal virtual TextBox txtREMRK
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFAXNO1")]
		internal virtual TextBox txtFAXNO1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR3")]
		internal virtual TextBox txtADDR3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR2")]
		internal virtual TextBox txtADDR2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR1")]
		internal virtual TextBox txtADDR1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCOMNM")]
		internal virtual TextBox txtCOMNM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtCOMCD")]
		internal virtual TextBox txtCOMCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTEL01")]
		internal virtual TextBox txtTEL01
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtADDR4")]
		internal virtual TextBox txtADDR4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtTEL02")]
		internal virtual TextBox txtTEL02
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtEMAIL")]
		internal virtual TextBox txtEMAIL
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblSTACD")]
		internal virtual Label lblSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("lblCNTRY")]
		internal virtual Label lblCNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("TableLayoutPanel1")]
		internal virtual TableLayoutPanel TableLayoutPanel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label3")]
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label2")]
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label1")]
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label7")]
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label4")]
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label5")]
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtREGNO")]
		internal virtual TextBox txtREGNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtHPAGE")]
		internal virtual TextBox txtHPAGE
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtGSTID")]
		internal virtual TextBox txtGSTID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtFAXNO2")]
		internal virtual TextBox txtFAXNO2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("txtPIC")]
		internal virtual TextBox txtPIC
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		internal virtual Button btnSAVE
		{
			[CompilerGenerated]
			get
			{
				return _btnSAVE;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnSAVE_Click;
				Button button = _btnSAVE;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnSAVE = value;
				button = _btnSAVE;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		internal virtual Button btnClose
		{
			[CompilerGenerated]
			get
			{
				return _btnClose;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[CompilerGenerated]
			set
			{
				EventHandler value2 = btnClose_Click;
				Button button = _btnClose;
				if (button != null)
				{
					button.Click -= value2;
				}
				_btnClose = value;
				button = _btnClose;
				if (button != null)
				{
					button.Click += value2;
				}
			}
		}

		[field: AccessedThroughProperty("Panel1")]
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("Label6")]
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbUOM")]
		internal virtual ComboBox cbUOM
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCURCD")]
		internal virtual ComboBox cbCURCD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbSTACD")]
		internal virtual ComboBox cbSTACD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("cbCNTRY")]
		internal virtual ComboBox cbCNTRY
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		[field: AccessedThroughProperty("chkIGRD")]
		internal virtual CheckBox chkIGRD
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		public frmLM1SYS()
		{
			base.Load += frmISYS_Load;
			base.FormClosing += frmMAECOD_FormClosing;
			Cmd = new OleDbCommand();
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.details = new System.Windows.Forms.TableLayoutPanel();
			this.cbCURCD = new System.Windows.Forms.ComboBox();
			this.cbSTACD = new System.Windows.Forms.ComboBox();
			this.cbCNTRY = new System.Windows.Forms.ComboBox();
			this.cbUOM = new System.Windows.Forms.ComboBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtHPAGE = new System.Windows.Forms.TextBox();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSAVE = new System.Windows.Forms.Button();
			this.txtGSTID = new System.Windows.Forms.TextBox();
			this.txtFAXNO2 = new System.Windows.Forms.TextBox();
			this.txtPIC = new System.Windows.Forms.TextBox();
			this.txtREGNO = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.lblSTACD = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.lblCNTRY = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtREMRK = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txtFAXNO1 = new System.Windows.Forms.TextBox();
			this.txtADDR3 = new System.Windows.Forms.TextBox();
			this.txtADDR2 = new System.Windows.Forms.TextBox();
			this.txtADDR1 = new System.Windows.Forms.TextBox();
			this.txtCOMNM = new System.Windows.Forms.TextBox();
			this.lblSYSCD = new System.Windows.Forms.Label();
			this.txtCOMCD = new System.Windows.Forms.TextBox();
			this.lblSYSNM = new System.Windows.Forms.Label();
			this.lblEMAIL = new System.Windows.Forms.Label();
			this.lblREMRK = new System.Windows.Forms.Label();
			this.lblADDR = new System.Windows.Forms.Label();
			this.lblTEL01 = new System.Windows.Forms.Label();
			this.lblFAXNO = new System.Windows.Forms.Label();
			this.lblTEL02 = new System.Windows.Forms.Label();
			this.txtTEL01 = new System.Windows.Forms.TextBox();
			this.txtADDR4 = new System.Windows.Forms.TextBox();
			this.txtTEL02 = new System.Windows.Forms.TextBox();
			this.txtEMAIL = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.chkIGRD = new System.Windows.Forms.CheckBox();
			this.details.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.details.AutoSize = true;
			this.details.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.details.ColumnCount = 3;
			this.details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.details.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.details.Controls.Add(this.chkIGRD, 2, 0);
			this.details.Controls.Add(this.cbCURCD, 1, 11);
			this.details.Controls.Add(this.cbSTACD, 1, 9);
			this.details.Controls.Add(this.cbCNTRY, 1, 8);
			this.details.Controls.Add(this.cbUOM, 1, 10);
			this.details.Controls.Add(this.Label6, 0, 10);
			this.details.Controls.Add(this.txtHPAGE, 1, 17);
			this.details.Controls.Add(this.TableLayoutPanel1, 0, 21);
			this.details.Controls.Add(this.txtGSTID, 1, 18);
			this.details.Controls.Add(this.txtFAXNO2, 1, 15);
			this.details.Controls.Add(this.txtPIC, 1, 7);
			this.details.Controls.Add(this.txtREGNO, 1, 2);
			this.details.Controls.Add(this.Label5, 0, 18);
			this.details.Controls.Add(this.Label4, 0, 17);
			this.details.Controls.Add(this.lblSTACD, 0, 9);
			this.details.Controls.Add(this.Label3, 0, 11);
			this.details.Controls.Add(this.lblCNTRY, 0, 8);
			this.details.Controls.Add(this.Label2, 0, 7);
			this.details.Controls.Add(this.txtREMRK, 1, 19);
			this.details.Controls.Add(this.Label1, 0, 2);
			this.details.Controls.Add(this.txtFAXNO1, 1, 14);
			this.details.Controls.Add(this.txtADDR3, 1, 5);
			this.details.Controls.Add(this.txtADDR2, 1, 4);
			this.details.Controls.Add(this.txtADDR1, 1, 3);
			this.details.Controls.Add(this.txtCOMNM, 1, 1);
			this.details.Controls.Add(this.lblSYSCD, 0, 0);
			this.details.Controls.Add(this.txtCOMCD, 1, 0);
			this.details.Controls.Add(this.lblSYSNM, 0, 1);
			this.details.Controls.Add(this.lblEMAIL, 0, 16);
			this.details.Controls.Add(this.lblREMRK, 0, 19);
			this.details.Controls.Add(this.lblADDR, 0, 3);
			this.details.Controls.Add(this.lblTEL01, 0, 12);
			this.details.Controls.Add(this.lblFAXNO, 0, 14);
			this.details.Controls.Add(this.lblTEL02, 0, 13);
			this.details.Controls.Add(this.txtTEL01, 1, 12);
			this.details.Controls.Add(this.txtADDR4, 1, 6);
			this.details.Controls.Add(this.txtTEL02, 1, 13);
			this.details.Controls.Add(this.txtEMAIL, 1, 16);
			this.details.Controls.Add(this.Label7, 0, 15);
			this.details.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.details.Location = new System.Drawing.Point(7, 4);
			this.details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.details.Name = "details";
			this.details.RowCount = 22;
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10f));
			this.details.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.details.Size = new System.Drawing.Size(610, 626);
			this.details.TabIndex = 0;
			this.cbCURCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbCURCD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCURCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbCURCD.FormattingEnabled = true;
			this.cbCURCD.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cbCURCD.Location = new System.Drawing.Point(117, 318);
			this.cbCURCD.Margin = new System.Windows.Forms.Padding(5);
			this.cbCURCD.Name = "cbCURCD";
			this.cbCURCD.Size = new System.Drawing.Size(120, 25);
			this.cbCURCD.TabIndex = 12;
			this.cbSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbSTACD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSTACD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbSTACD.FormattingEnabled = true;
			this.cbSTACD.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cbSTACD.Location = new System.Drawing.Point(117, 248);
			this.cbSTACD.Margin = new System.Windows.Forms.Padding(5);
			this.cbSTACD.Name = "cbSTACD";
			this.cbSTACD.Size = new System.Drawing.Size(120, 25);
			this.cbSTACD.TabIndex = 13;
			this.cbCNTRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbCNTRY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCNTRY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbCNTRY.FormattingEnabled = true;
			this.cbCNTRY.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cbCNTRY.Location = new System.Drawing.Point(117, 213);
			this.cbCNTRY.Margin = new System.Windows.Forms.Padding(5);
			this.cbCNTRY.Name = "cbCNTRY";
			this.cbCNTRY.Size = new System.Drawing.Size(120, 25);
			this.cbCNTRY.TabIndex = 12;
			this.cbUOM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.cbUOM.FormattingEnabled = true;
			this.cbUOM.Items.AddRange(new object[3] { "Exclude", "Include", "Auto Plan" });
			this.cbUOM.Location = new System.Drawing.Point(117, 283);
			this.cbUOM.Margin = new System.Windows.Forms.Padding(5);
			this.cbUOM.Name = "cbUOM";
			this.cbUOM.Size = new System.Drawing.Size(120, 25);
			this.cbUOM.TabIndex = 11;
			this.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label6.Location = new System.Drawing.Point(3, 287);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(74, 16);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Base UOM";
			this.txtHPAGE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtHPAGE.Location = new System.Drawing.Point(115, 480);
			this.txtHPAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtHPAGE.Name = "txtHPAGE";
			this.txtHPAGE.Size = new System.Drawing.Size(400, 22);
			this.txtHPAGE.TabIndex = 17;
			this.TableLayoutPanel1.AutoSize = true;
			this.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.details.SetColumnSpan(this.TableLayoutPanel1, 2);
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27f));
			this.TableLayoutPanel1.Controls.Add(this.btnClose, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btnSAVE, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(3, 569);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.Size = new System.Drawing.Size(260, 54);
			this.TableLayoutPanel1.TabIndex = 8;
			this.btnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.btnClose.Image = IMS.My.Resources.Resources.Close;
			this.btnClose.Location = new System.Drawing.Point(135, 2);
			this.btnClose.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(120, 50);
			this.btnClose.TabIndex = 20;
			this.btnClose.Text = "Close";
			this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnSAVE.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnSAVE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSAVE.Image = IMS.My.Resources.Resources.Save;
			this.btnSAVE.Location = new System.Drawing.Point(5, 2);
			this.btnSAVE.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
			this.btnSAVE.Name = "btnSAVE";
			this.btnSAVE.Size = new System.Drawing.Size(120, 50);
			this.btnSAVE.TabIndex = 19;
			this.btnSAVE.Text = "Save";
			this.btnSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSAVE.UseVisualStyleBackColor = false;
			this.txtGSTID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtGSTID.Location = new System.Drawing.Point(115, 506);
			this.txtGSTID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtGSTID.Name = "txtGSTID";
			this.txtGSTID.Size = new System.Drawing.Size(221, 22);
			this.txtGSTID.TabIndex = 18;
			this.txtFAXNO2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtFAXNO2.Location = new System.Drawing.Point(115, 428);
			this.txtFAXNO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO2.Name = "txtFAXNO2";
			this.txtFAXNO2.Size = new System.Drawing.Size(221, 22);
			this.txtFAXNO2.TabIndex = 15;
			this.txtPIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtPIC.Location = new System.Drawing.Point(115, 184);
			this.txtPIC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtPIC.Name = "txtPIC";
			this.txtPIC.Size = new System.Drawing.Size(221, 22);
			this.txtPIC.TabIndex = 8;
			this.txtREGNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtREGNO.Location = new System.Drawing.Point(115, 54);
			this.txtREGNO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREGNO.Name = "txtREGNO";
			this.txtREGNO.Size = new System.Drawing.Size(221, 22);
			this.txtREGNO.TabIndex = 3;
			this.Label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label5.Location = new System.Drawing.Point(3, 509);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(52, 16);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "GST ID";
			this.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label4.AutoSize = true;
			this.Label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label4.Location = new System.Drawing.Point(3, 483);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(73, 16);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "Web Page";
			this.lblSTACD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSTACD.AutoSize = true;
			this.lblSTACD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSTACD.Location = new System.Drawing.Point(3, 252);
			this.lblSTACD.Name = "lblSTACD";
			this.lblSTACD.Size = new System.Drawing.Size(39, 16);
			this.lblSTACD.TabIndex = 7;
			this.lblSTACD.Text = "State";
			this.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label3.AutoSize = true;
			this.Label3.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label3.Location = new System.Drawing.Point(3, 322);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(97, 16);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Currency Code";
			this.lblCNTRY.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblCNTRY.AutoSize = true;
			this.lblCNTRY.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblCNTRY.Location = new System.Drawing.Point(3, 217);
			this.lblCNTRY.Name = "lblCNTRY";
			this.lblCNTRY.Size = new System.Drawing.Size(53, 16);
			this.lblCNTRY.TabIndex = 8;
			this.lblCNTRY.Text = "Country";
			this.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label2.AutoSize = true;
			this.Label2.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label2.Location = new System.Drawing.Point(3, 187);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(29, 16);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "PIC";
			this.txtREMRK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtREMRK.Location = new System.Drawing.Point(115, 532);
			this.txtREMRK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtREMRK.Name = "txtREMRK";
			this.txtREMRK.Size = new System.Drawing.Size(400, 22);
			this.txtREMRK.TabIndex = 18;
			this.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label1.Location = new System.Drawing.Point(3, 57);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(101, 16);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Registration No";
			this.txtFAXNO1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtFAXNO1.Location = new System.Drawing.Point(115, 402);
			this.txtFAXNO1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtFAXNO1.Name = "txtFAXNO1";
			this.txtFAXNO1.Size = new System.Drawing.Size(221, 22);
			this.txtFAXNO1.TabIndex = 14;
			this.txtADDR3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtADDR3.Location = new System.Drawing.Point(115, 132);
			this.txtADDR3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR3.Name = "txtADDR3";
			this.txtADDR3.Size = new System.Drawing.Size(400, 22);
			this.txtADDR3.TabIndex = 6;
			this.txtADDR2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtADDR2.Location = new System.Drawing.Point(115, 106);
			this.txtADDR2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR2.Name = "txtADDR2";
			this.txtADDR2.Size = new System.Drawing.Size(400, 22);
			this.txtADDR2.TabIndex = 5;
			this.txtADDR1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtADDR1.Location = new System.Drawing.Point(115, 80);
			this.txtADDR1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR1.Name = "txtADDR1";
			this.txtADDR1.Size = new System.Drawing.Size(400, 22);
			this.txtADDR1.TabIndex = 4;
			this.txtCOMNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCOMNM.Location = new System.Drawing.Point(115, 28);
			this.txtCOMNM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCOMNM.Name = "txtCOMNM";
			this.txtCOMNM.Size = new System.Drawing.Size(400, 22);
			this.txtCOMNM.TabIndex = 2;
			this.lblSYSCD.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSYSCD.AutoSize = true;
			this.lblSYSCD.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSYSCD.Location = new System.Drawing.Point(3, 5);
			this.lblSYSCD.Name = "lblSYSCD";
			this.lblSYSCD.Size = new System.Drawing.Size(102, 16);
			this.lblSYSCD.TabIndex = 1;
			this.lblSYSCD.Text = "Company Code";
			this.txtCOMCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtCOMCD.Location = new System.Drawing.Point(115, 2);
			this.txtCOMCD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtCOMCD.Name = "txtCOMCD";
			this.txtCOMCD.Size = new System.Drawing.Size(221, 22);
			this.txtCOMCD.TabIndex = 1;
			this.lblSYSNM.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblSYSNM.AutoSize = true;
			this.lblSYSNM.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblSYSNM.Location = new System.Drawing.Point(3, 31);
			this.lblSYSNM.Name = "lblSYSNM";
			this.lblSYSNM.Size = new System.Drawing.Size(106, 16);
			this.lblSYSNM.TabIndex = 2;
			this.lblSYSNM.Text = "Company Name";
			this.lblEMAIL.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblEMAIL.AutoSize = true;
			this.lblEMAIL.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblEMAIL.Location = new System.Drawing.Point(3, 457);
			this.lblEMAIL.Name = "lblEMAIL";
			this.lblEMAIL.Size = new System.Drawing.Size(42, 16);
			this.lblEMAIL.TabIndex = 7;
			this.lblEMAIL.Text = "Email";
			this.lblREMRK.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblREMRK.AutoSize = true;
			this.lblREMRK.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblREMRK.Location = new System.Drawing.Point(3, 535);
			this.lblREMRK.Name = "lblREMRK";
			this.lblREMRK.Size = new System.Drawing.Size(56, 16);
			this.lblREMRK.TabIndex = 8;
			this.lblREMRK.Text = "Remark";
			this.lblADDR.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblADDR.AutoSize = true;
			this.lblADDR.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblADDR.Location = new System.Drawing.Point(3, 83);
			this.lblADDR.Name = "lblADDR";
			this.lblADDR.Size = new System.Drawing.Size(62, 16);
			this.lblADDR.TabIndex = 3;
			this.lblADDR.Text = "Address ";
			this.lblTEL01.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL01.AutoSize = true;
			this.lblTEL01.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL01.Location = new System.Drawing.Point(3, 353);
			this.lblTEL01.Name = "lblTEL01";
			this.lblTEL01.Size = new System.Drawing.Size(38, 16);
			this.lblTEL01.TabIndex = 4;
			this.lblTEL01.Text = "Tel 1";
			this.lblFAXNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblFAXNO.AutoSize = true;
			this.lblFAXNO.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblFAXNO.Location = new System.Drawing.Point(3, 405);
			this.lblFAXNO.Name = "lblFAXNO";
			this.lblFAXNO.Size = new System.Drawing.Size(61, 16);
			this.lblFAXNO.TabIndex = 6;
			this.lblFAXNO.Text = "Fax No 1";
			this.lblTEL02.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.lblTEL02.AutoSize = true;
			this.lblTEL02.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblTEL02.Location = new System.Drawing.Point(3, 379);
			this.lblTEL02.Name = "lblTEL02";
			this.lblTEL02.Size = new System.Drawing.Size(38, 16);
			this.lblTEL02.TabIndex = 5;
			this.lblTEL02.Text = "Tel 2";
			this.txtTEL01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTEL01.Location = new System.Drawing.Point(115, 350);
			this.txtTEL01.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL01.Name = "txtTEL01";
			this.txtTEL01.Size = new System.Drawing.Size(221, 22);
			this.txtTEL01.TabIndex = 12;
			this.txtADDR4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtADDR4.Location = new System.Drawing.Point(115, 158);
			this.txtADDR4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtADDR4.Name = "txtADDR4";
			this.txtADDR4.Size = new System.Drawing.Size(400, 22);
			this.txtADDR4.TabIndex = 7;
			this.txtTEL02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtTEL02.Location = new System.Drawing.Point(115, 376);
			this.txtTEL02.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtTEL02.Name = "txtTEL02";
			this.txtTEL02.Size = new System.Drawing.Size(221, 22);
			this.txtTEL02.TabIndex = 13;
			this.txtEMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.txtEMAIL.Location = new System.Drawing.Point(115, 454);
			this.txtEMAIL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtEMAIL.Name = "txtEMAIL";
			this.txtEMAIL.Size = new System.Drawing.Size(400, 22);
			this.txtEMAIL.TabIndex = 16;
			this.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.Label7.AutoSize = true;
			this.Label7.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.Label7.Location = new System.Drawing.Point(3, 431);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(61, 16);
			this.Label7.TabIndex = 14;
			this.Label7.Text = "Fax No 2";
			this.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.Panel1.AutoScroll = true;
			this.Panel1.Controls.Add(this.details);
			this.Panel1.Location = new System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1362, 636);
			this.Panel1.TabIndex = 9;
			this.chkIGRD.AutoSize = true;
			this.chkIGRD.Location = new System.Drawing.Point(521, 3);
			this.chkIGRD.Name = "chkIGRD";
			this.chkIGRD.Size = new System.Drawing.Size(86, 20);
			this.chkIGRD.TabIndex = 1;
			this.chkIGRD.Text = "Ingredient";
			this.chkIGRD.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.AliceBlue;
			base.ClientSize = new System.Drawing.Size(1370, 631);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			base.KeyPreview = true;
			base.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			base.Name = "frmLM1SYS";
			this.Text = "Company Profile";
			this.details.ResumeLayout(false);
			this.details.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		private void BindComboBox()
		{
			string strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH (NOLOCK) WHERE MACOD_CTYID = 'UOM' ORDER BY MACOD_CODID";
			cbUOM.ValueMember = "MACOD_CODID";
			cbUOM.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbUOM);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CURCD' ";
			strSQL += " ORDER BY MACOD_CODID ";
			cbCURCD.ValueMember = "MACOD_CODID";
			cbCURCD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCURCD);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'CNTRY' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbCNTRY.ValueMember = "MACOD_CODID";
			cbCNTRY.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbCNTRY);
			strSQL = "SELECT DISTINCT MACOD_CODID, MACOD_CODNM ";
			strSQL += "FROM MACOD_TBL WITH(NOLOCK) ";
			strSQL += "WHERE MACOD_CTYID = 'STACD' ";
			strSQL += "ORDER BY MACOD_CODID ";
			cbSTACD.ValueMember = "MACOD_CODID";
			cbSTACD.DisplayMember = "MACOD_CODNM";
			Common.RetriveComboItembySQL(strSQL, cbSTACD);
		}

		private bool SaveRecord()
		{
			string strSQL = string.Empty;
			bool SaveRecord = default(bool);
			if (ValidateDetailControl())
			{
				if (Operators.CompareString(btnSAVE.Text, "Save", false) == 0)
				{
					strSQL = "INSERT INTO LMSYS_TBL (LMSYS_COMCD, LMSYS_COMNM, LMSYS_REGNO, LMSYS_ADDR1, LMSYS_ADDR2, LMSYS_ADDR3, ";
					strSQL += "LMSYS_ADDR4, LMSYS_PIC, LMSYS_CNTRY, LMSYS_STACD, LMSYS_BUOM, LMSYS_CURCD, LMSYS_TEL01, LMSYS_TEL02, ";
					strSQL += "LMSYS_FAXNO1, LMSYS_FAXNO2, LMSYS_EMAIL, LMSYS_HPAGE, LMSYS_GSTID, LMSYS_IGRDFG, LMSYS_REMRK, LMSYS_ENTDT, LMSYS_ENTBY, ";
					strSQL += "LMSYS_LUPDT, LMSYS_LUPBY) ";
					strSQL += "VALUES (";
					strSQL = strSQL + "'" + txtCOMCD.Text + "', ";
					strSQL = strSQL + "'" + txtCOMNM.Text + "', ";
					strSQL = strSQL + "'" + txtREGNO.Text + "', ";
					strSQL = strSQL + "'" + txtADDR1.Text + "', ";
					strSQL = strSQL + "'" + txtADDR2.Text + "', ";
					strSQL = strSQL + "'" + txtADDR3.Text + "', ";
					strSQL = strSQL + "'" + txtADDR4.Text + "', ";
					strSQL = strSQL + "'" + txtPIC.Text + "', ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCNTRY.SelectedValue), "', ")));
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbSTACD.SelectedValue), "', ")));
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbUOM.SelectedValue), "', ")));
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", cbCURCD.SelectedValue), "', ")));
					strSQL = strSQL + "'" + txtTEL01.Text + "', ";
					strSQL = strSQL + "'" + txtTEL02.Text + "', ";
					strSQL = strSQL + "'" + txtFAXNO1.Text + "', ";
					strSQL = strSQL + "'" + txtFAXNO2.Text + "', ";
					strSQL = strSQL + "'" + txtEMAIL.Text + "', ";
					strSQL = strSQL + "'" + txtHPAGE.Text + "', ";
					strSQL = strSQL + "'" + txtGSTID.Text + "', ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("'", Interaction.IIf(chkIGRD.Checked, 1, 0)), "', ")));
					strSQL = strSQL + "'" + txtREMRK.Text + "', ";
					strSQL = strSQL + "'" + Common.gfSQLDate(DateTime.Now) + "', ";
					strSQL = strSQL + "'" + PublicVar.gstrLogonID + "', ";
					strSQL = strSQL + "'" + Common.gfSQLDate(DateTime.Now) + "', ";
					strSQL = strSQL + "'" + PublicVar.gstrLogonID + "')";
				}
				else
				{
					strSQL = "UPDATE LMSYS_TBL SET ";
					strSQL = strSQL + "LMSYS_COMNM = '" + txtCOMNM.Text + "', ";
					strSQL = strSQL + "LMSYS_REGNO = '" + txtREGNO.Text + "', ";
					strSQL = strSQL + "LMSYS_ADDR1 = '" + txtADDR1.Text + "', ";
					strSQL = strSQL + "LMSYS_ADDR2 = '" + txtADDR2.Text + "', ";
					strSQL = strSQL + "LMSYS_ADDR3 = '" + txtADDR3.Text + "', ";
					strSQL = strSQL + "LMSYS_ADDR4 = '" + txtADDR4.Text + "', ";
					strSQL = strSQL + "LMSYS_PIC = '" + txtPIC.Text + "', ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("LMSYS_CNTRY = '", cbCNTRY.SelectedValue), "', ")));
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("LMSYS_STACD = '", cbSTACD.SelectedValue), "', ")));
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("LMSYS_BUOM = '", cbUOM.SelectedValue), "', ")));
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("LMSYS_CURCD = '", cbCURCD.SelectedValue), "', ")));
					strSQL = strSQL + "LMSYS_TEL01 = '" + txtTEL01.Text + "', ";
					strSQL = strSQL + "LMSYS_TEL02 = '" + txtTEL02.Text + "', ";
					strSQL = strSQL + "LMSYS_FAXNO1 = '" + txtFAXNO1.Text + "', ";
					strSQL = strSQL + "LMSYS_FAXNO2 = '" + txtFAXNO2.Text + "', ";
					strSQL = strSQL + "LMSYS_EMAIL = '" + txtEMAIL.Text + "', ";
					strSQL = strSQL + "LMSYS_HPAGE = '" + txtHPAGE.Text + "', ";
					strSQL = strSQL + "LMSYS_GSTID = '" + txtGSTID.Text + "', ";
					strSQL = Conversions.ToString(Operators.ConcatenateObject(strSQL, Operators.ConcatenateObject(Operators.ConcatenateObject("LMSYS_IGRDFG = '", Interaction.IIf(chkIGRD.Checked, 1, 0)), "', ")));
					strSQL = strSQL + "LMSYS_REMRK = '" + txtREMRK.Text + "', ";
					strSQL = strSQL + "LMSYS_LUPDT = '" + Common.gfSQLDate(DateTime.Now) + "', ";
					strSQL = strSQL + "LMSYS_LUPBY = '" + PublicVar.gstrLogonID + "' ";
					strSQL = strSQL + "WHERE LMSYS_COMCD = '" + txtCOMCD.Text + "'";
				}
				try
				{
					Cmd.Connection = DB.GetDBConnection();
					Cmd.CommandText = strSQL;
					int intAffected = Cmd.ExecuteNonQuery();
					MessageBox.Show(strMessage, strMessage, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2);
					Exception ex = ex2;
					MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					SaveRecord = false;
					ProjectData.ClearProjectError();
					goto IL_06dd;
				}
				BindDatafromDB();
				SaveRecord = true;
			}
			goto IL_06dd;
			IL_06dd:
			return SaveRecord;
		}

		private void btnSAVE_Click(object sender, EventArgs e)
		{
			strMessage = ("Record " + btnSAVE.Text) ?? "";
			SaveRecord();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private bool BindDatafromDB()
		{
			string strSQL = "SELECT TOP 1 LMSYS_COMCD, LMSYS_COMNM, LMSYS_REGNO, LMSYS_ADDR1, LMSYS_ADDR2, LMSYS_ADDR3, ";
			strSQL += "LMSYS_ADDR4, LMSYS_PIC, LMSYS_CNTRY, LMSYS_STACD, LMSYS_BUOM, LMSYS_CURCD, LMSYS_TEL01, LMSYS_TEL02, ";
			strSQL += "LMSYS_FAXNO1, LMSYS_FAXNO2, LMSYS_EMAIL, LMSYS_HPAGE, LMSYS_GSTID, LMSYS_IGRDFG, LMSYS_REMRK, LMSYS_ENTDT, LMSYS_ENTBY, ";
			strSQL += "LMSYS_LUPDT, LMSYS_LUPBY ";
			strSQL += "FROM LMSYS_TBL ";
			DataTable dt = DB.ExecProc(strSQL);
			bool BindDatafromDB = default(bool);
			checked
			{
				if (dt.Rows.Count == 0)
				{
					btnSAVE.Text = "Save";
					txtCOMCD.Enabled = true;
				}
				else
				{
					try
					{
						int num = dt.Rows.Count - 1;
						for (int i = 0; i <= num; i++)
						{
							txtCOMCD.Text = dt.Rows[i]["LMSYS_COMCD"].ToString();
							txtCOMNM.Text = dt.Rows[i]["LMSYS_COMNM"].ToString();
							txtREGNO.Text = dt.Rows[i]["LMSYS_REGNO"].ToString();
							txtADDR1.Text = dt.Rows[i]["LMSYS_ADDR1"].ToString();
							txtADDR2.Text = dt.Rows[i]["LMSYS_ADDR2"].ToString();
							txtADDR3.Text = dt.Rows[i]["LMSYS_ADDR3"].ToString();
							txtADDR4.Text = dt.Rows[i]["LMSYS_ADDR4"].ToString();
							txtPIC.Text = dt.Rows[i]["LMSYS_PIC"].ToString();
							cbCNTRY.SelectedValue = dt.Rows[i]["LMSYS_CNTRY"].ToString();
							cbSTACD.SelectedValue = dt.Rows[i]["LMSYS_STACD"].ToString();
							cbUOM.SelectedValue = dt.Rows[i]["LMSYS_BUOM"].ToString();
							cbCURCD.SelectedValue = dt.Rows[i]["LMSYS_CURCD"].ToString();
							txtTEL01.Text = dt.Rows[i]["LMSYS_TEL01"].ToString();
							txtTEL02.Text = dt.Rows[i]["LMSYS_TEL02"].ToString();
							txtFAXNO1.Text = dt.Rows[i]["LMSYS_FAXNO1"].ToString();
							txtFAXNO2.Text = dt.Rows[i]["LMSYS_FAXNO2"].ToString();
							txtEMAIL.Text = dt.Rows[i]["LMSYS_EMAIL"].ToString();
							txtHPAGE.Text = dt.Rows[i]["LMSYS_HPAGE"].ToString();
							txtGSTID.Text = dt.Rows[i]["LMSYS_GSTID"].ToString();
							chkIGRD.Checked = Conversions.ToBoolean(dt.Rows[i]["LMSYS_IGRDFG"].ToString());
							txtREMRK.Text = dt.Rows[i]["LMSYS_REMRK"].ToString();
							cbCNTRY.SelectedText = Conversions.ToString(DB.GetColumnValue("MACOD_CODNM", "MACOD_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACOD_CTYID = 'CNTRY' AND MACOD_CODID = '", cbCNTRY.SelectedValue), "'"))));
							cbSTACD.SelectedText = Conversions.ToString(DB.GetColumnValue("MACOD_CODNM", "MACOD_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACOD_CTYID = 'STACD' AND MACOD_CODID = '", cbSTACD.SelectedValue), "'"))));
							cbUOM.SelectedText = Conversions.ToString(DB.GetColumnValue("MACOD_CODNM", "MACOD_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACOD_CTYID = 'UOM' AND MACOD_CODID = '", cbUOM.SelectedValue), "'"))));
							cbCURCD.SelectedText = Conversions.ToString(DB.GetColumnValue("MACOD_CODNM", "MACOD_TBL", Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("MACOD_CTYID = 'CURCD' AND MACOD_CODID = '", cbCURCD.SelectedValue), "'"))));
							btnSAVE.Text = "Update";
							txtCOMCD.Enabled = false;
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2);
						Exception ex = ex2;
						MessageBox.Show(ex.Message.ToString(), "Save err", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						BindDatafromDB = false;
						ProjectData.ClearProjectError();
						goto IL_054b;
					}
					BindDatafromDB = true;
				}
				goto IL_054b;
			}
			IL_054b:
			return BindDatafromDB;
		}

		private void frmISYS_Load(object sender, EventArgs e)
		{
			BindComboBox();
			BindDatafromDB();
		}

		private void frmMAECOD_FormClosing(object sender, FormClosingEventArgs e)
		{
			Form[] mdiChildren = base.ParentForm.MdiChildren;
			bool blnChildFormExists = default(bool);
			foreach (Form ChildForm in mdiChildren)
			{
				if (Operators.CompareString(ChildForm.Name, base.Name, false) != 0)
				{
					blnChildFormExists = true;
					break;
				}
			}
			if (!blnChildFormExists)
			{
				base.ParentForm.Controls["Panel1"].Visible = true;
			}
		}

		public bool ValidateDetailControl()
		{
			if (Operators.CompareString(txtCOMCD.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Company Code cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCOMCD.Focus();
				return false;
			}
			if (Operators.CompareString(txtCOMNM.Text.Trim(), "", false) == 0)
			{
				MessageBox.Show("Company Name cannot blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtCOMNM.Focus();
				return false;
			}
			return true;
		}
	}
}
