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
    }
}
