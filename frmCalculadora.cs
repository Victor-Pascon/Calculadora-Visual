using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraVisual
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private bool ValidarCalculo(string validar)
        {
            return !validar.Contains("++") && !validar.Contains("--") && !validar.Contains("**") && !validar.Contains("//");

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtTela.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtTela.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtTela.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtTela.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtTela.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtTela.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtTela.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtTela.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtTela.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtTela.Text += "0";
        }

        private void btnAdsao_Click(object sender, EventArgs e)
        {
            txtTela.Text += "+";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            txtTela.Text += "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            txtTela.Text += "*";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            txtTela.Text += "/";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTela.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var Calculo = txtTela.Text;

            txtTela.MaxLength = 50;
            txtTela.ScrollBars = ScrollBars.Vertical;

            try
            {
               if (ValidarCalculo(Calculo))
                {
                    var Resultado = new DataTable().Compute(Calculo, null);

                    txtTela.Text = Resultado.ToString();
                }

                else
                {
                    MessageBox.Show("Um erro aconteceu! Tente novamente!", "Pequeno Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtTela.Clear();
                }

            }
            catch (Exception ex)
            {
                txtTela.Text = "!! Erro !!";
                MessageBox.Show($"Um erro aconteceu! Tente novamente! \n{ex}", "Pequeno Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var Confirma = MessageBox.Show("Realmente Deseja Sair?", "Sair ou não sair, eis a questão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (Confirma == DialogResult.Yes)
            {
                MessageBox.Show("Muito obrigado por testar, até jaja!", "Valeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }


        private void frmCalculadora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.PerformClick();
            }
        }
    }
}
