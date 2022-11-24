
namespace ClassroomManagement.Home
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.DashboardPanel = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnAdmission = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.SchoolNamePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SchoolNameLabel = new System.Windows.Forms.Label();
            this.dashboardUserControl1 = new ClassroomManagement.Designs.DashboardUserControl();
            this.settingsUserControl1 = new ClassroomManagement.Designs.SettingsUserControl();
            this.admissionUserControl1 = new ClassroomManagement.Designs.AdmissionUserControl();
            this.attendanceUserControl1 = new ClassroomManagement.Designs.AttendanceUserControl();
            this.studentsUserControl1 = new ClassroomManagement.Designs.StudentsUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanel)).BeginInit();
            this.DashboardPanel.Panel1.SuspendLayout();
            this.DashboardPanel.Panel2.SuspendLayout();
            this.DashboardPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            this.SchoolNamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashboardPanel.Name = "DashboardPanel";
            // 
            // DashboardPanel.Panel1
            // 
            this.DashboardPanel.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.DashboardPanel.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.DashboardPanel.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DashboardPanel.Panel1MinSize = 50;
            // 
            // DashboardPanel.Panel2
            // 
            this.DashboardPanel.Panel2.Controls.Add(this.MainContentPanel);
            this.DashboardPanel.Panel2.Controls.Add(this.SchoolNamePanel);
            this.DashboardPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DashboardPanel.Size = new System.Drawing.Size(804, 452);
            this.DashboardPanel.SplitterDistance = 166;
            this.DashboardPanel.SplitterWidth = 2;
            this.DashboardPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(51)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnDashboard, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStudents, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAttendance, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnAdmission, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSettings, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(166, 294);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 48);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(166, 48);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = " Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStudents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 96);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(0);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(166, 48);
            this.btnStudents.TabIndex = 1;
            this.btnStudents.Text = " Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAttendance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAttendance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAttendance.FlatAppearance.BorderSize = 0;
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnAttendance.Image = ((System.Drawing.Image)(resources.GetObject("btnAttendance.Image")));
            this.btnAttendance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.Location = new System.Drawing.Point(0, 144);
            this.btnAttendance.Margin = new System.Windows.Forms.Padding(0);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(166, 48);
            this.btnAttendance.TabIndex = 2;
            this.btnAttendance.Text = " Attendance";
            this.btnAttendance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAttendance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnAdmission
            // 
            this.btnAdmission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnAdmission.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdmission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmission.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdmission.FlatAppearance.BorderSize = 0;
            this.btnAdmission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmission.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnAdmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnAdmission.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmission.Image")));
            this.btnAdmission.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmission.Location = new System.Drawing.Point(0, 192);
            this.btnAdmission.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdmission.Name = "btnAdmission";
            this.btnAdmission.Size = new System.Drawing.Size(166, 48);
            this.btnAdmission.TabIndex = 3;
            this.btnAdmission.Text = " Admission";
            this.btnAdmission.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdmission.UseVisualStyleBackColor = false;
            this.btnAdmission.Click += new System.EventHandler(this.btnAdmission_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Vermin Vibes", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(148)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 48);
            this.label1.TabIndex = 4;
            this.label1.Text = "Classter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Tahoma", 13F);
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 240);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(166, 54);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = " Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.Controls.Add(this.dashboardUserControl1);
            this.MainContentPanel.Controls.Add(this.settingsUserControl1);
            this.MainContentPanel.Controls.Add(this.admissionUserControl1);
            this.MainContentPanel.Controls.Add(this.attendanceUserControl1);
            this.MainContentPanel.Controls.Add(this.studentsUserControl1);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 63);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(636, 389);
            this.MainContentPanel.TabIndex = 1;
            // 
            // SchoolNamePanel
            // 
            this.SchoolNamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.SchoolNamePanel.Controls.Add(this.label3);
            this.SchoolNamePanel.Controls.Add(this.SchoolNameLabel);
            this.SchoolNamePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SchoolNamePanel.Location = new System.Drawing.Point(0, 0);
            this.SchoolNamePanel.Name = "SchoolNamePanel";
            this.SchoolNamePanel.Size = new System.Drawing.Size(636, 63);
            this.SchoolNamePanel.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(148)))), ((int)(((byte)(89)))));
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Rajakochautara, Pokhara-32";
            // 
            // SchoolNameLabel
            // 
            this.SchoolNameLabel.AutoSize = true;
            this.SchoolNameLabel.Font = new System.Drawing.Font("Open Sans Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchoolNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(148)))), ((int)(((byte)(89)))));
            this.SchoolNameLabel.Location = new System.Drawing.Point(1, 12);
            this.SchoolNameLabel.Name = "SchoolNameLabel";
            this.SchoolNameLabel.Size = new System.Drawing.Size(336, 28);
            this.SchoolNameLabel.TabIndex = 0;
            this.SchoolNameLabel.Text = "Brahma Rupa Secondary School";
            this.SchoolNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dashboardUserControl1
            // 
            this.dashboardUserControl1.AutoSize = true;
            this.dashboardUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.dashboardUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardUserControl1.Location = new System.Drawing.Point(0, 0);
            this.dashboardUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardUserControl1.Name = "dashboardUserControl1";
            this.dashboardUserControl1.Size = new System.Drawing.Size(636, 389);
            this.dashboardUserControl1.TabIndex = 0;
            // 
            // settingsUserControl1
            // 
            this.settingsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.settingsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.settingsUserControl1.Name = "settingsUserControl1";
            this.settingsUserControl1.Size = new System.Drawing.Size(636, 389);
            this.settingsUserControl1.TabIndex = 4;
            // 
            // admissionUserControl1
            // 
            this.admissionUserControl1.BackColor = System.Drawing.Color.DimGray;
            this.admissionUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.admissionUserControl1.Location = new System.Drawing.Point(0, 0);
            this.admissionUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.admissionUserControl1.Name = "admissionUserControl1";
            this.admissionUserControl1.Size = new System.Drawing.Size(636, 389);
            this.admissionUserControl1.TabIndex = 2;
            // 
            // attendanceUserControl1
            // 
            this.attendanceUserControl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.attendanceUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceUserControl1.Location = new System.Drawing.Point(0, 0);
            this.attendanceUserControl1.Margin = new System.Windows.Forms.Padding(2);
            this.attendanceUserControl1.Name = "attendanceUserControl1";
            this.attendanceUserControl1.Size = new System.Drawing.Size(636, 389);
            this.attendanceUserControl1.TabIndex = 3;
            // 
            // studentsUserControl1
            // 
            this.studentsUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.studentsUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentsUserControl1.Location = new System.Drawing.Point(0, 0);
            this.studentsUserControl1.Margin = new System.Windows.Forms.Padding(1);
            this.studentsUserControl1.Name = "studentsUserControl1";
            this.studentsUserControl1.Size = new System.Drawing.Size(636, 389);
            this.studentsUserControl1.TabIndex = 1;
            // 
            // Home
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.DashboardPanel);
            this.KeyPreview = true;
            this.Name = "Home";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classroom Management";
            this.TopMost = true;
            this.DashboardPanel.Panel1.ResumeLayout(false);
            this.DashboardPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DashboardPanel)).EndInit();
            this.DashboardPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.MainContentPanel.ResumeLayout(false);
            this.MainContentPanel.PerformLayout();
            this.SchoolNamePanel.ResumeLayout(false);
            this.SchoolNamePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer DashboardPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnAdmission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private Designs.StudentsUserControl studentsUserControl1;
        private Designs.DashboardUserControl dashboardUserControl1;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel SchoolNamePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SchoolNameLabel;
        private Designs.AdmissionUserControl admissionUserControl1;
        private Designs.AttendanceUserControl attendanceUserControl1;
        private Designs.SettingsUserControl settingsUserControl1;
    }
}