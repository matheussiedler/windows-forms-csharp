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
    public partial class MainForm : Form
    {
        public int num;

        public MainForm()
        {
            InitializeComponent();
            num = 0;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if(txt_veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veículo!");
                txt_veiculo.Focus();
                return;
            }

            txt_mult_veiculos.Text += txt_veiculo.Text + ", ";

            txt_veiculo.Clear();
            txt_veiculo.Focus();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_mult_veiculos.Clear();
            txt_veiculo.Focus();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            VeiculosForm veiculosForm = new VeiculosForm(txt_mult_veiculos.Text, this);
            veiculosForm.ShowDialog();
        }

        private void btn_val_num_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckboxForm checkboxForm = new CheckboxForm();
            checkboxForm.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckedListBoxForm checkedListBox = new CheckedListBoxForm();
            checkedListBox.ShowDialog();
        }
    }
}
