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
    public partial class CreateDelivery : Form
    {
        public CreateDelivery()
        {
            InitializeComponent();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }

        private void CreateDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void CreateDelivery_Load(object sender, EventArgs e)
        {
            tableDel.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableDel.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            SqlCommand cmd1 = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from client ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            int i = 0;
            foreach (DataRow row in dt.Rows)
            {
                tableDel.Rows.Add();
                // сортировка данных в DataGridView
                tableDel.Rows[i].Cells[0].Value = row[1].ToString();
                tableDel.Rows[i].Cells[1].Value = row[2].ToString();
                i++;
            }
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select name from products";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow row1 in dt1.Rows)
            {
                prodDel.Items.Add(row1[0].ToString());
            }
            sqlConnection.Close();
        }

        private int clientEnter (string nameID) //Поиск ID по введённым данным клиента
        {
            int clientID = 0, i = 0;
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id FROM client WHERE name LIKE '"+ nameID +"%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow row in dt.Rows)
            {
                i++;
                if (i == 1)
                    clientID = Convert.ToInt32(row[0].ToString());
                else
                {
                    clientID = 0;
                    //MessageBox.Show("Уточните ФИО клиента");
                }
                
            }
            return clientID;
        }

        private int productsEnter(string prodID) //Поиск ID по выбранной категории товара
        {
            int productID = 0;
            SqlConnection sqlConnection = new SqlConnection(BdConnect.connect);
            sqlConnection.Open();
            SqlCommand cmd = sqlConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT id FROM products WHERE name LIKE '" + prodID + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                productID = Convert.ToInt32(row[0].ToString());
            }
            return productID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string date = dataDel.Value.Date.ToString("yyyy-MM-dd");
            if (clientEnter(tbDel.Text) != 0)
            {
                SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into delivery(id_client, id_products, date) " +
                    "values ('" + clientEnter(tbDel.Text) + "', '" + productsEnter(prodDel.Text) + "', '" + date + "')";
                cmd.ExecuteNonQuery();
                sqlConnect.Close();
                MessageBox.Show("Доставка сформирована!");
                BdConnect.LogThis(Properties.Settings.Default.nameUsers + " была создана новая доставка " +
                    "пользователю под ID " + clientEnter(tbDel.Text) + " товара под ID " + productsEnter(prodDel.Text) + 
                    " " + date);
            }
            else
                MessageBox.Show("Уточните ФИО клиента");
        }
    }
}
