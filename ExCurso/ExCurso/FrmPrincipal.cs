using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExCurso
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void calcularMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instanciando o formulario
            FrmMedia fMedia = new FrmMedia();

            //indica que o formulario que sera aberto é filho do principal
            fMedia.MdiParent = this;

            //exibira o formulario filho
            fMedia.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente encerrar o sistema", "Pergunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if( resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Obrigado por utilizar nossos serviços e até mais!", "*** Obrigado***",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }
    }
}
