namespace InvoiceManager_DBFirst
{
    partial class ItemForm
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
            this.groupBoxItems = new System.Windows.Forms.GroupBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.groupBoxItemOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxItemOptionsEdit = new System.Windows.Forms.CheckBox();
            this.buttonNewItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonSaveItem = new System.Windows.Forms.Button();
            this.textBoxItemOptionsNote = new System.Windows.Forms.TextBox();
            this.labelItemOptionsNote = new System.Windows.Forms.Label();
            this.comboBoxItemOptionsGroup = new System.Windows.Forms.ComboBox();
            this.labelItemOptionsGroup = new System.Windows.Forms.Label();
            this.textBoxItemOptionsItem = new System.Windows.Forms.TextBox();
            this.labelItemOptionsItem = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxItemGroups = new System.Windows.Forms.GroupBox();
            this.dataGridViewItemGroups = new System.Windows.Forms.DataGridView();
            this.groupBoxItemGroupOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxGroupOptionsEdit = new System.Windows.Forms.CheckBox();
            this.comboBoxGroupOptionsTopGroup = new System.Windows.Forms.ComboBox();
            this.buttonNewGroup = new System.Windows.Forms.Button();
            this.textBoxGroupOptionsGroup = new System.Windows.Forms.TextBox();
            this.labelGroupOptionsGroup = new System.Windows.Forms.Label();
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonUpdateGroup = new System.Windows.Forms.Button();
            this.buttonSaveGroup = new System.Windows.Forms.Button();
            this.labelGroupOptionsTopGroup = new System.Windows.Forms.Label();
            this.groupBoxItemTopGroupOptions = new System.Windows.Forms.GroupBox();
            this.comboBoxTopGroupOptionsTopGroup = new System.Windows.Forms.ComboBox();
            this.buttonNewTopGroup = new System.Windows.Forms.Button();
            this.labelTopGroupOptionsTopGroup = new System.Windows.Forms.Label();
            this.buttonDeleteTopGroup = new System.Windows.Forms.Button();
            this.buttonUpdateTopGroup = new System.Windows.Forms.Button();
            this.buttonSaveTopGroup = new System.Windows.Forms.Button();
            this.groupBoxItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxItemOptions.SuspendLayout();
            this.groupBoxItemGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemGroups)).BeginInit();
            this.groupBoxItemGroupOptions.SuspendLayout();
            this.groupBoxItemTopGroupOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxItems
            // 
            this.groupBoxItems.Controls.Add(this.dataGridViewItems);
            this.groupBoxItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItems.Location = new System.Drawing.Point(380, 12);
            this.groupBoxItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItems.Name = "groupBoxItems";
            this.groupBoxItems.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItems.Size = new System.Drawing.Size(617, 769);
            this.groupBoxItems.TabIndex = 3;
            this.groupBoxItems.TabStop = false;
            this.groupBoxItems.Text = "Items";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(8, 22);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(601, 741);
            this.dataGridViewItems.TabIndex = 0;
            this.dataGridViewItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellClick);
            this.dataGridViewItems.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItems_ColumnHeaderMouseClick);
            this.dataGridViewItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewItems_DataBindingComplete);
            // 
            // groupBoxItemOptions
            // 
            this.groupBoxItemOptions.Controls.Add(this.checkBoxItemOptionsEdit);
            this.groupBoxItemOptions.Controls.Add(this.buttonNewItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonDeleteItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonUpdateItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonSaveItem);
            this.groupBoxItemOptions.Controls.Add(this.textBoxItemOptionsNote);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsNote);
            this.groupBoxItemOptions.Controls.Add(this.comboBoxItemOptionsGroup);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsGroup);
            this.groupBoxItemOptions.Controls.Add(this.textBoxItemOptionsItem);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsItem);
            this.groupBoxItemOptions.Location = new System.Drawing.Point(1004, 248);
            this.groupBoxItemOptions.Name = "groupBoxItemOptions";
            this.groupBoxItemOptions.Size = new System.Drawing.Size(433, 201);
            this.groupBoxItemOptions.TabIndex = 4;
            this.groupBoxItemOptions.TabStop = false;
            this.groupBoxItemOptions.Text = "Item Options";
            // 
            // checkBoxItemOptionsEdit
            // 
            this.checkBoxItemOptionsEdit.AutoSize = true;
            this.checkBoxItemOptionsEdit.Location = new System.Drawing.Point(6, 176);
            this.checkBoxItemOptionsEdit.Name = "checkBoxItemOptionsEdit";
            this.checkBoxItemOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxItemOptionsEdit.TabIndex = 10;
            this.checkBoxItemOptionsEdit.Text = "Edit";
            this.checkBoxItemOptionsEdit.UseVisualStyleBackColor = true;
            this.checkBoxItemOptionsEdit.CheckedChanged += new System.EventHandler(this.checkBoxItemOptionsEdit_CheckedChanged);
            // 
            // buttonNewItem
            // 
            this.buttonNewItem.Location = new System.Drawing.Point(86, 170);
            this.buttonNewItem.Name = "buttonNewItem";
            this.buttonNewItem.Size = new System.Drawing.Size(75, 23);
            this.buttonNewItem.TabIndex = 9;
            this.buttonNewItem.Text = "New";
            this.buttonNewItem.UseVisualStyleBackColor = true;
            this.buttonNewItem.Click += new System.EventHandler(this.buttonNewItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(339, 170);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 8;
            this.buttonDeleteItem.Text = "Delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(254, 170);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateItem.TabIndex = 7;
            this.buttonUpdateItem.Text = "Update";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(169, 170);
            this.buttonSaveItem.Name = "buttonSaveItem";
            this.buttonSaveItem.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveItem.TabIndex = 6;
            this.buttonSaveItem.Text = "Save";
            this.buttonSaveItem.UseVisualStyleBackColor = true;
            this.buttonSaveItem.Click += new System.EventHandler(this.buttonSaveItem_Click);
            // 
            // textBoxItemOptionsNote
            // 
            this.textBoxItemOptionsNote.Location = new System.Drawing.Point(86, 89);
            this.textBoxItemOptionsNote.Multiline = true;
            this.textBoxItemOptionsNote.Name = "textBoxItemOptionsNote";
            this.textBoxItemOptionsNote.Size = new System.Drawing.Size(330, 73);
            this.textBoxItemOptionsNote.TabIndex = 5;
            // 
            // labelItemOptionsNote
            // 
            this.labelItemOptionsNote.AutoSize = true;
            this.labelItemOptionsNote.Location = new System.Drawing.Point(37, 95);
            this.labelItemOptionsNote.Name = "labelItemOptionsNote";
            this.labelItemOptionsNote.Size = new System.Drawing.Size(32, 15);
            this.labelItemOptionsNote.TabIndex = 4;
            this.labelItemOptionsNote.Text = "Note";
            // 
            // comboBoxItemOptionsGroup
            // 
            this.comboBoxItemOptionsGroup.FormattingEnabled = true;
            this.comboBoxItemOptionsGroup.Location = new System.Drawing.Point(86, 32);
            this.comboBoxItemOptionsGroup.Name = "comboBoxItemOptionsGroup";
            this.comboBoxItemOptionsGroup.Size = new System.Drawing.Size(330, 23);
            this.comboBoxItemOptionsGroup.TabIndex = 3;
            // 
            // labelItemOptionsGroup
            // 
            this.labelItemOptionsGroup.AutoSize = true;
            this.labelItemOptionsGroup.Location = new System.Drawing.Point(27, 37);
            this.labelItemOptionsGroup.Name = "labelItemOptionsGroup";
            this.labelItemOptionsGroup.Size = new System.Drawing.Size(41, 15);
            this.labelItemOptionsGroup.TabIndex = 2;
            this.labelItemOptionsGroup.Text = "Group";
            // 
            // textBoxItemOptionsItem
            // 
            this.textBoxItemOptionsItem.Location = new System.Drawing.Point(86, 60);
            this.textBoxItemOptionsItem.Name = "textBoxItemOptionsItem";
            this.textBoxItemOptionsItem.Size = new System.Drawing.Size(330, 23);
            this.textBoxItemOptionsItem.TabIndex = 1;
            // 
            // labelItemOptionsItem
            // 
            this.labelItemOptionsItem.AutoSize = true;
            this.labelItemOptionsItem.Location = new System.Drawing.Point(37, 66);
            this.labelItemOptionsItem.Name = "labelItemOptionsItem";
            this.labelItemOptionsItem.Size = new System.Drawing.Size(31, 15);
            this.labelItemOptionsItem.TabIndex = 0;
            this.labelItemOptionsItem.Text = "Item";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(1362, 752);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxItemGroups
            // 
            this.groupBoxItemGroups.Controls.Add(this.dataGridViewItemGroups);
            this.groupBoxItemGroups.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxItemGroups.Location = new System.Drawing.Point(13, 12);
            this.groupBoxItemGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemGroups.Name = "groupBoxItemGroups";
            this.groupBoxItemGroups.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxItemGroups.Size = new System.Drawing.Size(359, 769);
            this.groupBoxItemGroups.TabIndex = 4;
            this.groupBoxItemGroups.TabStop = false;
            this.groupBoxItemGroups.Text = "Groups";
            // 
            // dataGridViewItemGroups
            // 
            this.dataGridViewItemGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewItemGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItemGroups.Location = new System.Drawing.Point(8, 22);
            this.dataGridViewItemGroups.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewItemGroups.Name = "dataGridViewItemGroups";
            this.dataGridViewItemGroups.Size = new System.Drawing.Size(343, 741);
            this.dataGridViewItemGroups.TabIndex = 0;
            this.dataGridViewItemGroups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItemGroups_CellClick);
            this.dataGridViewItemGroups.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewItemGroups_ColumnHeaderMouseClick);
            this.dataGridViewItemGroups.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewItemGroups_DataBindingComplete);
            // 
            // groupBoxItemGroupOptions
            // 
            this.groupBoxItemGroupOptions.Controls.Add(this.checkBoxGroupOptionsEdit);
            this.groupBoxItemGroupOptions.Controls.Add(this.comboBoxGroupOptionsTopGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonNewGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.textBoxGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.labelGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonDeleteGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonUpdateGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonSaveGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.labelGroupOptionsTopGroup);
            this.groupBoxItemGroupOptions.Location = new System.Drawing.Point(1004, 114);
            this.groupBoxItemGroupOptions.Name = "groupBoxItemGroupOptions";
            this.groupBoxItemGroupOptions.Size = new System.Drawing.Size(433, 126);
            this.groupBoxItemGroupOptions.TabIndex = 9;
            this.groupBoxItemGroupOptions.TabStop = false;
            this.groupBoxItemGroupOptions.Text = "Group Options";
            // 
            // checkBoxGroupOptionsEdit
            // 
            this.checkBoxGroupOptionsEdit.AutoSize = true;
            this.checkBoxGroupOptionsEdit.Location = new System.Drawing.Point(6, 96);
            this.checkBoxGroupOptionsEdit.Name = "checkBoxGroupOptionsEdit";
            this.checkBoxGroupOptionsEdit.Size = new System.Drawing.Size(47, 19);
            this.checkBoxGroupOptionsEdit.TabIndex = 11;
            this.checkBoxGroupOptionsEdit.Text = "Edit";
            this.checkBoxGroupOptionsEdit.UseVisualStyleBackColor = true;
            this.checkBoxGroupOptionsEdit.CheckedChanged += new System.EventHandler(this.checkBoxGroupOptionsEdit_CheckedChanged);
            // 
            // comboBoxGroupOptionsTopGroup
            // 
            this.comboBoxGroupOptionsTopGroup.FormattingEnabled = true;
            this.comboBoxGroupOptionsTopGroup.Location = new System.Drawing.Point(86, 32);
            this.comboBoxGroupOptionsTopGroup.Name = "comboBoxGroupOptionsTopGroup";
            this.comboBoxGroupOptionsTopGroup.Size = new System.Drawing.Size(328, 23);
            this.comboBoxGroupOptionsTopGroup.TabIndex = 12;
            // 
            // buttonNewGroup
            // 
            this.buttonNewGroup.Location = new System.Drawing.Point(86, 92);
            this.buttonNewGroup.Name = "buttonNewGroup";
            this.buttonNewGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonNewGroup.TabIndex = 11;
            this.buttonNewGroup.Text = "New";
            this.buttonNewGroup.UseVisualStyleBackColor = true;
            this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
            // 
            // textBoxGroupOptionsGroup
            // 
            this.textBoxGroupOptionsGroup.Location = new System.Drawing.Point(86, 61);
            this.textBoxGroupOptionsGroup.Name = "textBoxGroupOptionsGroup";
            this.textBoxGroupOptionsGroup.Size = new System.Drawing.Size(330, 23);
            this.textBoxGroupOptionsGroup.TabIndex = 10;
            // 
            // labelGroupOptionsGroup
            // 
            this.labelGroupOptionsGroup.AutoSize = true;
            this.labelGroupOptionsGroup.Location = new System.Drawing.Point(27, 64);
            this.labelGroupOptionsGroup.Name = "labelGroupOptionsGroup";
            this.labelGroupOptionsGroup.Size = new System.Drawing.Size(41, 15);
            this.labelGroupOptionsGroup.TabIndex = 9;
            this.labelGroupOptionsGroup.Text = "Group";
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(339, 92);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteGroup.TabIndex = 8;
            this.buttonDeleteGroup.Text = "Delete";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.Location = new System.Drawing.Point(254, 92);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateGroup.TabIndex = 7;
            this.buttonUpdateGroup.Text = "Update";
            this.buttonUpdateGroup.UseVisualStyleBackColor = true;
            this.buttonUpdateGroup.Click += new System.EventHandler(this.buttonUpdateGroup_Click);
            // 
            // buttonSaveGroup
            // 
            this.buttonSaveGroup.Location = new System.Drawing.Point(169, 92);
            this.buttonSaveGroup.Name = "buttonSaveGroup";
            this.buttonSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGroup.TabIndex = 6;
            this.buttonSaveGroup.Text = "Save";
            this.buttonSaveGroup.UseVisualStyleBackColor = true;
            this.buttonSaveGroup.Click += new System.EventHandler(this.buttonSaveGroup_Click);
            // 
            // labelGroupOptionsTopGroup
            // 
            this.labelGroupOptionsTopGroup.AutoSize = true;
            this.labelGroupOptionsTopGroup.Location = new System.Drawing.Point(5, 37);
            this.labelGroupOptionsTopGroup.Name = "labelGroupOptionsTopGroup";
            this.labelGroupOptionsTopGroup.Size = new System.Drawing.Size(63, 15);
            this.labelGroupOptionsTopGroup.TabIndex = 0;
            this.labelGroupOptionsTopGroup.Text = "Top Group";
            // 
            // groupBoxItemTopGroupOptions
            // 
            this.groupBoxItemTopGroupOptions.Controls.Add(this.comboBoxTopGroupOptionsTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonNewTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.labelTopGroupOptionsTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonDeleteTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonUpdateTopGroup);
            this.groupBoxItemTopGroupOptions.Controls.Add(this.buttonSaveTopGroup);
            this.groupBoxItemTopGroupOptions.Location = new System.Drawing.Point(1004, 12);
            this.groupBoxItemTopGroupOptions.Name = "groupBoxItemTopGroupOptions";
            this.groupBoxItemTopGroupOptions.Size = new System.Drawing.Size(433, 96);
            this.groupBoxItemTopGroupOptions.TabIndex = 12;
            this.groupBoxItemTopGroupOptions.TabStop = false;
            this.groupBoxItemTopGroupOptions.Text = "Top Group Options";
            // 
            // comboBoxTopGroupOptionsTopGroup
            // 
            this.comboBoxTopGroupOptionsTopGroup.FormattingEnabled = true;
            this.comboBoxTopGroupOptionsTopGroup.Location = new System.Drawing.Point(86, 33);
            this.comboBoxTopGroupOptionsTopGroup.Name = "comboBoxTopGroupOptionsTopGroup";
            this.comboBoxTopGroupOptionsTopGroup.Size = new System.Drawing.Size(328, 23);
            this.comboBoxTopGroupOptionsTopGroup.TabIndex = 12;
            // 
            // buttonNewTopGroup
            // 
            this.buttonNewTopGroup.Location = new System.Drawing.Point(86, 62);
            this.buttonNewTopGroup.Name = "buttonNewTopGroup";
            this.buttonNewTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonNewTopGroup.TabIndex = 11;
            this.buttonNewTopGroup.Text = "New";
            this.buttonNewTopGroup.UseVisualStyleBackColor = true;
            this.buttonNewTopGroup.Click += new System.EventHandler(this.buttonNewTopGroup_Click);
            // 
            // labelTopGroupOptionsTopGroup
            // 
            this.labelTopGroupOptionsTopGroup.AutoSize = true;
            this.labelTopGroupOptionsTopGroup.Location = new System.Drawing.Point(5, 36);
            this.labelTopGroupOptionsTopGroup.Name = "labelTopGroupOptionsTopGroup";
            this.labelTopGroupOptionsTopGroup.Size = new System.Drawing.Size(63, 15);
            this.labelTopGroupOptionsTopGroup.TabIndex = 9;
            this.labelTopGroupOptionsTopGroup.Text = "Top Group";
            // 
            // buttonDeleteTopGroup
            // 
            this.buttonDeleteTopGroup.Location = new System.Drawing.Point(339, 62);
            this.buttonDeleteTopGroup.Name = "buttonDeleteTopGroup";
            this.buttonDeleteTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteTopGroup.TabIndex = 8;
            this.buttonDeleteTopGroup.Text = "Delete";
            this.buttonDeleteTopGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteTopGroup.Click += new System.EventHandler(this.buttonDeleteTopGroup_Click);
            // 
            // buttonUpdateTopGroup
            // 
            this.buttonUpdateTopGroup.Location = new System.Drawing.Point(254, 62);
            this.buttonUpdateTopGroup.Name = "buttonUpdateTopGroup";
            this.buttonUpdateTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateTopGroup.TabIndex = 7;
            this.buttonUpdateTopGroup.Text = "Update";
            this.buttonUpdateTopGroup.UseVisualStyleBackColor = true;
            this.buttonUpdateTopGroup.Click += new System.EventHandler(this.buttonUpdateTopGroup_Click);
            // 
            // buttonSaveTopGroup
            // 
            this.buttonSaveTopGroup.Location = new System.Drawing.Point(169, 62);
            this.buttonSaveTopGroup.Name = "buttonSaveTopGroup";
            this.buttonSaveTopGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTopGroup.TabIndex = 6;
            this.buttonSaveTopGroup.Text = "Save";
            this.buttonSaveTopGroup.UseVisualStyleBackColor = true;
            this.buttonSaveTopGroup.Click += new System.EventHandler(this.buttonSaveTopGroup_Click);
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 793);
            this.Controls.Add(this.groupBoxItemTopGroupOptions);
            this.Controls.Add(this.groupBoxItemGroupOptions);
            this.Controls.Add(this.groupBoxItemGroups);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxItemOptions);
            this.Controls.Add(this.groupBoxItems);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ItemForm";
            this.Text = "Edit Items...";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.groupBoxItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBoxItemOptions.ResumeLayout(false);
            this.groupBoxItemOptions.PerformLayout();
            this.groupBoxItemGroups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemGroups)).EndInit();
            this.groupBoxItemGroupOptions.ResumeLayout(false);
            this.groupBoxItemGroupOptions.PerformLayout();
            this.groupBoxItemTopGroupOptions.ResumeLayout(false);
            this.groupBoxItemTopGroupOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxItems;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.GroupBox groupBoxItemOptions;
        private System.Windows.Forms.TextBox textBoxItemOptionsItem;
        private System.Windows.Forms.Label labelItemOptionsItem;
        private System.Windows.Forms.TextBox textBoxItemOptionsNote;
        private System.Windows.Forms.Label labelItemOptionsNote;
        private System.Windows.Forms.ComboBox comboBoxItemOptionsGroup;
        private System.Windows.Forms.Label labelItemOptionsGroup;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDeleteItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonSaveItem;
        private System.Windows.Forms.GroupBox groupBoxItemGroups;
        private System.Windows.Forms.DataGridView dataGridViewItemGroups;
        private System.Windows.Forms.GroupBox groupBoxItemGroupOptions;
        private System.Windows.Forms.Button buttonDeleteGroup;
        private System.Windows.Forms.Button buttonUpdateGroup;
        private System.Windows.Forms.Button buttonSaveGroup;
        private System.Windows.Forms.Label labelGroupOptionsTopGroup;
        private System.Windows.Forms.TextBox textBoxGroupOptionsGroup;
        private System.Windows.Forms.Label labelGroupOptionsGroup;
        private System.Windows.Forms.Button buttonNewGroup;
        private System.Windows.Forms.Button buttonNewItem;
        private System.Windows.Forms.GroupBox groupBoxItemTopGroupOptions;
        private System.Windows.Forms.Button buttonNewTopGroup;
        private System.Windows.Forms.Label labelTopGroupOptionsTopGroup;
        private System.Windows.Forms.Button buttonDeleteTopGroup;
        private System.Windows.Forms.Button buttonUpdateTopGroup;
        private System.Windows.Forms.Button buttonSaveTopGroup;
        private System.Windows.Forms.ComboBox comboBoxGroupOptionsTopGroup;
        private System.Windows.Forms.ComboBox comboBoxTopGroupOptionsTopGroup;
        private System.Windows.Forms.CheckBox checkBoxItemOptionsEdit;
        private System.Windows.Forms.CheckBox checkBoxGroupOptionsEdit;
    }
}