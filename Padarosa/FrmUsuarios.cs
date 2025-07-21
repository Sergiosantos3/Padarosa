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
        }
    }
}
