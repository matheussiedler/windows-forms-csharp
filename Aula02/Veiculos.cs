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
    public partial class VeiculosForm : Form
    {
        MainForm mainF = new MainForm();

        public VeiculosForm(String veiculos, MainForm mainForm)
        {
            InitializeComponent();

            txt_multi_veiculos.Text = veiculos;

            mainF = mainForm;
            mainForm.num = 7;
        }

        private void VeiculosForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainF.txt_mult_veiculos.Text = txt_multi_veiculos.Text;
        }
    }
}
