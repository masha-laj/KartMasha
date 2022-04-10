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
    public partial class MainMenu : Form
    {
        SponsorRegistration fSR = new SponsorRegistration();
        Info fI = new Info();
        Authorization fA = new Authorization();
        RacerPastYears fRPY = new RacerPastYears();

        public MainMenu()
        {
            InitializeComponent();
        }

        private void pb_reg_sponsor_Click(object sender, EventArgs e)
        {
            fSR.ShowDialog(this);
        }

        private void lbl_reg_sponsor_Click(object sender, EventArgs e)
        {
            fSR.ShowDialog(this);
        }

        private void lbl_information_Click(object sender, EventArgs e)
        {
            fI.ShowDialog(this);
        }

        private void pb_information_Click(object sender, EventArgs e)
        {
            fI.ShowDialog(this);
        }

        private void lbl_authorization_Click(object sender, EventArgs e)
        {
            fA.ShowDialog(this);
        }

        private void pb_authorization_Click(object sender, EventArgs e)
        {
            fA.ShowDialog(this);
        }

        private void pb_reg_racer_Click(object sender, EventArgs e)
        {
            fRPY.ShowDialog(this);
        }

        private void lbl_reg_racer_Click(object sender, EventArgs e)
        {
            fRPY.ShowDialog(this);
        }
    }
}
