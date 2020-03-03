namespace ExCurso
{
    partial class FrmMedia
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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNotaUm = new System.Windows.Forms.TextBox();
            this.txtNotaDois = new System.Windows.Forms.TextBox();
            this.txtNotaTres = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(153, 104);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNotaUm
            // 
            this.txtNotaUm.Location = new System.Drawing.Point(22, 30);
            this.txtNotaUm.Name = "txtNotaUm";
            this.txtNotaUm.Size = new System.Drawing.Size(100, 20);
            this.txtNotaUm.TabIndex = 1;
            // 
            // txtNotaDois
            // 
            this.txtNotaDois.Location = new System.Drawing.Point(139, 30);
            this.txtNotaDois.Name = "txtNotaDois";
            this.txtNotaDois.Size = new System.Drawing.Size(100, 20);
            this.txtNotaDois.TabIndex = 2;
            // 
            // txtNotaTres
            // 
            this.txtNotaTres.Location = new System.Drawing.Point(259, 30);
            this.txtNotaTres.Name = "txtNotaTres";
            this.txtNotaTres.Size = new System.Drawing.Size(100, 20);
            this.txtNotaTres.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(153, 56);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 145);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNotaTres);
            this.Controls.Add(this.txtNotaDois);
            this.Controls.Add(this.txtNotaUm);
            this.Controls.Add(this.btnSair);
            this.MaximizeBox = false;
            this.Name = "FrmMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMedia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNotaUm;
        private System.Windows.Forms.TextBox txtNotaDois;
        private System.Windows.Forms.TextBox txtNotaTres;
        private System.Windows.Forms.Button btnCalcular;
    }
}