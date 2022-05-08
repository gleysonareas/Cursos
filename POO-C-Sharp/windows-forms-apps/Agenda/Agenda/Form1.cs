using System;
using System.IO;
using System.Windows.Forms;

namespace Agenda
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
            carregarDados();
        }

        //Configuração das caixas de texto
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= (char)048) && (e.KeyChar <= (char)057))
            {
                e.Handled = true;
            }
        }

        private void mkdTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)08)
            {
                if (e.KeyChar != (char)032)
                {
                    if ((e.KeyChar < (char)048) || (e.KeyChar > (char)057))
                    {
                        e.Handled = true;
                    }
                }
            }
            this.mkdTel.Mask = "(99) 99999-9999";
        }

        //Paramentros de configuração de botões
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!contatoSelecionado(mkdTel.Text.Trim()))
            {
                if ((txtNome.Text.Trim() != "") && (mkdTel.Text.Trim() != ""))
                {
                    if (mkdTel.Mask != "")
                    {
                        lstContato.Items.Add(txtNome.Text.Trim() + " " + "#" + " " + mkdTel.Text.Trim());
                        MessageBox.Show("Cadastro realizado com sucesso");

                        if ((txtNome.Text.Trim() != "") && (mkdTel.Text.Trim() != ""))
                        {
                            txtNome.Clear();
                            mkdTel.Clear();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Este cadastro só pode ser realizado com todos os campos devidamente preenchidos");
                }
            }
            else
            {
                MessageBox.Show("Cadastre um número diferente");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstContato.SelectedIndex >= 0)
            {
                lstContato.Items[lstContato.SelectedIndex] = txtNome.Text.Trim() + " " + "#" + " " + mkdTel.Text.Trim();
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int selectcontat = lstContato.SelectedIndex;

            if (lstContato.SelectedIndex >= 0)
            {
                lstContato.Items.RemoveAt(selectcontat);
            }
        }

        //Minhas funções
        private void salvarDados()
        {
            using (FileStream arquivo = new FileStream("contatos.Gyn", FileMode.Create))
            {
                using (StreamWriter escritor = new StreamWriter(arquivo))
                {
                    foreach (var item in lstContato.Items)
                    {
                        escritor.WriteLine(item.ToString());
                    }
                }
            }
        }

        private void carregarDados()
        {
            using (FileStream arquivo = new FileStream("contatos.Gyn", FileMode.OpenOrCreate))
            {
                using (StreamReader leitor = new StreamReader(arquivo))
                {
                    while (!leitor.EndOfStream)
                    {
                        lstContato.Items.Add(leitor.ReadLine());
                    }
                }
            }
        }

        private void lstContato_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContato.SelectedItem != null)
            {
                string itemSelecionado = lstContato.SelectedItem.ToString();
                string[] dados = itemSelecionado.Split('#');

                if (dados.Length == 2)
                {
                    txtNome.Text = dados[0];
                    mkdTel.Text = dados[1];
                }
            }
        }

        private bool contatoSelecionado(string comparaNumero)
        {
            foreach (var contato in lstContato.Items)
            {
                string[] numero = contato.ToString().Split('#');

                if (numero[1].Trim().ToLower() == comparaNumero.Trim().ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        private void frmAgenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            salvarDados();
        }
    }
}
