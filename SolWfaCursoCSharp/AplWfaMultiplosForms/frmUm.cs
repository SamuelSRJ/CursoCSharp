﻿using System;
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
    public partial class frmUm : Form
    {
        string valor;

        public frmUm(string valor_nome)
        {
            InitializeComponent();

            valor = valor_nome;

            lblRes.Text = valor_nome;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // FECHA O FORMULÁRIO
            this.Close();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lblOutra.Text = valor;
        }
    }
}
