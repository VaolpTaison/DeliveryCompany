using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeliveryCompany
{
    public partial class Form1 : Form
    {
        //public static SqlConnection sqlConnect = new SqlConnection("Data Source=DESKTOP-9HDCF87;Initial Catalog=DeliveryDatabase;Integrated Security=True");
        public static SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void okAuth_Click(object sender, EventArgs e)
        {
            if (loginAuth.Text != String.Empty && passAuth.Text != String.Empty)
            {
                sqlConnect.Open();
                SqlCommand cmd = sqlConnect.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select type from users where login = '" + loginAuth.Text + "' and password = '" + passAuth.Text + "'";
                cmd.ExecuteNonQuery();
                object result = cmd.ExecuteScalar();
                if (result == null)
                {
                    MessageBox.Show("Такого пользователя не существует!\nОбратитесь к администратору");
                    loginAuth.Clear();
                    passAuth.Clear();
                    sqlConnect.Close();
                }
                else
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr[0].ToString() == "0")
                        {
                            this.Hide();
                            AdminPanel adPn = new AdminPanel();
                            adPn.Show();
                        }
                        if (dr[0].ToString() == "1")
                        {
                            this.Hide();
                            DeliveryShow dlSh = new DeliveryShow();
                            dlSh.Show();
                        }
                        else
                        {

                        }
                    }
                    sqlConnect.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Обязательные для ввода поля пусты!\nПовторите попытку");
            }
        }
    }
}
