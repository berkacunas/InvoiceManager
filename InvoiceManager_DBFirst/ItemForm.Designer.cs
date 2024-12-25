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
            this.buttonDeleteGroup = new System.Windows.Forms.Button();
            this.buttonUpdateGroup = new System.Windows.Forms.Button();
            this.buttonSaveGroup = new System.Windows.Forms.Button();
            this.textBoxGroupOptionsTopGroup = new System.Windows.Forms.TextBox();
            this.labelTopGroupOptionsGroup = new System.Windows.Forms.Label();
            this.textBoxGroupOptionsGroup = new System.Windows.Forms.TextBox();
            this.labelGroupOptionsGroup = new System.Windows.Forms.Label();
            this.groupBoxItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxItemOptions.SuspendLayout();
            this.groupBoxItemGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItemGroups)).BeginInit();
            this.groupBoxItemGroupOptions.SuspendLayout();
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
            // 
            // groupBoxItemOptions
            // 
            this.groupBoxItemOptions.Controls.Add(this.buttonDeleteItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonUpdateItem);
            this.groupBoxItemOptions.Controls.Add(this.buttonSaveItem);
            this.groupBoxItemOptions.Controls.Add(this.textBoxItemOptionsNote);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsNote);
            this.groupBoxItemOptions.Controls.Add(this.comboBoxItemOptionsGroup);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsGroup);
            this.groupBoxItemOptions.Controls.Add(this.textBoxItemOptionsItem);
            this.groupBoxItemOptions.Controls.Add(this.labelItemOptionsItem);
            this.groupBoxItemOptions.Location = new System.Drawing.Point(1004, 158);
            this.groupBoxItemOptions.Name = "groupBoxItemOptions";
            this.groupBoxItemOptions.Size = new System.Drawing.Size(433, 201);
            this.groupBoxItemOptions.TabIndex = 4;
            this.groupBoxItemOptions.TabStop = false;
            this.groupBoxItemOptions.Text = "Item Options";
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(256, 170);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteItem.TabIndex = 8;
            this.buttonDeleteItem.Text = "Delete";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(171, 170);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateItem.TabIndex = 7;
            this.buttonUpdateItem.Text = "Update";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonSaveItem
            // 
            this.buttonSaveItem.Location = new System.Drawing.Point(86, 170);
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
            // 
            // groupBoxItemGroupOptions
            // 
            this.groupBoxItemGroupOptions.Controls.Add(this.textBoxGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.labelGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonDeleteGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonUpdateGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.buttonSaveGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.textBoxGroupOptionsTopGroup);
            this.groupBoxItemGroupOptions.Controls.Add(this.labelTopGroupOptionsGroup);
            this.groupBoxItemGroupOptions.Location = new System.Drawing.Point(1004, 24);
            this.groupBoxItemGroupOptions.Name = "groupBoxItemGroupOptions";
            this.groupBoxItemGroupOptions.Size = new System.Drawing.Size(433, 126);
            this.groupBoxItemGroupOptions.TabIndex = 9;
            this.groupBoxItemGroupOptions.TabStop = false;
            this.groupBoxItemGroupOptions.Text = "Group Options";
            // 
            // buttonDeleteGroup
            // 
            this.buttonDeleteGroup.Location = new System.Drawing.Point(256, 92);
            this.buttonDeleteGroup.Name = "buttonDeleteGroup";
            this.buttonDeleteGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteGroup.TabIndex = 8;
            this.buttonDeleteGroup.Text = "Delete";
            this.buttonDeleteGroup.UseVisualStyleBackColor = true;
            this.buttonDeleteGroup.Click += new System.EventHandler(this.buttonDeleteGroup_Click);
            // 
            // buttonUpdateGroup
            // 
            this.buttonUpdateGroup.Location = new System.Drawing.Point(171, 92);
            this.buttonUpdateGroup.Name = "buttonUpdateGroup";
            this.buttonUpdateGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdateGroup.TabIndex = 7;
            this.buttonUpdateGroup.Text = "Update";
            this.buttonUpdateGroup.UseVisualStyleBackColor = true;
            this.buttonUpdateGroup.Click += new System.EventHandler(this.buttonUpdateGroup_Click);
            // 
            // buttonSaveGroup
            // 
            this.buttonSaveGroup.Location = new System.Drawing.Point(86, 92);
            this.buttonSaveGroup.Name = "buttonSaveGroup";
            this.buttonSaveGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveGroup.TabIndex = 6;
            this.buttonSaveGroup.Text = "Save";
            this.buttonSaveGroup.UseVisualStyleBackColor = true;
            this.buttonSaveGroup.Click += new System.EventHandler(this.buttonSaveGroup_Click);
            // 
            // textBoxGroupOptionsTopGroup
            // 
            this.textBoxGroupOptionsTopGroup.Location = new System.Drawing.Point(86, 32);
            this.textBoxGroupOptionsTopGroup.Name = "textBoxGroupOptionsTopGroup";
            this.textBoxGroupOptionsTopGroup.Size = new System.Drawing.Size(330, 23);
            this.textBoxGroupOptionsTopGroup.TabIndex = 1;
            // 
            // labelTopGroupOptionsGroup
            // 
            this.labelTopGroupOptionsGroup.AutoSize = true;
            this.labelTopGroupOptionsGroup.Location = new System.Drawing.Point(5, 37);
            this.labelTopGroupOptionsGroup.Name = "labelTopGroupOptionsGroup";
            this.labelTopGroupOptionsGroup.Size = new System.Drawing.Size(63, 15);
            this.labelTopGroupOptionsGroup.TabIndex = 0;
            this.labelTopGroupOptionsGroup.Text = "Top Group";
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
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 793);
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
        private System.Windows.Forms.TextBox textBoxGroupOptionsTopGroup;
        private System.Windows.Forms.Label labelTopGroupOptionsGroup;
        private System.Windows.Forms.TextBox textBoxGroupOptionsGroup;
        private System.Windows.Forms.Label labelGroupOptionsGroup;
    }
}