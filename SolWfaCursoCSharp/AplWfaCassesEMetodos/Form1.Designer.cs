namespace AplWfaCassesEMetodos
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
            this.btnRun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(52, 29);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(35, 13);
            this.lbltexto.TabIndex = 0;
            this.lbltexto.Text = "label1";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(493, 294);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Executar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 329);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.lbltexto);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Button btnRun;
    }
}

