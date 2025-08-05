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
    public partial class FrmGestaoDeProdutos : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        Model.Produtos produtos = new Produtos();
        Model.Categoria categoria = new Model.Categoria();
        public FrmGestaoDeProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            AtualizarDgv();


            //Obter as categorias do banco
            DataTable resultadoCategoria = categoria.Listar();
            foreach (DataRow linha in resultadoCategoria.Rows)
            {
                // Adicionarao combobox
                cmbCategoriaCadastrar.Items.Add($"{linha["id"]} - {linha["nome"]}");
                cmbCategoriaEditar.Items.Add($"{linha["id"]} - {linha["nome"]}");
            }
        }
        public void AtualizarDgv()
        {
            dgvProdutos.DataSource = produtos.Listar();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            // Validar Erro:
            if (double.Parse(txbCadastrarPreco.Text) == 0.00)
            {
                MessageBox.Show("O preço e invalido", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastrarProdutos.Text.Length <= 3)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastrarProdutos.Text.Length <= 0)
            {
                MessageBox.Show("A categoria nao pode ser null cacacteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar o  cadastro no bd
                //instanciar o produto
                Model.Produtos produto = new Model.Produtos();
                produto.Nome = txbCadastrarProdutos.Text;
                produto.preco = double.Parse(txbCadastrarPreco.Text);
                // obter apenas o id da categoria do combobox
                produto.id_categoria = int.Parse(cmbCategoriaCadastrar.Text.Split('-')[0]);
                produto.id_respCadastro = usuario.Id;

                if (produto.Cadatrar())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos de cadastro
                    txbCadastrarProdutos.Clear();
                    txbCadastrarPreco.Clear();
                    cmbCategoriaCadastrar.SelectedIndex = -1;
                    //Atualiza o dgv (reexecutando o select);
                    AtualizarDgv();

                }
                else
                {
                    MessageBox.Show("falha ao cadastrar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            // Validar Erro:
            if (double.Parse(txbEditarPreco.Text) == 0.00)
            {
                MessageBox.Show("O preço e invalido", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarProduto.Text.Length <= 3)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbCategoriaEditar.Text.Length <= 0)
            {
                MessageBox.Show("A categoria nao pode ser null cacacteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar o  no bd
                //instanciar o produto
                Model.Produtos produto = new Model.Produtos();
                produto.Nome = txbEditarProduto.Text;
                produto.preco = double.Parse(txbEditarPreco.Text);
                produto.id_categoria = int.Parse(cmbCategoriaEditar.Text.Split('-')[0]);
                produto.id_respCadastro = usuario.Id;
                produto.Id = this.produtos.Id;

                if (produto.Modificar())
                {
                    MessageBox.Show("Produto editado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos de cadastro
                    txbCadastrarProdutos.Clear();
                    txbCadastrarPreco.Clear();
                    cmbCategoriaCadastrar.SelectedIndex = - 1;
                    //Atualiza o dgv (reexecutando o select);
                    AtualizarDgv();

                }
                else
                {
                    MessageBox.Show("falha ao editar o produto", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnApagarProduto_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este Produto?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                // o id ja esta no usuario global 
                if (this.produtos.Remover())
                {
                    MessageBox.Show("Produto removido com sucesso", "Sucesso!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    // Limpar  o campos e desabilitar os grbs
                    grbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbEditarProduto.Clear();
                    txbEditarPreco.Clear();
                    cmbCategoriaCadastrar.SelectedIndex = - 1 ;
                    lblApagar.Text = "selecione o produto que deseja apagar";
                }
                else
                {
                    MessageBox.Show("Falha ao remover Produto!!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvProdutos.SelectedCells[0].RowIndex;
            // atribuir os dados da linha selecionada  no grbEditar
            this.produtos.Nome = dgvProdutos.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.produtos.preco = (double)dgvProdutos.Rows[linhaSelecionada].Cells[2].Value;
            this.produtos.id_categoria = (int)dgvProdutos.Rows[linhaSelecionada].Cells[3].Value;
            this.produtos.Id = (int)dgvProdutos.Rows[linhaSelecionada].Cells[0].Value;

            // atribuir os dados da linha selecionada no grbEditar
            txbEditarProduto.Text = this.produtos.Nome;
            txbEditarPreco.Text = this.produtos.preco.ToString();
            cmbCategoriaEditar.Text = this.produtos.id_categoria.ToString();
            // Ativar o grbEditor
            grbEdicao.Enabled = true;

            // Ativar o grvApagar
            grbApagar.Enabled = true;
        }

        private void txbCadastrarProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Impede o comportamento padrão do Enter (como emitir um som)
                e.SuppressKeyPress = true;


                // Move o foco para o próximo controle na ordem de tabulação
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}


        