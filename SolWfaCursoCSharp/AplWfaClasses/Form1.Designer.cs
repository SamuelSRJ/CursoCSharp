namespace AplWfaClasses
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
            this.lblresultado = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblresultado
            // 
            this.lblresultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(12, 9);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(411, 189);
            this.lblresultado.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(436, 79);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(145, 50);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Run";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(436, 42);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(145, 20);
            this.txtCod.TabIndex = 2;
            this.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(436, 148);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(145, 50);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 221);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lblresultado);
            this.Name = "frmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso C# - Classes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

