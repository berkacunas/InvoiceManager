using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst
{
    public partial class LoginForm : Form
    {
        private InvoicesEntities dbContext;
        private UserLogin _userLogin;
        private UserLoginDetails _loginDetails;

        private const int MAX_PASSWORD_ERROR = 3;

        public UserLogin UserLogin
        {
            get { return _userLogin; }
        }

        public UserLoginDetails LoginDetails
        {
            get { return _loginDetails; }
        }

        public LoginForm()
        {
            InitializeComponent();

            this.dbContext = new InvoicesEntities();
            
            this._userLogin = null;
            this._loginDetails = new UserLoginDetails();

            this.Load += loginForm_Load;

            this.buttonLogin.Click += buttonLogin_Click;
            this.buttonSignUp.Click += buttonSignUp_Click;
            this.buttonSignUpClose.Click += buttonSignUpClose_Click;
            this.buttonExit.Click += buttonExit_Click;

            this.linkLabelSignUp.Click += linkLabelSignUp_Click;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            this.switchPanels(true);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (_loginDetails.PasswordErrorCount == MAX_PASSWORD_ERROR)
            {
                MessageBox.Show("You have reached max password entry limit. Your account is locked.", "Spam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string firstName = this.textBoxLoginFirstName.Text;
            string lastName = this.textBoxLoginLastName.Text;
            string password = this.textBoxLoginPassword.Text;

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Enter first name.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Enter last name.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter password.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _userLogin = this.dbContext.UserLogin.Where(r => r.FirstName == firstName && r.LastName == lastName && r.Password == password).FirstOrDefault();

            if (_userLogin != null)
            {
                _loginDetails.UserLogin = _userLogin;
                _loginDetails.LoginType = LoginType.Login.ToString();
                _loginDetails.LoginDate = DateTime.Now;     // User's login datetime.
                _loginDetails.IsSuccess = true;

                this.dbContext.UserLoginDetails.Add(this._loginDetails);

                try
                {
                    this.dbContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Cannot save user login details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                ++_loginDetails.PasswordErrorCount;
                MessageBox.Show("Invalid login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string firstName = this.textBoxSignUpFirstName.Text;
            string lastName = this.textBoxSignUpLastName.Text;
            string password = this.textBoxSignUpPassword.Text;
            string passwordAgain = this.textBoxSignUpPasswordAgain.Text;

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Enter first name.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Enter last name.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Enter password.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(passwordAgain))
            {
                MessageBox.Show("Enter password again.", "Missing value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != passwordAgain)
            {
                MessageBox.Show("Passwords doesn't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserLogin userLogin = new UserLogin();
            userLogin.FirstName = firstName;
            userLogin.LastName = lastName;
            userLogin.Password = password;
            userLogin.LoginDate = DateTime.Now;     // User's sign-up datetime.

            this.dbContext.UserLogin.Add(userLogin);

            try
            {
                this.dbContext.SaveChanges();
                MessageBox.Show("You signed up successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cannot save signup info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.clearLoginPanel();
            this.clearSignUpPanel();
            this.switchPanels(true);
        }

        private void buttonSignUpClose_Click(object sender, EventArgs e)
        {
            this.clearLoginPanel();
            this.clearSignUpPanel();
            this.switchPanels(true);
        }

        private void linkLabelSignUp_Click(object sender, EventArgs e)
        {
            this.switchPanels(false);
        }

        private void switchPanels(bool switchit)
        {
            this.tableLayoutPanelLogin.Visible = switchit;
            this.tableLayoutPanelSignUp.Visible = !switchit;
            
            this.tableLayoutPanelLogin.Location = new Point(6, 6);
            this.tableLayoutPanelSignUp.Location = new Point(6, 6);

            this.ClientSize = (switchit) ? new Size(this.tableLayoutPanelLogin.Size.Width + 12, this.tableLayoutPanelLogin.Size.Height + 12) 
                : new Size(this.tableLayoutPanelSignUp.Size.Width + 12, this.tableLayoutPanelSignUp.Size.Height + 12);
        }

        private void clearLoginPanel()
        {
            foreach (Control c in this.tableLayoutPanelLogin.Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
            }
        }

        private void clearSignUpPanel()
        {
            foreach (Control c in this.tableLayoutPanelSignUp.Controls)
            {
                if (c is TextBox)
                    c.Text = string.Empty;
            }
        }

    }
}
