namespace Aula02
{
    partial class ComboBoxForm
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
            this.cb_transportes = new System.Windows.Forms.ComboBox();
            this.btn_mostrar_selecionados = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_resetar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.tb_transporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_transportes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_transportes
            // 
            this.cb_transportes.FormattingEnabled = true;
            this.cb_transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Moto",
            "Skate",
            "Bike",
            "Ônibus"});
            this.cb_transportes.Location = new System.Drawing.Point(12, 12);
            this.cb_transportes.Name = "cb_transportes";
            this.cb_transportes.Size = new System.Drawing.Size(292, 24);
            this.cb_transportes.TabIndex = 0;
            this.cb_transportes.SelectedIndexChanged += new System.EventHandler(this.cb_transportes_SelectedIndexChanged);
            // 
            // btn_mostrar_selecionados
            // 
            this.btn_mostrar_selecionados.Location = new System.Drawing.Point(310, 12);
            this.btn_mostrar_selecionados.Name = "btn_mostrar_selecionados";
            this.btn_mostrar_selecionados.Size = new System.Drawing.Size(280, 23);
            this.btn_mostrar_selecionados.TabIndex = 1;
            this.btn_mostrar_selecionados.Text = "Mostrar Selecionado";
            this.btn_mostrar_selecionados.UseVisualStyleBackColor = true;
            this.btn_mostrar_selecionados.Click += new System.EventHandler(this.btn_mostrar_selecionados_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Limpar elementos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_resetar
            // 
            this.btn_resetar.Location = new System.Drawing.Point(309, 70);
            this.btn_resetar.Name = "btn_resetar";
            this.btn_resetar.Size = new System.Drawing.Size(280, 23);
            this.btn_resetar.TabIndex = 3;
            this.btn_resetar.Text = "Resetar elementos";
            this.btn_resetar.UseVisualStyleBackColor = true;
            this.btn_resetar.Click += new System.EventHandler(this.btn_resetar_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(310, 164);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(280, 23);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Adicionar elemento";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tb_transporte
            // 
            this.tb_transporte.Location = new System.Drawing.Point(310, 136);
            this.tb_transporte.Name = "tb_transporte";
            this.tb_transporte.Size = new System.Drawing.Size(280, 22);
            this.tb_transporte.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Digite um transporte:";
            // 
            // tb_transportes
            // 
            this.tb_transportes.Location = new System.Drawing.Point(12, 45);
            this.tb_transportes.Multiline = true;
            this.tb_transportes.Name = "tb_transportes";
            this.tb_transportes.ReadOnly = true;
            this.tb_transportes.Size = new System.Drawing.Size(292, 141);
            this.tb_transportes.TabIndex = 7;
            // 
            // ComboBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 541);
            this.Controls.Add(this.tb_transportes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_transporte);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_resetar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_mostrar_selecionados);
            this.Controls.Add(this.cb_transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ComboBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBoxForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_transportes;
        private System.Windows.Forms.Button btn_mostrar_selecionados;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_resetar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.TextBox tb_transporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_transportes;
    }
}