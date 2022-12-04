namespace DeliveryCompany
{
    partial class DeleteDelivery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backButt = new System.Windows.Forms.Button();
            this.tableDel = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteCB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableDel)).BeginInit();
            this.SuspendLayout();
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButt.Location = new System.Drawing.Point(748, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(147, 45);
            this.backButt.TabIndex = 28;
            this.backButt.Text = "Назад";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // tableDel
            // 
            this.tableDel.AllowUserToAddRows = false;
            this.tableDel.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableDel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fio,
            this.product,
            this.adress,
            this.date,
            this.deleteCB});
            this.tableDel.Location = new System.Drawing.Point(12, 80);
            this.tableDel.Name = "tableDel";
            this.tableDel.Size = new System.Drawing.Size(881, 467);
            this.tableDel.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(881, 52);
            this.button1.TabIndex = 30;
            this.button1.Text = "Удалить выбранную строку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 51;
            // 
            // fio
            // 
            this.fio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fio.HeaderText = "ФИО клиента";
            this.fio.Name = "fio";
            this.fio.ReadOnly = true;
            this.fio.Width = 139;
            // 
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.product.HeaderText = "Доставляемый товар";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 180;
            // 
            // adress
            // 
            this.adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.adress.HeaderText = "Адрес доставки";
            this.adress.Name = "adress";
            this.adress.ReadOnly = true;
            this.adress.Width = 144;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.date.HeaderText = "Дата доставки";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Width = 136;
            // 
            // deleteCB
            // 
            this.deleteCB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.deleteCB.HeaderText = "Выберите доставки для удаления";
            this.deleteCB.Name = "deleteCB";
            this.deleteCB.Width = 185;
            // 
            // DeleteDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableDel);
            this.Controls.Add(this.backButt);
            this.Name = "DeleteDelivery";
            this.Text = "DeleteDelivery";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteDelivery_FormClosing);
            this.Load += new System.EventHandler(this.DeleteDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.DataGridView tableDel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deleteCB;
    }
}