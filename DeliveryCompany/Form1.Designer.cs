namespace DeliveryCompany
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
            this.okAuth = new System.Windows.Forms.Button();
            this.loginAuth = new System.Windows.Forms.TextBox();
            this.passAuth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okAuth
            // 
            this.okAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.okAuth.Location = new System.Drawing.Point(109, 255);
            this.okAuth.Name = "okAuth";
            this.okAuth.Size = new System.Drawing.Size(172, 57);
            this.okAuth.TabIndex = 0;
            this.okAuth.Text = "Войти";
            this.okAuth.UseVisualStyleBackColor = true;
            this.okAuth.Click += new System.EventHandler(this.okAuth_Click);
            // 
            // loginAuth
            // 
            this.loginAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginAuth.Location = new System.Drawing.Point(67, 150);
            this.loginAuth.Name = "loginAuth";
            this.loginAuth.Size = new System.Drawing.Size(262, 29);
            this.loginAuth.TabIndex = 1;
            // 
            // passAuth
            // 
            this.passAuth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passAuth.Location = new System.Drawing.Point(67, 191);
            this.passAuth.Name = "passAuth";
            this.passAuth.PasswordChar = '*';
            this.passAuth.Size = new System.Drawing.Size(262, 29);
            this.passAuth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Авторизация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passAuth);
            this.Controls.Add(this.loginAuth);
            this.Controls.Add(this.okAuth);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okAuth;
        private System.Windows.Forms.TextBox loginAuth;
        private System.Windows.Forms.TextBox passAuth;
        private System.Windows.Forms.Label label1;
    }
}

