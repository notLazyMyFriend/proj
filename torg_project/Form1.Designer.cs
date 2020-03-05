namespace torg_project
{
    partial class Form_login
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
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(110, 161);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 20);
            this.login.TabIndex = 0;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(110, 187);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(203, 20);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            this.password.WordWrap = false;
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(157, 213);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(98, 42);
            this.button_login.TabIndex = 2;
            this.button_login.Text = "Вход";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\study\\1c\\DE_Variant_7_s_kriteriami_2\\ДЭ Вариант 7 с критериями\\Style Guide\\log" +
    "o.png";
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(335, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 97);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Name = "Form_login";
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

