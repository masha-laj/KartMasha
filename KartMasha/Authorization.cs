using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartMasha
{
    public partial class Authorization : Form
    {
        RacerMenu fRM = new RacerMenu();
        public Authorization()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var email = tb_email.Text.Trim();      
            var pass = tb_password.Text.Trim();
            if (string.IsNullOrWhiteSpace(email)
                || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            this.Close();
            fRM.ShowDialog(this);
        }
    }
}
