namespace WindowsFormsApp1
{
    partial class EnterGrades
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
            this.Back = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.FN = new System.Windows.Forms.TextBox();
            this.Grade = new System.Windows.Forms.ComboBox();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 70);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(164, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(420, 70);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(164, 23);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(227, 28);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(164, 20);
            this.FN.TabIndex = 2;
            // 
            // Grade
            // 
            this.Grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Grade.FormattingEnabled = true;
            this.Grade.Location = new System.Drawing.Point(420, 27);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(164, 21);
            this.Grade.TabIndex = 3;
            // 
            // Subject
            // 
            this.Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(12, 27);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(164, 21);
            this.Subject.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grade";
            // 
            // EnterGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 116);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Grade);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Back);
            this.Name = "EnterGrades";
            this.Text = "EnterGrades";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.ComboBox Grade;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}