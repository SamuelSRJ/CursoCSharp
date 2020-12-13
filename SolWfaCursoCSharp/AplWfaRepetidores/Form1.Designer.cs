namespace AplWfaRepetidores
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
            this.lstlLista = new System.Windows.Forms.ListBox();
            this.btnBotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstlLista
            // 
            this.lstlLista.FormattingEnabled = true;
            this.lstlLista.Location = new System.Drawing.Point(25, 24);
            this.lstlLista.Name = "lstlLista";
            this.lstlLista.Size = new System.Drawing.Size(164, 303);
            this.lstlLista.TabIndex = 0;
            // 
            // btnBotao
            // 
            this.btnBotao.Location = new System.Drawing.Point(239, 269);
            this.btnBotao.Name = "btnBotao";
            this.btnBotao.Size = new System.Drawing.Size(108, 58);
            this.btnBotao.TabIndex = 1;
            this.btnBotao.Text = "Executar";
            this.btnBotao.UseVisualStyleBackColor = true;
            this.btnBotao.Click += new System.EventHandler(this.btnBotao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 358);
            this.Controls.Add(this.btnBotao);
            this.Controls.Add(this.lstlLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstlLista;
        private System.Windows.Forms.Button btnBotao;
    }
}

