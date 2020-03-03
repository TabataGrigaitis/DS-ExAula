namespace ExCurso
{
    partial class FrmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAlunos = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularMédiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlunos,
            this.btnSair});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(800, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuAlunos
            // 
            this.mnuAlunos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularMédiaToolStripMenuItem});
            this.mnuAlunos.Name = "mnuAlunos";
            this.mnuAlunos.Size = new System.Drawing.Size(56, 20);
            this.mnuAlunos.Text = "Alunos";
            // 
            // calcularMédiaToolStripMenuItem
            // 
            this.calcularMédiaToolStripMenuItem.Name = "calcularMédiaToolStripMenuItem";
            this.calcularMédiaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.calcularMédiaToolStripMenuItem.Text = "Calcular Média";
            this.calcularMédiaToolStripMenuItem.Click += new System.EventHandler(this.calcularMédiaToolStripMenuItem_Click);
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(38, 20);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuAlunos;
        private System.Windows.Forms.ToolStripMenuItem calcularMédiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
    }
}