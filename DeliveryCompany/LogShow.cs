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
            StreamReader sr = new StreamReader("log.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                fileShow.Items.Add(line);
            }
            sr.Close();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPanel adPn = new AdminPanel();
            adPn.Show();
        }

        private void LogShow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
