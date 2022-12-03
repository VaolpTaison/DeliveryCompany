namespace DeliveryCompany
{
    partial class SettingConnection
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCon = new System.Windows.Forms.TextBox();
            this.closeBut = new System.Windows.Forms.Button();
            this.enterBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Введите имя сервера";
            // 
            // tbCon
            // 
            this.tbCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCon.Location = new System.Drawing.Point(284, 56);
            this.tbCon.Name = "tbCon";
            this.tbCon.Size = new System.Drawing.Size(379, 29);
            this.tbCon.TabIndex = 5;
            // 
            // closeBut
            // 
            this.closeBut.Location = new System.Drawing.Point(14, 124);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(75, 23);
            this.closeBut.TabIndex = 6;
            this.closeBut.Text = "Закрыть";
            this.closeBut.UseVisualStyleBackColor = true;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // enterBut
            // 
            this.enterBut.Location = new System.Drawing.Point(588, 124);
            this.enterBut.Name = "enterBut";
            this.enterBut.Size = new System.Drawing.Size(75, 23);
            this.enterBut.TabIndex = 7;
            this.enterBut.Text = "Принять";
            this.enterBut.UseVisualStyleBackColor = true;
            this.enterBut.Click += new System.EventHandler(this.enterBut_Click);
            // 
            // SettingConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 159);
            this.Controls.Add(this.enterBut);
            this.Controls.Add(this.closeBut);
            this.Controls.Add(this.tbCon);
            this.Controls.Add(this.label1);
            this.Name = "SettingConnection";
            this.Text = "Настройка подключения к базе данных";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingConnection_FormClosing);
            this.Load += new System.EventHandler(this.SettingConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCon;
        private System.Windows.Forms.Button closeBut;
        private System.Windows.Forms.Button enterBut;
    }
}