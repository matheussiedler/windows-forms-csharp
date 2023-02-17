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
    public partial class ComboBoxForm : Form
    {
        public ComboBoxForm()
        {
            InitializeComponent();
        }

        private void btn_mostrar_selecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetar_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            List<string> transportes = new List<string>();
            transportes.Add("Avião");
            transportes.Add("Carro");
            transportes.Add("Moto");
            transportes.Add("Skate");
            transportes.Add("Navio");
            transportes.Add("Ônibus");
            transportes.Add("Bike");

            cb_transportes.Items.AddRange(transportes.ToArray());
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_transporte.Text != "")
            {
                if (!cb_transportes.Items.Contains(tb_transporte.Text))
                {
                    cb_transportes.Items.Add(tb_transporte.Text);
                }
            }
            else
            {
                MessageBox.Show("Digite um transporte.");
            }

            tb_transporte.Clear();
            tb_transporte.Focus();
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transportes.Text = cb_transportes.Text;
        }
    }
}
