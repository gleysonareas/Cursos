using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_Completa_form_01_
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            Decimal num1, num2;

            num1 = Decimal.Parse(txtNum1.Text);
            num2 = Decimal.Parse(txtNum2.Text);

            if (optSoma.Checked)
            {
                txtResultado.Text = (num1 + num2).ToString();
            }
            if (optSubtracao.Checked)
            {
                txtResultado.Text = (num1 - num2).ToString();
            }
            if (optMultiplicar.Checked)
            {
                txtResultado.Text = (num1 * num2).ToString();
            }
            if (optDividir.Checked)
            {
                txtResultado.Text = (num1 / num2).ToString();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }
    }
}
