using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompany
{
    public partial class SettingConnection : Form
    {
        public SettingConnection()
        {
            InitializeComponent();
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enterBut_Click(object sender, EventArgs e)
        {
            string oldIP = Properties.Settings.Default.dataSource;
            Properties.Settings.Default.dataSource = "";
            Properties.Settings.Default.connectBD = "";
            Properties.Settings.Default.connectBD = "Data Source=" + tbCon.Text + ";Initial Catalog=DeliveryDatabase;Integrated Security=True";
            Properties.Settings.Default.dataSource = tbCon.Text;
            Properties.Settings.Default.Save();
            this.Close();
            Process.Start(Application.ExecutablePath);
            Close();
            BdConnect.LogThis("Был сменён IP. Старый адрес:{" + oldIP + "} " +
                "Новый адрес:{" + Properties.Settings.Default.dataSource + "}");

        }

        private void SettingConnection_Load(object sender, EventArgs e)
        {
            tbCon.Text = Properties.Settings.Default.dataSource;
        }

        private void SettingConnection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
