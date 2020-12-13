namespace AplWfaMetodosEParametros
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
            this.lbltexto = new System.Windows.Forms.Label();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(24, 30);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(0, 17);
            this.lbltexto.TabIndex = 0;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(46, 245);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(185, 43);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 317);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.lbltexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Button btnExecutar;
    }
}

