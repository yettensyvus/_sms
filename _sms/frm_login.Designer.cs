namespace _sms
{
    partial class frm_login
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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_login = new Guna.UI.WinForms.GunaButton();
            this.drag_control = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txt_password = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txt_username = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.link_register = new System.Windows.Forms.LinkLabel();
            this.link_forgot = new System.Windows.Forms.LinkLabel();
            this.btn_min = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnl_header.Controls.Add(this.btn_min);
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(450, 51);
            this.pnl_header.TabIndex = 6;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(176, 32);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Authentication";
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Animated = true;
            this.btn_login.AnimationHoverSpeed = 0.07F;
            this.btn_login.AnimationSpeed = 0.03F;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_login.BorderColor = System.Drawing.Color.Black;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.FocusedColor = System.Drawing.Color.Empty;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btn_login.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_login.Image = ((System.Drawing.Image)(resources.GetObject("btn_login.Image")));
            this.btn_login.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_login.Location = new System.Drawing.Point(68, 258);
            this.btn_login.MaximumSize = new System.Drawing.Size(301, 40);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_login.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_login.OnHoverImage = null;
            this.btn_login.OnPressedColor = System.Drawing.Color.Black;
            this.btn_login.Size = new System.Drawing.Size(301, 40);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "LOGIN";
            this.btn_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // drag_control
            // 
            this.drag_control.Fixed = true;
            this.drag_control.Horizontal = true;
            this.drag_control.TargetControl = this.pnl_header;
            this.drag_control.Vertical = true;
            // 
            // txt_password
            // 
            this.txt_password.AcceptsReturn = false;
            this.txt_password.AcceptsTab = false;
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.AnimationSpeed = 200;
            this.txt_password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txt_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_password.BackgroundImage")));
            this.txt_password.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.txt_password.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_password.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txt_password.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.txt_password.BorderRadius = 30;
            this.txt_password.BorderThickness = 2;
            this.txt_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_password.DefaultText = "";
            this.txt_password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txt_password.ForeColor = System.Drawing.Color.White;
            this.txt_password.HideSelection = true;
            this.txt_password.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_password.IconLeft")));
            this.txt_password.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_password.IconPadding = 10;
            this.txt_password.IconRight = null;
            this.txt_password.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(68, 203);
            this.txt_password.MaximumSize = new System.Drawing.Size(301, 35);
            this.txt_password.MaxLength = 32767;
            this.txt_password.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_password.Modified = false;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            stateProperties1.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_password.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_password.OnIdleState = stateProperties4;
            this.txt_password.PasswordChar = '•';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.txt_password.PlaceholderText = "Password";
            this.txt_password.ReadOnly = false;
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(301, 35);
            this.txt_password.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txt_password.TabIndex = 11;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_password.TextMarginBottom = 0;
            this.txt_password.TextMarginLeft = 5;
            this.txt_password.TextMarginTop = 0;
            this.txt_password.TextPlaceholder = "Password";
            this.txt_password.UseSystemPasswordChar = false;
            this.txt_password.WordWrap = true;
            // 
            // txt_username
            // 
            this.txt_username.AcceptsReturn = false;
            this.txt_username.AcceptsTab = false;
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.AnimationSpeed = 200;
            this.txt_username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txt_username.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_username.BackgroundImage")));
            this.txt_username.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.txt_username.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_username.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.txt_username.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.txt_username.BorderRadius = 30;
            this.txt_username.BorderThickness = 2;
            this.txt_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_username.DefaultText = "";
            this.txt_username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.txt_username.ForeColor = System.Drawing.Color.White;
            this.txt_username.HideSelection = true;
            this.txt_username.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_username.IconLeft")));
            this.txt_username.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txt_username.IconPadding = 10;
            this.txt_username.IconRight = null;
            this.txt_username.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txt_username.Lines = new string[0];
            this.txt_username.Location = new System.Drawing.Point(68, 152);
            this.txt_username.MaximumSize = new System.Drawing.Size(301, 35);
            this.txt_username.MaxLength = 32767;
            this.txt_username.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_username.Modified = false;
            this.txt_username.Multiline = false;
            this.txt_username.Name = "txt_username";
            stateProperties5.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_username.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            stateProperties8.ForeColor = System.Drawing.Color.White;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_username.OnIdleState = stateProperties8;
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Gainsboro;
            this.txt_username.PlaceholderText = "username";
            this.txt_username.ReadOnly = false;
            this.txt_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_username.SelectedText = "";
            this.txt_username.SelectionLength = 0;
            this.txt_username.SelectionStart = 0;
            this.txt_username.ShortcutsEnabled = true;
            this.txt_username.Size = new System.Drawing.Size(301, 35);
            this.txt_username.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Material;
            this.txt_username.TabIndex = 10;
            this.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_username.TextMarginBottom = 0;
            this.txt_username.TextMarginLeft = 5;
            this.txt_username.TextMarginTop = 0;
            this.txt_username.TextPlaceholder = "username";
            this.txt_username.UseSystemPasswordChar = false;
            this.txt_username.WordWrap = true;
            // 
            // link_register
            // 
            this.link_register.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.link_register.AutoSize = true;
            this.link_register.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.link_register.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_register.LinkColor = System.Drawing.Color.Gainsboro;
            this.link_register.Location = new System.Drawing.Point(385, 376);
            this.link_register.Name = "link_register";
            this.link_register.Size = new System.Drawing.Size(53, 15);
            this.link_register.TabIndex = 12;
            this.link_register.TabStop = true;
            this.link_register.Text = "Sign Up?";
            this.link_register.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            // 
            // link_forgot
            // 
            this.link_forgot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.link_forgot.AutoSize = true;
            this.link_forgot.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.link_forgot.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.link_forgot.LinkColor = System.Drawing.Color.Gainsboro;
            this.link_forgot.Location = new System.Drawing.Point(242, 214);
            this.link_forgot.Name = "link_forgot";
            this.link_forgot.Size = new System.Drawing.Size(127, 15);
            this.link_forgot.TabIndex = 13;
            this.link_forgot.TabStop = true;
            this.link_forgot.Text = "Forgot your password?";
            this.link_forgot.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.ImageActive = null;
            this.btn_min.Location = new System.Drawing.Point(382, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(25, 25);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min.TabIndex = 9;
            this.btn_min.TabStop = false;
            this.btn_min.Zoom = 10;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(413, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 8;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(450, 400);
            this.Controls.Add(this.link_forgot);
            this.Controls.Add(this.link_register);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_header;
        internal Guna.UI.WinForms.GunaButton btn_login;
        private Bunifu.Framework.UI.BunifuDragControl drag_control;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_password;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_username;
        private System.Windows.Forms.LinkLabel link_register;
        private System.Windows.Forms.LinkLabel link_forgot;
        private Bunifu.Framework.UI.BunifuImageButton btn_min;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
    }
}