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
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
        }

        private void createProd_Click(object sender, EventArgs e)
        {
            if (nameCl.Text != String.Empty && adressCl.Text != String.Empty)
            {
                SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into client values ('" + nameCl.Text + "', '" + adressCl.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Клиент внесён в базу данных");
                BdConnect.LogThis(Properties.Settings.Default.nameUsers + " был создан новый клиент: " + nameCl.Text);
                nameCl.Clear();
                adressCl.Clear();
                sqlConnect.Close();
                
            }
            else
                MessageBox.Show("Все поля должны быть заполнены!");
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }
    }
}
