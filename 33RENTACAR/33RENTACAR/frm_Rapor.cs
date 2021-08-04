using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _33RENTACAR
{
    public partial class frm_Rapor : Form
    {
        public frm_Rapor()
        {
            InitializeComponent();
        }

        private void frm_Rapor_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'vtDataSet.AracKiralama' table. You can move, or remove it, as needed.
            this.AracKiralamaTableAdapter.Fill(this.vtDataSet.AracKiralama);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            ControlBox = false;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.AracKiralamaTableAdapter.FillBy(this.vtDataSet.AracKiralama);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
