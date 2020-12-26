using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaDataHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBotao_Click(object sender, EventArgs e)
        {
            //lblRes.Text = DateTime.Now.ToString("yyyy/MM/dd");
            //lblRes.Text = DateTime.Now.ToLongDateString();

            //DateTime data = new DateTime(1998, 11, 28);
            //lblRes.Text = data.DayOfWeek.ToString();

            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int ano = int.Parse(txtAno.Text);

            DateTime data = new DateTime(ano, mes, dia);
            lblRes.Text = data.DayOfWeek.ToString();
        }
    }
}
