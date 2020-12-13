namespace AplWfaOperadoresAritmeticos
{
    partial class frmForm
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
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnbotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(12, 28);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(100, 20);
            this.txtnum1.TabIndex = 0;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(12, 63);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(100, 20);
            this.txtnum2.TabIndex = 1;
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(12, 102);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 2;
            // 
            // btnbotao
            // 
            this.btnbotao.Location = new System.Drawing.Point(12, 131);
            this.btnbotao.Name = "btnbotao";
            this.btnbotao.Size = new System.Drawing.Size(75, 23);
            this.btnbotao.TabIndex = 3;
            this.btnbotao.Text = "Executar";
            this.btnbotao.UseVisualStyleBackColor = true;
            this.btnbotao.Click += new System.EventHandler(this.btnbotao_Click);
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 227);
            this.Controls.Add(this.btnbotao);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Name = "frmForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnbotao;
    }
}

