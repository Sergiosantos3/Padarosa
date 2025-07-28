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
        public FrmGestaoDeProdutos(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
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
            else if (txbCadastrarCategoria.Text.Length <= 0)
            {
                MessageBox.Show("A senha de conter no minio 6 cacacteres!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Iniciar o  cadastro no bd
                //instanciar o usuario
                Model.Usuario usuario = new Model.Usuario();
                usuario. = txbCadastrarEmail.Text;
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
}
