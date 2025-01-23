using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InvoiceManager_DBFirst
{
    public partial class UserForm : Form
    {
        enum Mode
        {
            Display,
            Add,
            Edit,
            Search
        }

        private enum SortOrder
        {
            ASC,
            DESC,
            UNORDERED
        }

        private InvoicesEntities dbContext;

        private User _newUser;
        private UserImage _newUserImage;

        private Mode _userMode;
        private Mode _userImageMode;

        private SortOrder[] _sortOrdersDataGridViewUsers = { SortOrder.ASC, SortOrder.UNORDERED };

        public UserForm()
        {
            InitializeComponent();

            this.Icon = Icon.FromHandle(BitmapResourceLoader.User.GetHicon());

            this.dbContext = new InvoicesEntities();

            this.dataGridViewUsers.CellClick += DataGridViewUsers_CellClick;
            this.dataGridViewUsers.DataSourceChanged += DataGridViewUsers_DataSourceChanged;
            this.dataGridViewUsers.DataBindingComplete += DataGridViewUsers_DataBindingComplete;

            this.textBoxUserOptionsName.Leave += TextBoxUserOptionsName_Leave;
            this.textBoxUserOptionsSurname.Leave += TextBoxUserOptionsSurname_Leave;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            this.textBoxUserOptionsFullname.ReadOnly = true;
            this.pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            this.pictureBoxUser.Image = BitmapResourceLoader.DefaultUser;

            this._setModes(Mode.Display);

            _setDefaultGridViewStyles(this.dataGridViewUsers);
            _enableDataGridViewMultiSelect(this.dataGridViewUsers, false);

            this._setEditableUsers(false);
            this._bindDataToGridViewUser();

            //this.onUserFormOpened("Users", "Window opened", DateTime.Now);
        }

        private void DataGridViewUsers_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewUsers.DataSource == null)
                return;

            string[] headerTexts = new string[] { "userId", "imageData", "Name", "Surname", "Full name" };
            int[] columnWidths = new int[] { 50, 100, 150, 150, 175 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleCenter,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft };

            _setDefaultGridViewHeaderStyles(this.dataGridViewUsers, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewUsers.Columns["userId"].Visible = false;
        }

        private void DataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this._clearUserControls();
            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;
            this._setUserControls(row);
        }

        private void DataGridViewUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewUsers.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewUsers.Rows[0];
                if (row != null)
                    this._setUserControls(row);
            }
        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                byte[] data = (byte[])e.Value;

                using (var ms = new MemoryStream(data))
                {
                    Image img = ResizeImage(new Bitmap(ms), new Size(16, 16));
                    e.Value = GetBytesOfImage(img);
                }
            }
        }

        private void TextBoxUserOptionsName_Leave(object sender, EventArgs e)
        {
            this._setFullnameField();
        }

        private void TextBoxUserOptionsSurname_Leave(object sender, EventArgs e)
        {
            this._setFullnameField();
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            this._userMode = (this._userMode == Mode.Add) ? Mode.Display : Mode.Add;
            this.buttonNewUser.Text = (this._userMode == Mode.Add) ? "Cancel" : "New";
            this.dataGridViewUsers.Enabled = (this._userMode != Mode.Add);

            if (this._userMode == Mode.Add)
            {
                this._setEditableUsers(true);
                this._newUser = new User();
            }
            else
            {
                this._setEditableUsers(false);
            }

            this._clearUserControls();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            this._setUserDataFromUiToObject(this._newUser);
            this.dbContext.User.Add(this._newUser);

            try
            {
                this.dbContext.SaveChanges();
                //this.onUserSaved("Users", $"New id {_newUser.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding user.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearUserControls();
            this._setEditableUsers(false);
            this._bindDataToGridViewUser();
            this._newUser = new User();
            this._userMode = Mode.Display;
        }

        private void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(row.Cells["userId"].Value);
            User user = dbContext.User.Where(r => r.id == userId).FirstOrDefault();

            this._setUserDataFromUiToObject(user);

            try
            {
                this.dbContext.SaveChanges();
                //this.onUserUpdated("Items", $"Id {user.id} updated", DateTime.Now);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewUser();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to delete first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(row.Cells["userId"].Value);
            User user = dbContext.User.Where(r => r.id == userId).FirstOrDefault();

            int whoDidItCount = dbContext.Taction.Where(r => r.WhoDidIt == user.id).Count();

            if (whoDidItCount > 0)
            {
                MessageBox.Show($"Cannot delete this user.\nThere are {whoDidItCount} tactions done with this user.", "Unable to delete user.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var userImages = user.UserImage.ToList();

                foreach (var userImage in userImages)
                {
                    user.UserImage.Remove(userImage);
                    dbContext.UserImage.Remove(userImage);
                }

                dbContext.User.Remove(user);
                dbContext.SaveChanges();
                //this.onUserRemoved("Users", $"User id {user.id} removed", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting user.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._clearUserControls();
            this._bindDataToGridViewUser();
        }

        private void buttonAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Multiselect = false;
            ofd.Filter = " (*.jpg;*.png;*.jpeg) | *.jpg;*.png;*.jpeg";

            if (ofd.ShowDialog() != DialogResult.OK)
                return;

            _newUserImage = new UserImage();
            this.pictureBoxUser.Image = new Bitmap(ofd.FileName);

            this._setUserImageDataFromUiToObject(this._newUserImage);
            this.dbContext.UserImage.Add(this._newUserImage);

            try
            {
                this.dbContext.SaveChanges();
                //this.onUserImageSaved("Items", $"New id {_newUserImage.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewUser();
            this._newUserImage = new UserImage();
            this._userImageMode = Mode.Display;
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _bindDataToGridViewUser()
        {
            this._refreshData();
            //this.onUsersLoaded("Users", "User data loaded", DateTime.Now);
        }

        private void _setUserDataFromUiToObject(User user)
        {
            if (string.IsNullOrEmpty(this.textBoxUserOptionsName.Text))
            {
                MessageBox.Show("You didn't enter name.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(this.textBoxUserOptionsSurname.Text))
            {
                MessageBox.Show("You didn't enter surname.", "Missing value.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            user.Name = this.textBoxUserOptionsName.Text;
            user.Surname = this.textBoxUserOptionsSurname.Text;
            user.Fullname = this.textBoxUserOptionsFullname.Text;
        }

        private void _setUserImageDataFromUiToObject(UserImage userImage)
        {
            if (this.pictureBoxUser.Image == null)
            {
                MessageBox.Show("You didn't select a picture.", "Missing picture.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this._newUser == null)   // Edit mode: taction exists in db, we get this taction object from database.
            {
                DataGridViewRow row = this.dataGridViewUsers.CurrentRow;
                int userid = Convert.ToInt32(row.Cells["userId"].Value);
                this._newUser = dbContext.User.Where(r => r.id == userid).FirstOrDefault();
            }

            userImage.User = this._newUser;
            userImage.imageData = this._saveImage();
        }

        private void _setUserControls(DataGridViewRow row)
        {
            int userId = Convert.ToInt32(row.Cells["userId"].Value);

            this.textBoxUserOptionsName.Text = row.Cells["userName"].Value.ToString();
            this.textBoxUserOptionsSurname.Text = row.Cells["userSurname"].Value.ToString();
            this.textBoxUserOptionsFullname.Text = row.Cells["userFullname"].Value.ToString();

            UserImage userImage = dbContext.UserImage.Where(r => r.userId == userId).FirstOrDefault();

            if (userImage != null)
            {
                this.pictureBoxUser.Image = GetImageFromBytes(userImage.imageData);
                this.pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void _setFullnameField()
        {
            if (!string.IsNullOrEmpty(this.textBoxUserOptionsName.Text) && !string.IsNullOrEmpty(this.textBoxUserOptionsSurname.Text))
                this.textBoxUserOptionsFullname.Text = $"{this.textBoxUserOptionsName.Text} {this.textBoxUserOptionsSurname.Text}";
        }

        private void _setEditableUsers(bool isEditable)
        {
            this.buttonSaveUser.Enabled = isEditable;
            this.buttonUpdateUser.Enabled = !isEditable;
            this.buttonDeleteUser.Enabled = !isEditable;
        }

        private static void _setDefaultGridViewStyles(DataGridView gridview)
        {
            gridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridview.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders);

            gridview.DefaultCellStyle.Font = new Font("Calibri", 10);
            gridview.DefaultCellStyle.ForeColor = Color.FromArgb(7, 7, 7); //  152, g: 255, b: 152
            gridview.DefaultCellStyle.BackColor = Color.White;

            gridview.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(7, 7, 7);
            gridview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);

            gridview.DefaultCellStyle.SelectionForeColor = Color.FromArgb(7, 7, 7);
            gridview.DefaultCellStyle.SelectionBackColor = Color.FromArgb(163, 255, 179);

            gridview.ColumnHeadersDefaultCellStyle.Font = new Font("Calibri", 9.5f, FontStyle.Bold);
            gridview.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private static void _setDefaultGridViewHeaderStyles(DataGridView gridview, string[] headerTexts, int[] columnWidths, DataGridViewContentAlignment[] columnAlignments)
        {
            for (int i = 0; i < gridview.Columns.Count; ++i)
            {
                gridview.Columns[i].HeaderCell.Value = headerTexts[i];
                gridview.Columns[i].Width = columnWidths[i];
                gridview.Columns[i].DefaultCellStyle.Alignment = columnAlignments[i];
            }
        }

        public static void _enableDataGridViewMultiSelect(DataGridView gridview, bool enable)
        {
            gridview.MultiSelect = enable;
        }

        private void _clearUserControls()
        {
            this.pictureBoxUser.Image = null;

            foreach (Control c in this.groupBoxUserOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        private void _setModes(Mode mode)
        {
            this._userMode = mode;
            this._userImageMode = mode;
        }

        // New approach. Apply this method to other forms.
        private void _refreshData()
        {
            BindingSource bs = new BindingSource();

            var query = from user in dbContext.User
                        join userImage in dbContext.UserImage on user.id equals userImage.userId into joinTable
                        from jt in joinTable.DefaultIfEmpty()
                        orderby user.Name ascending
                        select new
                        {
                            userId = user.id,
                            userImageData = jt.imageData,
                            userName = user.Name,
                            userSurname = user.Surname,
                            userFullname = user.Fullname
                        };

            bs.DataSource = query.ToList();

            this.dataGridViewUsers.DataSource = bs;
            this.dataGridViewUsers.Refresh();
        }

        private byte[] _saveImage()
        {
            MemoryStream ms = new MemoryStream();
            this.pictureBoxUser.Image.Save(ms, this.pictureBoxUser.Image.RawFormat);

            return ms.GetBuffer();
        }

        private static Image ResizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            double nPercent = 0;
            double nPercentW = 0;
            double nPercentH = 0;

            // Calculate width and height with new desired size
            nPercentW = ((double)size.Width / (double)sourceWidth);
            nPercentH = ((double)size.Height / (double)sourceHeight);
            nPercent = Math.Min(nPercentW, nPercentH);

            // New Width and Height
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);

            Graphics g = Graphics.FromImage((Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            // Draw image with new width and height
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();

            return (Image)b;
        }

        public static byte[] GetBytesOfImage(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public static Image GetImageFromBytes(byte[] imageData)
        {
            MemoryStream ms = new MemoryStream(imageData);
            return new Bitmap(ms);
        }
    }
}
