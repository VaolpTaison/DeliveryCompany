namespace DeliveryCompany
{
    partial class CreateDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButt = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.prodDel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataDel = new System.Windows.Forms.DateTimePicker();
            this.tableDel = new System.Windows.Forms.DataGridView();
            this.users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableDel)).BeginInit();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButt.Location = new System.Drawing.Point(1163, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(147, 45);
            this.backButt.TabIndex = 21;
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
            this.label4.Size = new System.Drawing.Size(505, 31);
            this.label4.TabIndex = 20;
            this.label4.Text = "Окно формирования доставок клиенту";
            // 
            // prodDel
            // 
            this.prodDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prodDel.FormattingEnabled = true;
            this.prodDel.Location = new System.Drawing.Point(365, 87);
            this.prodDel.Name = "prodDel";
            this.prodDel.Size = new System.Drawing.Size(345, 39);
            this.prodDel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(79, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 31);
            this.label1.TabIndex = 24;
            this.label1.Text = "Выберите тип товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 62);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите ФИО клиента, \r\nруководствуясь списком";
            // 
            // tbDel
            // 
            this.tbDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDel.Location = new System.Drawing.Point(365, 189);
            this.tbDel.Multiline = true;
            this.tbDel.Name = "tbDel";
            this.tbDel.Size = new System.Drawing.Size(345, 73);
            this.tbDel.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 31);
            this.label3.TabIndex = 27;
            this.label3.Text = "Выберите дату доставки";
            // 
            // dataDel
            // 
            this.dataDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataDel.Location = new System.Drawing.Point(365, 142);
            this.dataDel.Name = "dataDel";
            this.dataDel.Size = new System.Drawing.Size(345, 38);
            this.dataDel.TabIndex = 28;
            // 
            // tableDel
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableDel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.tableDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.users,
            this.adress});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDel.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableDel.Location = new System.Drawing.Point(728, 87);
            this.tableDel.Name = "tableDel";
            this.tableDel.Size = new System.Drawing.Size(582, 313);
            this.tableDel.TabIndex = 29;
            // 
            // users
            // 
            this.users.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.users.HeaderText = "ФИО Покупателя";
            this.users.Name = "users";
            this.users.ReadOnly = true;
            this.users.Width = 236;
            // 
            // adress
            // 
            this.adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.adress.HeaderText = "Адрес Покупателя";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            this.adress.Width = 249;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(561, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 45);
            this.button1.TabIndex = 30;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableDel);
            this.Controls.Add(this.dataDel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prodDel);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label4);
            this.Name = "CreateDelivery";
            this.Text = "CreateDelivery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDelivery_FormClosing);
            this.Load += new System.EventHandler(this.CreateDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox prodDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataDel;
        private System.Windows.Forms.DataGridView tableDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn users;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.Button button1;
    }
}