using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manipulandoCaixaDeTexto
{
    public partial class frmFomulario : Form
    {
        public frmFomulario()
        {
            InitializeComponent();
        }

        private void txtIdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < (char)048) || (e.KeyChar > (char)057))
            {
                e.Handled = true;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)048) && (e.KeyChar <= (char)057))
            {
                e.Handled = true;
            }
        }

        private void txtMaiusc_Leave(object sender, EventArgs e)
        {
            txtMaiusc.Text = txtMaiusc.Text.ToUpper();
        }

        private void btnDel_MouseClick(object sender, MouseEventArgs e)
        {
            txtNome.Clear();
            txtIdad.Clear();
            txtMaiusc.Clear();
        }
    }
}
