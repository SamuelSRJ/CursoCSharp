﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AplWfaPastasEFicheiros
{
    public partial class Form1 : Form
    {
        // CAMINHO DA PASTA A SER CRIADA OU VALIDADA
        // É POSSIVEL CRIAR DUAS PASTAS AUTOMATICAMENTE UTILIZANDO POR EXEMPLO - \trabalho\docs
        //string pasta_trabalho = @"C:\trabalho";

        string pasta_config = @"C:\configuracoes\";
        string ficheiro_config = "config.dat";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            // VERIFICA SE A PASTA JÁ EXISTE
            if(!Directory.Exists(pasta_config))
            {
                Directory.CreateDirectory(pasta_config);
            }

            StreamWriter ficheiro = new StreamWriter(pasta_config + ficheiro_config, false, Encoding.Default);
            ficheiro.WriteLine(txtNome.Text);
            ficheiro.WriteLine(dtpData.Value.ToShortDateString());
            ficheiro.Dispose();

            MessageBox.Show("Configurações gravadas com sucesso!");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            // VERIFICA SE O FICHEIRO EXISTE
            if (!File.Exists(pasta_config + ficheiro_config))
            {
                MessageBox.Show("Não existe o ficheiro desejado");
                return;
            }

            // CARREGAR CONFIGURAÇÕES
            StreamReader ficheiro = new StreamReader(pasta_config + ficheiro_config, Encoding.Default);
            txtNome.Text = ficheiro.ReadLine();
            dtpData.Value = Convert.ToDateTime(ficheiro.ReadLine());
            ficheiro.Dispose();
        }
    }
}
