using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaMultiplosForms
{
    public partial class frmPrimeiro : Form
    {
        public frmPrimeiro()
        {
            InitializeComponent();
        }

        private void frmPrimeiro_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmUm formulario = new frmUm();
            formulario.ShowDialog();
        }
    }
}
