﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            retangulo forma1 = new retangulo();
            forma1.Largura = 50;
            forma1.Altura = 100;
            forma1.Apresentar();
            forma1.Desenhar();
            forma1.Desenhar_Outro();

            triangulo forma2 = new triangulo();
            forma2.Largura = 100;
            forma2.Altura = 200;
            forma2.Apresentar();
            forma2.Desenhar();
            forma2.Desenhar_Outro();

            circunferencia forma3 = new circunferencia();
            forma3.Largura = 250;
            forma3.Altura = 300;
            forma3.Apresentar();
            forma3.Desenhar();
            forma3.Desenhar_Outro();
        }
    }
}
