namespace AplWfaEventos
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
            this.btnBotao = new System.Windows.Forms.Button();
            this.lblLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBotao
            // 
            this.btnBotao.Location = new System.Drawing.Point(304, 290);
            this.btnBotao.Name = "btnBotao";
            this.btnBotao.Size = new System.Drawing.Size(190, 74);
            this.btnBotao.TabIndex = 0;
            this.btnBotao.Text = "Botão";
            this.btnBotao.UseVisualStyleBackColor = true;
            // 
            // lblLabel
            // 
            this.lblLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLabel.Location = new System.Drawing.Point(304, 137);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(190, 54);
            this.lblLabel.TabIndex = 1;
            this.lblLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLabel.Click += new System.EventHandler(this.lblLabel_Click);
            this.lblLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseDown);
            this.lblLabel.MouseEnter += new System.EventHandler(this.lblLabel_MouseEnter);
            this.lblLabel.MouseLeave += new System.EventHandler(this.lblLabel_MouseLeave);
            this.lblLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblLabel_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(304, 236);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblLabel);
            this.Controls.Add(this.btnBotao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBotao;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox textBox1;
    }
}

