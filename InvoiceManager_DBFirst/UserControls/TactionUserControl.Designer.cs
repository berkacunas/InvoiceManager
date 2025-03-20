namespace InvoiceManager_DBFirst.UserControls
{
    partial class TactionUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTactionOptions = new System.Windows.Forms.GroupBox();
            this.textBoxTotalVatPrice = new System.Windows.Forms.TextBox();
            this.labelTotalVatPrice = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboBoxOwner = new System.Windows.Forms.ComboBox();
            this.buttonCancelTaction = new System.Windows.Forms.Button();
            this.checkBoxTactionsEditable = new System.Windows.Forms.CheckBox();
            this.textBoxSeller = new System.Windows.Forms.TextBox();
            this.dateTimePickerTactionDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSeller = new System.Windows.Forms.CheckBox();
            this.labelTactionDate = new System.Windows.Forms.Label();
            this.buttonNewTaction = new System.Windows.Forms.Button();
            this.labelShop = new System.Windows.Forms.Label();
            this.buttonDeleteTaction = new System.Windows.Forms.Button();
            this.textBoxShop = new System.Windows.Forms.TextBox();
            this.textBoxTotalPrice = new System.Windows.Forms.TextBox();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.buttonSaveTaction = new System.Windows.Forms.Button();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTactionNo = new System.Windows.Forms.Label();
            this.buttonUpdateTaction = new System.Windows.Forms.Button();
            this.textBoxTactionNo = new System.Windows.Forms.TextBox();
            this.groupBoxTactionDetailsOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxItemSubType = new System.Windows.Forms.ComboBox();
            this.buttonAdviceLastUnitPrice = new System.Windows.Forms.Button();
            this.labelVatPercantage = new System.Windows.Forms.Label();
            this.textBoxItem = new System.Windows.Forms.TextBox();
            this.labelItemGroup = new System.Windows.Forms.Label();
            this.textBoxItemGroup = new System.Windows.Forms.TextBox();
            this.labelItem = new System.Windows.Forms.Label();
            this.labelItemSubType = new System.Windows.Forms.Label();
            this.labelUnit = new System.Windows.Forms.Label();
            this.textBoxUnit = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelVat = new System.Windows.Forms.Label();
            this.textBoxVat = new System.Windows.Forms.TextBox();
            this.labelDiscountRate = new System.Windows.Forms.Label();
            this.textBoxDiscountRate = new System.Windows.Forms.TextBox();
            this.labelDiscountedPrice = new System.Windows.Forms.Label();
            this.buttonRemoveDetail = new System.Windows.Forms.Button();
            this.buttonUpdateDetail = new System.Windows.Forms.Button();
            this.checkBoxDiscount = new System.Windows.Forms.CheckBox();
            this.checkBoxDetailsEditable = new System.Windows.Forms.CheckBox();
            this.textBoxDiscountedPrice = new System.Windows.Forms.TextBox();
            this.labelDetailsNote = new System.Windows.Forms.Label();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            this.textBoxDetailsNote = new System.Windows.Forms.TextBox();
            this.groupBoxTactionDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewTactionDetails = new System.Windows.Forms.DataGridView();
            this.groupBoxTactions = new System.Windows.Forms.GroupBox();
            this.dataGridViewTactions = new System.Windows.Forms.DataGridView();
            this.buttonClearDetail = new System.Windows.Forms.Button();
            this.groupBoxTactionOptions.SuspendLayout();
            this.groupBoxTactionDetailsOptions.SuspendLayout();
            this.groupBoxTactionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).BeginInit();
            this.groupBoxTactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).BeginInit();
            this.SuspendLayout();
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
            this.groupBoxTactionOptions.Location = new System.Drawing.Point(742, 591);
            this.groupBoxTactionOptions.Name = "groupBoxTactionOptions";
            this.groupBoxTactionOptions.Size = new System.Drawing.Size(921, 168);
            this.groupBoxTactionOptions.TabIndex = 7;
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
            // 
            // textBoxSeller
            // 
            this.textBoxSeller.Location = new System.Drawing.Point(413, 27);
            this.textBoxSeller.Name = "textBoxSeller";
            this.textBoxSeller.Size = new System.Drawing.Size(200, 23);
            this.textBoxSeller.TabIndex = 45;
            // 
            // dateTimePickerTactionDate
            // 
            this.dateTimePickerTactionDate.Location = new System.Drawing.Point(78, 26);
            this.dateTimePickerTactionDate.Name = "dateTimePickerTactionDate";
            this.dateTimePickerTactionDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerTactionDate.TabIndex = 34;
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
            // buttonNewTaction
            // 
            this.buttonNewTaction.Location = new System.Drawing.Point(24, 133);
            this.buttonNewTaction.Name = "buttonNewTaction";
            this.buttonNewTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonNewTaction.TabIndex = 21;
            this.buttonNewTaction.Text = "New";
            this.buttonNewTaction.UseVisualStyleBackColor = true;
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
            // buttonDeleteTaction
            // 
            this.buttonDeleteTaction.Location = new System.Drawing.Point(279, 133);
            this.buttonDeleteTaction.Name = "buttonDeleteTaction";
            this.buttonDeleteTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonDeleteTaction.TabIndex = 24;
            this.buttonDeleteTaction.Text = "Delete";
            this.buttonDeleteTaction.UseVisualStyleBackColor = true;
            // 
            // textBoxShop
            // 
            this.textBoxShop.Location = new System.Drawing.Point(78, 57);
            this.textBoxShop.Name = "textBoxShop";
            this.textBoxShop.Size = new System.Drawing.Size(200, 23);
            this.textBoxShop.TabIndex = 36;
            // 
            // textBoxTotalPrice
            // 
            this.textBoxTotalPrice.Location = new System.Drawing.Point(749, 27);
            this.textBoxTotalPrice.Name = "textBoxTotalPrice";
            this.textBoxTotalPrice.Size = new System.Drawing.Size(118, 23);
            this.textBoxTotalPrice.TabIndex = 42;
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
            // buttonSaveTaction
            // 
            this.buttonSaveTaction.Location = new System.Drawing.Point(109, 133);
            this.buttonSaveTaction.Name = "buttonSaveTaction";
            this.buttonSaveTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonSaveTaction.TabIndex = 22;
            this.buttonSaveTaction.Text = "Save";
            this.buttonSaveTaction.UseVisualStyleBackColor = true;
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(78, 88);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(200, 23);
            this.comboBoxPaymentMethod.TabIndex = 38;
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
            // labelTactionNo
            // 
            this.labelTactionNo.AutoSize = true;
            this.labelTactionNo.Location = new System.Drawing.Point(357, 62);
            this.labelTactionNo.Name = "labelTactionNo";
            this.labelTactionNo.Size = new System.Drawing.Size(22, 15);
            this.labelTactionNo.TabIndex = 39;
            this.labelTactionNo.Text = "No";
            // 
            // buttonUpdateTaction
            // 
            this.buttonUpdateTaction.Location = new System.Drawing.Point(194, 133);
            this.buttonUpdateTaction.Name = "buttonUpdateTaction";
            this.buttonUpdateTaction.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateTaction.TabIndex = 23;
            this.buttonUpdateTaction.Text = "Update";
            this.buttonUpdateTaction.UseVisualStyleBackColor = true;
            // 
            // textBoxTactionNo
            // 
            this.textBoxTactionNo.Location = new System.Drawing.Point(413, 58);
            this.textBoxTactionNo.Name = "textBoxTactionNo";
            this.textBoxTactionNo.Size = new System.Drawing.Size(75, 23);
            this.textBoxTactionNo.TabIndex = 40;
            // 
            // groupBoxTactionDetailsOptions
            // 
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonClearDetail);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.comboBoxItemSubType);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.buttonAdviceLastUnitPrice);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelVatPercantage);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItem);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItemGroup);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.textBoxItemGroup);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItem);
            this.groupBoxTactionDetailsOptions.Controls.Add(this.labelItemSubType);
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
            this.groupBoxTactionDetailsOptions.Location = new System.Drawing.Point(742, 765);
            this.groupBoxTactionDetailsOptions.Name = "groupBoxTactionDetailsOptions";
            this.groupBoxTactionDetailsOptions.Size = new System.Drawing.Size(921, 167);
            this.groupBoxTactionDetailsOptions.TabIndex = 8;
            this.groupBoxTactionDetailsOptions.TabStop = false;
            this.groupBoxTactionDetailsOptions.Text = "Detail Options";
            // 
            // comboBoxItemSubType
            // 
            this.comboBoxItemSubType.FormattingEnabled = true;
            this.comboBoxItemSubType.Location = new System.Drawing.Point(77, 86);
            this.comboBoxItemSubType.Name = "comboBoxItemSubType";
            this.comboBoxItemSubType.Size = new System.Drawing.Size(174, 23);
            this.comboBoxItemSubType.TabIndex = 34;
            // 
            // buttonAdviceLastUnitPrice
            // 
            this.buttonAdviceLastUnitPrice.Location = new System.Drawing.Point(451, 54);
            this.buttonAdviceLastUnitPrice.Name = "buttonAdviceLastUnitPrice";
            this.buttonAdviceLastUnitPrice.Size = new System.Drawing.Size(23, 23);
            this.buttonAdviceLastUnitPrice.TabIndex = 33;
            this.buttonAdviceLastUnitPrice.UseVisualStyleBackColor = true;
            // 
            // labelVatPercantage
            // 
            this.labelVatPercantage.Location = new System.Drawing.Point(355, 90);
            this.labelVatPercantage.Name = "labelVatPercantage";
            this.labelVatPercantage.Size = new System.Drawing.Size(12, 15);
            this.labelVatPercantage.TabIndex = 32;
            this.labelVatPercantage.Text = "%";
            this.labelVatPercantage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxItem
            // 
            this.textBoxItem.Location = new System.Drawing.Point(77, 54);
            this.textBoxItem.Name = "textBoxItem";
            this.textBoxItem.Size = new System.Drawing.Size(174, 23);
            this.textBoxItem.TabIndex = 6;
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
            // textBoxItemGroup
            // 
            this.textBoxItemGroup.Location = new System.Drawing.Point(77, 23);
            this.textBoxItemGroup.Name = "textBoxItemGroup";
            this.textBoxItemGroup.Size = new System.Drawing.Size(174, 23);
            this.textBoxItemGroup.TabIndex = 4;
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
            // labelItemSubType
            // 
            this.labelItemSubType.AutoSize = true;
            this.labelItemSubType.Location = new System.Drawing.Point(30, 91);
            this.labelItemSubType.Name = "labelItemSubType";
            this.labelItemSubType.Size = new System.Drawing.Size(31, 15);
            this.labelItemSubType.TabIndex = 7;
            this.labelItemSubType.Text = "Type";
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
            // textBoxUnit
            // 
            this.textBoxUnit.Location = new System.Drawing.Point(370, 23);
            this.textBoxUnit.Name = "textBoxUnit";
            this.textBoxUnit.Size = new System.Drawing.Size(75, 23);
            this.textBoxUnit.TabIndex = 10;
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
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(370, 54);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxUnitPrice.TabIndex = 12;
            // 
            // labelVat
            // 
            this.labelVat.AutoSize = true;
            this.labelVat.Location = new System.Drawing.Point(330, 90);
            this.labelVat.Name = "labelVat";
            this.labelVat.Size = new System.Drawing.Size(24, 15);
            this.labelVat.TabIndex = 13;
            this.labelVat.Text = "Vat";
            // 
            // textBoxVat
            // 
            this.textBoxVat.Location = new System.Drawing.Point(370, 86);
            this.textBoxVat.Name = "textBoxVat";
            this.textBoxVat.Size = new System.Drawing.Size(75, 23);
            this.textBoxVat.TabIndex = 14;
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
            // textBoxDiscountRate
            // 
            this.textBoxDiscountRate.Location = new System.Drawing.Point(552, 54);
            this.textBoxDiscountRate.Name = "textBoxDiscountRate";
            this.textBoxDiscountRate.Size = new System.Drawing.Size(75, 23);
            this.textBoxDiscountRate.TabIndex = 16;
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
            // buttonRemoveDetail
            // 
            this.buttonRemoveDetail.Location = new System.Drawing.Point(193, 133);
            this.buttonRemoveDetail.Name = "buttonRemoveDetail";
            this.buttonRemoveDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonRemoveDetail.TabIndex = 27;
            this.buttonRemoveDetail.Text = "Remove";
            this.buttonRemoveDetail.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateDetail
            // 
            this.buttonUpdateDetail.Location = new System.Drawing.Point(108, 133);
            this.buttonUpdateDetail.Name = "buttonUpdateDetail";
            this.buttonUpdateDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonUpdateDetail.TabIndex = 26;
            this.buttonUpdateDetail.Text = "Update";
            this.buttonUpdateDetail.UseVisualStyleBackColor = true;
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
            // 
            // textBoxDiscountedPrice
            // 
            this.textBoxDiscountedPrice.Location = new System.Drawing.Point(552, 86);
            this.textBoxDiscountedPrice.Name = "textBoxDiscountedPrice";
            this.textBoxDiscountedPrice.Size = new System.Drawing.Size(75, 23);
            this.textBoxDiscountedPrice.TabIndex = 20;
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
            // buttonAddDetail
            // 
            this.buttonAddDetail.Location = new System.Drawing.Point(23, 133);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonAddDetail.TabIndex = 25;
            this.buttonAddDetail.Text = "Add";
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            // 
            // textBoxDetailsNote
            // 
            this.textBoxDetailsNote.Location = new System.Drawing.Point(701, 39);
            this.textBoxDetailsNote.Multiline = true;
            this.textBoxDetailsNote.Name = "textBoxDetailsNote";
            this.textBoxDetailsNote.Size = new System.Drawing.Size(182, 71);
            this.textBoxDetailsNote.TabIndex = 29;
            // 
            // groupBoxTactionDetails
            // 
            this.groupBoxTactionDetails.Controls.Add(this.dataGridViewTactionDetails);
            this.groupBoxTactionDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactionDetails.Location = new System.Drawing.Point(742, 3);
            this.groupBoxTactionDetails.Name = "groupBoxTactionDetails";
            this.groupBoxTactionDetails.Size = new System.Drawing.Size(921, 582);
            this.groupBoxTactionDetails.TabIndex = 6;
            this.groupBoxTactionDetails.TabStop = false;
            this.groupBoxTactionDetails.Text = "Details";
            // 
            // dataGridViewTactionDetails
            // 
            this.dataGridViewTactionDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTactionDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactionDetails.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewTactionDetails.Name = "dataGridViewTactionDetails";
            this.dataGridViewTactionDetails.Size = new System.Drawing.Size(908, 548);
            this.dataGridViewTactionDetails.TabIndex = 0;
            // 
            // groupBoxTactions
            // 
            this.groupBoxTactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxTactions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxTactions.Controls.Add(this.dataGridViewTactions);
            this.groupBoxTactions.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTactions.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTactions.Name = "groupBoxTactions";
            this.groupBoxTactions.Size = new System.Drawing.Size(733, 929);
            this.groupBoxTactions.TabIndex = 5;
            this.groupBoxTactions.TabStop = false;
            this.groupBoxTactions.Text = "Transactions";
            // 
            // dataGridViewTactions
            // 
            this.dataGridViewTactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewTactions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTactions.Location = new System.Drawing.Point(6, 24);
            this.dataGridViewTactions.Name = "dataGridViewTactions";
            this.dataGridViewTactions.Size = new System.Drawing.Size(721, 899);
            this.dataGridViewTactions.TabIndex = 0;
            // 
            // buttonClearDetail
            // 
            this.buttonClearDetail.Location = new System.Drawing.Point(279, 133);
            this.buttonClearDetail.Name = "buttonClearDetail";
            this.buttonClearDetail.Size = new System.Drawing.Size(75, 25);
            this.buttonClearDetail.TabIndex = 35;
            this.buttonClearDetail.Text = "Clear";
            this.buttonClearDetail.UseVisualStyleBackColor = true;
            // 
            // TactionUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.groupBoxTactionOptions);
            this.Controls.Add(this.groupBoxTactionDetailsOptions);
            this.Controls.Add(this.groupBoxTactionDetails);
            this.Controls.Add(this.groupBoxTactions);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TactionUserControl";
            this.Size = new System.Drawing.Size(1670, 938);
            this.groupBoxTactionOptions.ResumeLayout(false);
            this.groupBoxTactionOptions.PerformLayout();
            this.groupBoxTactionDetailsOptions.ResumeLayout(false);
            this.groupBoxTactionDetailsOptions.PerformLayout();
            this.groupBoxTactionDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactionDetails)).EndInit();
            this.groupBoxTactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTactionOptions;
        private System.Windows.Forms.TextBox textBoxTotalVatPrice;
        private System.Windows.Forms.Label labelTotalVatPrice;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.ComboBox comboBoxOwner;
        private System.Windows.Forms.Button buttonCancelTaction;
        private System.Windows.Forms.CheckBox checkBoxTactionsEditable;
        private System.Windows.Forms.TextBox textBoxSeller;
        private System.Windows.Forms.DateTimePicker dateTimePickerTactionDate;
        private System.Windows.Forms.CheckBox checkBoxSeller;
        private System.Windows.Forms.Label labelTactionDate;
        private System.Windows.Forms.Button buttonNewTaction;
        private System.Windows.Forms.Label labelShop;
        private System.Windows.Forms.Button buttonDeleteTaction;
        private System.Windows.Forms.TextBox textBoxShop;
        private System.Windows.Forms.TextBox textBoxTotalPrice;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.Button buttonSaveTaction;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTactionNo;
        private System.Windows.Forms.Button buttonUpdateTaction;
        private System.Windows.Forms.TextBox textBoxTactionNo;
        private System.Windows.Forms.GroupBox groupBoxTactionDetailsOptions;
        private System.Windows.Forms.ComboBox comboBoxItemSubType;
        private System.Windows.Forms.Button buttonAdviceLastUnitPrice;
        private System.Windows.Forms.Label labelVatPercantage;
        private System.Windows.Forms.TextBox textBoxItem;
        private System.Windows.Forms.Label labelItemGroup;
        private System.Windows.Forms.TextBox textBoxItemGroup;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label labelItemSubType;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.TextBox textBoxUnit;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label labelVat;
        private System.Windows.Forms.TextBox textBoxVat;
        private System.Windows.Forms.Label labelDiscountRate;
        private System.Windows.Forms.TextBox textBoxDiscountRate;
        private System.Windows.Forms.Label labelDiscountedPrice;
        private System.Windows.Forms.Button buttonRemoveDetail;
        private System.Windows.Forms.Button buttonUpdateDetail;
        private System.Windows.Forms.CheckBox checkBoxDiscount;
        private System.Windows.Forms.CheckBox checkBoxDetailsEditable;
        private System.Windows.Forms.TextBox textBoxDiscountedPrice;
        private System.Windows.Forms.Label labelDetailsNote;
        private System.Windows.Forms.Button buttonAddDetail;
        private System.Windows.Forms.TextBox textBoxDetailsNote;
        private System.Windows.Forms.GroupBox groupBoxTactionDetails;
        private System.Windows.Forms.DataGridView dataGridViewTactionDetails;
        private System.Windows.Forms.GroupBox groupBoxTactions;
        private System.Windows.Forms.DataGridView dataGridViewTactions;
        private System.Windows.Forms.Button buttonClearDetail;
    }
}
