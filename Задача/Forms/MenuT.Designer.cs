namespace WindowsFormsApp1
{
    partial class MenuT
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
            this.EnterZaverski = new System.Windows.Forms.Button();
            this.EnterExamDate = new System.Windows.Forms.Button();
            this.ViewGrades = new System.Windows.Forms.Button();
            this.ViewExamDate = new System.Windows.Forms.Button();
            this.ViewZaverki = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.RegisterSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnterGrades
            // 
            this.EnterGrades.Location = new System.Drawing.Point(7, 12);
            this.EnterGrades.Name = "EnterGrades";
            this.EnterGrades.Size = new System.Drawing.Size(188, 23);
            this.EnterGrades.TabIndex = 0;
            this.EnterGrades.Text = "Enter Grades";
            this.EnterGrades.UseVisualStyleBackColor = true;
            this.EnterGrades.Click += new System.EventHandler(this.EnterGrades_Click);
            // 
            // EnterZaverski
            // 
            this.EnterZaverski.Location = new System.Drawing.Point(7, 77);
            this.EnterZaverski.Name = "EnterZaverski";
            this.EnterZaverski.Size = new System.Drawing.Size(188, 23);
            this.EnterZaverski.TabIndex = 1;
            this.EnterZaverski.Text = "Enter Zaverski";
            this.EnterZaverski.UseVisualStyleBackColor = true;
            this.EnterZaverski.Click += new System.EventHandler(this.EnterZaverski_Click);
            // 
            // EnterExamDate
            // 
            this.EnterExamDate.Location = new System.Drawing.Point(7, 139);
            this.EnterExamDate.Name = "EnterExamDate";
            this.EnterExamDate.Size = new System.Drawing.Size(188, 23);
            this.EnterExamDate.TabIndex = 2;
            this.EnterExamDate.Text = "Enter Exam Date";
            this.EnterExamDate.UseVisualStyleBackColor = true;
            this.EnterExamDate.Click += new System.EventHandler(this.EnterExamDate_Click);
            // 
            // ViewGrades
            // 
            this.ViewGrades.Location = new System.Drawing.Point(7, 45);
            this.ViewGrades.Name = "ViewGrades";
            this.ViewGrades.Size = new System.Drawing.Size(188, 23);
            this.ViewGrades.TabIndex = 3;
            this.ViewGrades.Text = "View Grades";
            this.ViewGrades.UseVisualStyleBackColor = true;
            this.ViewGrades.Click += new System.EventHandler(this.ViewGrades_Click);
            // 
            // ViewExamDate
            // 
            this.ViewExamDate.Location = new System.Drawing.Point(7, 169);
            this.ViewExamDate.Name = "ViewExamDate";
            this.ViewExamDate.Size = new System.Drawing.Size(188, 23);
            this.ViewExamDate.TabIndex = 4;
            this.ViewExamDate.Text = "View Exam Date";
            this.ViewExamDate.UseVisualStyleBackColor = true;
            this.ViewExamDate.Click += new System.EventHandler(this.ViewExamDate_Click);
            // 
            // ViewZaverki
            // 
            this.ViewZaverki.Location = new System.Drawing.Point(7, 109);
            this.ViewZaverki.Name = "ViewZaverki";
            this.ViewZaverki.Size = new System.Drawing.Size(188, 23);
            this.ViewZaverki.TabIndex = 5;
            this.ViewZaverki.Text = "View Zaverki";
            this.ViewZaverki.UseVisualStyleBackColor = true;
            this.ViewZaverki.Click += new System.EventHandler(this.ViewZaverki_Click);
            // 
            // Logout
            // 
            this.Logout.Location = new System.Drawing.Point(7, 232);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(188, 23);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // RegisterSubject
            // 
            this.RegisterSubject.Location = new System.Drawing.Point(9, 201);
            this.RegisterSubject.Name = "RegisterSubject";
            this.RegisterSubject.Size = new System.Drawing.Size(182, 23);
            this.RegisterSubject.TabIndex = 7;
            this.RegisterSubject.Text = "Register Subject";
            this.RegisterSubject.UseVisualStyleBackColor = true;
            this.RegisterSubject.Click += new System.EventHandler(this.RegisterSubject_Click);
            // 
            // MenuT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 267);
            this.Controls.Add(this.RegisterSubject);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ViewZaverki);
            this.Controls.Add(this.ViewExamDate);
            this.Controls.Add(this.ViewGrades);
            this.Controls.Add(this.EnterExamDate);
            this.Controls.Add(this.EnterZaverski);
            this.Controls.Add(this.EnterGrades);
            this.Name = "MenuT";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnterGrades;
        private System.Windows.Forms.Button EnterZaverski;
        private System.Windows.Forms.Button EnterExamDate;
        private System.Windows.Forms.Button ViewGrades;
        private System.Windows.Forms.Button ViewExamDate;
        private System.Windows.Forms.Button ViewZaverki;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button RegisterSubject;
    }
}