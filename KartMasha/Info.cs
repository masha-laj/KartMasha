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
    public partial class Info : Form
    {
        Charity fC = new Charity();
        public Info()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_charity_Click(object sender, EventArgs e)
        {
            fC.ShowDialog(this);
        }
    }
}
