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
    public partial class RacerPastYears : Form
    {
        Authorization fA = new Authorization();
        public RacerPastYears()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            fA.ShowDialog(this);
        }
    }
}
