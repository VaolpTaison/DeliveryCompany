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
using System.IO;

namespace DeliveryCompany
{
    public partial class Form1 : Form
    {
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
            try
            {
                SqlConnection sqlConnect = new SqlConnection(BdConnect.connect);
                if (loginAuth.Text != String.Empty && passAuth.Text != String.Empty)
                {
                    
                    sqlConnect.Open();
                    SqlCommand cmd = sqlConnect.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select type, login from users where login = '" + loginAuth.Text + "' and password = '" + passAuth.Text + "'";
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
                                Properties.Settings.Default.nameUsers = dr[1].ToString(); 
                                Properties.Settings.Default.typeUsers = 0;
                                this.Hide();
                                AdminPanel adPn = new AdminPanel();
                                adPn.Show();
                                BdConnect.LogThis(Properties.Settings.Default.nameUsers + " был осущствлён вход");
                            }
                            if (dr[0].ToString() == "1")
                            {
                                Properties.Settings.Default.nameUsers = dr[1].ToString();
                                Properties.Settings.Default.typeUsers = 1;
                                this.Hide();
                                AdminPanel dlSh = new AdminPanel();
                                dlSh.Show();
                                BdConnect.LogThis(Properties.Settings.Default.nameUsers + " был осущствлён вход");
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
            catch
            {
                MessageBox.Show("Было введено неправильное подключение к БД!\n" +
                    "Проверьте правильность адреса подключения или обратитесь к администратору!");
            }
            
        }

        private void настройкаПодключенияКБазеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingConnection dlSh = new SettingConnection();
            dlSh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int date = Convert.ToInt32(DateTime.Now.ToString("dd"));
            Properties.Settings.Default.typeUsers = 0;
            Properties.Settings.Default.nameUsers = "";
            //-----------------------------------------------------------------
            // ПОДУМАТЬ НАД УДАЛЕНИЕМ СТРОК В ОПРЕДЕЛЁННЫЙ ДЕНЬ
            /*if (date % 2 == 0 & Properties.Settings.Default.intDeleteLog == 0)
            {
                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    string str = "";
                    for (int i = 0; i < 10; i++)
                    {
                        str = str + sr.ReadLine() + "\n";
                    }
                    sr.Close();
                }
            }
            else
                Properties.Settings.Default.intDeleteLog = 0;*/
        }
    }
}
