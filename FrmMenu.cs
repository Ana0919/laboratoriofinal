using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationInterface
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void sedesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportOffices frmOffices = new();
            frmOffices.MdiParent = FrmMenu.ActiveForm;
            frmOffices.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPatient frmPatient = new();
            frmPatient.MdiParent = FrmMenu.ActiveForm;
            frmPatient.Show();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registroExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInfoTest frmInfoTest = new();
            frmInfoTest.MdiParent = FrmMenu.ActiveForm;
            frmInfoTest.Show();
        }
    }
}
