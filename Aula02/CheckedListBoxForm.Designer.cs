namespace Aula02
{
    partial class CheckedListBoxForm
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
            this.clb_transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_mostrar_selecionados = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_novo_transporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_selecionados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clb_transportes
            // 
            this.clb_transportes.FormattingEnabled = true;
            this.clb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Moto",
            "Ônibus",
            "Navio",
            "Skate",
            "Patinete"});
            this.clb_transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_transportes.Name = "clb_transportes";
            this.clb_transportes.Size = new System.Drawing.Size(179, 293);
            this.clb_transportes.TabIndex = 0;
            // 
            // btn_mostrar_selecionados
            // 
            this.btn_mostrar_selecionados.Location = new System.Drawing.Point(197, 12);
            this.btn_mostrar_selecionados.Name = "btn_mostrar_selecionados";
            this.btn_mostrar_selecionados.Size = new System.Drawing.Size(253, 31);
            this.btn_mostrar_selecionados.TabIndex = 1;
            this.btn_mostrar_selecionados.Text = "Mostrar Selecionados";
            this.btn_mostrar_selecionados.UseVisualStyleBackColor = true;
            this.btn_mostrar_selecionados.Click += new System.EventHandler(this.btn_mostrar_selecionados_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(197, 156);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(253, 31);
            this.btn_limpar.TabIndex = 2;
            this.btn_limpar.Text = "Limpar Lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(197, 193);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(253, 31);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar Lista";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(197, 274);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(253, 31);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar Novo Transporte";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_novo_transporte
            // 
            this.tb_novo_transporte.Location = new System.Drawing.Point(197, 246);
            this.tb_novo_transporte.Name = "tb_novo_transporte";
            this.tb_novo_transporte.Size = new System.Drawing.Size(253, 22);
            this.tb_novo_transporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um novo transporte:";
            // 
            // tb_selecionados
            // 
            this.tb_selecionados.Location = new System.Drawing.Point(197, 49);
            this.tb_selecionados.Multiline = true;
            this.tb_selecionados.Name = "tb_selecionados";
            this.tb_selecionados.ReadOnly = true;
            this.tb_selecionados.Size = new System.Drawing.Size(253, 101);
            this.tb_selecionados.TabIndex = 7;
            // 
            // CheckedListBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 576);
            this.Controls.Add(this.tb_selecionados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_novo_transporte);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_mostrar_selecionados);
            this.Controls.Add(this.clb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckedListBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Checked List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_transportes;
        private System.Windows.Forms.Button btn_mostrar_selecionados;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_novo_transporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_selecionados;
    }
}