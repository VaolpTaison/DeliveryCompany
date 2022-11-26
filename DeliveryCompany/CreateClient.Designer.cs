namespace DeliveryCompany
{
    partial class CreateClient
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
            this.backButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adressCl = new System.Windows.Forms.TextBox();
            this.nameCl = new System.Windows.Forms.TextBox();
            this.createProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButt.Location = new System.Drawing.Point(641, 9);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(147, 45);
            this.backButt.TabIndex = 26;
            this.backButt.Text = "Назад";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 31);
            this.label4.TabIndex = 25;
            this.label4.Text = "Окно создания клиентов";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(42, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "Адрес проживания";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(216, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "ФИО";
            // 
            // adressCl
            // 
            this.adressCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressCl.Location = new System.Drawing.Point(300, 176);
            this.adressCl.MaxLength = 48;
            this.adressCl.Multiline = true;
            this.adressCl.Name = "adressCl";
            this.adressCl.Size = new System.Drawing.Size(467, 99);
            this.adressCl.TabIndex = 22;
            // 
            // nameCl
            // 
            this.nameCl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameCl.Location = new System.Drawing.Point(300, 132);
            this.nameCl.MaxLength = 48;
            this.nameCl.Name = "nameCl";
            this.nameCl.Size = new System.Drawing.Size(467, 38);
            this.nameCl.TabIndex = 21;
            // 
            // createProd
            // 
            this.createProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createProd.Location = new System.Drawing.Point(300, 281);
            this.createProd.Name = "createProd";
            this.createProd.Size = new System.Drawing.Size(467, 45);
            this.createProd.TabIndex = 20;
            this.createProd.Text = "Создать";
            this.createProd.UseVisualStyleBackColor = true;
            this.createProd.Click += new System.EventHandler(this.createProd_Click);
            // 
            // CreateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adressCl);
            this.Controls.Add(this.nameCl);
            this.Controls.Add(this.createProd);
            this.Name = "CreateClient";
            this.Text = "Окно создания клиентов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adressCl;
        private System.Windows.Forms.TextBox nameCl;
        private System.Windows.Forms.Button createProd;
    }
}