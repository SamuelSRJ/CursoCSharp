using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaProjEntre
{
    public partial class Form1 : Form
    {
        int num1;
        int num2;
        int res;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt16(txtNum1.Text);
            num2 = Convert.ToInt16(txtNum2.Text);
            res = num1 + num2;

            lblRes.Text = Convert.ToString(res);
        }
    }
}
