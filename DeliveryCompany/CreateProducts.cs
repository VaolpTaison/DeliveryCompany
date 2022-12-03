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
    public partial class CreateProducts : Form
    {
        public CreateProducts()
        {
            InitializeComponent();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }

        private void createProd_Click(object sender, EventArgs e)
        {
            if (nameProd.Text != String.Empty && descProd.Text != String.Empty)
            {
                SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into products values ('" + nameProd.Text + "', '" + descProd.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Товар внесён в базу данных");
                BdConnect.LogThis(Properties.Settings.Default.nameUsers + " внесён в базу данных новый товар " +
                    "" + nameProd.Text + "; Добавлено описание товара: " + descProd.Text);
                nameProd.Clear();
                descProd.Clear();
                sqlConnect.Close();
                
            }
            else
                MessageBox.Show("Все поля должны быть заполнены!");
        }
        private void CreateProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
