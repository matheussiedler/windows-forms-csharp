namespace Aula01
{
    partial class FormCFBCursos
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ok = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.Label();
            this.txt_input_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_ok.Location = new System.Drawing.Point(265, 5);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(46, 35);
            this.btn_ok.TabIndex = 0;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.Location = new System.Drawing.Point(12, 50);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(0, 29);
            this.lb_message.TabIndex = 1;
            // 
            // txt_input_name
            // 
            this.txt_input_name.Location = new System.Drawing.Point(12, 12);
            this.txt_input_name.Name = "txt_input_name";
            this.txt_input_name.Size = new System.Drawing.Size(242, 22);
            this.txt_input_name.TabIndex = 2;
            this.txt_input_name.Text = "Digite o seu nome";
            // 
            // FormCFBCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.txt_input_name);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_ok);
            this.Name = "FormCFBCursos";
            this.Text = "CBFCursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox txt_input_name;
    }
}

