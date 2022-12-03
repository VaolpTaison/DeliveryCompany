using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompany
{
    public partial class DeliveryShow : Form
    {
        //public static SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
        public string connect;
        public int id_users, id_products, id_del;
        public DeliveryShow()
        {
            InitializeComponent();
        }

        private string client_inf(int id)
        {
            string id_u = "";
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from client where id = " + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                id_u = Convert.ToString(row[0]);
            }
            sqlConnection.Close();
            return id_u;
        }

        private void dateDel_ValueChanged(object sender, EventArgs e)
        {
            tableDel.Rows.Clear();
            string date = dateDel.Value.Date.ToString("yyyy-MM-dd");
            string add, fio, del;
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_client, id_products from delivery where date = '" + date + "'; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                id_users = Convert.ToInt32(row[0]);
                id_products = Convert.ToInt32(row[0]);
                id_del = Convert.ToInt32(row[1]);

                fio = client_inf(id_users);
                add = client_add(id_users);
                del = product_name(id_del);
                tableDel.Rows.Add();
                // сортировка данных в DataGridView
                tableDel.Rows[i].Cells[0].Value = fio;
                tableDel.Rows[i].Cells[1].Value = add;
                tableDel.Rows[i].Cells[2].Value = del;
                i++;
            }
            sqlConnection.Close();
        }

        private void DeliveryShow_Load(object sender, EventArgs e)
        {
            tableDel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableDel.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }

        private void butDel_Click(object sender, EventArgs e)
        {
            tableDel.Rows.Clear();
            string date = dateDel.Value.Date.ToString("yyyy-MM-dd");
            string add, fio, del;
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id_client, id_products from delivery where date = '" + date + "'; ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                id_users = Convert.ToInt32(row[0]);
                id_products = Convert.ToInt32(row[0]);
                id_del = Convert.ToInt32(row[1]);

                fio = client_inf(id_users);
                add = client_add(id_users);
                del = product_name(id_del);
                tableDel.Rows.Add();
                // сортировка данных в DataGridView
                tableDel.Rows[i].Cells[0].Value = fio;
                tableDel.Rows[i].Cells[1].Value = add;
                tableDel.Rows[i].Cells[2].Value = del;
                i++;
            }
            sqlConnection.Close();
        }

        private void PrintPage_Click(object sender, EventArgs e)
        {

        }

        private void PrintPage_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            int x = 0;
            int y = 20;
            int cell_height = 0;

            int colCount = tableDel.ColumnCount;
            int rowCount = tableDel.RowCount - 1;

            Font font = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Point);

            int[] widthC = new int[colCount];

            int current_col = 0;
            int current_row = 0;

            while (current_col < colCount)
            {
                if (g.MeasureString(tableDel.Columns[current_col].HeaderText.ToString(), font).Width > widthC[current_col])
                {
                    widthC[current_col] = (int)g.MeasureString(tableDel.Columns[current_col].HeaderText.ToString(), font).Width;
                }
                current_col++;
            }

            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    if (g.MeasureString(tableDel[current_col, current_row].Value.ToString(), font).Width > widthC[current_col])
                    {
                        widthC[current_col] = (int)g.MeasureString(tableDel[current_col, current_row].Value.ToString(), font).Width;
                    }
                    current_col++;
                }
                current_col = 0;
                current_row++;
            }

            current_col = 0;
            current_row = 0;

            string value = "";

            int width = widthC[current_col];
            int height = tableDel[current_col, current_row].Size.Height;

            Rectangle cell_border;
            SolidBrush brush = new SolidBrush(Color.Black);


            while (current_col < colCount)
            {
                width = widthC[current_col];
                cell_height = tableDel[current_col, current_row].Size.Height;
                cell_border = new Rectangle(x, y, width, height);
                value = tableDel.Columns[current_col].HeaderText.ToString();
                g.DrawRectangle(new Pen(Color.Black), cell_border);
                g.DrawString(value, font, brush, x, y);
                x += widthC[current_col];
                current_col++;
            }
            while (current_row < rowCount)
            {
                while (current_col < colCount)
                {
                    width = widthC[current_col];
                    cell_height = tableDel[current_col, current_row].Size.Height;
                    cell_border = new Rectangle(x, y, width, height);
                    value = tableDel[current_col, current_row].Value.ToString();
                    g.DrawRectangle(new Pen(Color.Black), cell_border);
                    g.DrawString(value, font, brush, x, y);
                    x += widthC[current_col];
                    current_col++;
                }
                current_col = 0;
                current_row++;
                x = 0;
                y += cell_height;
            }
        }
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            BdConnect.LogThis(Properties.Settings.Default.nameUsers + " была произведена распечатка файла доставок за" + dateDel.Value.Date.ToString("yyyy-MM-dd"));
            PrintDocument printDocument = new PrintDocument();

            printPreviewDialog1.Document = PrintPage;
            printPreviewDialog1.ShowDialog();
        }

        /*private void PrintPage_Click(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }*/

        private string client_add(int id)
        {
            string id_a = "";
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select address from client where id = " + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                id_a = Convert.ToString(row[0]);
            }
            sqlConnection.Close();
            return id_a;
        }
        private string product_name(int id)
        {
            string id_p = "";
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select name from products where id = " + id + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                id_p = Convert.ToString(row[0]);
            }
            sqlConnection.Close();
            return id_p;
        }
    }
}
