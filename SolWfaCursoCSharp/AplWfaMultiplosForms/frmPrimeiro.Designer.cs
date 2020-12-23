namespace AplWfaMultiplosForms
{
    partial class frmPrimeiro
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(369, 71);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(145, 49);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(369, 140);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(145, 49);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // frmPrimeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 342);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "frmPrimeiro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrimeiro_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

