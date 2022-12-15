namespace _sms
{
    partial class frm_management
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_management));
            this.pnl_elipse_1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.table_layout_1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_students = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_students_count = new System.Windows.Forms.Label();
            this.btn_student_list = new Guna.UI2.WinForms.Guna2Button();
            this.pic_student = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_total_students = new System.Windows.Forms.Label();
            this.lbl_student = new System.Windows.Forms.Label();
            this.pnl_teachers = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_teachers_count = new System.Windows.Forms.Label();
            this.btn_teachers_list = new Guna.UI2.WinForms.Guna2Button();
            this.pic_teachers = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_total_teachers = new System.Windows.Forms.Label();
            this.lbl_teacher = new System.Windows.Forms.Label();
            this.pnl_admins = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_admins_count = new System.Windows.Forms.Label();
            this.btn_admins_list = new Guna.UI2.WinForms.Guna2Button();
            this.pic_admin = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbl_total_admins = new System.Windows.Forms.Label();
            this.lbl_admin = new System.Windows.Forms.Label();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.pnl_right = new System.Windows.Forms.Panel();
            this.pnl_separator = new System.Windows.Forms.Panel();
            this.pnl_elipse_1.SuspendLayout();
            this.table_layout_1.SuspendLayout();
            this.pnl_students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).BeginInit();
            this.pnl_teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_teachers)).BeginInit();
            this.pnl_admins.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_admin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_elipse_1
            // 
            this.pnl_elipse_1.BackColor = System.Drawing.Color.Transparent;
            this.pnl_elipse_1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnl_elipse_1.Controls.Add(this.table_layout_1);
            this.pnl_elipse_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_elipse_1.Location = new System.Drawing.Point(20, 40);
            this.pnl_elipse_1.Name = "pnl_elipse_1";
            this.pnl_elipse_1.Radius = 30;
            this.pnl_elipse_1.Size = new System.Drawing.Size(969, 166);
            this.pnl_elipse_1.TabIndex = 4;
            // 
            // table_layout_1
            // 
            this.table_layout_1.ColumnCount = 3;
            this.table_layout_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_layout_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_layout_1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_layout_1.Controls.Add(this.pnl_students, 0, 0);
            this.table_layout_1.Controls.Add(this.pnl_teachers, 0, 0);
            this.table_layout_1.Controls.Add(this.pnl_admins, 0, 0);
            this.table_layout_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_layout_1.Location = new System.Drawing.Point(0, 0);
            this.table_layout_1.Name = "table_layout_1";
            this.table_layout_1.RowCount = 1;
            this.table_layout_1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_layout_1.Size = new System.Drawing.Size(969, 166);
            this.table_layout_1.TabIndex = 1;
            // 
            // pnl_students
            // 
            this.pnl_students.BackColor = System.Drawing.Color.Transparent;
            this.pnl_students.Controls.Add(this.lbl_students_count);
            this.pnl_students.Controls.Add(this.btn_student_list);
            this.pnl_students.Controls.Add(this.pic_student);
            this.pnl_students.Controls.Add(this.lbl_total_students);
            this.pnl_students.Controls.Add(this.lbl_student);
            this.pnl_students.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_students.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnl_students.Location = new System.Drawing.Point(649, 3);
            this.pnl_students.Name = "pnl_students";
            this.pnl_students.Radius = 15;
            this.pnl_students.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_students.ShadowDepth = 80;
            this.pnl_students.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnl_students.Size = new System.Drawing.Size(317, 160);
            this.pnl_students.TabIndex = 31;
            // 
            // lbl_students_count
            // 
            this.lbl_students_count.AutoSize = true;
            this.lbl_students_count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_students_count.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_students_count.Location = new System.Drawing.Point(21, 113);
            this.lbl_students_count.Name = "lbl_students_count";
            this.lbl_students_count.Size = new System.Drawing.Size(28, 32);
            this.lbl_students_count.TabIndex = 19;
            this.lbl_students_count.Text = "7";
            // 
            // btn_student_list
            // 
            this.btn_student_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_student_list.Animated = true;
            this.btn_student_list.AutoRoundedCorners = true;
            this.btn_student_list.BackColor = System.Drawing.Color.Transparent;
            this.btn_student_list.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_student_list.BorderRadius = 21;
            this.btn_student_list.CheckedState.Parent = this.btn_student_list;
            this.btn_student_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student_list.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_student_list.CustomImages.Parent = this.btn_student_list;
            this.btn_student_list.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_student_list.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_student_list.ForeColor = System.Drawing.Color.White;
            this.btn_student_list.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_student_list.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_student_list.HoverState.Parent = this.btn_student_list;
            this.btn_student_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_student_list.Image")));
            this.btn_student_list.Location = new System.Drawing.Point(240, 114);
            this.btn_student_list.Name = "btn_student_list";
            this.btn_student_list.ShadowDecoration.Parent = this.btn_student_list;
            this.btn_student_list.Size = new System.Drawing.Size(55, 44);
            this.btn_student_list.TabIndex = 15;
            this.btn_student_list.UseTransparentBackground = true;
            // 
            // pic_student
            // 
            this.pic_student.BackColor = System.Drawing.Color.Transparent;
            this.pic_student.Enabled = false;
            this.pic_student.Image = ((System.Drawing.Image)(resources.GetObject("pic_student.Image")));
            this.pic_student.Location = new System.Drawing.Point(151, 10);
            this.pic_student.Name = "pic_student";
            this.pic_student.ShadowDecoration.Parent = this.pic_student;
            this.pic_student.Size = new System.Drawing.Size(125, 115);
            this.pic_student.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_student.TabIndex = 18;
            this.pic_student.TabStop = false;
            this.pic_student.UseTransparentBackground = true;
            // 
            // lbl_total_students
            // 
            this.lbl_total_students.AutoSize = true;
            this.lbl_total_students.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_students.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_total_students.Location = new System.Drawing.Point(23, 78);
            this.lbl_total_students.Name = "lbl_total_students";
            this.lbl_total_students.Size = new System.Drawing.Size(96, 19);
            this.lbl_total_students.TabIndex = 17;
            this.lbl_total_students.Text = "Total Students";
            // 
            // lbl_student
            // 
            this.lbl_student.AutoSize = true;
            this.lbl_student.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_student.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_student.Location = new System.Drawing.Point(22, 41);
            this.lbl_student.Name = "lbl_student";
            this.lbl_student.Size = new System.Drawing.Size(95, 28);
            this.lbl_student.TabIndex = 16;
            this.lbl_student.Text = "Students";
            // 
            // pnl_teachers
            // 
            this.pnl_teachers.BackColor = System.Drawing.Color.Transparent;
            this.pnl_teachers.Controls.Add(this.lbl_teachers_count);
            this.pnl_teachers.Controls.Add(this.btn_teachers_list);
            this.pnl_teachers.Controls.Add(this.pic_teachers);
            this.pnl_teachers.Controls.Add(this.lbl_total_teachers);
            this.pnl_teachers.Controls.Add(this.lbl_teacher);
            this.pnl_teachers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_teachers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnl_teachers.Location = new System.Drawing.Point(326, 3);
            this.pnl_teachers.Name = "pnl_teachers";
            this.pnl_teachers.Radius = 15;
            this.pnl_teachers.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_teachers.ShadowDepth = 80;
            this.pnl_teachers.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnl_teachers.Size = new System.Drawing.Size(317, 160);
            this.pnl_teachers.TabIndex = 30;
            // 
            // lbl_teachers_count
            // 
            this.lbl_teachers_count.AutoSize = true;
            this.lbl_teachers_count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_teachers_count.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_teachers_count.Location = new System.Drawing.Point(21, 113);
            this.lbl_teachers_count.Name = "lbl_teachers_count";
            this.lbl_teachers_count.Size = new System.Drawing.Size(28, 32);
            this.lbl_teachers_count.TabIndex = 19;
            this.lbl_teachers_count.Text = "7";
            // 
            // btn_teachers_list
            // 
            this.btn_teachers_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_teachers_list.Animated = true;
            this.btn_teachers_list.AutoRoundedCorners = true;
            this.btn_teachers_list.BackColor = System.Drawing.Color.Transparent;
            this.btn_teachers_list.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_teachers_list.BorderRadius = 21;
            this.btn_teachers_list.CheckedState.Parent = this.btn_teachers_list;
            this.btn_teachers_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_teachers_list.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_teachers_list.CustomImages.Parent = this.btn_teachers_list;
            this.btn_teachers_list.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_teachers_list.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_teachers_list.ForeColor = System.Drawing.Color.White;
            this.btn_teachers_list.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_teachers_list.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_teachers_list.HoverState.Parent = this.btn_teachers_list;
            this.btn_teachers_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_teachers_list.Image")));
            this.btn_teachers_list.Location = new System.Drawing.Point(243, 114);
            this.btn_teachers_list.Name = "btn_teachers_list";
            this.btn_teachers_list.ShadowDecoration.Parent = this.btn_teachers_list;
            this.btn_teachers_list.Size = new System.Drawing.Size(55, 44);
            this.btn_teachers_list.TabIndex = 15;
            this.btn_teachers_list.UseTransparentBackground = true;
            // 
            // pic_teachers
            // 
            this.pic_teachers.BackColor = System.Drawing.Color.Transparent;
            this.pic_teachers.Enabled = false;
            this.pic_teachers.Image = ((System.Drawing.Image)(resources.GetObject("pic_teachers.Image")));
            this.pic_teachers.Location = new System.Drawing.Point(151, 10);
            this.pic_teachers.Name = "pic_teachers";
            this.pic_teachers.ShadowDecoration.Parent = this.pic_teachers;
            this.pic_teachers.Size = new System.Drawing.Size(125, 115);
            this.pic_teachers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_teachers.TabIndex = 18;
            this.pic_teachers.TabStop = false;
            this.pic_teachers.UseTransparentBackground = true;
            // 
            // lbl_total_teachers
            // 
            this.lbl_total_teachers.AutoSize = true;
            this.lbl_total_teachers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_teachers.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_total_teachers.Location = new System.Drawing.Point(23, 78);
            this.lbl_total_teachers.Name = "lbl_total_teachers";
            this.lbl_total_teachers.Size = new System.Drawing.Size(94, 19);
            this.lbl_total_teachers.TabIndex = 17;
            this.lbl_total_teachers.Text = "Total Teachers";
            // 
            // lbl_teacher
            // 
            this.lbl_teacher.AutoSize = true;
            this.lbl_teacher.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_teacher.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_teacher.Location = new System.Drawing.Point(22, 41);
            this.lbl_teacher.Name = "lbl_teacher";
            this.lbl_teacher.Size = new System.Drawing.Size(94, 28);
            this.lbl_teacher.TabIndex = 16;
            this.lbl_teacher.Text = "Teachers";
            // 
            // pnl_admins
            // 
            this.pnl_admins.BackColor = System.Drawing.Color.Transparent;
            this.pnl_admins.Controls.Add(this.lbl_admins_count);
            this.pnl_admins.Controls.Add(this.btn_admins_list);
            this.pnl_admins.Controls.Add(this.pic_admin);
            this.pnl_admins.Controls.Add(this.lbl_total_admins);
            this.pnl_admins.Controls.Add(this.lbl_admin);
            this.pnl_admins.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_admins.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnl_admins.Location = new System.Drawing.Point(3, 3);
            this.pnl_admins.Name = "pnl_admins";
            this.pnl_admins.Radius = 15;
            this.pnl_admins.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnl_admins.ShadowDepth = 80;
            this.pnl_admins.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.pnl_admins.Size = new System.Drawing.Size(317, 160);
            this.pnl_admins.TabIndex = 29;
            // 
            // lbl_admins_count
            // 
            this.lbl_admins_count.AutoSize = true;
            this.lbl_admins_count.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_admins_count.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_admins_count.Location = new System.Drawing.Point(21, 113);
            this.lbl_admins_count.Name = "lbl_admins_count";
            this.lbl_admins_count.Size = new System.Drawing.Size(28, 32);
            this.lbl_admins_count.TabIndex = 19;
            this.lbl_admins_count.Text = "7";
            // 
            // btn_admins_list
            // 
            this.btn_admins_list.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_admins_list.Animated = true;
            this.btn_admins_list.AutoRoundedCorners = true;
            this.btn_admins_list.BackColor = System.Drawing.Color.Transparent;
            this.btn_admins_list.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.btn_admins_list.BorderRadius = 21;
            this.btn_admins_list.CheckedState.Parent = this.btn_admins_list;
            this.btn_admins_list.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_admins_list.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_admins_list.CustomImages.Parent = this.btn_admins_list;
            this.btn_admins_list.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btn_admins_list.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_admins_list.ForeColor = System.Drawing.Color.White;
            this.btn_admins_list.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.btn_admins_list.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_admins_list.HoverState.Parent = this.btn_admins_list;
            this.btn_admins_list.Image = ((System.Drawing.Image)(resources.GetObject("btn_admins_list.Image")));
            this.btn_admins_list.Location = new System.Drawing.Point(243, 114);
            this.btn_admins_list.Name = "btn_admins_list";
            this.btn_admins_list.ShadowDecoration.Parent = this.btn_admins_list;
            this.btn_admins_list.Size = new System.Drawing.Size(55, 44);
            this.btn_admins_list.TabIndex = 15;
            this.btn_admins_list.UseTransparentBackground = true;
            // 
            // pic_admin
            // 
            this.pic_admin.BackColor = System.Drawing.Color.Transparent;
            this.pic_admin.Enabled = false;
            this.pic_admin.Image = ((System.Drawing.Image)(resources.GetObject("pic_admin.Image")));
            this.pic_admin.Location = new System.Drawing.Point(151, 10);
            this.pic_admin.Name = "pic_admin";
            this.pic_admin.ShadowDecoration.Parent = this.pic_admin;
            this.pic_admin.Size = new System.Drawing.Size(125, 115);
            this.pic_admin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_admin.TabIndex = 18;
            this.pic_admin.TabStop = false;
            this.pic_admin.UseTransparentBackground = true;
            // 
            // lbl_total_admins
            // 
            this.lbl_total_admins.AutoSize = true;
            this.lbl_total_admins.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_admins.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_total_admins.Location = new System.Drawing.Point(23, 78);
            this.lbl_total_admins.Name = "lbl_total_admins";
            this.lbl_total_admins.Size = new System.Drawing.Size(88, 19);
            this.lbl_total_admins.TabIndex = 17;
            this.lbl_total_admins.Text = "Total Admins";
            // 
            // lbl_admin
            // 
            this.lbl_admin.AutoSize = true;
            this.lbl_admin.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_admin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_admin.Location = new System.Drawing.Point(22, 41);
            this.lbl_admin.Name = "lbl_admin";
            this.lbl_admin.Size = new System.Drawing.Size(83, 28);
            this.lbl_admin.TabIndex = 16;
            this.lbl_admin.Text = "Admins";
            // 
            // pnl_header
            // 
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1009, 40);
            this.pnl_header.TabIndex = 3;
            // 
            // pnl_left
            // 
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(0, 40);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(20, 509);
            this.pnl_left.TabIndex = 5;
            // 
            // pnl_right
            // 
            this.pnl_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_right.Location = new System.Drawing.Point(989, 40);
            this.pnl_right.Name = "pnl_right";
            this.pnl_right.Size = new System.Drawing.Size(20, 509);
            this.pnl_right.TabIndex = 7;
            // 
            // pnl_separator
            // 
            this.pnl_separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_separator.Location = new System.Drawing.Point(20, 206);
            this.pnl_separator.Name = "pnl_separator";
            this.pnl_separator.Size = new System.Drawing.Size(969, 40);
            this.pnl_separator.TabIndex = 9;
            // 
            // frm_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1009, 549);
            this.Controls.Add(this.pnl_separator);
            this.Controls.Add(this.pnl_elipse_1);
            this.Controls.Add(this.pnl_right);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_management";
            this.Load += new System.EventHandler(this.frm_management_Load);
            this.pnl_elipse_1.ResumeLayout(false);
            this.table_layout_1.ResumeLayout(false);
            this.pnl_students.ResumeLayout(false);
            this.pnl_students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_student)).EndInit();
            this.pnl_teachers.ResumeLayout(false);
            this.pnl_teachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_teachers)).EndInit();
            this.pnl_admins.ResumeLayout(false);
            this.pnl_admins.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_admin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipsePanel pnl_elipse_1;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_right;
        private System.Windows.Forms.TableLayoutPanel table_layout_1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_students;
        private System.Windows.Forms.Label lbl_students_count;
        private Guna.UI2.WinForms.Guna2Button btn_student_list;
        private Guna.UI2.WinForms.Guna2PictureBox pic_student;
        private System.Windows.Forms.Label lbl_total_students;
        private System.Windows.Forms.Label lbl_student;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_teachers;
        private System.Windows.Forms.Label lbl_teachers_count;
        private Guna.UI2.WinForms.Guna2Button btn_teachers_list;
        private Guna.UI2.WinForms.Guna2PictureBox pic_teachers;
        private System.Windows.Forms.Label lbl_total_teachers;
        private System.Windows.Forms.Label lbl_teacher;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_admins;
        private System.Windows.Forms.Label lbl_admins_count;
        private Guna.UI2.WinForms.Guna2Button btn_admins_list;
        private Guna.UI2.WinForms.Guna2PictureBox pic_admin;
        private System.Windows.Forms.Label lbl_total_admins;
        private System.Windows.Forms.Label lbl_admin;
        private System.Windows.Forms.Panel pnl_separator;
    }
}