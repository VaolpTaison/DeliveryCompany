namespace DeliveryCompany
{
    partial class CreateProducts
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
            this.descProd = new System.Windows.Forms.TextBox();
            this.nameProd = new System.Windows.Forms.TextBox();
            this.createProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButt.Location = new System.Drawing.Point(641, 9);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(147, 45);
            this.backButt.TabIndex = 19;
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
            this.label4.Size = new System.Drawing.Size(298, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "Окно создания товара";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(176, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 31);
            this.label2.TabIndex = 16;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Наименование товара";
            // 
            // descProd
            // 
            this.descProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.descProd.Location = new System.Drawing.Point(321, 179);
            this.descProd.MaxLength = 97;
            this.descProd.Multiline = true;
            this.descProd.Name = "descProd";
            this.descProd.Size = new System.Drawing.Size(355, 99);
            this.descProd.TabIndex = 14;
            // 
            // nameProd
            // 
            this.nameProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameProd.Location = new System.Drawing.Point(321, 135);
            this.nameProd.MaxLength = 48;
            this.nameProd.Name = "nameProd";
            this.nameProd.Size = new System.Drawing.Size(355, 38);
            this.nameProd.TabIndex = 13;
            // 
            // createProd
            // 
            this.createProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createProd.Location = new System.Drawing.Point(321, 284);
            this.createProd.Name = "createProd";
            this.createProd.Size = new System.Drawing.Size(355, 45);
            this.createProd.TabIndex = 12;
            this.createProd.Text = "Создать";
            this.createProd.UseVisualStyleBackColor = true;
            this.createProd.Click += new System.EventHandler(this.createProd_Click);
            // 
            // CreateProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descProd);
            this.Controls.Add(this.nameProd);
            this.Controls.Add(this.createProd);
            this.Name = "CreateProducts";
            this.Text = "Окно создания товара";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateProducts_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descProd;
        private System.Windows.Forms.TextBox nameProd;
        private System.Windows.Forms.Button createProd;
    }
}