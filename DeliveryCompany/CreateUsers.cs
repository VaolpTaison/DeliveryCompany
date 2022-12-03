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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeliveryCompany
{
    public partial class CreateUsers : Form
    {
        public CreateUsers()
        {
            InitializeComponent();
            viewReg.KeyPress += (sender, e) => e.Handled = true;
        }

        private void createReg_Click(object sender, EventArgs e)
        {
            if (loginReg.Text != String.Empty && passReg.Text != String.Empty && viewReg.SelectedIndex.ToString() != String.Empty)
            {
                SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into users values ('" + loginReg.Text + "', '" + passReg.Text + "', " + viewReg.SelectedIndex.ToString() + ")";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Новый пользователь создан");
                loginReg.Clear();
                passReg.Clear();
                sqlConnect.Close();
                BdConnect.LogThis(Properties.Settings.Default.nameUsers + " создан новый пользователь с логином " + loginReg.Text);
            }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
        }

        private void CreateUsers_Load(object sender, EventArgs e)
        {
            createReg.Enabled = !(passReg.Text.Length < 8);
        }

        private void passReg_TextChanged(object sender, EventArgs e)
        {
            createReg.Enabled = !(passReg.Text.Length < 8);
        }

        private void loginReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void passReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }

        private void CreateUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
