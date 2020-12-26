namespace AplWfaMenus
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
            this.msMenuGeral = new System.Windows.Forms.MenuStrip();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_edit_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_edit_properties = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_cmb1 = new System.Windows.Forms.ToolStripComboBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnCombo = new System.Windows.Forms.Button();
            this.lblTexto = new System.Windows.Forms.Label();
            this.msMenuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuGeral
            // 
            this.msMenuGeral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.mnu_edit,
            this.mnu_cmb1});
            this.msMenuGeral.Location = new System.Drawing.Point(0, 0);
            this.msMenuGeral.Name = "msMenuGeral";
            this.msMenuGeral.Size = new System.Drawing.Size(702, 32);
            this.msMenuGeral.TabIndex = 0;
            this.msMenuGeral.Text = "menuStrip1";
            // 
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_new,
            this.mnu_file_open,
            this.toolStripSeparator1,
            this.mnu_file_exit});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.Size = new System.Drawing.Size(44, 28);
            this.mnu_file.Text = "File";
            // 
            // mnu_file_new
            // 
            this.mnu_file_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file_new_project,
            this.mnu_file_new_file});
            this.mnu_file_new.Name = "mnu_file_new";
            this.mnu_file_new.Size = new System.Drawing.Size(216, 26);
            this.mnu_file_new.Text = "New";
            // 
            // mnu_file_new_project
            // 
            this.mnu_file_new_project.Name = "mnu_file_new_project";
            this.mnu_file_new_project.Size = new System.Drawing.Size(130, 26);
            this.mnu_file_new_project.Text = "Project";
            // 
            // mnu_file_new_file
            // 
            this.mnu_file_new_file.Name = "mnu_file_new_file";
            this.mnu_file_new_file.Size = new System.Drawing.Size(130, 26);
            this.mnu_file_new_file.Text = "File";
            // 
            // mnu_file_open
            // 
            this.mnu_file_open.Name = "mnu_file_open";
            this.mnu_file_open.Size = new System.Drawing.Size(216, 26);
            this.mnu_file_open.Text = "Open";
            this.mnu_file_open.Click += new System.EventHandler(this.mnu_file_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // mnu_file_exit
            // 
            this.mnu_file_exit.Name = "mnu_file_exit";
            this.mnu_file_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnu_file_exit.Size = new System.Drawing.Size(216, 26);
            this.mnu_file_exit.Text = "Exit";
            this.mnu_file_exit.Click += new System.EventHandler(this.mnu_file_exit_Click);
            // 
            // mnu_edit
            // 
            this.mnu_edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_edit_copy,
            this.mnu_edit_paste,
            this.toolStripSeparator2,
            this.mnu_edit_properties});
            this.mnu_edit.Name = "mnu_edit";
            this.mnu_edit.Size = new System.Drawing.Size(47, 28);
            this.mnu_edit.Text = "Edit";
            // 
            // mnu_edit_copy
            // 
            this.mnu_edit_copy.Name = "mnu_edit_copy";
            this.mnu_edit_copy.Size = new System.Drawing.Size(160, 26);
            this.mnu_edit_copy.Text = "Copy";
            // 
            // mnu_edit_paste
            // 
            this.mnu_edit_paste.Name = "mnu_edit_paste";
            this.mnu_edit_paste.Size = new System.Drawing.Size(160, 26);
            this.mnu_edit_paste.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(157, 6);
            // 
            // mnu_edit_properties
            // 
            this.mnu_edit_properties.Name = "mnu_edit_properties";
            this.mnu_edit_properties.Size = new System.Drawing.Size(160, 26);
            this.mnu_edit_properties.Text = "Properties...";
            // 
            // mnu_cmb1
            // 
            this.mnu_cmb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mnu_cmb1.Name = "mnu_cmb1";
            this.mnu_cmb1.Size = new System.Drawing.Size(121, 28);
            this.mnu_cmb1.SelectedIndexChanged += new System.EventHandler(this.mnu_cmb1_SelectedIndexChanged);
            // 
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(360, 261);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(148, 45);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(206, 261);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(148, 45);
            this.btnCombo.TabIndex = 2;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTexto.Location = new System.Drawing.Point(232, 132);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(252, 59);
            this.lblTexto.TabIndex = 3;
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 343);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.btnCombo);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.msMenuGeral);
            this.MainMenuStrip = this.msMenuGeral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.msMenuGeral.ResumeLayout(false);
            this.msMenuGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuGeral;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_new_project;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_new_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_open;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_file_exit;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit_copy;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit_paste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnu_edit_properties;
        private System.Windows.Forms.ToolStripComboBox mnu_cmb1;
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.Label lblTexto;
    }
}

