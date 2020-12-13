namespace AplWfaEnumeracoes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnCima = new System.Windows.Forms.Button();
            this.btnBaixo = new System.Windows.Forms.Button();
            this.btnDireita = new System.Windows.Forms.Button();
            this.btnEsquerda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCima
            // 
            this.btnCima.Location = new System.Drawing.Point(326, 42);
            this.btnCima.Name = "btnCima";
            this.btnCima.Size = new System.Drawing.Size(133, 57);
            this.btnCima.TabIndex = 1;
            this.btnCima.Text = "Cima";
            this.btnCima.UseVisualStyleBackColor = true;
            this.btnCima.Click += new System.EventHandler(this.btnCima_Click);
            // 
            // btnBaixo
            // 
            this.btnBaixo.Location = new System.Drawing.Point(326, 171);
            this.btnBaixo.Name = "btnBaixo";
            this.btnBaixo.Size = new System.Drawing.Size(133, 57);
            this.btnBaixo.TabIndex = 2;
            this.btnBaixo.Text = "Baixo";
            this.btnBaixo.UseVisualStyleBackColor = true;
            this.btnBaixo.Click += new System.EventHandler(this.btnBaixo_Click);
            // 
            // btnDireita
            // 
            this.btnDireita.Location = new System.Drawing.Point(478, 106);
            this.btnDireita.Name = "btnDireita";
            this.btnDireita.Size = new System.Drawing.Size(133, 57);
            this.btnDireita.TabIndex = 3;
            this.btnDireita.Text = "Direita";
            this.btnDireita.UseVisualStyleBackColor = true;
            this.btnDireita.Click += new System.EventHandler(this.btnDireita_Click);
            // 
            // btnEsquerda
            // 
            this.btnEsquerda.Location = new System.Drawing.Point(165, 106);
            this.btnEsquerda.Name = "btnEsquerda";
            this.btnEsquerda.Size = new System.Drawing.Size(133, 57);
            this.btnEsquerda.TabIndex = 4;
            this.btnEsquerda.Text = "Esquerda";
            this.btnEsquerda.UseVisualStyleBackColor = true;
            this.btnEsquerda.Click += new System.EventHandler(this.btnEsquerda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsquerda);
            this.Controls.Add(this.btnDireita);
            this.Controls.Add(this.btnBaixo);
            this.Controls.Add(this.btnCima);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCima;
        private System.Windows.Forms.Button btnBaixo;
        private System.Windows.Forms.Button btnDireita;
        private System.Windows.Forms.Button btnEsquerda;
    }
}

