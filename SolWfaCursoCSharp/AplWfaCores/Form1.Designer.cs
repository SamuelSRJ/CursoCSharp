namespace AplWfaCores
{
    partial class frmMain
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
            this.pcbCor = new System.Windows.Forms.PictureBox();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.trbTransparencia = new System.Windows.Forms.TrackBar();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.trbRed = new System.Windows.Forms.TrackBar();
            this.lblMsg3 = new System.Windows.Forms.Label();
            this.trbGreen = new System.Windows.Forms.TrackBar();
            this.lblMsg4 = new System.Windows.Forms.Label();
            this.trbBlue = new System.Windows.Forms.TrackBar();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTransparencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbCor
            // 
            this.pcbCor.BackColor = System.Drawing.Color.Transparent;
            this.pcbCor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbCor.Location = new System.Drawing.Point(32, 24);
            this.pcbCor.Name = "pcbCor";
            this.pcbCor.Size = new System.Drawing.Size(393, 103);
            this.pcbCor.TabIndex = 0;
            this.pcbCor.TabStop = false;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(490, 153);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(139, 51);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Alterar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Visible = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // trbTransparencia
            // 
            this.trbTransparencia.Location = new System.Drawing.Point(32, 168);
            this.trbTransparencia.Maximum = 255;
            this.trbTransparencia.Name = "trbTransparencia";
            this.trbTransparencia.Size = new System.Drawing.Size(359, 56);
            this.trbTransparencia.TabIndex = 2;
            this.trbTransparencia.Scroll += new System.EventHandler(this.trbTransparencia_Scroll);
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg1.Location = new System.Drawing.Point(39, 139);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(141, 17);
            this.lblMsg1.TabIndex = 3;
            this.lblMsg1.Text = "TRANSPARENCIA:";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg2.ForeColor = System.Drawing.Color.Red;
            this.lblMsg2.Location = new System.Drawing.Point(39, 213);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(45, 17);
            this.lblMsg2.TabIndex = 5;
            this.lblMsg2.Text = "RED:";
            // 
            // trbRed
            // 
            this.trbRed.Location = new System.Drawing.Point(32, 242);
            this.trbRed.Maximum = 255;
            this.trbRed.Name = "trbRed";
            this.trbRed.Size = new System.Drawing.Size(359, 56);
            this.trbRed.TabIndex = 4;
            this.trbRed.Scroll += new System.EventHandler(this.trbRed_Scroll);
            // 
            // lblMsg3
            // 
            this.lblMsg3.AutoSize = true;
            this.lblMsg3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg3.ForeColor = System.Drawing.Color.Green;
            this.lblMsg3.Location = new System.Drawing.Point(39, 301);
            this.lblMsg3.Name = "lblMsg3";
            this.lblMsg3.Size = new System.Drawing.Size(67, 17);
            this.lblMsg3.TabIndex = 7;
            this.lblMsg3.Text = "GREEN:";
            // 
            // trbGreen
            // 
            this.trbGreen.Location = new System.Drawing.Point(32, 330);
            this.trbGreen.Maximum = 255;
            this.trbGreen.Name = "trbGreen";
            this.trbGreen.Size = new System.Drawing.Size(359, 56);
            this.trbGreen.TabIndex = 6;
            this.trbGreen.Scroll += new System.EventHandler(this.trbGreen_Scroll);
            // 
            // lblMsg4
            // 
            this.lblMsg4.AutoSize = true;
            this.lblMsg4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsg4.ForeColor = System.Drawing.Color.Blue;
            this.lblMsg4.Location = new System.Drawing.Point(39, 389);
            this.lblMsg4.Name = "lblMsg4";
            this.lblMsg4.Size = new System.Drawing.Size(53, 17);
            this.lblMsg4.TabIndex = 9;
            this.lblMsg4.Text = "BLUE:";
            // 
            // trbBlue
            // 
            this.trbBlue.Location = new System.Drawing.Point(32, 418);
            this.trbBlue.Maximum = 255;
            this.trbBlue.Name = "trbBlue";
            this.trbBlue.Size = new System.Drawing.Size(359, 56);
            this.trbBlue.TabIndex = 8;
            this.trbBlue.Scroll += new System.EventHandler(this.trbBlue_Scroll);
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(397, 170);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(16, 17);
            this.lblTrans.TabIndex = 10;
            this.lblTrans.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(397, 246);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(16, 17);
            this.lblRed.TabIndex = 11;
            this.lblRed.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(397, 330);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(16, 17);
            this.lblGreen.TabIndex = 12;
            this.lblGreen.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(397, 419);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(16, 17);
            this.lblBlue.TabIndex = 13;
            this.lblBlue.Text = "0";
            // 
            // lblRes
            // 
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRes.Location = new System.Drawing.Point(431, 47);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(253, 52);
            this.lblRes.TabIndex = 14;
            this.lblRes.Text = "RGB";
            this.lblRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(688, 486);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblTrans);
            this.Controls.Add(this.lblMsg4);
            this.Controls.Add(this.trbBlue);
            this.Controls.Add(this.lblMsg3);
            this.Controls.Add(this.trbGreen);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.trbRed);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.trbTransparencia);
            this.Controls.Add(this.pcbCor);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmMain";
            this.Text = "Aula #051 - Cores";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbTransparencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbCor;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.TrackBar trbTransparencia;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.TrackBar trbRed;
        private System.Windows.Forms.Label lblMsg3;
        private System.Windows.Forms.TrackBar trbGreen;
        private System.Windows.Forms.Label lblMsg4;
        private System.Windows.Forms.TrackBar trbBlue;
        private System.Windows.Forms.Label lblTrans;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRes;
    }
}

