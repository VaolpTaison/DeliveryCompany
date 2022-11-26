namespace DeliveryCompany
{
    partial class CreateUsers
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
            this.viewReg = new System.Windows.Forms.ComboBox();
            this.createReg = new System.Windows.Forms.Button();
            this.loginReg = new System.Windows.Forms.TextBox();
            this.passReg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backButt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewReg
            // 
            this.viewReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viewReg.FormattingEnabled = true;
            this.viewReg.Items.AddRange(new object[] {
            "Администратор",
            "Доставщик"});
            this.viewReg.Location = new System.Drawing.Point(327, 220);
            this.viewReg.Name = "viewReg";
            this.viewReg.Size = new System.Drawing.Size(355, 39);
            this.viewReg.TabIndex = 0;
            // 
            // createReg
            // 
            this.createReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createReg.Location = new System.Drawing.Point(327, 281);
            this.createReg.Name = "createReg";
            this.createReg.Size = new System.Drawing.Size(355, 45);
            this.createReg.TabIndex = 1;
            this.createReg.Text = "Создать";
            this.createReg.UseVisualStyleBackColor = true;
            this.createReg.Click += new System.EventHandler(this.createReg_Click);
            // 
            // loginReg
            // 
            this.loginReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginReg.Location = new System.Drawing.Point(327, 132);
            this.loginReg.Name = "loginReg";
            this.loginReg.Size = new System.Drawing.Size(355, 38);
            this.loginReg.TabIndex = 2;
            this.loginReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.loginReg_KeyPress);
            // 
            // passReg
            // 
            this.passReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passReg.Location = new System.Drawing.Point(327, 176);
            this.passReg.Name = "passReg";
            this.passReg.Size = new System.Drawing.Size(355, 38);
            this.passReg.TabIndex = 3;
            this.passReg.TextChanged += new System.EventHandler(this.passReg_TextChanged);
            this.passReg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passReg_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(233, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(213, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(79, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(401, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Окно создания пользователей";
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButt.Location = new System.Drawing.Point(641, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(147, 45);
            this.backButt.TabIndex = 10;
            this.backButt.Text = "Назад";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // CreateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passReg);
            this.Controls.Add(this.loginReg);
            this.Controls.Add(this.createReg);
            this.Controls.Add(this.viewReg);
            this.Name = "CreateUsers";
            this.Text = "CreateUsers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateUsers_FormClosing);
            this.Load += new System.EventHandler(this.CreateUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox viewReg;
        private System.Windows.Forms.Button createReg;
        private System.Windows.Forms.TextBox loginReg;
        private System.Windows.Forms.TextBox passReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backButt;
    }
}