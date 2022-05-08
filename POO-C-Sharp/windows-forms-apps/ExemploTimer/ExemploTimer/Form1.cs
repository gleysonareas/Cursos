using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploTimer
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            this.BackColor = Color.Aquamarine;
            InitializeComponent();
            if(timer1.Enabled == true)
            {
                this.Text = "timer ligado";
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            textBox2.Text = (int.Parse(textBox2.Text) + 2).ToString();
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                this.Text = "Timer Desligado";  
            }
            else
            {
                timer1.Enabled = true;
                this.Text = "Timer Ligado";
            }
        }
    }
}
