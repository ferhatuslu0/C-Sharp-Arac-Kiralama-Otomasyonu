using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33RENTACAR
{
    public partial class frm_Yardim : Form
    {
        public frm_Yardim()
        {
            InitializeComponent();
        }

        private void frm_Yardim_Load(object sender, EventArgs e)
        {
            ControlBox = false;
            this.WindowState = FormWindowState.Maximized;

            tmr_gecis.Interval = 40;
            tmr_gecis.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_KayanYazi.Text = lbl_KayanYazi.Text.Substring(1) + lbl_KayanYazi.Text.Substring(0,1);
            
        }
    }
}
