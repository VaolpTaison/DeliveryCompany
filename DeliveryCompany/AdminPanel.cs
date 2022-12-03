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
        private Button createUs = new Button();
        private Button logShow = new Button();
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
            this.Hide();
            CreateDelivery show = new CreateDelivery();
            show.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryShow show = new DeliveryShow();
            show.Show();
        }

        private void backButt_Click(object sender, EventArgs e)
        {
            BdConnect.LogThis(Properties.Settings.Default.nameUsers + " вышел из системы");
            this.Hide();
            Form1 adPn = new Form1();
            adPn.Show();
        }

        private void createUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUsers show = new CreateUsers();
            show.Show();
        }
        private void logShow_Click(object sender, EventArgs e)
        {
            this.Hide();
            LogShow show = new LogShow();
            show.Show();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.typeUsers == 0)
            {
                // изменение размера формы
                this.Height = 629;
                this.Width = 951;
                label1.Text = "Панель администратора";
                // createUs Button
                createUs.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular,
                        GraphicsUnit.Point, ((byte)(204)));
                createUs.Height = 67;
                createUs.Width = 572;
                createUs.Location = new Point(186, 401);
                createUs.Text = "Создать нового пользователя";
                createUs.Click += createUs_Click;
                Controls.Add(createUs);
                // logShow Button
                logShow.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular,
                        GraphicsUnit.Point, ((byte)(204)));
                logShow.Height = 67;
                logShow.Width = 572;
                logShow.Location = new Point(186, 474);
                logShow.Text = "Отображение логов";
                logShow.Click += logShow_Click;
                Controls.Add(logShow);
            }
            else
                label1.Text = "Панель доставщика";
        }
    }
}
