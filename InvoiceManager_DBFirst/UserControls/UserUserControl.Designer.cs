﻿namespace InvoiceManager_DBFirst.UserControls
{
    partial class UserUserControl
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
            this.groupBoxUserOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxDefaultUserImage = new System.Windows.Forms.CheckBox();
            this.textBoxUserOptionsName = new System.Windows.Forms.TextBox();
            this.textBoxUserOptionsSurname = new System.Windows.Forms.TextBox();
            this.buttonPreviousImage = new System.Windows.Forms.Button();
            this.buttonNextImage = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.pictureBoxUser = new System.Windows.Forms.PictureBox();
            this.labelUserOptionsName = new System.Windows.Forms.Label();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.textBoxUserOptionsFullname = new System.Windows.Forms.TextBox();
            this.labelUserOptionsFullname = new System.Windows.Forms.Label();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonUpdateUser = new System.Windows.Forms.Button();
            this.buttonSaveUser = new System.Windows.Forms.Button();
            this.labelUserOptionsSurname = new System.Windows.Forms.Label();
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.groupBoxUserOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).BeginInit();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUserOptions
            // 
            this.groupBoxUserOptions.Controls.Add(this.checkBoxDefaultUserImage);
            this.groupBoxUserOptions.Controls.Add(this.textBoxUserOptionsName);
            this.groupBoxUserOptions.Controls.Add(this.textBoxUserOptionsSurname);
            this.groupBoxUserOptions.Controls.Add(this.buttonPreviousImage);
            this.groupBoxUserOptions.Controls.Add(this.buttonNextImage);
            this.groupBoxUserOptions.Controls.Add(this.buttonAddImage);
            this.groupBoxUserOptions.Controls.Add(this.buttonDeleteImage);
            this.groupBoxUserOptions.Controls.Add(this.pictureBoxUser);
            this.groupBoxUserOptions.Controls.Add(this.labelUserOptionsName);
            this.groupBoxUserOptions.Controls.Add(this.buttonNewUser);
            this.groupBoxUserOptions.Controls.Add(this.textBoxUserOptionsFullname);
            this.groupBoxUserOptions.Controls.Add(this.labelUserOptionsFullname);
            this.groupBoxUserOptions.Controls.Add(this.buttonDeleteUser);
            this.groupBoxUserOptions.Controls.Add(this.buttonUpdateUser);
            this.groupBoxUserOptions.Controls.Add(this.buttonSaveUser);
            this.groupBoxUserOptions.Controls.Add(this.labelUserOptionsSurname);
            this.groupBoxUserOptions.Location = new System.Drawing.Point(620, 3);
            this.groupBoxUserOptions.Name = "groupBoxUserOptions";
            this.groupBoxUserOptions.Size = new System.Drawing.Size(553, 226);
            this.groupBoxUserOptions.TabIndex = 13;
            this.groupBoxUserOptions.TabStop = false;
            this.groupBoxUserOptions.Text = "User Options";
            // 
            // checkBoxDefaultUserImage
            // 
            this.checkBoxDefaultUserImage.AutoSize = true;
            this.checkBoxDefaultUserImage.Location = new System.Drawing.Point(160, 167);
            this.checkBoxDefaultUserImage.Name = "checkBoxDefaultUserImage";
            this.checkBoxDefaultUserImage.Size = new System.Drawing.Size(66, 19);
            this.checkBoxDefaultUserImage.TabIndex = 16;
            this.checkBoxDefaultUserImage.Text = "Default";
            this.checkBoxDefaultUserImage.UseVisualStyleBackColor = true;
            // 
            // textBoxUserOptionsName
            // 
            this.textBoxUserOptionsName.Location = new System.Drawing.Point(296, 24);
            this.textBoxUserOptionsName.Name = "textBoxUserOptionsName";
            this.textBoxUserOptionsName.Size = new System.Drawing.Size(240, 23);
            this.textBoxUserOptionsName.TabIndex = 1;
            // 
            // textBoxUserOptionsSurname
            // 
            this.textBoxUserOptionsSurname.Location = new System.Drawing.Point(296, 52);
            this.textBoxUserOptionsSurname.Name = "textBoxUserOptionsSurname";
            this.textBoxUserOptionsSurname.Size = new System.Drawing.Size(240, 23);
            this.textBoxUserOptionsSurname.TabIndex = 2;
            // 
            // buttonPreviousImage
            // 
            this.buttonPreviousImage.Location = new System.Drawing.Point(13, 188);
            this.buttonPreviousImage.Name = "buttonPreviousImage";
            this.buttonPreviousImage.Size = new System.Drawing.Size(23, 23);
            this.buttonPreviousImage.TabIndex = 10;
            this.buttonPreviousImage.Text = "<";
            this.buttonPreviousImage.UseVisualStyleBackColor = true;
            // 
            // buttonNextImage
            // 
            this.buttonNextImage.Location = new System.Drawing.Point(131, 188);
            this.buttonNextImage.Name = "buttonNextImage";
            this.buttonNextImage.Size = new System.Drawing.Size(23, 23);
            this.buttonNextImage.TabIndex = 11;
            this.buttonNextImage.Text = ">";
            this.buttonNextImage.UseVisualStyleBackColor = true;
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(160, 24);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(48, 23);
            this.buttonAddImage.TabIndex = 8;
            this.buttonAddImage.Text = "Add";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(160, 53);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(48, 23);
            this.buttonDeleteImage.TabIndex = 9;
            this.buttonDeleteImage.Text = "Delete";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            // 
            // pictureBoxUser
            // 
            this.pictureBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxUser.Location = new System.Drawing.Point(13, 24);
            this.pictureBoxUser.Name = "pictureBoxUser";
            this.pictureBoxUser.Size = new System.Drawing.Size(141, 160);
            this.pictureBoxUser.TabIndex = 15;
            this.pictureBoxUser.TabStop = false;
            // 
            // labelUserOptionsName
            // 
            this.labelUserOptionsName.AutoSize = true;
            this.labelUserOptionsName.Location = new System.Drawing.Point(251, 28);
            this.labelUserOptionsName.Name = "labelUserOptionsName";
            this.labelUserOptionsName.Size = new System.Drawing.Size(38, 15);
            this.labelUserOptionsName.TabIndex = 13;
            this.labelUserOptionsName.Text = "Name";
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(296, 114);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(55, 23);
            this.buttonNewUser.TabIndex = 4;
            this.buttonNewUser.Text = "New";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            // 
            // textBoxUserOptionsFullname
            // 
            this.textBoxUserOptionsFullname.Location = new System.Drawing.Point(296, 80);
            this.textBoxUserOptionsFullname.Name = "textBoxUserOptionsFullname";
            this.textBoxUserOptionsFullname.Size = new System.Drawing.Size(240, 23);
            this.textBoxUserOptionsFullname.TabIndex = 3;
            // 
            // labelUserOptionsFullname
            // 
            this.labelUserOptionsFullname.AutoSize = true;
            this.labelUserOptionsFullname.Location = new System.Drawing.Point(237, 84);
            this.labelUserOptionsFullname.Name = "labelUserOptionsFullname";
            this.labelUserOptionsFullname.Size = new System.Drawing.Size(58, 15);
            this.labelUserOptionsFullname.TabIndex = 9;
            this.labelUserOptionsFullname.Text = "Fullname";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(481, 114);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(55, 23);
            this.buttonDeleteUser.TabIndex = 7;
            this.buttonDeleteUser.Text = "Delete";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateUser
            // 
            this.buttonUpdateUser.Location = new System.Drawing.Point(419, 114);
            this.buttonUpdateUser.Name = "buttonUpdateUser";
            this.buttonUpdateUser.Size = new System.Drawing.Size(55, 23);
            this.buttonUpdateUser.TabIndex = 6;
            this.buttonUpdateUser.Text = "Update";
            this.buttonUpdateUser.UseVisualStyleBackColor = true;
            // 
            // buttonSaveUser
            // 
            this.buttonSaveUser.Location = new System.Drawing.Point(358, 114);
            this.buttonSaveUser.Name = "buttonSaveUser";
            this.buttonSaveUser.Size = new System.Drawing.Size(55, 23);
            this.buttonSaveUser.TabIndex = 5;
            this.buttonSaveUser.Text = "Save";
            this.buttonSaveUser.UseVisualStyleBackColor = true;
            // 
            // labelUserOptionsSurname
            // 
            this.labelUserOptionsSurname.AutoSize = true;
            this.labelUserOptionsSurname.Location = new System.Drawing.Point(237, 55);
            this.labelUserOptionsSurname.Name = "labelUserOptionsSurname";
            this.labelUserOptionsSurname.Size = new System.Drawing.Size(55, 15);
            this.labelUserOptionsSurname.TabIndex = 0;
            this.labelUserOptionsSurname.Text = "Surname";
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.dataGridViewUsers);
            this.groupBoxUsers.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUsers.Location = new System.Drawing.Point(4, 3);
            this.groupBoxUsers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxUsers.Size = new System.Drawing.Size(609, 511);
            this.groupBoxUsers.TabIndex = 12;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Users";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(595, 483);
            this.dataGridViewUsers.TabIndex = 13;
            this.dataGridViewUsers.TabStop = false;
            // 
            // UserUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.groupBoxUserOptions);
            this.Controls.Add(this.groupBoxUsers);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UserUserControl";
            this.Size = new System.Drawing.Size(1670, 936);
            this.groupBoxUserOptions.ResumeLayout(false);
            this.groupBoxUserOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUser)).EndInit();
            this.groupBoxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserOptions;
        private System.Windows.Forms.CheckBox checkBoxDefaultUserImage;
        private System.Windows.Forms.TextBox textBoxUserOptionsName;
        private System.Windows.Forms.TextBox textBoxUserOptionsSurname;
        private System.Windows.Forms.Button buttonPreviousImage;
        private System.Windows.Forms.Button buttonNextImage;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.PictureBox pictureBoxUser;
        private System.Windows.Forms.Label labelUserOptionsName;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.TextBox textBoxUserOptionsFullname;
        private System.Windows.Forms.Label labelUserOptionsFullname;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonUpdateUser;
        private System.Windows.Forms.Button buttonSaveUser;
        private System.Windows.Forms.Label labelUserOptionsSurname;
        private System.Windows.Forms.GroupBox groupBoxUsers;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
    }
}
