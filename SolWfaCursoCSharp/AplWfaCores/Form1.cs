using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaCores
{
    public partial class frmMain : Form
    {
        Color cor = Color.Black;

        //------------------------------------------------------------------------
        public frmMain()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            /*
             
            ALPHA (0 -> 255) É A OPACIDADE, SENDO [0 - TRANSPARENTE] [255 - OPACO]
            RED (0 -> 255)
            GREEN (0 -> 255)
            BLUE (0 -> 255)

            Color.FromArgb(ALPHA, RED, GREEN, BLUE);

             */

            //pcbCor.BackColor = Color.FromArgb(50, 200, 0, 200);
        }

        //------------------------------------------------------------------------

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        //------------------------------------------------------------------------
        private void ApresentarCor()
        {
            cor = Color.FromArgb(trbTransparencia.Value, 
                                 trbRed.Value, 
                                 trbGreen.Value, 
                                 trbBlue.Value);

            pcbCor.BackColor = cor;
            lblRes.Text = "RGB ("+trbRed.Value + " ; " + trbGreen.Value + " ; " + trbBlue.Value + ")";
            lblRes.ForeColor = cor;
        }

        //------------------------------------------------------------------------
        private void trbTransparencia_Scroll(object sender, EventArgs e)
        {
            lblTrans.Text = trbTransparencia.Value.ToString();
            ApresentarCor();
        }

        //------------------------------------------------------------------------
        private void trbRed_Scroll(object sender, EventArgs e)
        {
            lblRed.Text = trbRed.Value.ToString();
            ApresentarCor();
        }

        //------------------------------------------------------------------------
        private void trbGreen_Scroll(object sender, EventArgs e)
        {
            lblGreen.Text = trbGreen.Value.ToString();
            ApresentarCor();
        }
        //------------------------------------------------------------------------
        private void trbBlue_Scroll(object sender, EventArgs e)
        {
            lblBlue.Text = trbBlue.Value.ToString();
            ApresentarCor();
        }
    }
}
