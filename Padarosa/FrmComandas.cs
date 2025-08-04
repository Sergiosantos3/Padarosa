using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padarosa
{
    public partial class FrmComandas : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        Model.Produtos produtos = new Model.Produtos();
        Model.OrdemComanda ordemComanda = new Model.OrdemComanda();
        public FrmComandas(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvComnadas.DataSource = produtos.Listar();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            // Verificar se os campos foram prenchidos
            if(txbComanda.Text == "")
            {
                MessageBox.Show("Informe o número da comnada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbProduto.Text == "")
            {
                MessageBox.Show("Informe o codigo do produto" , "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grbLançamento.Enabled = true;
                txbNome.Enabled = false;

                // desativar o grbinfo
                grbInformaçoes.Enabled = false;
            }
        }

        private void dgvComnadas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvComnadas.SelectedCells[0].RowIndex;
            //atribuir o nome do txb
            txbProduto.Text = dgvComnadas.Rows[linhaSelecionada].ToString();
            txbNome.Text = dgvComnadas.Rows[linhaSelecionada].Cells[1].Value.ToString();
        }

        private void btnLancar_Click(object sender, EventArgs e)
        {
            if(txbquantidade.Text == "")
            {
                MessageBox.Show("Informe a qauntodade do produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult r = MessageBox.Show("Tem certeza que deseja lançar " +
                    $"{txbquantidade.Text} unidades do {txbNome.Text} na comanda {txbComanda.Text}");
                // se sim
                if ( r == DialogResult.Yes )
                {
                    MessageBox.Show("Lançamento efetuado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //resetar os campos
                }
            }
        }
    }
}
