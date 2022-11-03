namespace WindowsFormsApp1
{
    partial class MenuS
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
            this.ViewGrades = new System.Windows.Forms.Button();
            this.ViewZaverki = new System.Windows.Forms.Button();
            this.ViewExamDate = new System.Windows.Forms.Button();
            this.EnterSubjects = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewGrades
            // 
            this.ViewGrades.Location = new System.Drawing.Point(12, 21);
            this.ViewGrades.Name = "ViewGrades";
            this.ViewGrades.Size = new System.Drawing.Size(160, 23);
            this.ViewGrades.TabIndex = 0;
            this.ViewGrades.Text = "View Grades";
            this.ViewGrades.UseVisualStyleBackColor = true;
            this.ViewGrades.Click += new System.EventHandler(this.ViewGrades_Click);
            // 
            // ViewZaverki
            // 
            this.ViewZaverki.Location = new System.Drawing.Point(12, 59);
            this.ViewZaverki.Name = "ViewZaverki";
            this.ViewZaverki.Size = new System.Drawing.Size(160, 23);
            this.ViewZaverki.TabIndex = 1;
            this.ViewZaverki.Text = "View Zaverki";
            this.ViewZaverki.UseVisualStyleBackColor = true;
            this.ViewZaverki.Click += new System.EventHandler(this.ViewZaverki_Click);
            // 
            // ViewExamDate
            // 
            this.ViewExamDate.Location = new System.Drawing.Point(12, 98);
            this.ViewExamDate.Name = "ViewExamDate";
            this.ViewExamDate.Size = new System.Drawing.Size(160, 23);
            this.ViewExamDate.TabIndex = 2;
            this.ViewExamDate.Text = "View Exam Date";
            this.ViewExamDate.UseVisualStyleBackColor = true;
            this.ViewExamDate.Click += new System.EventHandler(this.ViewExamDate_Click);
            // 
            // EnterSubjects
            // 
            this.EnterSubjects.Location = new System.Drawing.Point(12, 136);
            this.EnterSubjects.Name = "EnterSubjects";
            this.EnterSubjects.Size = new System.Drawing.Size(160, 23);
            this.EnterSubjects.TabIndex = 3;
            this.EnterSubjects.Text = "Enter Subjects";
            this.EnterSubjects.UseVisualStyleBackColor = true;
            this.EnterSubjects.Click += new System.EventHandler(this.ElectiveSubjects_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 174);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(160, 23);
            this.Logout.TabIndex = 4;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // MenuS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 205);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.EnterSubjects);
            this.Controls.Add(this.ViewExamDate);
            this.Controls.Add(this.ViewZaverki);
            this.Controls.Add(this.ViewGrades);
            this.Name = "MenuS";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewGrades;
        private System.Windows.Forms.Button ViewZaverki;
        private System.Windows.Forms.Button ViewExamDate;
        private System.Windows.Forms.Button EnterSubjects;
        private System.Windows.Forms.Button Logout;
    }
}