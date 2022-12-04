using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompany
{
    public partial class DeleteDelivery : Form
    {
        public string connect;
        public int id_users, id_products, id_del;

        public DeleteDelivery()
        {
            InitializeComponent();
        }

        // нумерация столбцов до удаления
        private int initiallyNum()
        {
            int i = 0;
            SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
            sqlConnect.Open();
            SqlCommand cmd1 = sqlConnect.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "SELECT count(*) from delivery";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                i = Convert.ToInt32(row[0].ToString());
            }
            return i;
        }

        // нумерация столбцов после удаления
        private int deleteNum()
        {
            int i = 0;
            SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
            sqlConnect.Open();
            SqlCommand cmd = sqlConnect.CreateCommand();
            SqlCommand cmd1 = sqlConnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd1.CommandType = CommandType.Text;
            /*cmd.CommandText = "DELETE from supplier( WHERE EXISTS " +
                "( SELECT customers.customer_name FROM customers " +
                "WHERE customer_id > 25 );";*/
            cmd.CommandText = "DELETE from delivery WHERE  date < '" + DateTime.Now.ToString("yyyy-MM-dd") + "'";
            cmd.ExecuteNonQuery();
            cmd1.CommandText = "SELECT count(*) from delivery";
            cmd1.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd1);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                i = Convert.ToInt32(row[0].ToString());
            }
            return i;
        }

        // фамилия клиента
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

        // адрес проживания
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

        // наименование продукта
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

        private void tableLoad()
        {
            tableDel.Rows.Clear();
            string add, fio, del;
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select id, id_client, id_products, DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1) as date from delivery;";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                id_users = Convert.ToInt32(row[1]);
                id_products = Convert.ToInt32(row[1]);
                id_del = Convert.ToInt32(row[2]);

                fio = client_inf(id_users);
                add = client_add(id_users);
                del = product_name(id_del);
                tableDel.Rows.Add();
                // сортировка данных в DataGridView
                tableDel.Rows[i].Cells[0].Value = Convert.ToInt32(row[0].ToString());
                tableDel.Rows[i].Cells[1].Value = fio;
                tableDel.Rows[i].Cells[2].Value = add;
                tableDel.Rows[i].Cells[3].Value = del;
                tableDel.Rows[i].Cells[4].Value = row[3].ToString();
                i++;
            }
            sqlConnection.Close();
        }

        private void DeleteDelivery_Load(object sender, EventArgs e)
        {
            int num = initiallyNum() - deleteNum();
            BdConnect.LogThis("Из таблицы с доставками было удалено " + num + " строк за предыдущие дни от текущего " +
                "(" + DateTime.Now.ToString("yyyy-MM-dd") + ")");
            tableLoad();
        }

        // удаление строк из бд по id
        private void deleteDelivery (int id)
        {
            SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
            sqlConnect.Open();
            SqlCommand cmd = sqlConnect.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE from delivery WHERE  id = " + id + "";
            cmd.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rows = tableDel.Rows.Count;
            int i = 0, id = 0;
            bool check = false;
            foreach (DataGridViewRow row in tableDel.Rows)
            {
                check = Convert.ToBoolean(tableDel.Rows[i].Cells[5].Value);
                if (check == true)
                {
                    id = Convert.ToInt32(tableDel.Rows[i].Cells[0].Value);
                    deleteDelivery(id);
                }
                i++;
            }
            tableLoad();

            BdConnect.LogThis(Properties.Settings.Default.nameUsers + " из таблицы с доставками было удалено " + i + " строк");

            /*int index = tableDel.SelectedRows[0].Index;
            int id = Convert.ToInt32(tableDel.Rows[index].Cells[0].Value);
            MessageBox.Show("" + index);
            MessageBox.Show("" + tableDel.Rows[index].Cells[0].Value);
            deleteDelivery(id);*/

        }

        private void DeleteDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }
    }
}
