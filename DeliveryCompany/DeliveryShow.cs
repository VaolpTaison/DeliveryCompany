using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
