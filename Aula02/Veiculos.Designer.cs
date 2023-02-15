namespace Aula02
{
    partial class VeiculosForm
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
            this.txt_multi_veiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_multi_veiculos
            // 
            this.txt_multi_veiculos.Location = new System.Drawing.Point(8, 12);
            this.txt_multi_veiculos.Multiline = true;
            this.txt_multi_veiculos.Name = "txt_multi_veiculos";
            this.txt_multi_veiculos.Size = new System.Drawing.Size(578, 467);
            this.txt_multi_veiculos.TabIndex = 0;
            // 
            // VeiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 491);
            this.Controls.Add(this.txt_multi_veiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "VeiculosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VeiculosForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_multi_veiculos;
    }
}