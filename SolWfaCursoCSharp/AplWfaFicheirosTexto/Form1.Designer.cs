namespace AplWfaFicheirosTexto
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
            this.btnGravar = new System.Windows.Forms.Button();
            this.lstCaixa = new System.Windows.Forms.ListBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(408, 63);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(187, 54);
            this.btnGravar.TabIndex = 0;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // lstCaixa
            // 
            this.lstCaixa.FormattingEnabled = true;
            this.lstCaixa.ItemHeight = 16;
            this.lstCaixa.Location = new System.Drawing.Point(31, 33);
            this.lstCaixa.Name = "lstCaixa";
            this.lstCaixa.Size = new System.Drawing.Size(349, 164);
            this.lstCaixa.TabIndex = 1;
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(31, 212);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(349, 22);
            this.txtTexto.TabIndex = 2;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(408, 143);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(187, 54);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 379);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lstCaixa);
            this.Controls.Add(this.btnGravar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.ListBox lstCaixa;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnLer;
    }
}

