using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblLabel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Clicado");
        }

        private void lblLabel_MouseEnter(object sender, EventArgs e)
        {
            lblLabel.BackColor = Color.Yellow;
        }

        private void lblLabel_MouseLeave(object sender, EventArgs e)
        {
            lblLabel.BackColor = Color.Transparent;
        }

        private void lblLabel_MouseDown(object sender, MouseEventArgs e)
        {
            lblLabel.BackColor = Color.Red;
        }

        private void lblLabel_MouseUp(object sender, MouseEventArgs e)
        {
            lblLabel.BackColor = Color.Yellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblLabel.Text = textBox1.Text;
        }
    }
}
