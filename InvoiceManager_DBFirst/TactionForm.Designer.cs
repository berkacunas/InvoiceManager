namespace InvoiceManager_DBFirst
{
    partial class TactionForm
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
            this.dataGridViewTactions = new System.Windows.Forms.DataGridView();
            this.groupBoxTactions = new System.Windows.Forms.GroupBox();
            this.groupBoxTactionDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewTactionDetails = new System.Windows.Forms.DataGridView();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.checkBoxSeller = new System.Windows.Forms.CheckBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.textBoxTactionNo = new System.Windows.Forms.TextBox();
            this.labelTactionNo = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.textBoxShop = new System.Windows.Forms.TextBox();
            this.labelShop = new System.Windows.Forms.Label();
            this.dateTimePickerTactionDate = new System.Windows.Forms.DateTimePicker();
            this.labelTactionDate = new System.Windows.Forms.Label();
            this.checkBoxDetailsEditable = new System.Windows.Forms.CheckBox();
            this.labelDetailsNote = new System.Windows.Forms.Label();
            this.textBoxDetailsNote = new System.Windows.Forms.TextBox();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            this.textBoxDiscountedPrice = new System.Windows.Forms.TextBox();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.buttonUpdateDetail = new System.Windows.Forms.Button();
            this.buttonRemoveDetail = new System.Windows.Forms.Button();
            this.labelDiscountedPrice = new System.Windows.Forms.Label();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.labelDiscountRate = new System.Windows.Forms.Label();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.labelVat = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxItemSubType = new System.Windows.Forms.TextBox();
            this.labelItemSubType = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.textBoxItemGroup = new System.Windows.Forms.TextBox();
            this.labelItemGroup = new System.Windows.Forms.Label();
            this.buttonNewTaction = new System.Windows.Forms.Button();
            this.buttonSaveTaction = new System.Windows.Forms.Button();
            this.buttonDeleteTaction = new System.Windows.Forms.Button();
            this.buttonUpdateTaction = new System.Windows.Forms.Button();
            this.groupBoxTactionOptions = new System.Windows.Forms.GroupBox();
            this.textBoxTotalVatPrice = new System.Windows.Forms.TextBox();
            this.labelTotalVatPrice = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.buttonCancelTaction = new System.Windows.Forms.Button();
            this.checkBoxTactionsEditable = new System.Windows.Forms.CheckBox();
            this.groupBoxTactionDetailsOptions = new System.Windows.Forms.GroupBox();
            this.toolStripTaction = new System.Windows.Forms.ToolStrip();
            this.statusStripTaction = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).BeginInit();
            this.groupBoxTactions.SuspendLayout();
            this.groupBoxTactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).BeginInit();
            this.groupBoxTactionOptions.SuspendLayout();
            this.groupBoxTactionDetailsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTactions
            // 
            this.dataGridViewTactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactions.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewTactions.Name = "dataGridViewTactions";
            this.dataGridViewTactions.Size = new System.Drawing.Size(721, 802);
            this.dataGridViewTactions.TabIndex = 0;
            this.dataGridViewTactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTactions_CellClick);
            this.dataGridViewTactions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewTactions_DataBindingComplete);
            // 
            // groupBoxTactions
            // 
            this.groupBoxTactions.Controls.Add(this.dataGridViewTactions);
            this.groupBoxTactions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactions.Location = new System.Drawing.Point(12, 28);
            this.groupBoxTactions.Name = "groupBoxTactions";
            this.groupBoxTactions.Size = new System.Drawing.Size(733, 832);
            this.groupBoxTactions.TabIndex = 2;
            this.groupBoxTactions.TabStop = false;
            this.groupBoxTactions.Text = "Transactions";
            // 
            // groupBoxTactionDetails
            // 
            this.groupBoxTactionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTactionDetails.Controls.Add(this.dataGridViewTactionDetails);
            this.groupBoxTactionDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionDetails.Location = new System.Drawing.Point(751, 29);
            this.groupBoxTactionDetails.Name = "groupBoxTactionDetails";
            this.groupBoxTactionDetails.Size = new System.Drawing.Size(927, 479);
            this.groupBoxTactionDetails.TabIndex = 3;
            this.groupBoxTactionDetails.TabStop = false;
            this.groupBoxTactionDetails.Text = "Details";
            // 
            // dataGridViewTactionDetails
            // 
            this.dataGridViewTactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactionDetails.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewTactionDetails.Name = "dataGridViewTactionDetails";
            this.dataGridViewTactionDetails.Size = new System.Drawing.Size(915, 449);
            this.dataGridViewTactionDetails.TabIndex = 0;
            this.dataGridViewTactionDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTactionDetails_CellClick);
            this.dataGridViewTactionDetails.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewTactionDetails_DataBindingComplete);
            // 
            // textBoxSeller
            // 
            this.textBoxSeller.Location = new System.Drawing.Point(413, 27);
            this.textBoxSeller.Name = "textBoxSeller";
            this.textBoxSeller.Size = new System.Drawing.Size(200, 23);
            this.textBoxSeller.TabIndex = 45;
            // 
            // checkBoxSeller
            // 
            this.checkBoxSeller.AutoSize = true;
            this.checkBoxSeller.Location = new System.Drawing.Point(328, 30);
            this.checkBoxSeller.Name = "checkBoxSeller";
            this.checkBoxSeller.Size = new System.Drawing.Size(57, 19);
            this.checkBoxSeller.TabIndex = 43;
            this.checkBoxSeller.Text = "Seller";
            this.checkBoxSeller.UseVisualStyleBackColor = true;
            this.checkBoxSeller.CheckedChanged += new System.EventHandler(this.checkBoxSeller_CheckedChanged);
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(749, 27);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(118, 23);
            this.textBoxTotalPrice.TabIndex = 42;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(667, 32);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(65, 15);
            this.labelTotalPrice.TabIndex = 41;
            this.labelTotalPrice.Text = "Total Price";
            // 
            // textBoxTactionNo
            // 
            this.textBoxTactionNo.Location = new System.Drawing.Point(413, 58);
            this.textBoxTactionNo.Name = "textBoxTactionNo";
            this.textBoxTactionNo.Size = new System.Drawing.Size(75, 23);
            this.textBoxTactionNo.TabIndex = 40;
            // 
            // labelTactionNo
            // 
            this.labelTactionNo.AutoSize = true;
            this.labelTactionNo.Location = new System.Drawing.Point(357, 62);
            this.labelTactionNo.Name = "labelTactionNo";
            this.labelTactionNo.Size = new System.Drawing.Size(22, 15);
            this.labelTactionNo.TabIndex = 39;
            this.labelTactionNo.Text = "No";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(78, 88);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(200, 23);
            this.comboBoxPaymentMethod.TabIndex = 38;
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Location = new System.Drawing.Point(8, 92);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(54, 15);
            this.labelPaymentMethod.TabIndex = 37;
            this.labelPaymentMethod.Text = "Payment";
            // 
            // textBoxShop
            // 
            this.textBoxShop.Location = new System.Drawing.Point(78, 57);
            this.textBoxShop.Name = "textBoxShop";
            this.textBoxShop.Size = new System.Drawing.Size(200, 23);
            this.textBoxShop.TabIndex = 36;
            // 
            // labelShop
            // 
            this.labelShop.AutoSize = true;
            this.labelShop.Location = new System.Drawing.Point(28, 61);
            this.labelShop.Name = "labelShop";
            this.labelShop.Size = new System.Drawing.Size(34, 15);
            this.labelShop.TabIndex = 35;
            this.labelShop.Text = "Shop";
            // 
            // dateTimePickerTactionDate
            // 
            this.dateTimePickerTactionDate.Location = new System.Drawing.Point(78, 26);
            this.dateTimePickerTactionDate.Name = "dateTimePickerTactionDate";
            this.dateTimePickerTactionDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTactionDate.TabIndex = 34;
            // 
            // labelTactionDate
            // 
            this.labelTactionDate.AutoSize = true;
            this.labelTactionDate.Location = new System.Drawing.Point(30, 30);
            this.labelTactionDate.Name = "labelTactionDate";
            this.labelTactionDate.Size = new System.Drawing.Size(32, 15);
            this.labelTactionDate.TabIndex = 33;
            this.labelTactionDate.Text = "Date";
            // 
            // checkBoxDetailsEditable
            // 
            this.checkBoxDetailsEditable.AutoSize = true;
            this.checkBoxDetailsEditable.Location = new System.Drawing.Point(794, 133);
            this.checkBoxDetailsEditable.Name = "checkBoxDetailsEditable";
            this.checkBoxDetailsEditable.Size = new System.Drawing.Size(71, 19);
            this.checkBoxDetailsEditable.TabIndex = 31;
            this.checkBoxDetailsEditable.Text = "Editable";
            this.checkBoxDetailsEditable.UseVisualStyleBackColor = true;
            this.checkBoxDetailsEditable.CheckedChanged += new System.EventHandler(this.checkBoxDetailsEditable_CheckedChanged);
            // 
            // labelDetailsNote
            // 
            this.labelDetailsNote.AutoSize = true;
            this.labelDetailsNote.Location = new System.Drawing.Point(701, 23);
            this.labelDetailsNote.Name = "labelDetailsNote";
            this.labelDetailsNote.Size = new System.Drawing.Size(32, 15);
            this.labelDetailsNote.TabIndex = 30;
            this.labelDetailsNote.Text = "Note";
            // 
            // textBoxDetailsNote
            // 
            this.textBoxDetailsNote.Location = new System.Drawing.Point(701, 39);
            this.textBoxDetailsNote.Multiline = true;
            this.textBoxDetailsNote.Name = "textBoxDetailsNote";
            this.textBoxDetailsNote.Size = new System.Drawing.Size(182, 71);
            this.textBoxDetailsNote.TabIndex = 29;
            // 
            // buttonAddDetail
            // 
            this.buttonAddDetail.Location = new System.Drawing.Point(23, 133);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonAddDetail.TabIndex = 25;
            this.buttonAddDetail.Text = "Add";
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            this.buttonAddDetail.Click += new System.EventHandler(this.buttonAddDetail_Click);
            // 
            // textBoxDiscountedPrice
            // 
            this.textBoxDiscountedPrice.Location = new System.Drawing.Point(552, 86);
            this.textBoxDiscountedPrice.Name = "textBoxDiscountedPrice";
            this.textBoxDiscountedPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxDiscountedPrice.TabIndex = 20;
            // 
            // checkBoxDiscount
            // 
            this.checkBoxDiscount.AutoSize = true;
            this.checkBoxDiscount.Location = new System.Drawing.Point(552, 26);
            this.checkBoxDiscount.Name = "checkBoxDiscount";
            this.checkBoxDiscount.Size = new System.Drawing.Size(75, 19);
            this.checkBoxDiscount.TabIndex = 19;
            this.checkBoxDiscount.Text = "Discount";
            this.checkBoxDiscount.UseVisualStyleBackColor = true;
            this.checkBoxDiscount.CheckedChanged += new System.EventHandler(this.checkBoxDiscount_CheckedChanged);
            // 
            // buttonUpdateDetail
            // 
            this.buttonUpdateDetail.Location = new System.Drawing.Point(108, 133);
            this.buttonUpdateDetail.Name = "buttonUpdateDetail";
            this.buttonUpdateDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateDetail.TabIndex = 26;
            this.buttonUpdateDetail.Text = "Update";
            this.buttonUpdateDetail.UseVisualStyleBackColor = true;
            this.buttonUpdateDetail.Click += new System.EventHandler(this.buttonUpdateDetail_Click);
            // 
            // buttonRemoveDetail
            // 
            this.buttonRemoveDetail.Location = new System.Drawing.Point(193, 133);
            this.buttonRemoveDetail.Name = "buttonRemoveDetail";
            this.buttonRemoveDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonRemoveDetail.TabIndex = 27;
            this.buttonRemoveDetail.Text = "Remove";
            this.buttonRemoveDetail.UseVisualStyleBackColor = true;
            this.buttonRemoveDetail.Click += new System.EventHandler(this.buttonRemoveDetail_Click);
            // 
            // labelDiscountedPrice
            // 
            this.labelDiscountedPrice.AutoSize = true;
            this.labelDiscountedPrice.Location = new System.Drawing.Point(494, 91);
            this.labelDiscountedPrice.Name = "labelDiscountedPrice";
            this.labelDiscountedPrice.Size = new System.Drawing.Size(52, 15);
            this.labelDiscountedPrice.TabIndex = 17;
            this.labelDiscountedPrice.Text = "Price (*)";
            // 
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Location = new System.Drawing.Point(552, 54);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.Size = new System.Drawing.Size(75, 23);
            this.textBoxDiscountRate.TabIndex = 16;
            // 
            // labelDiscountRate
            // 
            this.labelDiscountRate.AutoSize = true;
            this.labelDiscountRate.Location = new System.Drawing.Point(498, 60);
            this.labelDiscountRate.Name = "labelDiscountRate";
            this.labelDiscountRate.Size = new System.Drawing.Size(48, 15);
            this.labelDiscountRate.TabIndex = 15;
            this.labelDiscountRate.Text = "Rate (*)";
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(370, 86);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(75, 23);
            this.textBoxVat.TabIndex = 14;
            this.textBoxVat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVat_KeyPress);
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(330, 91);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(24, 15);
            this.labelVat.TabIndex = 13;
            this.labelVat.Text = "Vat";
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(370, 54);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxUnitPrice.TabIndex = 12;
            this.textBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUnitPrice_KeyPress);
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(293, 60);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(61, 15);
            this.labelUnitPrice.TabIndex = 11;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(370, 23);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(75, 23);
            this.textBoxUnit.TabIndex = 10;
            this.textBoxUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUnit_KeyPress);
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Location = new System.Drawing.Point(324, 27);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(30, 15);
            this.labelUnit.TabIndex = 9;
            this.labelUnit.Text = "Unit";
            // 
            // textBoxItemSubType
            // 
            this.textBoxItemSubType.Location = new System.Drawing.Point(77, 86);
            this.textBoxItemSubType.Name = "textBoxItemSubType";
            this.textBoxItemSubType.Size = new System.Drawing.Size(174, 23);
            this.textBoxItemSubType.TabIndex = 8;
            // 
            // labelItemSubType
            // 
            this.labelItemSubType.AutoSize = true;
            this.labelItemSubType.Location = new System.Drawing.Point(30, 91);
            this.labelItemSubType.Name = "labelItemSubType";
            this.labelItemSubType.Size = new System.Drawing.Size(31, 15);
            this.labelItemSubType.TabIndex = 7;
            this.labelItemSubType.Text = "Type";
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(77, 54);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(174, 23);
            this.textBoxItem.TabIndex = 6;
            this.textBoxItem.Leave += new System.EventHandler(this.textBoxItem_Leave);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(30, 60);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(31, 15);
            this.labelItem.TabIndex = 5;
            this.labelItem.Text = "Item";
            // 
            // textBoxItemGroup
            // 
            this.textBoxItemGroup.Location = new System.Drawing.Point(77, 23);
            this.textBoxItemGroup.Name = "textBoxItemGroup";
            this.textBoxItemGroup.Size = new System.Drawing.Size(174, 23);
            this.textBoxItemGroup.TabIndex = 4;
            this.textBoxItemGroup.Leave += new System.EventHandler(this.textBoxItemGroup_Leave);
            // 
            // labelItemGroup
            // 
            this.labelItemGroup.AutoSize = true;
            this.labelItemGroup.Location = new System.Drawing.Point(20, 27);
            this.labelItemGroup.Name = "labelItemGroup";
            this.labelItemGroup.Size = new System.Drawing.Size(41, 15);
            this.labelItemGroup.TabIndex = 3;
            this.labelItemGroup.Text = "Group";
            // 
            // buttonNewTaction
            // 
            this.buttonNewTaction.Location = new System.Drawing.Point(24, 133);
            this.buttonNewTaction.Name = "buttonNewTaction";
            this.buttonNewTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonNewTaction.TabIndex = 21;
            this.buttonNewTaction.Text = "New";
            this.buttonNewTaction.UseVisualStyleBackColor = true;
            this.buttonNewTaction.Click += new System.EventHandler(this.buttonNewTaction_Click);
            // 
            // buttonSaveTaction
            // 
            this.buttonSaveTaction.Location = new System.Drawing.Point(109, 133);
            this.buttonSaveTaction.Name = "buttonSaveTaction";
            this.buttonSaveTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveTaction.TabIndex = 22;
            this.buttonSaveTaction.Text = "Save";
            this.buttonSaveTaction.UseVisualStyleBackColor = true;
            this.buttonSaveTaction.Click += new System.EventHandler(this.buttonSaveTaction_Click);
            // 
            // buttonDeleteTaction
            // 
            this.buttonDeleteTaction.Location = new System.Drawing.Point(279, 133);
            this.buttonDeleteTaction.Name = "buttonDeleteTaction";
            this.buttonDeleteTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonDeleteTaction.TabIndex = 24;
            this.buttonDeleteTaction.Text = "Delete";
            this.buttonDeleteTaction.UseVisualStyleBackColor = true;
            this.buttonDeleteTaction.Click += new System.EventHandler(this.buttonDeleteTaction_Click);
            // 
            // buttonUpdateTaction
            // 
            this.buttonUpdateTaction.Location = new System.Drawing.Point(194, 133);
            this.buttonUpdateTaction.Name = "buttonUpdateTaction";
            this.buttonUpdateTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateTaction.TabIndex = 23;
            this.buttonUpdateTaction.Text = "Update";
            this.buttonUpdateTaction.UseVisualStyleBackColor = true;
            this.buttonUpdateTaction.Click += new System.EventHandler(this.buttonUpdateTaction_Click);
            // 
            // groupBoxTactionOptions
            // 
            this.groupBoxTactionOptions.Controls.Add(this.textBoxTotalVatPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelTotalVatPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelOwner);
            this.groupBoxTactionOptions.Controls.Add(this.comboBoxOwner);
            this.groupBoxTactionOptions.Controls.Add(this.buttonCancelTaction);
            this.groupBoxTactionOptions.Controls.Add(this.checkBoxTactionsEditable);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxSeller);
            this.groupBoxTactionOptions.Controls.Add(this.dateTimePickerTactionDate);
            this.groupBoxTactionOptions.Controls.Add(this.checkBoxSeller);
            this.groupBoxTactionOptions.Controls.Add(this.labelTactionDate);
            this.groupBoxTactionOptions.Controls.Add(this.buttonNewTaction);
            this.groupBoxTactionOptions.Controls.Add(this.labelShop);
            this.groupBoxTactionOptions.Controls.Add(this.buttonDeleteTaction);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxShop);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxTotalPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelPaymentMethod);
            this.groupBoxTactionOptions.Controls.Add(this.buttonSaveTaction);
            this.groupBoxTactionOptions.Controls.Add(this.comboBoxPaymentMethod);
            this.groupBoxTactionOptions.Controls.Add(this.labelTotalPrice);
            this.groupBoxTactionOptions.Controls.Add(this.labelTactionNo);
            this.groupBoxTactionOptions.Controls.Add(this.buttonUpdateTaction);
            this.groupBoxTactionOptions.Controls.Add(this.textBoxTactionNo);
            this.groupBoxTactionOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionOptions.Location = new System.Drawing.Point(751, 514);
            this.groupBoxTactionOptions.Name = "groupBoxTactionOptions";
            this.groupBoxTactionOptions.Size = new System.Drawing.Size(922, 166);
            this.groupBoxTactionOptions.TabIndex = 4;
            this.groupBoxTactionOptions.TabStop = false;
            this.groupBoxTactionOptions.Text = "Transaction Options";
            // 
            // textBoxTotalVatPrice
            // 
            this.textBoxTotalVatPrice.Location = new System.Drawing.Point(749, 58);
            this.textBoxTotalVatPrice.Name = "textBoxTotalVatPrice";
            this.textBoxTotalVatPrice.Size = new System.Drawing.Size(118, 23);
            this.textBoxTotalVatPrice.TabIndex = 51;
            // 
            // labelTotalVatPrice
            // 
            this.labelTotalVatPrice.AutoSize = true;
            this.labelTotalVatPrice.Location = new System.Drawing.Point(678, 62);
            this.labelTotalVatPrice.Name = "labelTotalVatPrice";
            this.labelTotalVatPrice.Size = new System.Drawing.Size(54, 15);
            this.labelTotalVatPrice.TabIndex = 50;
            this.labelTotalVatPrice.Text = "Total Vat";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(336, 93);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(43, 15);
            this.labelOwner.TabIndex = 48;
            this.labelOwner.Text = "Owner";
            // 
            // comboBoxOwner
            // 
            this.comboBoxOwner.FormattingEnabled = true;
            this.comboBoxOwner.Location = new System.Drawing.Point(413, 89);
            this.comboBoxOwner.Name = "comboBoxOwner";
            this.comboBoxOwner.Size = new System.Drawing.Size(200, 23);
            this.comboBoxOwner.TabIndex = 49;
            // 
            // buttonCancelTaction
            // 
            this.buttonCancelTaction.Location = new System.Drawing.Point(364, 133);
            this.buttonCancelTaction.Name = "buttonCancelTaction";
            this.buttonCancelTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonCancelTaction.TabIndex = 47;
            this.buttonCancelTaction.Text = "Cancel";
            this.buttonCancelTaction.UseVisualStyleBackColor = true;
            this.buttonCancelTaction.Click += new System.EventHandler(this.buttonCancelTaction_Click);
            // 
            // checkBoxTactionsEditable
            // 
            this.checkBoxTactionsEditable.AutoSize = true;
            this.checkBoxTactionsEditable.Location = new System.Drawing.Point(795, 135);
            this.checkBoxTactionsEditable.Name = "checkBoxTactionsEditable";
            this.checkBoxTactionsEditable.Size = new System.Drawing.Size(71, 19);
            this.checkBoxTactionsEditable.TabIndex = 46;
            this.checkBoxTactionsEditable.Text = "Editable";
            this.checkBoxTactionsEditable.UseVisualStyleBackColor = true;
            this.checkBoxTactionsEditable.CheckedChanged += new System.EventHandler(this.checkBoxTactionsEditable_CheckedChanged);
            // 
            // groupBoxTactionDetailsOptions
            // 
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItem);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItemGroup);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItemGroup);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItem);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItemSubType);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItemSubType);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelUnit);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxUnit);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelUnitPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxUnitPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelVat);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxVat);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelDiscountRate);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxDiscountRate);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelDiscountedPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonRemoveDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonUpdateDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.checkBoxDiscount);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.checkBoxDetailsEditable);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxDiscountedPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelDetailsNote);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonAddDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxDetailsNote);
            this.groupBoxTactionDetailsOptions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionDetailsOptions.Location = new System.Drawing.Point(751, 686);
            this.groupBoxTactionDetailsOptions.Name = "groupBoxTactionDetailsOptions";
            this.groupBoxTactionDetailsOptions.Size = new System.Drawing.Size(927, 168);
            this.groupBoxTactionDetailsOptions.TabIndex = 4;
            this.groupBoxTactionDetailsOptions.TabStop = false;
            this.groupBoxTactionDetailsOptions.Text = "Detail Options";
            // 
            // toolStripTaction
            // 
            this.toolStripTaction.Location = new System.Drawing.Point(0, 0);
            this.toolStripTaction.Name = "toolStripTaction";
            this.toolStripTaction.Size = new System.Drawing.Size(1690, 25);
            this.toolStripTaction.TabIndex = 6;
            this.toolStripTaction.Text = "toolStrip1";
            // 
            // statusStripTaction
            // 
            this.statusStripTaction.Location = new System.Drawing.Point(0, 864);
            this.statusStripTaction.Name = "statusStripTaction";
            this.statusStripTaction.Size = new System.Drawing.Size(1690, 22);
            this.statusStripTaction.TabIndex = 7;
            this.statusStripTaction.Text = "statusStrip1";
            // 
            // TactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1690, 886);
            this.Controls.Add(this.statusStripTaction);
            this.Controls.Add(this.toolStripTaction);
            this.Controls.Add(this.groupBoxTactionOptions);
            this.Controls.Add(this.groupBoxTactionDetailsOptions);
            this.Controls.Add(this.groupBoxTactionDetails);
            this.Controls.Add(this.groupBoxTactions);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "TactionForm";
            this.Text = "Transactions";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TactionForm_FormClosing);
            this.Load += new System.EventHandler(this.TactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).EndInit();
            this.groupBoxTactions.ResumeLayout(false);
            this.groupBoxTactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).EndInit();
            this.groupBoxTactionOptions.ResumeLayout(false);
            this.groupBoxTactionOptions.PerformLayout();
            this.groupBoxTactionDetailsOptions.ResumeLayout(false);
            this.groupBoxTactionDetailsOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTactions;
        private System.Windows.Forms.GroupBox groupBoxTactions;
        private System.Windows.Forms.GroupBox groupBoxTactionDetails;
        private System.Windows.Forms.DataGridView dataGridViewTactionDetails;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.TextBox textBoxItemGroup;
        private System.Windows.Forms.Label labelItemGroup;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxItemSubType;
        private System.Windows.Forms.Label labelItemSubType;
        private System.Windows.Forms.Button buttonDeleteTaction;
        private System.Windows.Forms.Button buttonUpdateTaction;
        private System.Windows.Forms.Button buttonSaveTaction;
        private System.Windows.Forms.Button buttonNewTaction;
        private System.Windows.Forms.GroupBox groupBoxTactionOptions;
        private System.Windows.Forms.Label labelDetailsNote;
        private System.Windows.Forms.TextBox textBoxDetailsNote;
        private System.Windows.Forms.Button buttonAddDetail;
        private System.Windows.Forms.Button buttonUpdateDetail;
        private System.Windows.Forms.Button buttonRemoveDetail;
        private System.Windows.Forms.CheckBox checkBoxDetailsEditable;
        private System.Windows.Forms.TextBox textBoxDiscountedPrice;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.Label labelDiscountedPrice;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.Label labelDiscountRate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTactionDate;
        private System.Windows.Forms.Label labelTactionDate;
        private System.Windows.Forms.TextBox textBoxShop;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.TextBox textBoxTactionNo;
        private System.Windows.Forms.Label labelTactionNo;
        private System.Windows.Forms.TextBox textBoxSeller;
        private System.Windows.Forms.CheckBox checkBoxSeller;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.CheckBox checkBoxTactionsEditable;
        private System.Windows.Forms.Button buttonCancelTaction;
        private System.Windows.Forms.GroupBox groupBoxTactionDetailsOptions;
        private System.Windows.Forms.ToolStrip toolStripTaction;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.StatusStrip statusStripTaction;
        private System.Windows.Forms.TextBox textBoxTotalVatPrice;
        private System.Windows.Forms.Label labelTotalVatPrice;
    }
}