using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Padarosa.Model;

namespace Padarosa
{
    public partial class FrmCaixa : Form
    {
        // Variavel global
        Model.Usuario usuario;
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
        public FrmCaixa(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if(txbNcomanda.Text == "")
            {
                MessageBox.Show("Informe corretamente o número da comanda!", "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ordemComanda.IdFicha = int.Parse(txbNcomanda.Text);
                DataTable consulta = ordemComanda.BusacrFicha();

                // Verificar se existem lançamento na comanda 
                if(consulta.Rows.Count == 0)
                {
                    MessageBox.Show("Não existe lançamento desta comanda!", "ERRO",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Mostrar a consulta no dgv
                    dgvCaixa.DataSource = consulta;

                    decimal valor = decimal.Parse(consulta.Compute("Sum(Total_Item)", "True").ToString());
                    // Mostrar o total no lblTotal
                    lblTotal.Text = "R$ " + valor.ToString("F");
                }
            }
        }

        private void chbPagamentoRecebido_CheckedChanged(object sender, EventArgs e)
        {
            btnEncerrarComanda.Enabled = chbPagamentoRecebido.Checked;
        }

        private void btnEncerrarComanda_Click(object sender, EventArgs e)
        {
            DialogResult pergunta = MessageBox.Show(
                $"Tem certeza que deseja encerrar a comanda {ordemComanda.IdFicha}?",
                "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(pergunta == DialogResult.Yes)
            {
                if (ordemComanda.Encerrar())
                {
                    MessageBox.Show("Comanda encerrada com sucesso", "Sucesso",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                  // Desabiltar o botão de encerrar e o chb
                  btnEncerrarComanda.Enabled = false;
                    // Limpar o dgv
                    dgvCaixa.DataSource = null;
                    // Apagar o numero da comanda
                    txbNcomanda.Clear();
                    // Resetar o lblTotal
                    lblTotal.Text = "R$ 0,00";
                }
            }
        }
    }
}
