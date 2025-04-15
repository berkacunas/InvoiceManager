using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using InvoiceManager_DBFirst.Globals;

namespace InvoiceManager_DBFirst.UserControls
{
    public partial class UserUserControl : UserControl
    {
        public event Notify UsersLoaded;
        public event UserHandler UserSaved;
        public event UserUpdateHandler UserUpdated;
        public event UserHandler UserRemoved;

        public event Notify UserChanged;
        public event Notify UserFormOpened;
        public event Notify UserFormClosed;

        private InvoicesEntities dbContext;

        private bool _isInitialized;
        private IDictionary<int, int> _currentImageIndexDict;

        private User _newUser;
        private UserImage _newUserImage;

        private Mode _userMode;
        private Mode _userImageMode;

        private List<ColumnSortOrder[]> _columnSortOrdersUsers = new List<ColumnSortOrder[]>
        {
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC },
            new ColumnSortOrder[] { ColumnSortOrder.ASC, ColumnSortOrder.DESC }
        };

        public UserUserControl()
        {
            InitializeComponent();

            this.Load += userUserControl_Load;

            this._isInitialized = false;
            this._currentImageIndexDict = new Dictionary<int, int>();

            this.dbContext = new InvoicesEntities();

            this.dataGridViewUsers.DataBindingComplete += dataGridViewUsers_DataBindingComplete;
            this.dataGridViewUsers.DataSourceChanged += dataGridViewUsers_DataSourceChanged;
            this.dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            this.dataGridViewUsers.ColumnHeaderMouseClick += dataGridViewUsers_ColumnHeaderMouseClick;
            this.dataGridViewUsers.CellFormatting += dataGridViewUsers_CellFormatting;

            this.buttonNewUser.Click += buttonNewUser_Click;
            this.buttonSaveUser.Click += buttonSaveUser_Click;
            this.buttonUpdateUser.Click += buttonUpdateUser_Click;
            this.buttonDeleteUser.Click += buttonDeleteUser_Click;

            this.buttonAddImage.Click += buttonAddImage_Click;
            this.buttonDeleteImage.Click += buttonDeleteImage_Click;
            this.buttonPreviousImage.Click += buttonPreviousImage_Click;
            this.buttonNextImage.Click += buttonNextImage_Click;

            this.textBoxUserOptionsName.Leave += textBoxUserOptionsName_Leave;
            this.textBoxUserOptionsSurname.Leave += textBoxUserOptionsSurname_Leave;
        }

        #region Event Handlers

        private void userUserControl_Load(object sender, EventArgs e)
        {
            this.textBoxUserOptionsFullname.ReadOnly = true;

            this._setModes(Mode.Display);

            WinFormsHelper.SetDefaultGridViewStyles(this.dataGridViewUsers);
            WinFormsHelper.EnableDataGridViewMultiSelect(this.dataGridViewUsers, false);

            this._setEditableUsers(false);
            this._bindDataToGridViewUser();

            this.onUserFormOpened("Users", "Window opened", DateTime.Now);
        }

