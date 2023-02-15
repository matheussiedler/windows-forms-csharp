using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula01
{
    public partial class FormCFBCursos : Form
    {
        public FormCFBCursos()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string user_name = txt_input_name.Text;

            lb_message.Text = "Olá, " + user_name + "! Seja Bem-Vindo!";
        }
    }
}
