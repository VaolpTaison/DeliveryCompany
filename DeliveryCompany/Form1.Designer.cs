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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкаПодключенияКБазеДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(419, 29);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкаПодключенияКБазеДанныхToolStripMenuItem});
            this.настройкиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(99, 25);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настройкаПодключенияКБазеДанныхToolStripMenuItem
            // 
            this.настройкаПодключенияКБазеДанныхToolStripMenuItem.Name = "настройкаПодключенияКБазеДанныхToolStripMenuItem";
            this.настройкаПодключенияКБазеДанныхToolStripMenuItem.Size = new System.Drawing.Size(364, 26);
            this.настройкаПодключенияКБазеДанныхToolStripMenuItem.Text = "Настройка подключения к базе данных";
            this.настройкаПодключенияКБазеДанныхToolStripMenuItem.Click += new System.EventHandler(this.настройкаПодключенияКБазеДанныхToolStripMenuItem_Click);
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
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okAuth;
        private System.Windows.Forms.TextBox loginAuth;
        private System.Windows.Forms.TextBox passAuth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкаПодключенияКБазеДанныхToolStripMenuItem;
    }
}

