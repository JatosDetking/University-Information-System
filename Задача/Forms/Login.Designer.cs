namespace WindowsFormsApp1.Properties
{
    partial class Login
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
            this.Loging = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.t = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Loging
            // 
            this.Loging.Location = new System.Drawing.Point(161, 183);
            this.Loging.Name = "Loging";
            this.Loging.Size = new System.Drawing.Size(124, 33);
            this.Loging.TabIndex = 0;
            this.Loging.Text = "Login";
            this.Loging.UseVisualStyleBackColor = true;
            this.Loging.Click += new System.EventHandler(this.Login_Click);
            // 
            // Username
            // 
            this.Username.AccessibleName = "";
            this.Username.Location = new System.Drawing.Point(16, 48);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(217, 20);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(16, 94);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(217, 20);
            this.Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password\r\n";
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(12, 183);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(124, 32);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // Type
            // 
            this.Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(20, 148);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(217, 21);
            this.Type.TabIndex = 6;
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.BackColor = System.Drawing.SystemColors.Menu;
            this.t.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.t.Location = new System.Drawing.Point(16, 121);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(43, 20);
            this.t.TabIndex = 7;
            this.t.Text = "Type";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 225);
            this.Controls.Add(this.t);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Loging);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Loging;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Label t;
    }
}