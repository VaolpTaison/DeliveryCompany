using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompany
{
    public partial class LogShow : Form
    {
        public LogShow()
        {
            InitializeComponent();
        }

        private void LogShow_Load(object sender, EventArgs e)
        {
            /*using (StreamWriter fstream = new StreamWriter("log.txt", false))
            {
                fileShow.DataSource = File.ReadAllLines("log.txt");
                fstream.Close();
            }*/
            fileShow.Text = File.ReadAllText("log.txt");
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }
    }
}
