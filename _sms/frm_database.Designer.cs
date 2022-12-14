namespace _sms
{
    partial class frm_database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_database));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.btn_min = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_close = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_header = new System.Windows.Forms.Label();
            this.cmb_databaselist = new Guna.UI.WinForms.GunaComboBox();
            this.btn_connect = new Guna.UI.WinForms.GunaButton();
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
            this.pnl_header.Size = new System.Drawing.Size(330, 51);
            this.pnl_header.TabIndex = 7;
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.ImageActive = null;
            this.btn_min.Location = new System.Drawing.Point(262, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(25, 25);
            this.btn_min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_min.TabIndex = 9;
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
            this.btn_close.Location = new System.Drawing.Point(293, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(25, 25);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 8;
            this.btn_close.TabStop = false;
            this.btn_close.Zoom = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_header.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_header.Location = new System.Drawing.Point(3, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(116, 32);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Database";
            // 
            // cmb_databaselist
            // 
            this.cmb_databaselist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cmb_databaselist.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cmb_databaselist.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.cmb_databaselist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_databaselist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_databaselist.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_databaselist.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_databaselist.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_databaselist.FormattingEnabled = true;
            this.cmb_databaselist.ItemHeight = 30;
            this.cmb_databaselist.Location = new System.Drawing.Point(9, 100);
            this.cmb_databaselist.Name = "cmb_databaselist";
            this.cmb_databaselist.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cmb_databaselist.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmb_databaselist.Size = new System.Drawing.Size(309, 36);
            this.cmb_databaselist.StartIndex = 0;
            this.cmb_databaselist.TabIndex = 8;
            // 
            // btn_connect
            // 
            this.btn_connect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connect.Animated = true;
            this.btn_connect.AnimationHoverSpeed = 0.07F;
            this.btn_connect.AnimationSpeed = 0.03F;
            this.btn_connect.BackColor = System.Drawing.Color.Transparent;
            this.btn_connect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btn_connect.BorderColor = System.Drawing.Color.Black;
            this.btn_connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_connect.FocusedColor = System.Drawing.Color.Empty;
            this.btn_connect.Font = new System.Drawing.Font("Segoe UI Semibold", 8F);
            this.btn_connect.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_connect.Image = ((System.Drawing.Image)(resources.GetObject("btn_connect.Image")));
            this.btn_connect.ImageSize = new System.Drawing.Size(12, 12);
            this.btn_connect.Location = new System.Drawing.Point(59, 168);
            this.btn_connect.MaximumSize = new System.Drawing.Size(301, 40);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_connect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_connect.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_connect.OnHoverImage = null;
            this.btn_connect.OnPressedColor = System.Drawing.Color.Black;
            this.btn_connect.Size = new System.Drawing.Size(201, 40);
            this.btn_connect.TabIndex = 9;
            this.btn_connect.Text = "CONNECTION";
            this.btn_connect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // frm_database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(330, 220);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.cmb_databaselist);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_database";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_database";
            this.Load += new System.EventHandler(this.frm_database_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private Bunifu.Framework.UI.BunifuImageButton btn_min;
        private Bunifu.Framework.UI.BunifuImageButton btn_close;
        private System.Windows.Forms.Label lbl_header;
        private Guna.UI.WinForms.GunaComboBox cmb_databaselist;
        internal Guna.UI.WinForms.GunaButton btn_connect;
    }
}