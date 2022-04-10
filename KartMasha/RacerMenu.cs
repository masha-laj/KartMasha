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
    public partial class RacerMenu : Form
    {

        public RacerMenu()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_kontakts_Click(object sender, EventArgs e)
        {
            p_kontakts.Visible = true;
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            p_kontakts.Visible = false;
        }
    }
}
