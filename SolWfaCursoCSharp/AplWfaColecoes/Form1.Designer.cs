namespace AplWfaColecoes
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.lstLista = new System.Windows.Forms.ListBox();
            this.btnList2 = new System.Windows.Forms.Button();
            this.btnHashSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(283, 12);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(141, 51);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "List";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // lstLista
            // 
            this.lstLista.FormattingEnabled = true;
            this.lstLista.Location = new System.Drawing.Point(12, 12);
            this.lstLista.Name = "lstLista";
            this.lstLista.Size = new System.Drawing.Size(265, 251);
            this.lstLista.TabIndex = 1;
            // 
            // btnList2
            // 
            this.btnList2.Location = new System.Drawing.Point(283, 69);
            this.btnList2.Name = "btnList2";
            this.btnList2.Size = new System.Drawing.Size(141, 51);
            this.btnList2.TabIndex = 0;
            this.btnList2.Text = "List inline";
            this.btnList2.UseVisualStyleBackColor = true;
            this.btnList2.Click += new System.EventHandler(this.btnList2_Click);
            // 
            // btnHashSet
            // 
            this.btnHashSet.Location = new System.Drawing.Point(283, 126);
            this.btnHashSet.Name = "btnHashSet";
            this.btnHashSet.Size = new System.Drawing.Size(141, 51);
            this.btnHashSet.TabIndex = 2;
            this.btnHashSet.Text = "HashSet";
            this.btnHashSet.UseVisualStyleBackColor = true;
            this.btnHashSet.Click += new System.EventHandler(this.btnHashSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 281);
            this.Controls.Add(this.btnHashSet);
            this.Controls.Add(this.lstLista);
            this.Controls.Add(this.btnList2);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox lstLista;
        private System.Windows.Forms.Button btnList2;
        private System.Windows.Forms.Button btnHashSet;
    }
}

