using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryCompany
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUsers show = new CreateUsers();
            show.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProducts show = new CreateProducts();
            show.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateClient show = new CreateClient();
            show.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryShow show = new DeliveryShow();
            show.Show();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 adPn = new Form1();
            adPn.Show();
        }
    }
}
