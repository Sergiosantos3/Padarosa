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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntar_Click(object sender, EventArgs e)
        {
            if(txbEmail.Text.Length < 6)
            {
                MessageBox.Show("E-mail invalido!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txbSenha.Text.Length < 3)
            {
                MessageBox.Show("Senha invalida ou correta!", "Erro",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // instanciar um obj do tipo usuario;
                Model.Usuario usuario = new Model.Usuario();
                usuario.Email = txbEmail.Text;
                usuario.Senha = txbSenha.Text;
                // variavel p/ armazenar o resultado do logar (SELECT)
                DataTable resultado = new DataTable();
                resultado = usuario.Logar();

                // Verificar se a tabela tem ao menos uma linha
                if(resultado.Rows.Count > 0)
                {
                    MessageBox.Show("OK");
                    // armazenar as infos do usuarios do obj
                    usuario.NomeCompleto = resultado.Rows[0]["nome_completo"].ToString();
                    usuario.Id = (int)resultado.Rows[0]["id"];

                    // Mudar para o menu Principal
                    FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal(usuario);
                    this.Hide();
                    formMenuPrincipal.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha invalida!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