        private void dataGridViewUsers_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.Reset && this.dataGridViewUsers.Rows.Count > 0)
            {
                DataGridViewRow row = this.dataGridViewUsers.Rows[0];
                if (row != null)
                {
                    this._setUserControls(row);
                    if (!this._isInitialized)
                        this._setPictureBoxImage(row);
                }
            }

            //this._isInitialized = true;
        }

        private void dataGridViewUsers_DataSourceChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewUsers.DataSource == null)
                return;

            string[] headerTexts = new string[] { "userId", "thumbnail", "Name", "Surname", "Full name" };
            int[] columnWidths = new int[] { 50, 100, 150, 150, 175 };
            DataGridViewContentAlignment[] columnAlignments = { DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleCenter,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft,
                                                                DataGridViewContentAlignment.MiddleLeft };

            WinFormsHelper.SetDefaultGridViewHeaderStyles(this.dataGridViewUsers, headerTexts, columnWidths, columnAlignments);

            this.dataGridViewUsers.Columns["userId"].Visible = false;
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;

            this._clearUserControls();
            this._setUserControls(row);
            this._setPictureBoxImage(row);
        }

        private void dataGridViewUsers_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = this.dataGridViewUsers.Columns[e.ColumnIndex].HeaderText;

            var query = from user in dbContext.User
                        orderby user.Name ascending
                        select new
                        {
                            userId = user.id,
                            thumbnail = user.Thumbnail,
                            userName = user.Name,
                            userSurname = user.Surname,
                            userFullname = user.Fullname
                        };

            switch (columnName)
            {
                case "Name":
                    this.dataGridViewUsers.DataSource = (this._columnSortOrdersUsers[0][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.userName).ToList() : query.OrderByDescending(r => r.userName).ToList();
                    this._columnSortOrdersUsers[0][0] = (this._columnSortOrdersUsers[0][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;

                case "Surname":
                    this.dataGridViewUsers.DataSource = (this._columnSortOrdersUsers[1][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.userSurname).ToList() : query.OrderByDescending(r => r.userSurname).ToList();
                    this._columnSortOrdersUsers[1][0] = (this._columnSortOrdersUsers[1][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
                case "Full name":
                    this.dataGridViewUsers.DataSource = (this._columnSortOrdersUsers[2][0] == ColumnSortOrder.ASC) ? query.OrderBy(r => r.userFullname).ToList() : query.OrderByDescending(r => r.userFullname).ToList();
                    this._columnSortOrdersUsers[2][0] = (this._columnSortOrdersUsers[2][0] == ColumnSortOrder.ASC) ? ColumnSortOrder.DESC : ColumnSortOrder.ASC;
                    break;
            }
        }

        private void dataGridViewUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.Value != null)
            {
                byte[] data = (byte[])e.Value;

                using (var ms = new MemoryStream(data))
                {
                    Image img = ImageHelper.ResizeImage(new Bitmap(ms), new Size(16, 16));
                    e.Value = ImageHelper.GetBytesOfImage(img);
                }
            }
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
                this._setEditableUsers(false);

            this._clearUserControls();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            this._setUserDataFromUiToObject(this._newUser);
            this.dbContext.User.Add(this._newUser);

            try
            {
                this.dbContext.SaveChanges();
                this.onUserSaved(this._newUser);
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
            User oldUser = dbContext.User.Where(r => r.id == userId).AsNoTracking().FirstOrDefault();

            this._setUserDataFromUiToObject(user);

            try
            {
                this.dbContext.SaveChanges();
                this.onUserUpdated(user, oldUser);

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

                this.onUserRemoved(user);
                dbContext.User.Remove(user);
                dbContext.SaveChanges();
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

            bool isCheckedDefault = this.checkBoxDefaultUserImage.Checked;
            this._checkCheckBoxDefault(false);
            if (ofd.ShowDialog() != DialogResult.OK)
            {
                this._checkCheckBoxDefault(isCheckedDefault);
                return;
            }

            _newUserImage = new UserImage();

            Image image = new Bitmap(ofd.FileName);
            this.pictureBoxUser.Image = image;


            this._setUserImageDataFromUiToObject(this._newUserImage);

            this.dbContext.UserImage.Add(this._newUserImage);

            if (this._newUserImage.isDefault)
                this._saveAsThumbnail(_newUser, image);

            try
            {
                this.dbContext.SaveChanges();
                //this.onUserImageSaved("Items", $"New id {_newUserImage.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.pictureBoxUser.Tag = this._newUserImage.id;

            int rowIndex = -1;
            if (this.dataGridViewUsers.CurrentRow != null)
            {
                rowIndex = this.dataGridViewUsers.CurrentRow.Index;
                int userId = Convert.ToInt32(this.dataGridViewUsers.Rows[rowIndex].Cells["userId"].Value);

                if (!this._currentImageIndexDict.ContainsKey(userId))
                    this._currentImageIndexDict.Add(userId, 0);
                else
                    this._currentImageIndexDict[userId] += 1;

                this._setPictureBoxImage(this.dataGridViewUsers.Rows[rowIndex]);

            }

            this._bindDataToGridViewUser();

            this._newUser = null;
            this._newUserImage = null;
            this._userImageMode = Mode.Display;
        }

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            if (this.pictureBoxUser.Tag == null)
                return;

            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;
            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userImageId = Convert.ToInt32(this.pictureBoxUser.Tag);

            int userId = Convert.ToInt32(row.Cells["userId"].Value);
            User user = dbContext.User.Where(r => r.id == userId).SingleOrDefault();

            UserImage userImage = user.UserImage.Where(r => r.id == userImageId).SingleOrDefault();

            if (userImage.isDefault)
                this._removeThumbnail(user);

            user.UserImage.Remove(userImage);
            this.dbContext.UserImage.Remove(userImage);

            if (this._currentImageIndexDict[userId] > 0)
            {
                this._currentImageIndexDict[userId] -= 1;

                int rowIndex = this.dataGridViewUsers.CurrentRow.Index;
                //this.dataGridViewUsers.CurrentCell = this.dataGridViewUsers.Rows[rowIndex].Cells[1]; // Cell[0] is a hidden column.
                this._setPictureBoxImage(this.dataGridViewUsers.Rows[rowIndex]);

            }
            else
                this._currentImageIndexDict.Remove(userId);

            try
            {
                this.dbContext.SaveChanges();
                // this.onUserThumbnailRemoved("Users", $"New id {_newUser.id} saved", DateTime.Now);
                // this.onUserImageRemoved("Users", $"New id {_newUserImage.id} saved", DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding item.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this._bindDataToGridViewUser();
            this._userImageMode = Mode.Display;
        }

        private void buttonPreviousImage_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(row.Cells["userId"].Value);

            if (this._currentImageIndexDict.ContainsKey(userId))
            {
                if (this._currentImageIndexDict[userId] > 0)
                    --this._currentImageIndexDict[userId];

                this._setPictureBoxImage(row);
            }
        }

        private void buttonNextImage_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridViewUsers.CurrentRow;

            if (row == null)
            {
                MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = Convert.ToInt32(row.Cells["userId"].Value);

            if (this._currentImageIndexDict.ContainsKey(userId))
            {
                if (this._currentImageIndexDict[userId] < dbContext.UserImage.Where(r => r.userId == userId).Count() - 1)
                {
                    ++this._currentImageIndexDict[userId];
                    this._setPictureBoxImage(row);
                }
            }
        }

        private void textBoxUserOptionsName_Leave(object sender, EventArgs e)
        {
            this._setFullnameField();
        }

        private void textBoxUserOptionsSurname_Leave(object sender, EventArgs e)
        {
            this._setFullnameField();
        }

        #endregion

        #region Databind Queries

        private void _bindDataToGridViewUser()
        {
            this._refreshData();
            this.onUsersLoaded("Users", "User data loaded", DateTime.Now);
        }

        private void _refreshData()
        {
            BindingSource bs = new BindingSource();

            var query = from user in dbContext.User
                        orderby user.Name ascending
                        select new
                        {
                            userId = user.id,
                            thumbnail = user.Thumbnail,
                            userName = user.Name,
                            userSurname = user.Surname,
                            userFullname = user.Fullname
                        };

            bs.DataSource = query.ToList();

            this.dataGridViewUsers.DataSource = bs;
            this.dataGridViewUsers.Refresh();
        }

        #endregion

        #region Set data to Controls

        private void _setUserControls(DataGridViewRow row)
        {
            int userId = Convert.ToInt32(row.Cells["userId"].Value);

            this.textBoxUserOptionsName.Text = row.Cells["userName"].Value.ToString();
            this.textBoxUserOptionsSurname.Text = row.Cells["userSurname"].Value.ToString();
            this.textBoxUserOptionsFullname.Text = row.Cells["userFullname"].Value.ToString();
        }

        private void _setPictureBoxImage(DataGridViewRow row)
        {
            int userId = Convert.ToInt32(row.Cells["userId"].Value);

            List<UserImage> userImages = dbContext.UserImage.Where(r => r.userId == userId).ToList();

            if (userImages.Count > 0)
            {
                if (!this._currentImageIndexDict.ContainsKey(userId))
                    this._currentImageIndexDict.Add(userId, 0);

                UserImage userImage = userImages[this._currentImageIndexDict[userId]];
                this.pictureBoxUser.Image = (userImage != null) ? ImageHelper.GetImageFromBytes(userImage.imageData) : BitmapResourceLoader.DefaultUser;
                this.pictureBoxUser.Tag = userImage.id;
                this._checkCheckBoxDefault(userImage.isDefault);
            }
            else
            {
                this.pictureBoxUser.Image = BitmapResourceLoader.DefaultUser;
                this.pictureBoxUser.Tag = null;
                this._checkCheckBoxDefault(false);
            }

            this.pictureBoxUser.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void _setFullnameField()
        {
            if (!string.IsNullOrEmpty(this.textBoxUserOptionsName.Text) && !string.IsNullOrEmpty(this.textBoxUserOptionsSurname.Text))
                this.textBoxUserOptionsFullname.Text = $"{this.textBoxUserOptionsName.Text} {this.textBoxUserOptionsSurname.Text}";
        }

        #endregion

        #region Get data from Controls

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

            if (this._newUser == null)   // Edit mode: user exists in db, we get this user object from database.
            {
                DataGridViewRow row = this.dataGridViewUsers.CurrentRow;
                if (row == null)
                {
                    MessageBox.Show("Select the row you want to update first.", "Row not selected.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int userid = Convert.ToInt32(row.Cells["userId"].Value);
                this._newUser = dbContext.User.Where(r => r.id == userid).FirstOrDefault();
            }

            userImage.User = this._newUser;
            userImage.imageData = this._saveImage();
            userImage.isDefault = (dbContext.UserImage.Where(r => r.userId == this._newUser.id).Any()) ? this.checkBoxDefaultUserImage.Checked : true;
        }

        #endregion

        #region Set Enabled & Checked & Read-only Controls

        private void _setEditableUsers(bool isEditable)
        {
            this.buttonSaveUser.Enabled = isEditable;
            this.buttonUpdateUser.Enabled = !isEditable;
            this.buttonDeleteUser.Enabled = !isEditable;
        }

        private void _checkCheckBoxDefault(bool check)
        {
            this.checkBoxDefaultUserImage.Checked = check;
        }

        private void _setModes(Mode mode)
        {
            this._userMode = mode;
            this._userImageMode = mode;
        }

        #endregion

        #region Clear Controls
        private void _clearUserControls()
        {
            this.pictureBoxUser.Image = null;
            this.pictureBoxUser.Tag = null;

            foreach (Control c in this.groupBoxUserOptions.Controls)
                if (c is TextBox)
                    ((TextBox)c).Clear();
        }

        #endregion

        #region Operations

        private byte[] _saveImage()
        {
            MemoryStream ms = new MemoryStream();
            this.pictureBoxUser.Image.Save(ms, this.pictureBoxUser.Image.RawFormat);

            return ms.GetBuffer();
        }

        private void _saveAsThumbnail(User user, Image image)
        {
            Image tempImage = ImageHelper.ResizeImage(image, new Size(24, 24));
            user.Thumbnail = ImageHelper.GetBytesOfImage(tempImage);

            try
            {
                this.dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving thumbnail.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _removeThumbnail(User user)
        {
            user.Thumbnail = null;
        }

        #endregion

        #region User-defined Event Handlers

        protected virtual void onUsersLoaded(string actionType, string message, DateTime eventTime) //protected virtual method
        {
            this.UsersLoaded?.Invoke(actionType, message, eventTime);
            this.onUserChanged(actionType, message, eventTime);
        }

        protected virtual void onUserSaved(User user) //protected virtual method
        {
            this.UserSaved?.Invoke(user);
            this.onUserChanged("Users", $"New user {user.id}: {user.Fullname} saved", DateTime.Now);
        }

        protected virtual void onUserUpdated(User newUser, User oldUser) //protected virtual method
        {
            this.UserUpdated?.Invoke(newUser, oldUser);
            this.onUserChanged("Users", $"User {newUser.id}: {newUser.Fullname} updated", DateTime.Now);
        }

        protected virtual void onUserRemoved(User user) //protected virtual method
        {
            this.UserRemoved?.Invoke(user);
            this.onUserChanged("Users", $"User {user.id}: {user.Fullname} removed", DateTime.Now);
        }

        protected virtual void onUserChanged(string actionType, string message, DateTime eventTime)
        {
            this.UserChanged?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onUserFormOpened(string actionType, string message, DateTime eventTime)
        {
            this.UserFormOpened?.Invoke(actionType, message, eventTime);
        }

        protected virtual void onUserFormClosed(string actionType, string message, DateTime eventTime)
        {
            this.UserFormClosed?.Invoke(actionType, message, eventTime);
        }

        #endregion
    }
}
