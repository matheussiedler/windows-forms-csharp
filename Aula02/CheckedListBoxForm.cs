using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula02
{
    public partial class CheckedListBoxForm : Form
    {
        public CheckedListBoxForm()
        {
            InitializeComponent();
        }

        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            tb_selecionados.Text = "";
            foreach (string transporte in clb_transportes.CheckedItems)
            {
                tb_selecionados.Text += transporte + ", ";
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
            /*clb_transportes.Items.Add("Carro", false);
            clb_transportes.Items.Add("Avião", false);
            clb_transportes.Items.Add("Navio", false);
            clb_transportes.Items.Add("Moto", false);
            clb_transportes.Items.Add("Bike", false);
            clb_transportes.Items.Add("Ônibus", false);
            clb_transportes.Items.Add("Patinete", false);*/

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Moto");
            tr.Add("Bike");
            tr.Add("Ônibus");
            tr.Add("Patinete");

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_novo_transporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novo_transporte.Text);
                tb_novo_transporte.Clear();
            }
            else
            {
                MessageBox.Show("Digite um transporte.");
            }
            tb_novo_transporte.Focus();
        }
    }
}
