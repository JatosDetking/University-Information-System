namespace WindowsFormsApp1.Forms
{
    partial class RegisterSubject
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
            this.Register = new System.Windows.Forms.Button();
            this.SybjectType = new System.Windows.Forms.ComboBox();
            this.SubjectName = new System.Windows.Forms.TextBox();
            this.Asistant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 168);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(189, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 138);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(189, 23);
            this.Register.TabIndex = 1;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // SybjectType
            // 
            this.SybjectType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SybjectType.FormattingEnabled = true;
            this.SybjectType.Location = new System.Drawing.Point(12, 64);
            this.SybjectType.Name = "SybjectType";
            this.SybjectType.Size = new System.Drawing.Size(189, 21);
            this.SybjectType.TabIndex = 2;
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(12, 25);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(189, 20);
            this.SubjectName.TabIndex = 3;
            // 
            // Asistant
            // 
            this.Asistant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Asistant.FormattingEnabled = true;
            this.Asistant.Location = new System.Drawing.Point(12, 107);
            this.Asistant.Name = "Asistant";
            this.Asistant.Size = new System.Drawing.Size(189, 21);
            this.Asistant.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Subject Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asistant";
            // 
            // RegisterSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 200);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Asistant);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.SybjectType);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.Back);
            this.Name = "RegisterSubject";
            this.Text = "tr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.ComboBox SybjectType;
        private System.Windows.Forms.TextBox SubjectName;
        private System.Windows.Forms.ComboBox Asistant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}