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
    public partial class FrmUsuarios : Form
    {
        // Variavel Global
        Model.Usuario usuario;
        public FrmUsuarios(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            // Puxar o os dados da tabela 
            AtualizarDgv();
        }

        public void AtualizarDgv()
        {
            dgvUsuarios.DataSource = usuario.Listar();
        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // Validar Erro:
            if (txbCadastrarEmail.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbCadastrarNome.Text.Length < 7)
            {
                MessageBox.Show("O Nome informado é invalido!", "ERRO",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbCadastrarSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha de conter no minio 6 cacacteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar o  cadastro no bd
                //instanciar o usuario
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbCadastrarEmail.Text;
                usuario.NomeCompleto = txbCadastrarNome.Text;
                usuario.Senha = txbCadastrarSenha.Text;

                if (usuario.Cadatrar())
                {
                    MessageBox.Show("Usuario cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpar os campos de cadastro
                    txbCadastrarEmail.Clear();
                    txbCadastrarNome.Clear();
                    txbCadastrarSenha.Clear();
                    //Atualiza o dgv (reexecutando o select);
                    AtualizarDgv();
                }
                else
                {
                    MessageBox.Show("fala ao cadastrar o usuario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Validar Erro:
            if (txbEditarEmail.Text.Length < 6)
            {
                MessageBox.Show("O e-mail informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarNome.Text.Length < 7)
            {
                MessageBox.Show("O nome informado é invalido!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbEditarSenha.Text.Length < 6)
            {
                MessageBox.Show("A senha deve conter no minimo 6 caracteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Inicia a edição no bd
                this.usuario.NomeCompleto = txbEditarNome.Text;
                this.usuario.Email = txbEditarEmail.Text;
                this.usuario.Senha = txbEditarSenha.Text;

                //Executar o .Modificar()
                if (this.usuario.Modificar())
                {
                    MessageBox.Show("Usuário modificado com sucesso! ", "Sucesso!",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    //Limparos campos e desabilitar os grbs
                    grbEdicao.Enabled = false;
                    grbApagar.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbCadastrarNome.Clear();


                }
                else
                {
                    MessageBox.Show("Falha ao modificar o usuario! ", "Erro!",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                AtualizarDgv();
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            DialogResult apagar = MessageBox.Show("Tem certeza que deseja apagar este usuario?",
                "Atenção!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (apagar == DialogResult.Yes)
            {
                // o id ja esta no usuario global 
                if (this.usuario.Remover())
                {
                    MessageBox.Show("Usuario removido com sucesso", "Sucesso!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AtualizarDgv();
                    // Limpar  o campos e desabilitar os grbs
                    grbApagar.Enabled = false;
                    grbEdicao.Enabled = false;
                    txbEditarEmail.Clear();
                    txbEditarSenha.Clear();
                    txbEditarNome.Clear();
                    lblApagar.Text = "selecione o usuario que deseja apagar";
                }
                else
                {
                    MessageBox.Show("Falha ao remover usuario!!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaSelecionada = dgvUsuarios.SelectedCells[0].RowIndex;
            // atribuir os dados da linha selecionada  no grbEditar
            this.usuario.NomeCompleto = dgvUsuarios.Rows[linhaSelecionada].Cells[1].Value.ToString();
            this.usuario.Email= dgvUsuarios.Rows[linhaSelecionada].Cells[2].Value.ToString();
            this.usuario.Id = (int)dgvUsuarios.Rows[linhaSelecionada].Cells[0].Value;

            // atribuir os dados da linha selecionada no grbEditar
            txbEditarNome.Text = this.usuario.NomeCompleto;
            txbEditarEmail.Text = this.usuario.Email;
            // Ativar o grbEditor
            grbEdicao.Enabled = true;

            // Ativar o grvApagar
            grbApagar.Enabled = true;
        }

        
    }
}
