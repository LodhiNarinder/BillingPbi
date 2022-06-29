namespace BillingPbi
{
    partial class VoucherMst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtVuDate = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listActName = new Zuby.ADGV.AdvancedDataGridView();
            this.VuType = new System.Windows.Forms.ListBox();
            this.grpBank = new System.Windows.Forms.GroupBox();
            this.listBankName = new Zuby.ADGV.AdvancedDataGridView();
            this.listBankName1 = new System.Windows.Forms.ListBox();
            this.txtBankName = new System.Windows.Forms.TextBox();
            this.txtBankCode = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textNart = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVuName = new System.Windows.Forms.TextBox();
            this.advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtVuType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVuAmt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVuNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtVuAcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.actMstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wtrBillingDataSet = new BillingPbi.WtrBillingDataSet();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.grpDataGrid = new System.Windows.Forms.GroupBox();
            this.advancedDataGridViewSearchToolBar1 = new Zuby.ADGV.AdvancedDataGridViewSearchToolBar();
            this.dataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripErrors = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.actMstTableAdapter = new BillingPbi.WtrBillingDataSetTableAdapters.ActMstTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.To = new System.Windows.Forms.DateTimePicker();
            this.From = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listActName)).BeginInit();
            this.grpBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBankName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actMstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wtrBillingDataSet)).BeginInit();
            this.grpDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtVuDate
            // 
            this.txtVuDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVuDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuDate.Location = new System.Drawing.Point(236, 19);
            this.txtVuDate.Name = "txtVuDate";
            this.txtVuDate.Size = new System.Drawing.Size(100, 20);
            this.txtVuDate.TabIndex = 0;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(196, 22);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(43, 13);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "VuDate";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listActName);
            this.groupBox1.Controls.Add(this.VuType);
            this.groupBox1.Controls.Add(this.grpBank);
            this.groupBox1.Controls.Add(this.textNart);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtVuName);
            this.groupBox1.Controls.Add(this.advancedDataGridView1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtVuType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtVuAmt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtVuNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtVuAcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVuDate);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 361);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VoucherDetail";
            // 
            // listActName
            // 
            this.listActName.AllowUserToAddRows = false;
            this.listActName.AllowUserToDeleteRows = false;
            this.listActName.AllowUserToResizeColumns = false;
            this.listActName.AllowUserToResizeRows = false;
            this.listActName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listActName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listActName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listActName.FilterAndSortEnabled = true;
            this.listActName.Location = new System.Drawing.Point(183, 48);
            this.listActName.Name = "listActName";
            this.listActName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listActName.Size = new System.Drawing.Size(153, 95);
            this.listActName.TabIndex = 39;
            this.listActName.Visible = false;
            this.listActName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listActName_KeyPress);
            // 
            // VuType
            // 
            this.VuType.FormattingEnabled = true;
            this.VuType.Items.AddRange(new object[] {
            "JL",
            "CR",
            "CP",
            "BR",
            "BP",
            "SL"});
            this.VuType.Location = new System.Drawing.Point(392, 38);
            this.VuType.Name = "VuType";
            this.VuType.Size = new System.Drawing.Size(120, 95);
            this.VuType.TabIndex = 35;
            this.VuType.Visible = false;
            this.VuType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VuType_KeyPress);
            // 
            // grpBank
            // 
            this.grpBank.Controls.Add(this.listBankName);
            this.grpBank.Controls.Add(this.listBankName1);
            this.grpBank.Controls.Add(this.txtBankName);
            this.grpBank.Controls.Add(this.txtBankCode);
            this.grpBank.Controls.Add(this.label9);
            this.grpBank.Location = new System.Drawing.Point(440, 19);
            this.grpBank.Name = "grpBank";
            this.grpBank.Size = new System.Drawing.Size(240, 159);
            this.grpBank.TabIndex = 34;
            this.grpBank.TabStop = false;
            this.grpBank.Text = "BankDetail";
            this.grpBank.Visible = false;
            // 
            // listBankName
            // 
            this.listBankName.AllowUserToAddRows = false;
            this.listBankName.AllowUserToDeleteRows = false;
            this.listBankName.AllowUserToResizeColumns = false;
            this.listBankName.AllowUserToResizeRows = false;
            this.listBankName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBankName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listBankName.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.listBankName.FilterAndSortEnabled = true;
            this.listBankName.Location = new System.Drawing.Point(74, 19);
            this.listBankName.Name = "listBankName";
            this.listBankName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBankName.Size = new System.Drawing.Size(153, 95);
            this.listBankName.TabIndex = 38;
            this.listBankName.Visible = false;
            this.listBankName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBankName_KeyPress_1);
            // 
            // listBankName1
            // 
            this.listBankName1.FormattingEnabled = true;
            this.listBankName1.Location = new System.Drawing.Point(107, 24);
            this.listBankName1.Name = "listBankName1";
            this.listBankName1.Size = new System.Drawing.Size(120, 95);
            this.listBankName1.TabIndex = 37;
            this.listBankName1.Visible = false;
            this.listBankName1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listBankName_KeyPress);
            // 
            // txtBankName
            // 
            this.txtBankName.Location = new System.Drawing.Point(17, 50);
            this.txtBankName.Name = "txtBankName";
            this.txtBankName.ReadOnly = true;
            this.txtBankName.Size = new System.Drawing.Size(210, 20);
            this.txtBankName.TabIndex = 36;
            // 
            // txtBankCode
            // 
            this.txtBankCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBankCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtBankCode.Location = new System.Drawing.Point(52, 24);
            this.txtBankCode.Name = "txtBankCode";
            this.txtBankCode.Size = new System.Drawing.Size(57, 20);
            this.txtBankCode.TabIndex = 34;
            this.txtBankCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBankCode_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Bank";
            // 
            // textNart
            // 
            this.textNart.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textNart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textNart.Location = new System.Drawing.Point(90, 100);
            this.textNart.Name = "textNart";
            this.textNart.Size = new System.Drawing.Size(338, 20);
            this.textNart.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Narration";
            // 
            // txtVuName
            // 
            this.txtVuName.Location = new System.Drawing.Point(199, 48);
            this.txtVuName.Name = "txtVuName";
            this.txtVuName.ReadOnly = true;
            this.txtVuName.Size = new System.Drawing.Size(229, 20);
            this.txtVuName.TabIndex = 28;
            // 
            // advancedDataGridView1
            // 
            this.advancedDataGridView1.AllowUserToAddRows = false;
            this.advancedDataGridView1.AllowUserToDeleteRows = false;
            this.advancedDataGridView1.AllowUserToResizeColumns = false;
            this.advancedDataGridView1.AllowUserToResizeRows = false;
            this.advancedDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.advancedDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advancedDataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.advancedDataGridView1.FilterAndSortEnabled = true;
            this.advancedDataGridView1.Location = new System.Drawing.Point(6, 184);
            this.advancedDataGridView1.Name = "advancedDataGridView1";
            this.advancedDataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.advancedDataGridView1.Size = new System.Drawing.Size(764, 171);
            this.advancedDataGridView1.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dr/Cr";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(605, 0);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(75, 20);
            this.txtId.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtVuType
            // 
            this.txtVuType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVuType.Location = new System.Drawing.Point(392, 19);
            this.txtVuType.Name = "txtVuType";
            this.txtVuType.Size = new System.Drawing.Size(35, 20);
            this.txtVuType.TabIndex = 18;
            this.txtVuType.Text = "JL";
            this.txtVuType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVuType_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "VuType";
            // 
            // txtVuAmt
            // 
            this.txtVuAmt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVuAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtVuAmt.Location = new System.Drawing.Point(90, 74);
            this.txtVuAmt.Name = "txtVuAmt";
            this.txtVuAmt.Size = new System.Drawing.Size(100, 20);
            this.txtVuAmt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "VuAmount";
            // 
            // txtVuNo
            // 
            this.txtVuNo.Location = new System.Drawing.Point(89, 19);
            this.txtVuNo.Name = "txtVuNo";
            this.txtVuNo.ReadOnly = true;
            this.txtVuNo.Size = new System.Drawing.Size(100, 20);
            this.txtVuNo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "VuNo";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(682, 131);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtVuAcode
            // 
            this.txtVuAcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVuAcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtVuAcode.Location = new System.Drawing.Point(90, 48);
            this.txtVuAcode.Name = "txtVuAcode";
            this.txtVuAcode.Size = new System.Drawing.Size(100, 20);
            this.txtVuAcode.TabIndex = 2;
            this.txtVuAcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVuAcode_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VuAcode";
            // 
            // actMstBindingSource
            // 
            this.actMstBindingSource.DataMember = "ActMst";
            this.actMstBindingSource.DataSource = this.wtrBillingDataSet;
            this.actMstBindingSource.CurrentChanged += new System.EventHandler(this.actMstBindingSource_CurrentChanged);
            // 
            // wtrBillingDataSet
            // 
            this.wtrBillingDataSet.DataSetName = "WtrBillingDataSet";
            this.wtrBillingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(369, 287);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilters.TabIndex = 25;
            this.btnClearFilters.Text = "ClearFilters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // grpDataGrid
            // 
            this.grpDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpDataGrid.Controls.Add(this.advancedDataGridViewSearchToolBar1);
            this.grpDataGrid.Controls.Add(this.dataGridView1);
            this.grpDataGrid.Controls.Add(this.label11);
            this.grpDataGrid.Controls.Add(this.lblTotal);
            this.grpDataGrid.Location = new System.Drawing.Point(6, 368);
            this.grpDataGrid.Name = "grpDataGrid";
            this.grpDataGrid.Size = new System.Drawing.Size(1249, 386);
            this.grpDataGrid.TabIndex = 3;
            this.grpDataGrid.TabStop = false;
            this.grpDataGrid.Text = "DataGrid";
            // 
            // advancedDataGridViewSearchToolBar1
            // 
            this.advancedDataGridViewSearchToolBar1.AllowMerge = false;
            this.advancedDataGridViewSearchToolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.advancedDataGridViewSearchToolBar1.Location = new System.Drawing.Point(3, 16);
            this.advancedDataGridViewSearchToolBar1.MaximumSize = new System.Drawing.Size(0, 27);
            this.advancedDataGridViewSearchToolBar1.MinimumSize = new System.Drawing.Size(0, 27);
            this.advancedDataGridViewSearchToolBar1.Name = "advancedDataGridViewSearchToolBar1";
            this.advancedDataGridViewSearchToolBar1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.advancedDataGridViewSearchToolBar1.Size = new System.Drawing.Size(1243, 27);
            this.advancedDataGridViewSearchToolBar1.TabIndex = 27;
            this.advancedDataGridViewSearchToolBar1.Text = "advancedDataGridViewSearchToolBar1";
            this.advancedDataGridViewSearchToolBar1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.advancedDataGridViewSearchToolBar1_ItemClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.FilterAndSortEnabled = true;
            this.dataGridView1.Location = new System.Drawing.Point(6, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 171);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.SortStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.SortEventArgs>(this.dataGridView1_SortStringChanged);
            this.dataGridView1.FilterStringChanged += new System.EventHandler<Zuby.ADGV.AdvancedDataGridView.FilterEventArgs>(this.dataGridView1_FilterStringChanged);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(1139, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(1195, -3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 17);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripErrors});
            this.statusStrip1.Location = new System.Drawing.Point(0, 591);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1273, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripErrors
            // 
            this.toolStripErrors.Name = "toolStripErrors";
            this.toolStripErrors.Size = new System.Drawing.Size(10, 17);
            this.toolStripErrors.Text = ".";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // actMstTableAdapter
            // 
            this.actMstTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.To);
            this.groupBox2.Controls.Add(this.From);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnSelectAll);
            this.groupBox2.Controls.Add(this.btnClearFilters);
            this.groupBox2.Location = new System.Drawing.Point(794, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GridControls";
            // 
            // To
            // 
            this.To.CustomFormat = "yyyy-MM-dd";
            this.To.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.To.Location = new System.Drawing.Point(199, 22);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(104, 20);
            this.To.TabIndex = 33;
            this.To.Value = new System.DateTime(2021, 11, 1, 15, 43, 38, 0);
            this.To.ValueChanged += new System.EventHandler(this.To_ValueChanged);
            // 
            // From
            // 
            this.From.CustomFormat = "yyyy-MM-dd";
            this.From.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.From.Location = new System.Drawing.Point(55, 22);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(104, 20);
            this.From.TabIndex = 32;
            this.From.Value = new System.DateTime(2021, 11, 1, 15, 53, 10, 0);
            this.From.ValueChanged += new System.EventHandler(this.From_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "From";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(369, 316);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 26;
            this.btnSelectAll.Text = "ProcessBill";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // VoucherMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpDataGrid);
            this.Controls.Add(this.groupBox1);
            this.Name = "VoucherMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "VoucherMst";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listActName)).EndInit();
            this.grpBank.ResumeLayout(false);
            this.grpBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBankName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advancedDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actMstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wtrBillingDataSet)).EndInit();
            this.grpDataGrid.ResumeLayout(false);
            this.grpDataGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVuDate;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtVuAcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDataGrid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripErrors;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtVuNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVuAmt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtVuType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label11;
        private Zuby.ADGV.AdvancedDataGridView dataGridView1;
        private WtrBillingDataSet wtrBillingDataSet;
        private System.Windows.Forms.BindingSource actMstBindingSource;
        private WtrBillingDataSetTableAdapters.ActMstTableAdapter actMstTableAdapter;
        private System.Windows.Forms.Button btnClearFilters;
        private Zuby.ADGV.AdvancedDataGridViewSearchToolBar advancedDataGridViewSearchToolBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker From;
        private System.Windows.Forms.DateTimePicker To;
        private System.Windows.Forms.TextBox textNart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVuName;
        private System.Windows.Forms.GroupBox grpBank;
        private System.Windows.Forms.TextBox txtBankName;
        private System.Windows.Forms.TextBox txtBankCode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox VuType;
        private System.Windows.Forms.ListBox listBankName1;
        private Zuby.ADGV.AdvancedDataGridView listBankName;
        private Zuby.ADGV.AdvancedDataGridView listActName;
    }
}

