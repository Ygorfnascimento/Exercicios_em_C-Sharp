namespace LOPAL_Ygor
{
    partial class Form1
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
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblValor01 = new System.Windows.Forms.Label();
            this.LblValor02 = new System.Windows.Forms.Label();
            this.LblValor03 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.GroupBox();
            this.LblMenor = new System.Windows.Forms.Label();
            this.LblMaior = new System.Windows.Forms.Label();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.TxtValor01 = new System.Windows.Forms.TextBox();
            this.TxtValor02 = new System.Windows.Forms.TextBox();
            this.TxtValor03 = new System.Windows.Forms.TextBox();
            this.txtResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(47, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(325, 33);
            this.LblTitulo.TabIndex = 0;
            this.LblTitulo.Text = "Atividade - Maior ou Menor";
            // 
            // LblValor01
            // 
            this.LblValor01.AutoSize = true;
            this.LblValor01.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor01.Location = new System.Drawing.Point(25, 73);
            this.LblValor01.Name = "LblValor01";
            this.LblValor01.Size = new System.Drawing.Size(72, 23);
            this.LblValor01.TabIndex = 1;
            this.LblValor01.Text = "Valor01:";
            // 
            // LblValor02
            // 
            this.LblValor02.AutoSize = true;
            this.LblValor02.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor02.Location = new System.Drawing.Point(25, 125);
            this.LblValor02.Name = "LblValor02";
            this.LblValor02.Size = new System.Drawing.Size(72, 23);
            this.LblValor02.TabIndex = 2;
            this.LblValor02.Text = "Valor02:";
            // 
            // LblValor03
            // 
            this.LblValor03.AutoSize = true;
            this.LblValor03.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValor03.Location = new System.Drawing.Point(25, 176);
            this.LblValor03.Name = "LblValor03";
            this.LblValor03.Size = new System.Drawing.Size(72, 23);
            this.LblValor03.TabIndex = 3;
            this.LblValor03.Text = "Valor03:";
            // 
            // txtResultado
            // 
            this.txtResultado.Controls.Add(this.LblMenor);
            this.txtResultado.Controls.Add(this.LblMaior);
            this.txtResultado.Location = new System.Drawing.Point(103, 223);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(282, 128);
            this.txtResultado.TabIndex = 4;
            this.txtResultado.TabStop = false;
            this.txtResultado.Text = "Resultado";
            // 
            // LblMenor
            // 
            this.LblMenor.AutoSize = true;
            this.LblMenor.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMenor.Location = new System.Drawing.Point(16, 95);
            this.LblMenor.Name = "LblMenor";
            this.LblMenor.Size = new System.Drawing.Size(44, 16);
            this.LblMenor.TabIndex = 1;
            this.LblMenor.Text = "Menor:";
            // 
            // LblMaior
            // 
            this.LblMaior.AutoSize = true;
            this.LblMaior.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaior.Location = new System.Drawing.Point(16, 35);
            this.LblMaior.Name = "LblMaior";
            this.LblMaior.Size = new System.Drawing.Size(40, 16);
            this.LblMaior.TabIndex = 0;
            this.LblMaior.Text = "Maior:";
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(142, 379);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(156, 48);
            this.BtnCalcular.TabIndex = 5;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // TxtValor01
            // 
            this.TxtValor01.Location = new System.Drawing.Point(103, 73);
            this.TxtValor01.Multiline = true;
            this.TxtValor01.Name = "TxtValor01";
            this.TxtValor01.Size = new System.Drawing.Size(208, 25);
            this.TxtValor01.TabIndex = 2;
            // 
            // TxtValor02
            // 
            this.TxtValor02.Location = new System.Drawing.Point(103, 125);
            this.TxtValor02.Multiline = true;
            this.TxtValor02.Name = "TxtValor02";
            this.TxtValor02.Size = new System.Drawing.Size(208, 25);
            this.TxtValor02.TabIndex = 6;
            // 
            // TxtValor03
            // 
            this.TxtValor03.Location = new System.Drawing.Point(103, 176);
            this.TxtValor03.Multiline = true;
            this.TxtValor03.Name = "TxtValor03";
            this.TxtValor03.Size = new System.Drawing.Size(208, 25);
            this.TxtValor03.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 450);
            this.Controls.Add(this.TxtValor03);
            this.Controls.Add(this.TxtValor02);
            this.Controls.Add(this.TxtValor01);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.LblValor03);
            this.Controls.Add(this.LblValor02);
            this.Controls.Add(this.LblValor01);
            this.Controls.Add(this.LblTitulo);
            this.Name = "Form1";
            this.Text = " ";
            this.txtResultado.ResumeLayout(false);
            this.txtResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblValor01;
        private System.Windows.Forms.Label LblValor02;
        private System.Windows.Forms.Label LblValor03;
        private System.Windows.Forms.GroupBox txtResultado;
        private System.Windows.Forms.Label LblMenor;
        private System.Windows.Forms.Label LblMaior;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.TextBox TxtValor01;
        private System.Windows.Forms.TextBox TxtValor02;
        private System.Windows.Forms.TextBox TxtValor03;
    }
}

