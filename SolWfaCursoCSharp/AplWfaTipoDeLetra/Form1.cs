using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaTipoDeLetra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Font letra = new Font("Helvetica", 18, FontStyle.Italic | FontStyle.Bold, GraphicsUnit.Pixel);
            lblLabel.Font = letra;
            lblLabel.ForeColor = Color.Yellow;
            lblLabel.BackColor = Color.Black;
        }
    }
}
