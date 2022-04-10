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
    public partial class SponsorRegistration : Form
    {
        SponsorConfirm fSC = new SponsorConfirm();
        public SponsorRegistration()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            var sponsor = tb_sponsor_name.Text.Trim();
            var racer = cb_racer_name.SelectedItem;
            var card = tb_card.Text.Trim();
            var card_num = tb_card_num.Text;
            var val_m = tb_validity_month.Text.Trim();
            var val_y = tb_validity_year.Text.Trim();
            var cvc = tb_cvc.Text.Trim();
            var sum = tb_sum.Text.Trim();

            if (string.IsNullOrWhiteSpace(sponsor)
                || string.IsNullOrWhiteSpace((string)racer)
                || string.IsNullOrWhiteSpace(card)
                || string.IsNullOrWhiteSpace(card_num)
                || string.IsNullOrWhiteSpace(val_m)
                || string.IsNullOrWhiteSpace(val_y)
                || string.IsNullOrWhiteSpace(cvc)
                || string.IsNullOrWhiteSpace(sum))
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            this.Close();
            fSC.ShowDialog(this);
        }
    }
}
