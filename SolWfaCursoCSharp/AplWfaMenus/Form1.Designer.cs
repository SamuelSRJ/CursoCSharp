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
            this.mnu_file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_file_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBlock = new System.Windows.Forms.Button();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenuGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenuGeral
            // 
            this.msMenuGeral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMenuGeral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.editToolStripMenuItem});
            this.msMenuGeral.Location = new System.Drawing.Point(0, 0);
            this.msMenuGeral.Name = "msMenuGeral";
            this.msMenuGeral.Size = new System.Drawing.Size(702, 28);
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
            this.mnu_file.Size = new System.Drawing.Size(44, 24);
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
            // mnu_file_open
            // 
            this.mnu_file_open.Name = "mnu_file_open";
            this.mnu_file_open.Size = new System.Drawing.Size(216, 26);
            this.mnu_file_open.Text = "Open";
            // 
            // mnu_file_new_project
            // 
            this.mnu_file_new_project.Name = "mnu_file_new_project";
            this.mnu_file_new_project.Size = new System.Drawing.Size(216, 26);
            this.mnu_file_new_project.Text = "Project";
            // 
            // mnu_file_new_file
            // 
            this.mnu_file_new_file.Name = "mnu_file_new_file";
            this.mnu_file_new_file.Size = new System.Drawing.Size(216, 26);
            this.mnu_file_new_file.Text = "File";
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
            // btnBlock
            // 
            this.btnBlock.Location = new System.Drawing.Point(268, 264);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(148, 45);
            this.btnBlock.TabIndex = 1;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.propertiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(213, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.propertiesToolStripMenuItem.Text = "Properties...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 343);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.msMenuGeral);
            this.MainMenuStrip = this.msMenuGeral;
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
    }
}

