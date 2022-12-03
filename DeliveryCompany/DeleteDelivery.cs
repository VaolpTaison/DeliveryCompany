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
    public partial class DeleteDelivery : Form
    {
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

        private void DeleteDelivery_Load(object sender, EventArgs e)
        {
            int num = initiallyNum() - deleteNum();
            BdConnect.LogThis("Из таблицы с доставками было удалено " + num + " строк за предыдущие дни от текущего " +
                "(" + DateTime.Now.ToString("yyyy-MM-dd") + ")");
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
