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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_dashboard));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_min = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_max = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_normal = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_toggle = new System.Windows.Forms.Panel();
            this.btn_toggle = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_user_data = new System.Windows.Forms.Panel();
            this.pic_user = new System.Windows.Forms.PictureBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pnl_drawer = new System.Windows.Forms.Panel();
            this.btn_management = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_child = new System.Windows.Forms.Panel();
            this.drag_control = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btn_exit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normal)).BeginInit();
            this.pnl_toggle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_toggle)).BeginInit();
            this.pnl_user_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).BeginInit();
            this.pnl_drawer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.pnl_header.Controls.Add(this.btn_min);
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.lbl_title);
            this.pnl_header.Controls.Add(this.btn_max);
            this.pnl_header.Controls.Add(this.btn_normal);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(200, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(619, 51);
            this.pnl_header.TabIndex = 13;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.ImageActive = null;
            this.btn_min.Location = new System.Drawing.Point(520, 14);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(25, 25);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min.TabIndex = 7;
            this.btn_min.TabStop = false;
            this.btn_min.Zoom = 10;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.Location = new System.Drawing.Point(582, 14);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 5;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.ImageActive = null;
            this.btn_max.Location = new System.Drawing.Point(551, 14);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(25, 25);
            this.btn_max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_max.TabIndex = 6;
            this.btn_max.TabStop = false;
            this.btn_max.Zoom = 10;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_normal
            // 
            this.btn_normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_normal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_normal.Image = ((System.Drawing.Image)(resources.GetObject("btn_normal.Image")));
            this.btn_normal.ImageActive = null;
            this.btn_normal.Location = new System.Drawing.Point(551, 14);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(25, 25);
            this.btn_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_normal.TabIndex = 8;
            this.btn_normal.TabStop = false;
            this.btn_normal.Zoom = 10;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // pnl_toggle
            // 
            this.pnl_toggle.Controls.Add(this.btn_toggle);
            this.pnl_toggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toggle.Location = new System.Drawing.Point(0, 0);
            this.pnl_toggle.Name = "pnl_toggle";
            this.pnl_toggle.Size = new System.Drawing.Size(200, 52);
            this.pnl_toggle.TabIndex = 7;
            // 
            // btn_toggle
            // 
            this.btn_toggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_toggle.Image = ((System.Drawing.Image)(resources.GetObject("btn_toggle.Image")));
            this.btn_toggle.ImageActive = null;
            this.btn_toggle.Location = new System.Drawing.Point(12, 14);
            this.btn_toggle.Name = "btn_toggle";
            this.btn_toggle.Size = new System.Drawing.Size(27, 27);
            this.btn_toggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_toggle.TabIndex = 3;
            this.btn_toggle.TabStop = false;
            this.btn_toggle.Zoom = 10;
            this.btn_toggle.Click += new System.EventHandler(this.btn_toggle_Click);
            // 
            // pnl_user_data
            // 
            this.pnl_user_data.Controls.Add(this.pic_user);
            this.pnl_user_data.Controls.Add(this.lbl_username);
            this.pnl_user_data.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_user_data.Location = new System.Drawing.Point(0, 52);
            this.pnl_user_data.Name = "pnl_user_data";
            this.pnl_user_data.Size = new System.Drawing.Size(200, 180);
            this.pnl_user_data.TabIndex = 11;
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
            this.lbl_username.Text = "USERNAME";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_drawer
            // 
            this.pnl_drawer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnl_drawer.Controls.Add(this.btn_exit);
            this.pnl_drawer.Controls.Add(this.btn_management);
            this.pnl_drawer.Controls.Add(this.pnl_user_data);
            this.pnl_drawer.Controls.Add(this.pnl_toggle);
            this.pnl_drawer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_drawer.Location = new System.Drawing.Point(0, 0);
            this.pnl_drawer.Name = "pnl_drawer";
            this.pnl_drawer.Size = new System.Drawing.Size(200, 513);
            this.pnl_drawer.TabIndex = 14;
            // 
            // btn_management
            // 
            this.btn_management.Animated = true;
            this.btn_management.AnimationHoverSpeed = 0.07F;
            this.btn_management.AnimationSpeed = 0.03F;
            this.btn_management.BackColor = System.Drawing.Color.Transparent;
            this.btn_management.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_management.BorderColor = System.Drawing.Color.Empty;
            this.btn_management.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btn_management.CheckedBorderColor = System.Drawing.Color.Empty;
            this.btn_management.CheckedForeColor = System.Drawing.Color.Gainsboro;
            this.btn_management.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_management.CheckedImage")));
            this.btn_management.CheckedLineColor = System.Drawing.Color.Black;
            this.btn_management.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_management.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_management.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_management.FocusedColor = System.Drawing.Color.Empty;
            this.btn_management.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_management.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_management.Image = ((System.Drawing.Image)(resources.GetObject("btn_management.Image")));
            this.btn_management.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_management.LineColor = System.Drawing.Color.Black;
            this.btn_management.LineLeft = 3;
            this.btn_management.Location = new System.Drawing.Point(0, 232);
            this.btn_management.Margin = new System.Windows.Forms.Padding(0);
            this.btn_management.Name = "btn_management";
            this.btn_management.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_management.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btn_management.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btn_management.OnHoverImage = null;
            this.btn_management.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.btn_management.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btn_management.OnPressedDepth = 2;
            this.btn_management.Size = new System.Drawing.Size(200, 49);
            this.btn_management.TabIndex = 13;
            this.btn_management.Text = "Management";
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
            // drag_control
            // 
            this.drag_control.Fixed = true;
            this.drag_control.Horizontal = true;
            this.drag_control.TargetControl = this.pnl_header;
            this.drag_control.Vertical = true;
            // 
            // btn_exit
            // 
            this.btn_exit.Animated = true;
            this.btn_exit.AnimationHoverSpeed = 0.07F;
            this.btn_exit.AnimationSpeed = 0.03F;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_exit.BorderColor = System.Drawing.Color.Empty;
            this.btn_exit.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_exit.CheckedBorderColor = System.Drawing.Color.Empty;
            this.btn_exit.CheckedForeColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.CheckedImage")));
            this.btn_exit.CheckedLineColor = System.Drawing.Color.Black;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_exit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
            this.btn_exit.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_exit.LineColor = System.Drawing.Color.Empty;
            this.btn_exit.LineLeft = 3;
            this.btn_exit.Location = new System.Drawing.Point(0, 464);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btn_exit.OnHoverBorderColor = System.Drawing.Color.Empty;
            this.btn_exit.OnHoverForeColor = System.Drawing.Color.Gainsboro;
            this.btn_exit.OnHoverImage = null;
            this.btn_exit.OnHoverLineColor = System.Drawing.Color.Empty;
            this.btn_exit.OnPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btn_exit.OnPressedDepth = 0;
            this.btn_exit.Size = new System.Drawing.Size(200, 49);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Exit";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_normal)).EndInit();
            this.pnl_toggle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_toggle)).EndInit();
            this.pnl_user_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_user)).EndInit();
            this.pnl_drawer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_toggle;
        private System.Windows.Forms.Panel pnl_user_data;
        internal System.Windows.Forms.PictureBox pic_user;
        internal System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Panel pnl_drawer;
        private Bunifu.Framework.UI.BunifuImageButton btn_toggle;
        private System.Windows.Forms.Panel pnl_child;
        internal Guna.UI.WinForms.GunaAdvenceButton btn_management;
        private Bunifu.Framework.UI.BunifuImageButton btn_min;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private Bunifu.Framework.UI.BunifuImageButton btn_normal;
        private Bunifu.Framework.UI.BunifuImageButton btn_max;
        private Bunifu.Framework.UI.BunifuDragControl drag_control;
        internal Guna.UI.WinForms.GunaAdvenceButton btn_exit;
    }
}

