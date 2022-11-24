
namespace ClassroomManagement.Designs
{
    partial class StudentsUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Class09Page = new System.Windows.Forms.TabPage();
            this.Class10Page = new System.Windows.Forms.TabPage();
            this.Class11Page = new System.Windows.Forms.TabPage();
            this.Class12Page = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Class09Page);
            this.tabControl1.Controls.Add(this.Class10Page);
            this.tabControl1.Controls.Add(this.Class11Page);
            this.tabControl1.Controls.Add(this.Class12Page);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // Class09Page
            // 
            this.Class09Page.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Class09Page.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Class09Page.Location = new System.Drawing.Point(4, 25);
            this.Class09Page.Margin = new System.Windows.Forms.Padding(0);
            this.Class09Page.Name = "Class09Page";
            this.Class09Page.Size = new System.Drawing.Size(798, 446);
            this.Class09Page.TabIndex = 0;
            this.Class09Page.Text = "Class 9";
            // 
            // Class10Page
            // 
            this.Class10Page.Location = new System.Drawing.Point(4, 25);
            this.Class10Page.Name = "Class10Page";
            this.Class10Page.Padding = new System.Windows.Forms.Padding(5);
            this.Class10Page.Size = new System.Drawing.Size(798, 446);
            this.Class10Page.TabIndex = 1;
            this.Class10Page.Text = "Class 10";
            this.Class10Page.UseVisualStyleBackColor = true;
            // 
            // Class11Page
            // 
            this.Class11Page.Location = new System.Drawing.Point(4, 25);
            this.Class11Page.Name = "Class11Page";
            this.Class11Page.Padding = new System.Windows.Forms.Padding(5);
            this.Class11Page.Size = new System.Drawing.Size(798, 446);
            this.Class11Page.TabIndex = 2;
            this.Class11Page.Text = "Class 11";
            this.Class11Page.UseVisualStyleBackColor = true;
            // 
            // Class12Page
            // 
            this.Class12Page.Location = new System.Drawing.Point(4, 25);
            this.Class12Page.Name = "Class12Page";
            this.Class12Page.Padding = new System.Windows.Forms.Padding(5);
            this.Class12Page.Size = new System.Drawing.Size(798, 446);
            this.Class12Page.TabIndex = 3;
            this.Class12Page.Text = "Class 12";
            this.Class12Page.UseVisualStyleBackColor = true;
            // 
            // StudentsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentsUserControl";
            this.Size = new System.Drawing.Size(806, 475);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Class09Page;
        private System.Windows.Forms.TabPage Class10Page;
        private System.Windows.Forms.TabPage Class11Page;
        private System.Windows.Forms.TabPage Class12Page;
    }
}
