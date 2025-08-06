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
    public partial class FormMenuPrincipal : Form
    {
        // Variaveis globais:
        Model.Usuario usuario;
        public FormMenuPrincipal(Model.Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            lblUsuario.Text = $"Você está logado como: {usuario.NomeCompleto}";

            // Ocultar os botoes de usuarios
            if(usuario.Id != 1)
            {
                btnGestaoProdutos.Visible = false;
                btnGestaoUsuarios.Visible = false;
            }
        }

        private void btnGestaoProdutos_Click(object sender, EventArgs e)
        {
           FrmGestaoDeProdutos frmGestaoDeProdutos = new FrmGestaoDeProdutos(usuario);
            frmGestaoDeProdutos.ShowDialog();
        }

        private void btnLcmComandas_Click(object sender, EventArgs e)
        {
            FrmComandas frmComandas = new FrmComandas(usuario);
            frmComandas.ShowDialog();
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            FrmCaixa frmCaixa = new FrmCaixa(usuario);
            frmCaixa.ShowDialog();
        }

        private void btnGestaoUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmusuarios = new FrmUsuarios(usuario);
            frmusuarios.ShowDialog();  
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
