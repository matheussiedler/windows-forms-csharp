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
    public partial class ChildCheckBoxForm : Form
    {
        public CheckboxForm checkboxForm;

        public ChildCheckBoxForm()
        {
            InitializeComponent();

            if (Application.OpenForms["CheckboxForm"].Created)
            {
                checkboxForm = (CheckboxForm) Application.OpenForms["CheckboxForm"]; // as CheckboxForm;
                cb_carro.Checked = checkboxForm.cb_carro.Checked;
                cb_aviao.Checked = checkboxForm.cb_aviao.Checked;
                cb_navio.Checked = checkboxForm.cb_navio.Checked;
                cb_onibus.Checked = checkboxForm.cb_onibus.Checked;
            }
            
        }

        private void cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            checkboxForm.cb_carro.Checked = cb_carro.Checked;
        }

        private void cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            checkboxForm.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            checkboxForm.cb_navio.Checked = cb_navio.Checked;
        }

        private void cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            checkboxForm.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
