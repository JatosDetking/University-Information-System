namespace WindowsFormsApp1.Forms
{
    partial class MenuA
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
            this.EnterGrades = new System.Windows.Forms.Button();
            this.ViewGrades = new System.Windows.Forms.Button();
            this.ViewExamDate = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.EnterZaverki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterGrades
            // 
            this.EnterGrades.Location = new System.Drawing.Point(12, 12);
            this.EnterGrades.Name = "EnterGrades";
            this.EnterGrades.Size = new System.Drawing.Size(209, 23);
            this.EnterGrades.TabIndex = 0;
            this.EnterGrades.Text = "Enter Grades";
            this.EnterGrades.UseVisualStyleBackColor = true;
            this.EnterGrades.Click += new System.EventHandler(this.EnterGrades_Click);
            // 
            // ViewGrades
            // 
            this.ViewGrades.Location = new System.Drawing.Point(12, 50);
            this.ViewGrades.Name = "ViewGrades";
            this.ViewGrades.Size = new System.Drawing.Size(209, 23);
            this.ViewGrades.TabIndex = 1;
            this.ViewGrades.Text = "View Grades";
            this.ViewGrades.UseVisualStyleBackColor = true;
            this.ViewGrades.Click += new System.EventHandler(this.ViewGrades_Click);
            // 
            // ViewExamDate
            // 
            this.ViewExamDate.Location = new System.Drawing.Point(12, 129);
            this.ViewExamDate.Name = "ViewExamDate";
            this.ViewExamDate.Size = new System.Drawing.Size(209, 23);
            this.ViewExamDate.TabIndex = 2;
            this.ViewExamDate.Text = "View Exam Date";
            this.ViewExamDate.UseVisualStyleBackColor = true;
            this.ViewExamDate.Click += new System.EventHandler(this.ViewExamDate_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(12, 163);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(209, 23);
            this.Logout.TabIndex = 3;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // EnterZaverki
            // 
            this.EnterZaverki.Location = new System.Drawing.Point(12, 90);
            this.EnterZaverki.Name = "EnterZaverki";
            this.EnterZaverki.Size = new System.Drawing.Size(209, 23);
            this.EnterZaverki.TabIndex = 4;
            this.EnterZaverki.Text = "Enter Zaverki";
            this.EnterZaverki.UseVisualStyleBackColor = true;
            this.EnterZaverki.Click += new System.EventHandler(this.EnterZaverki_Click);
            // 
            // MenuA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 205);
            this.Controls.Add(this.EnterZaverki);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ViewExamDate);
            this.Controls.Add(this.ViewGrades);
            this.Controls.Add(this.EnterGrades);
            this.Name = "MenuA";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterGrades;
        private System.Windows.Forms.Button ViewGrades;
        private System.Windows.Forms.Button ViewExamDate;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button EnterZaverki;
    }
}