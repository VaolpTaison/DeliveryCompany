namespace DeliveryCompany
{
    partial class DeliveryShow
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
            this.tableDel = new System.Windows.Forms.DataGridView();
            this.users = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.butDel = new System.Windows.Forms.Button();
            this.dateDel = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.backButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PrintPage = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.tableDel)).BeginInit();
            this.SuspendLayout();
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
            this.adress,
            this.product});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDel.DefaultCellStyle = dataGridViewCellStyle6;
            this.tableDel.Location = new System.Drawing.Point(157, 199);
            this.tableDel.Name = "tableDel";
            this.tableDel.Size = new System.Drawing.Size(807, 350);
            this.tableDel.TabIndex = 4;
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
            // product
            // 
            this.product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.product.HeaderText = "Доставляемый товар";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            this.product.Width = 277;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Выберите дату";
            // 
            // butDel
            // 
            this.butDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butDel.Location = new System.Drawing.Point(867, 115);
            this.butDel.Name = "butDel";
            this.butDel.Size = new System.Drawing.Size(97, 42);
            this.butDel.TabIndex = 6;
            this.butDel.Text = "ОК";
            this.butDel.UseVisualStyleBackColor = true;
            this.butDel.Click += new System.EventHandler(this.butDel_Click);
            // 
            // dateDel
            // 
            this.dateDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateDel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDel.Location = new System.Drawing.Point(157, 115);
            this.dateDel.Name = "dateDel";
            this.dateDel.Size = new System.Drawing.Size(225, 38);
            this.dateDel.TabIndex = 5;
            this.dateDel.ValueChanged += new System.EventHandler(this.dateDel_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Окно отображения доставок";
            // 
            // backButt
            // 
            this.backButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButt.Location = new System.Drawing.Point(977, 12);
            this.backButt.Name = "backButt";
            this.backButt.Size = new System.Drawing.Size(147, 45);
            this.backButt.TabIndex = 20;
            this.backButt.Text = "Назад";
            this.backButt.UseVisualStyleBackColor = true;
            this.backButt.Click += new System.EventHandler(this.backButt_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(687, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Распечатать отчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrintPage
            // 
            this.PrintPage.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintPage_PrintPage);
            // 
            // DeliveryShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 655);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backButt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butDel);
            this.Controls.Add(this.dateDel);
            this.Controls.Add(this.tableDel);
            this.Name = "DeliveryShow";
            this.Text = "Окно отображение доставок";
            this.Load += new System.EventHandler(this.DeliveryShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableDel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butDel;
        private System.Windows.Forms.DateTimePicker dateDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn users;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.Button backButt;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument PrintPage;
    }
}