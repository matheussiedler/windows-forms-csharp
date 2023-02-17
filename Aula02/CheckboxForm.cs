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
    public partial class CheckboxForm : Form
    {
        List<CheckBox> transportes = new List<CheckBox>();

        public CheckboxForm()
        {
            InitializeComponent();
            transportes.Add(cb_carro);
            transportes.Add(cb_aviao);
            transportes.Add(cb_navio);
            transportes.Add(cb_onibus);
        }

        private void btn_transportes_Click(object sender, EventArgs e)
        {
            string txt = "";

            /*if (cb_carro.Checked)
            {
                txt += cb_carro.Text + ", ";
            }

            if (cb_aviao.Checked)
            {
                txt += cb_aviao.Text + ", ";
            }

            if (cb_navio.Checked)
            {
                txt += cb_navio.Text + ", ";
            }

            if (cb_onibus.Checked)
            {
                txt += cb_onibus.Text + ", ";
            }*/

            foreach (CheckBox transporte in transportes)
            {
                if (transporte.Checked)
                {
                    txt += transporte.Text + ", ";
                }
            }

            tb_transportes.Text = txt;
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked)
            {
                MessageBox.Show("Patinete Marcado!");
            }
        }

        private void btn_outro_form_Click(object sender, EventArgs e)
        {
            ChildCheckBoxForm childCheckBoxForm = new ChildCheckBoxForm();
            childCheckBoxForm.ShowDialog();
        }
    }
}
