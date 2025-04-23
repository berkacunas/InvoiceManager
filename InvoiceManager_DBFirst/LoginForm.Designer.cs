namespace InvoiceManager_DBFirst
{
    partial class LoginForm
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
            this.tableLayoutPanelLogin = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.textBoxLoginLastName = new System.Windows.Forms.TextBox();
            this.labelLoginLastName = new System.Windows.Forms.Label();
            this.labelLoginFirstName = new System.Windows.Forms.Label();
            this.textBoxLoginFirstName = new System.Windows.Forms.TextBox();
            this.panelLoginButtons = new System.Windows.Forms.Panel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.linkLabelSignUp = new System.Windows.Forms.LinkLabel();
            this.panelSignupButtons = new System.Windows.Forms.Panel();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonSignUpClose = new System.Windows.Forms.Button();
            this.textBoxSignUpFirstName = new System.Windows.Forms.TextBox();
            this.labelSignUpFirstName = new System.Windows.Forms.Label();
            this.labelSignUpLastName = new System.Windows.Forms.Label();
            this.textBoxSignUpLastName = new System.Windows.Forms.TextBox();
            this.labelSignUpPassword = new System.Windows.Forms.Label();
            this.textBoxSignUpPassword = new System.Windows.Forms.TextBox();
            this.labelSignUpPasswordAgain = new System.Windows.Forms.Label();
            this.textBoxSignUpPasswordAgain = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelSignUp = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelLogin.SuspendLayout();
            this.panelLoginButtons.SuspendLayout();
            this.panelSignupButtons.SuspendLayout();
            this.tableLayoutPanelSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLogin
            // 
            this.tableLayoutPanelLogin.ColumnCount = 2;
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.62952F));
            this.tableLayoutPanelLogin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.37048F));
            this.tableLayoutPanelLogin.Controls.Add(this.textBoxLoginPassword, 1, 2);
            this.tableLayoutPanelLogin.Controls.Add(this.labelLoginPassword, 0, 2);
            this.tableLayoutPanelLogin.Controls.Add(this.textBoxLoginLastName, 1, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.labelLoginLastName, 0, 1);
            this.tableLayoutPanelLogin.Controls.Add(this.labelLoginFirstName, 0, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.textBoxLoginFirstName, 1, 0);
            this.tableLayoutPanelLogin.Controls.Add(this.panelLoginButtons, 1, 3);
            this.tableLayoutPanelLogin.Controls.Add(this.linkLabelSignUp, 0, 3);
            this.tableLayoutPanelLogin.Location = new System.Drawing.Point(332, 6);
            this.tableLayoutPanelLogin.Name = "tableLayoutPanelLogin";
            this.tableLayoutPanelLogin.RowCount = 4;
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLogin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelLogin.Size = new System.Drawing.Size(294, 113);
            this.tableLayoutPanelLogin.TabIndex = 0;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLoginPassword.Location = new System.Drawing.Point(78, 59);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.Size = new System.Drawing.Size(209, 23);
            this.textBoxLoginPassword.TabIndex = 5;
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Location = new System.Drawing.Point(3, 62);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(61, 15);
            this.labelLoginPassword.TabIndex = 4;
            this.labelLoginPassword.Text = "Password";
            // 
            // textBoxLoginLastName
            // 
            this.textBoxLoginLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLoginLastName.Location = new System.Drawing.Point(78, 31);
            this.textBoxLoginLastName.Name = "textBoxLoginLastName";
            this.textBoxLoginLastName.Size = new System.Drawing.Size(209, 23);
            this.textBoxLoginLastName.TabIndex = 3;
            // 
            // labelLoginLastName
            // 
            this.labelLoginLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLoginLastName.AutoSize = true;
            this.labelLoginLastName.Location = new System.Drawing.Point(3, 34);
            this.labelLoginLastName.Name = "labelLoginLastName";
            this.labelLoginLastName.Size = new System.Drawing.Size(62, 15);
            this.labelLoginLastName.TabIndex = 2;
            this.labelLoginLastName.Text = "Last name";
            // 
            // labelLoginFirstName
            // 
            this.labelLoginFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLoginFirstName.AutoSize = true;
            this.labelLoginFirstName.Location = new System.Drawing.Point(3, 6);
            this.labelLoginFirstName.Name = "labelLoginFirstName";
            this.labelLoginFirstName.Size = new System.Drawing.Size(65, 15);
            this.labelLoginFirstName.TabIndex = 0;
            this.labelLoginFirstName.Text = "First name";
            // 
            // textBoxLoginFirstName
            // 
            this.textBoxLoginFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLoginFirstName.Location = new System.Drawing.Point(78, 3);
            this.textBoxLoginFirstName.Name = "textBoxLoginFirstName";
            this.textBoxLoginFirstName.Size = new System.Drawing.Size(209, 23);
            this.textBoxLoginFirstName.TabIndex = 1;
            // 
            // panelLoginButtons
            // 
            this.panelLoginButtons.Controls.Add(this.buttonLogin);
            this.panelLoginButtons.Controls.Add(this.buttonExit);
            this.panelLoginButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginButtons.Location = new System.Drawing.Point(78, 87);
            this.panelLoginButtons.Name = "panelLoginButtons";
            this.panelLoginButtons.Size = new System.Drawing.Size(213, 23);
            this.panelLoginButtons.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLogin.Location = new System.Drawing.Point(53, 0);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 1;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonExit.Location = new System.Drawing.Point(134, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // linkLabelSignUp
            // 
            this.linkLabelSignUp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabelSignUp.AutoSize = true;
            this.linkLabelSignUp.Location = new System.Drawing.Point(18, 93);
            this.linkLabelSignUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.linkLabelSignUp.Name = "linkLabelSignUp";
            this.linkLabelSignUp.Size = new System.Drawing.Size(54, 15);
            this.linkLabelSignUp.TabIndex = 7;
            this.linkLabelSignUp.TabStop = true;
            this.linkLabelSignUp.Text = "Sign up !";
            // 
            // panelSignupButtons
            // 
            this.panelSignupButtons.Controls.Add(this.buttonSignUp);
            this.panelSignupButtons.Controls.Add(this.buttonSignUpClose);
            this.panelSignupButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSignupButtons.Location = new System.Drawing.Point(78, 119);
            this.panelSignupButtons.Name = "panelSignupButtons";
            this.panelSignupButtons.Size = new System.Drawing.Size(213, 24);
            this.panelSignupButtons.TabIndex = 6;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSignUp.Location = new System.Drawing.Point(53, 1);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 1;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            // 
            // buttonSignUpClose
            // 
            this.buttonSignUpClose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonSignUpClose.Location = new System.Drawing.Point(134, 1);
            this.buttonSignUpClose.Name = "buttonSignUpClose";
            this.buttonSignUpClose.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUpClose.TabIndex = 0;
            this.buttonSignUpClose.Text = "Close";
            this.buttonSignUpClose.UseVisualStyleBackColor = true;
            // 
            // textBoxSignUpFirstName
            // 
            this.textBoxSignUpFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSignUpFirstName.Location = new System.Drawing.Point(78, 3);
            this.textBoxSignUpFirstName.Name = "textBoxSignUpFirstName";
            this.textBoxSignUpFirstName.Size = new System.Drawing.Size(209, 23);
            this.textBoxSignUpFirstName.TabIndex = 1;
            // 
            // labelSignUpFirstName
            // 
            this.labelSignUpFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSignUpFirstName.AutoSize = true;
            this.labelSignUpFirstName.Location = new System.Drawing.Point(3, 7);
            this.labelSignUpFirstName.Name = "labelSignUpFirstName";
            this.labelSignUpFirstName.Size = new System.Drawing.Size(65, 15);
            this.labelSignUpFirstName.TabIndex = 0;
            this.labelSignUpFirstName.Text = "First name";
            // 
            // labelSignUpLastName
            // 
            this.labelSignUpLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSignUpLastName.AutoSize = true;
            this.labelSignUpLastName.Location = new System.Drawing.Point(3, 36);
            this.labelSignUpLastName.Name = "labelSignUpLastName";
            this.labelSignUpLastName.Size = new System.Drawing.Size(62, 15);
            this.labelSignUpLastName.TabIndex = 2;
            this.labelSignUpLastName.Text = "Last name";
            // 
            // textBoxSignUpLastName
            // 
            this.textBoxSignUpLastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSignUpLastName.Location = new System.Drawing.Point(78, 32);
            this.textBoxSignUpLastName.Name = "textBoxSignUpLastName";
            this.textBoxSignUpLastName.Size = new System.Drawing.Size(209, 23);
            this.textBoxSignUpLastName.TabIndex = 3;
            // 
            // labelSignUpPassword
            // 
            this.labelSignUpPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSignUpPassword.AutoSize = true;
            this.labelSignUpPassword.Location = new System.Drawing.Point(3, 65);
            this.labelSignUpPassword.Name = "labelSignUpPassword";
            this.labelSignUpPassword.Size = new System.Drawing.Size(61, 15);
            this.labelSignUpPassword.TabIndex = 4;
            this.labelSignUpPassword.Text = "Password";
            // 
            // textBoxSignUpPassword
            // 
            this.textBoxSignUpPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSignUpPassword.Location = new System.Drawing.Point(78, 61);
            this.textBoxSignUpPassword.Name = "textBoxSignUpPassword";
            this.textBoxSignUpPassword.Size = new System.Drawing.Size(209, 23);
            this.textBoxSignUpPassword.TabIndex = 5;
            // 
            // labelSignUpPasswordAgain
            // 
            this.labelSignUpPasswordAgain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSignUpPasswordAgain.AutoSize = true;
            this.labelSignUpPasswordAgain.Location = new System.Drawing.Point(3, 94);
            this.labelSignUpPasswordAgain.Name = "labelSignUpPasswordAgain";
            this.labelSignUpPasswordAgain.Size = new System.Drawing.Size(61, 15);
            this.labelSignUpPasswordAgain.TabIndex = 7;
            this.labelSignUpPasswordAgain.Text = "Password";
            // 
            // textBoxSignUpPasswordAgain
            // 
            this.textBoxSignUpPasswordAgain.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSignUpPasswordAgain.Location = new System.Drawing.Point(78, 90);
            this.textBoxSignUpPasswordAgain.Name = "textBoxSignUpPasswordAgain";
            this.textBoxSignUpPasswordAgain.Size = new System.Drawing.Size(209, 23);
            this.textBoxSignUpPasswordAgain.TabIndex = 8;
            // 
            // tableLayoutPanelSignUp
            // 
            this.tableLayoutPanelSignUp.ColumnCount = 2;
            this.tableLayoutPanelSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.62814F));
            this.tableLayoutPanelSignUp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.37186F));
            this.tableLayoutPanelSignUp.Controls.Add(this.textBoxSignUpPasswordAgain, 1, 3);
            this.tableLayoutPanelSignUp.Controls.Add(this.labelSignUpPasswordAgain, 0, 3);
            this.tableLayoutPanelSignUp.Controls.Add(this.textBoxSignUpPassword, 1, 2);
            this.tableLayoutPanelSignUp.Controls.Add(this.labelSignUpPassword, 0, 2);
            this.tableLayoutPanelSignUp.Controls.Add(this.textBoxSignUpLastName, 1, 1);
            this.tableLayoutPanelSignUp.Controls.Add(this.labelSignUpLastName, 0, 1);
            this.tableLayoutPanelSignUp.Controls.Add(this.labelSignUpFirstName, 0, 0);
            this.tableLayoutPanelSignUp.Controls.Add(this.textBoxSignUpFirstName, 1, 0);
            this.tableLayoutPanelSignUp.Controls.Add(this.panelSignupButtons, 1, 4);
            this.tableLayoutPanelSignUp.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanelSignUp.Name = "tableLayoutPanelSignUp";
            this.tableLayoutPanelSignUp.RowCount = 5;
            this.tableLayoutPanelSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSignUp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelSignUp.Size = new System.Drawing.Size(294, 146);
            this.tableLayoutPanelSignUp.TabIndex = 8;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(637, 213);
            this.Controls.Add(this.tableLayoutPanelLogin);
            this.Controls.Add(this.tableLayoutPanelSignUp);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.tableLayoutPanelLogin.ResumeLayout(false);
            this.tableLayoutPanelLogin.PerformLayout();
            this.panelLoginButtons.ResumeLayout(false);
            this.panelSignupButtons.ResumeLayout(false);
            this.tableLayoutPanelSignUp.ResumeLayout(false);
            this.tableLayoutPanelSignUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogin;
        private System.Windows.Forms.Label labelLoginFirstName;
        private System.Windows.Forms.TextBox textBoxLoginLastName;
        private System.Windows.Forms.Label labelLoginLastName;
        private System.Windows.Forms.TextBox textBoxLoginFirstName;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Panel panelLoginButtons;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.LinkLabel linkLabelSignUp;
        private System.Windows.Forms.Panel panelSignupButtons;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonSignUpClose;
        private System.Windows.Forms.TextBox textBoxSignUpFirstName;
        private System.Windows.Forms.Label labelSignUpFirstName;
        private System.Windows.Forms.Label labelSignUpLastName;
        private System.Windows.Forms.TextBox textBoxSignUpLastName;
        private System.Windows.Forms.Label labelSignUpPassword;
        private System.Windows.Forms.TextBox textBoxSignUpPassword;
        private System.Windows.Forms.Label labelSignUpPasswordAgain;
        private System.Windows.Forms.TextBox textBoxSignUpPasswordAgain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSignUp;
    }
}