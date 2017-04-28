namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.NameM = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.Pass1 = new System.Windows.Forms.Label();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            this.Pass2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NameM
            // 
            this.NameM.AutoSize = true;
            this.NameM.Location = new System.Drawing.Point(67, 58);
            this.NameM.Name = "NameM";
            this.NameM.Size = new System.Drawing.Size(35, 13);
            this.NameM.TabIndex = 1;
            this.NameM.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(108, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(108, 81);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(100, 20);
            this.textBoxLogin.TabIndex = 4;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(67, 84);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 3;
            this.Login.Text = "Login";
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.Location = new System.Drawing.Point(108, 107);
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass1.TabIndex = 6;
            // 
            // Pass1
            // 
            this.Pass1.AutoSize = true;
            this.Pass1.Location = new System.Drawing.Point(49, 110);
            this.Pass1.Name = "Pass1";
            this.Pass1.Size = new System.Drawing.Size(53, 13);
            this.Pass1.TabIndex = 5;
            this.Pass1.Text = "Password";
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.Location = new System.Drawing.Point(108, 133);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(100, 20);
            this.textBoxPass2.TabIndex = 8;
            // 
            // Pass2
            // 
            this.Pass2.AutoSize = true;
            this.Pass2.Location = new System.Drawing.Point(49, 136);
            this.Pass2.Name = "Pass2";
            this.Pass2.Size = new System.Drawing.Size(53, 13);
            this.Pass2.TabIndex = 7;
            this.Pass2.Text = "Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.Pass2);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.Pass1);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.NameM);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label NameM;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.Label Pass1;
        private System.Windows.Forms.TextBox textBoxPass2;
        private System.Windows.Forms.Label Pass2;
    }
}

