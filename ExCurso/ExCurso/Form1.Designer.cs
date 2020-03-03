namespace ExCurso
{
    partial class frmCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCursos));
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNumeroCurso = new System.Windows.Forms.TextBox();
            this.lblDigiteCurso = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(46, 129);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(81, 32);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(46, 185);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 37);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNumeroCurso
            // 
            this.txtNumeroCurso.Location = new System.Drawing.Point(35, 79);
            this.txtNumeroCurso.Name = "txtNumeroCurso";
            this.txtNumeroCurso.Size = new System.Drawing.Size(141, 20);
            this.txtNumeroCurso.TabIndex = 2;
            // 
            // lblDigiteCurso
            // 
            this.lblDigiteCurso.Location = new System.Drawing.Point(32, 47);
            this.lblDigiteCurso.Name = "lblDigiteCurso";
            this.lblDigiteCurso.Size = new System.Drawing.Size(230, 29);
            this.lblDigiteCurso.TabIndex = 3;
            this.lblDigiteCurso.Text = "Digite um número para o curso:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 20);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Cursos";
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDigiteCurso);
            this.Controls.Add(this.txtNumeroCurso);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCursos";
            this.Text = "Cursos - ETEC Horácio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNumeroCurso;
        private System.Windows.Forms.Label lblDigiteCurso;
        private System.Windows.Forms.Label lblTitulo;
    }
}

