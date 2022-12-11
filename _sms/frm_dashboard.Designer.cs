namespace _sms
{
    partial class frm_dashboard
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dashboard));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_toggle = new System.Windows.Forms.Panel();
            this.user_data_panel = new System.Windows.Forms.Panel();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pnl_drawer = new System.Windows.Forms.Panel();
            this.toggle_button = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_child = new System.Windows.Forms.Panel();
            this.btnManagement = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMax = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnNormal = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_header.SuspendLayout();
            this.pnl_toggle.SuspendLayout();
            this.user_data_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.pnl_drawer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggle_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnl_header.Controls.Add(this.btnMin);
            this.pnl_header.Controls.Add(this.btnClose);
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Controls.Add(this.btnMax);
            this.pnl_header.Controls.Add(this.btnNormal);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(200, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(619, 51);
            this.pnl_header.TabIndex = 13;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(132, 32);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Dashboard";
            // 
            // pnl_toggle
            // 
            this.pnl_toggle.Controls.Add(this.toggle_button);
            this.pnl_toggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toggle.Location = new System.Drawing.Point(0, 0);
            this.pnl_toggle.Name = "pnl_toggle";
            this.pnl_toggle.Size = new System.Drawing.Size(200, 52);
            this.pnl_toggle.TabIndex = 7;
            // 
            // user_data_panel
            // 
            this.user_data_panel.Controls.Add(this.pic_user);
            this.user_data_panel.Controls.Add(this.lbl_username);
            this.user_data_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_data_panel.Location = new System.Drawing.Point(0, 52);
            this.user_data_panel.Name = "user_data_panel";
            this.user_data_panel.Size = new System.Drawing.Size(200, 180);
            this.user_data_panel.TabIndex = 11;
            // 
            // pic_user
            // 
            this.pic_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic_user.Location = new System.Drawing.Point(0, 0);
            this.pic_user.Name = "pic_user";
            this.pic_user.Size = new System.Drawing.Size(200, 140);
            this.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_user.TabIndex = 109;
            this.pic_user.TabStop = false;
            this.pic_user.WaitOnLoad = true;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoEllipsis = true;
            this.lbl_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_username.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_username.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_username.Location = new System.Drawing.Point(0, 140);
            this.lbl_username.MinimumSize = new System.Drawing.Size(215, 30);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(215, 40);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "USENAME";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_drawer
            // 
            this.pnl_drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnl_drawer.Controls.Add(this.btnManagement);
            this.pnl_drawer.Controls.Add(this.user_data_panel);
            this.pnl_drawer.Controls.Add(this.pnl_toggle);
            this.pnl_drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_drawer.Location = new System.Drawing.Point(0, 0);
            this.pnl_drawer.Name = "pnl_drawer";
            this.pnl_drawer.Size = new System.Drawing.Size(200, 513);
            this.pnl_drawer.TabIndex = 14;
            // 
            // toggle_button
            // 
            this.toggle_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggle_button.Image = ((System.Drawing.Image)(resources.GetObject("toggle_button.Image")));
            this.toggle_button.ImageActive = null;
            this.toggle_button.Location = new System.Drawing.Point(12, 14);
            this.toggle_button.Name = "toggle_button";
            this.toggle_button.Size = new System.Drawing.Size(27, 27);
            this.toggle_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.toggle_button.TabIndex = 3;
            this.toggle_button.TabStop = false;
            this.toggle_button.Zoom = 10;
            // 
            // pnl_child
            // 
            this.pnl_child.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.pnl_child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_child.Location = new System.Drawing.Point(200, 51);
            this.pnl_child.Name = "pnl_child";
            this.pnl_child.Size = new System.Drawing.Size(619, 462);
            this.pnl_child.TabIndex = 15;
            // 
            // btnManagement
            // 
            this.btnManagement.Animated = true;
            this.btnManagement.AnimationHoverSpeed = 0.07F;
            this.btnManagement.AnimationSpeed = 0.03F;
            this.btnManagement.BackColor = System.Drawing.Color.Transparent;
            this.btnManagement.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btnManagement.BorderColor = System.Drawing.Color.Empty;
            this.btnManagement.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnManagement.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnManagement.CheckedBorderColor = System.Drawing.Color.Empty;
            this.btnManagement.CheckedForeColor = System.Drawing.Color.Gainsboro;
            this.btnManagement.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnManagement.CheckedImage")));
            this.btnManagement.CheckedLineColor = System.Drawing.Color.Black;
            this.btnManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagement.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManagement.FocusedColor = System.Drawing.Color.Empty;
            this.btnManagement.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManagement.Image = ((System.Drawing.Image)(resources.GetObject("btnManagement.Image")));
            this.btnManagement.ImageSize = new System.Drawing.Size(32, 32);
            this.btnManagement.LineColor = System.Drawing.Color.Black;
            this.btnManagement.LineLeft = 3;
            this.btnManagement.Location = new System.Drawing.Point(0, 232);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btnManagement.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btnManagement.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btnManagement.OnHoverImage = null;
            this.btnManagement.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btnManagement.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnManagement.OnPressedDepth = 2;
            this.btnManagement.Size = new System.Drawing.Size(200, 49);
            this.btnManagement.TabIndex = 13;
            this.btnManagement.Text = "Management";
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(520, 14);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 25);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 7;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(582, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMax.Image")));
            this.btnMax.ImageActive = null;
            this.btnMax.Location = new System.Drawing.Point(551, 14);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(25, 25);
            this.btnMax.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMax.TabIndex = 6;
            this.btnMax.TabStop = false;
            this.btnMax.Zoom = 10;
            // 
            // btnNormal
            // 
            this.btnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNormal.Image = ((System.Drawing.Image)(resources.GetObject("btnNormal.Image")));
            this.btnNormal.ImageActive = null;
            this.btnNormal.Location = new System.Drawing.Point(551, 14);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(25, 25);
            this.btnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnNormal.TabIndex = 8;
            this.btnNormal.TabStop = false;
            this.btnNormal.Zoom = 10;
            // 
            // frm_dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(819, 513);
            this.Controls.Add(this.pnl_child);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.pnl_drawer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_dashboard";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.pnl_toggle.ResumeLayout(false);
            this.user_data_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.pnl_drawer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.toggle_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNormal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_toggle;
        private System.Windows.Forms.Panel user_data_panel;
        internal System.Windows.Forms.PictureBox pic_user;
        internal System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel pnl_drawer;
        private Bunifu.Framework.UI.BunifuImageButton toggle_button;
        private System.Windows.Forms.Panel pnl_child;
        internal Guna.UI.WinForms.GunaAdvenceButton btnManagement;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuImageButton btnNormal;
        private Bunifu.Framework.UI.BunifuImageButton btnMax;
    }
}

