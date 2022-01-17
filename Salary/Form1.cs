using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_no.BringToFront();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы знали это", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btn_no_Enter(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int new_x = rnd.Next(btn_no.Size.Width, panel.Size.Width - btn_no.Size.Width);
            int new_y = rnd.Next(btn_no.Size.Height, panel.Size.Height - btn_no.Size.Height);
            btn_no.Location = new Point(new_x, new_y);
            rnd = null;
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем, мы повышаем вам зарпоату в 0.9 раз", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
