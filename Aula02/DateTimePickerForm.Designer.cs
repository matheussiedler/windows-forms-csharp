namespace Aula02
{
    partial class DateTimePickerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_obter_data = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_dia = new System.Windows.Forms.TextBox();
            this.tb_mes = new System.Windows.Forms.TextBox();
            this.tb_ano = new System.Windows.Forms.TextBox();
            this.btn_alterar_data = new System.Windows.Forms.Button();
            this.btn_hoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 12);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(333, 22);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_obter_data
            // 
            this.btn_obter_data.Location = new System.Drawing.Point(351, 8);
            this.btn_obter_data.Name = "btn_obter_data";
            this.btn_obter_data.Size = new System.Drawing.Size(161, 28);
            this.btn_obter_data.TabIndex = 1;
            this.btn_obter_data.Text = "Obter Data";
            this.btn_obter_data.UseVisualStyleBackColor = true;
            this.btn_obter_data.Click += new System.EventHandler(this.btn_obter_data_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 40);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(333, 22);
            this.tb_data.TabIndex = 2;
            // 
            // tb_dia
            // 
            this.tb_dia.Location = new System.Drawing.Point(12, 68);
            this.tb_dia.Name = "tb_dia";
            this.tb_dia.Size = new System.Drawing.Size(107, 22);
            this.tb_dia.TabIndex = 3;
            // 
            // tb_mes
            // 
            this.tb_mes.Location = new System.Drawing.Point(125, 68);
            this.tb_mes.Name = "tb_mes";
            this.tb_mes.Size = new System.Drawing.Size(107, 22);
            this.tb_mes.TabIndex = 4;
            // 
            // tb_ano
            // 
            this.tb_ano.Location = new System.Drawing.Point(238, 68);
            this.tb_ano.Name = "tb_ano";
            this.tb_ano.Size = new System.Drawing.Size(107, 22);
            this.tb_ano.TabIndex = 5;
            // 
            // btn_alterar_data
            // 
            this.btn_alterar_data.Location = new System.Drawing.Point(351, 64);
            this.btn_alterar_data.Name = "btn_alterar_data";
            this.btn_alterar_data.Size = new System.Drawing.Size(161, 30);
            this.btn_alterar_data.TabIndex = 6;
            this.btn_alterar_data.Text = "Alterar Data";
            this.btn_alterar_data.UseVisualStyleBackColor = true;
            this.btn_alterar_data.Click += new System.EventHandler(this.btn_alterar_data_Click);
            // 
            // btn_hoje
            // 
            this.btn_hoje.Location = new System.Drawing.Point(351, 100);
            this.btn_hoje.Name = "btn_hoje";
            this.btn_hoje.Size = new System.Drawing.Size(161, 30);
            this.btn_hoje.TabIndex = 7;
            this.btn_hoje.Text = "Hoje";
            this.btn_hoje.UseVisualStyleBackColor = true;
            this.btn_hoje.Click += new System.EventHandler(this.btn_hoje_Click);
            // 
            // DateTimePickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 548);
            this.Controls.Add(this.btn_hoje);
            this.Controls.Add(this.btn_alterar_data);
            this.Controls.Add(this.tb_ano);
            this.Controls.Add(this.tb_mes);
            this.Controls.Add(this.tb_dia);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_obter_data);
            this.Controls.Add(this.dtp_data);
            this.Name = "DateTimePickerForm";
            this.Text = "DateTimePickerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_obter_data;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_dia;
        private System.Windows.Forms.TextBox tb_mes;
        private System.Windows.Forms.TextBox tb_ano;
        private System.Windows.Forms.Button btn_alterar_data;
        private System.Windows.Forms.Button btn_hoje;
    }
}