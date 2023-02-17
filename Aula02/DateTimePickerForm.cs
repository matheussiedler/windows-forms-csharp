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
    public partial class DateTimePickerForm : Form
    {
        public DateTimePickerForm()
        {
            InitializeComponent();
        }

        private void btn_obter_data_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;

            tb_dia.Text = dtp_data.Value.Day.ToString();
            tb_mes.Text = dtp_data.Value.Month.ToString();
            tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void btn_alterar_data_Click(object sender, EventArgs e)
        {
            int day, month, year;

            day = int.Parse(tb_dia.Text);
            month = int.Parse(tb_mes.Text);
            year = int.Parse(tb_ano.Text);

            DateTime dateTime= new DateTime(year, month, day);

            dtp_data.Value = dateTime;
        }

        private void btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Now;
        }
    }
}
