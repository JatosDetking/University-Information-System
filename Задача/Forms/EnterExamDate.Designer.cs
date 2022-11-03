namespace WindowsFormsApp1
{
    partial class EnterExamDate
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
            this.ExDate = new System.Windows.Forms.DateTimePicker();
            this.Enter = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExDate
            // 
            this.ExDate.Location = new System.Drawing.Point(196, 38);
            this.ExDate.Name = "ExDate";
            this.ExDate.Size = new System.Drawing.Size(154, 20);
            this.ExDate.TabIndex = 0;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(196, 76);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(154, 23);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 76);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(154, 23);
            this.Back.TabIndex = 2;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Subject
            // 
            this.Subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject.FormattingEnabled = true;
            this.Subject.Location = new System.Drawing.Point(12, 38);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(154, 21);
            this.Subject.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Exam Date";
            // 
            // EnterExamDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 109);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.ExDate);
            this.Name = "EnterExamDate";
            this.Text = "EnterExamDate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker ExDate;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.ComboBox Subject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}