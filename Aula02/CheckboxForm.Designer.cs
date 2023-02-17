namespace Aula02
{
    partial class CheckboxForm
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
            this.cb_carro = new System.Windows.Forms.CheckBox();
            this.cb_aviao = new System.Windows.Forms.CheckBox();
            this.cb_navio = new System.Windows.Forms.CheckBox();
            this.cb_onibus = new System.Windows.Forms.CheckBox();
            this.btn_transportes = new System.Windows.Forms.Button();
            this.tb_transportes = new System.Windows.Forms.TextBox();
            this.cb_patinete = new System.Windows.Forms.CheckBox();
            this.btn_outro_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_carro
            // 
            this.cb_carro.AutoSize = true;
            this.cb_carro.Location = new System.Drawing.Point(12, 12);
            this.cb_carro.Name = "cb_carro";
            this.cb_carro.Size = new System.Drawing.Size(62, 20);
            this.cb_carro.TabIndex = 0;
            this.cb_carro.Text = "Carro";
            this.cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            this.cb_aviao.AutoSize = true;
            this.cb_aviao.Location = new System.Drawing.Point(12, 38);
            this.cb_aviao.Name = "cb_aviao";
            this.cb_aviao.Size = new System.Drawing.Size(64, 20);
            this.cb_aviao.TabIndex = 1;
            this.cb_aviao.Text = "Avião";
            this.cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            this.cb_navio.AutoSize = true;
            this.cb_navio.Location = new System.Drawing.Point(12, 64);
            this.cb_navio.Name = "cb_navio";
            this.cb_navio.Size = new System.Drawing.Size(65, 20);
            this.cb_navio.TabIndex = 2;
            this.cb_navio.Text = "Navio";
            this.cb_navio.UseVisualStyleBackColor = true;
            // 
            // cb_onibus
            // 
            this.cb_onibus.AutoSize = true;
            this.cb_onibus.Location = new System.Drawing.Point(12, 90);
            this.cb_onibus.Name = "cb_onibus";
            this.cb_onibus.Size = new System.Drawing.Size(71, 20);
            this.cb_onibus.TabIndex = 3;
            this.cb_onibus.Text = "Ônibus";
            this.cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transportes
            // 
            this.btn_transportes.Location = new System.Drawing.Point(159, 9);
            this.btn_transportes.Name = "btn_transportes";
            this.btn_transportes.Size = new System.Drawing.Size(194, 23);
            this.btn_transportes.TabIndex = 4;
            this.btn_transportes.Text = "Transportes Marcados";
            this.btn_transportes.UseVisualStyleBackColor = true;
            this.btn_transportes.Click += new System.EventHandler(this.btn_transportes_Click);
            // 
            // tb_transportes
            // 
            this.tb_transportes.Location = new System.Drawing.Point(159, 38);
            this.tb_transportes.Multiline = true;
            this.tb_transportes.Name = "tb_transportes";
            this.tb_transportes.ReadOnly = true;
            this.tb_transportes.Size = new System.Drawing.Size(193, 179);
            this.tb_transportes.TabIndex = 5;
            // 
            // cb_patinete
            // 
            this.cb_patinete.AutoSize = true;
            this.cb_patinete.Location = new System.Drawing.Point(12, 116);
            this.cb_patinete.Name = "cb_patinete";
            this.cb_patinete.Size = new System.Drawing.Size(78, 20);
            this.cb_patinete.TabIndex = 6;
            this.cb_patinete.Text = "Patinete";
            this.cb_patinete.UseVisualStyleBackColor = true;
            this.cb_patinete.CheckedChanged += new System.EventHandler(this.cb_patinete_CheckedChanged);
            // 
            // btn_outro_form
            // 
            this.btn_outro_form.Location = new System.Drawing.Point(159, 223);
            this.btn_outro_form.Name = "btn_outro_form";
            this.btn_outro_form.Size = new System.Drawing.Size(194, 23);
            this.btn_outro_form.TabIndex = 7;
            this.btn_outro_form.Text = "Abrir o outro formulário";
            this.btn_outro_form.UseVisualStyleBackColor = true;
            this.btn_outro_form.Click += new System.EventHandler(this.btn_outro_form_Click);
            // 
            // CheckboxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 254);
            this.Controls.Add(this.btn_outro_form);
            this.Controls.Add(this.cb_patinete);
            this.Controls.Add(this.tb_transportes);
            this.Controls.Add(this.btn_transportes);
            this.Controls.Add(this.cb_onibus);
            this.Controls.Add(this.cb_navio);
            this.Controls.Add(this.cb_aviao);
            this.Controls.Add(this.cb_carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckboxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_transportes;
        private System.Windows.Forms.TextBox tb_transportes;
        private System.Windows.Forms.CheckBox cb_patinete;
        public System.Windows.Forms.CheckBox cb_carro;
        public System.Windows.Forms.CheckBox cb_aviao;
        public System.Windows.Forms.CheckBox cb_navio;
        public System.Windows.Forms.CheckBox cb_onibus;
        private System.Windows.Forms.Button btn_outro_form;
    }
}