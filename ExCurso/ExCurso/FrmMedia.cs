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
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal Num1;
            decimal Num2;
            decimal Num3;
            decimal Resultado;
            

            try
            {
                Num1 = decimal.Parse(txtNotaUm.Text);
                Num2 = decimal.Parse(txtNotaDois.Text);
                Num3 = decimal.Parse(txtNotaTres.Text);
                Resultado = (Num1+Num2+Num3)/3;
                
                if (Resultado >= 7)
                {
                    MessageBox.Show(string.Format("Sua média é: {0:0.0} \nAluno Aprovado", Resultado)); 
                }
                
                else
                {
                    if (Resultado < 4)
                    {
                        MessageBox.Show(string.Format("Sua média é: {0:0.0} \nAluno Reprovado", Resultado));
                    }
                    else
                    {
                        MessageBox.Show(string.Format("Sua média é: {0:0.0} \nAluno em Recuperação", Resultado));
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Apenas números");
            }

        }
    }
}
