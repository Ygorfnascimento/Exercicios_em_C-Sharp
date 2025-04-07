namespace LOPAL_Ygor
{
    partial class Atividade_2
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
            this.LblTitluo = new System.Windows.Forms.Label();
            this.TxtPeso = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.RbMercúrio = new System.Windows.Forms.RadioButton();
            this.RbMarte = new System.Windows.Forms.RadioButton();
            this.RbSaturno = new System.Windows.Forms.RadioButton();
            this.RbUrano = new System.Windows.Forms.RadioButton();
            this.RbJúpiter = new System.Windows.Forms.RadioButton();
            this.RbVênus = new System.Windows.Forms.RadioButton();
            this.LblSelecionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblTitluo
            // 
            this.LblTitluo.AutoSize = true;
            this.LblTitluo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitluo.Location = new System.Drawing.Point(78, 9);
            this.LblTitluo.Name = "LblTitluo";
            this.LblTitluo.Size = new System.Drawing.Size(106, 16);
            this.LblTitluo.TabIndex = 0;
            this.LblTitluo.Text = "Peso na Terra (kg):";
            // 
            // TxtPeso
            // 
            this.TxtPeso.Location = new System.Drawing.Point(81, 28);
            this.TxtPeso.Multiline = true;
            this.TxtPeso.Name = "TxtPeso";
            this.TxtPeso.Size = new System.Drawing.Size(100, 24);
            this.TxtPeso.TabIndex = 1;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalcular.Location = new System.Drawing.Point(199, 28);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(128, 37);
            this.BtnCalcular.TabIndex = 2;
            this.BtnCalcular.Text = "Calcular peso:";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbMercúrio
            // 
            this.RbMercúrio.AutoSize = true;
            this.RbMercúrio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMercúrio.Location = new System.Drawing.Point(45, 106);
            this.RbMercúrio.Name = "RbMercúrio";
            this.RbMercúrio.Size = new System.Drawing.Size(71, 20);
            this.RbMercúrio.TabIndex = 3;
            this.RbMercúrio.TabStop = true;
            this.RbMercúrio.Text = "Mercúrio";
            this.RbMercúrio.UseVisualStyleBackColor = true;
            // 
            // RbMarte
            // 
            this.RbMarte.AutoSize = true;
            this.RbMarte.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbMarte.Location = new System.Drawing.Point(175, 161);
            this.RbMarte.Name = "RbMarte";
            this.RbMarte.Size = new System.Drawing.Size(54, 20);
            this.RbMarte.TabIndex = 4;
            this.RbMarte.TabStop = true;
            this.RbMarte.Text = "Marte";
            this.RbMarte.UseVisualStyleBackColor = true;
            // 
            // RbSaturno
            // 
            this.RbSaturno.AutoSize = true;
            this.RbSaturno.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbSaturno.Location = new System.Drawing.Point(45, 220);
            this.RbSaturno.Name = "RbSaturno";
            this.RbSaturno.Size = new System.Drawing.Size(68, 20);
            this.RbSaturno.TabIndex = 5;
            this.RbSaturno.TabStop = true;
            this.RbSaturno.Text = "Saturno";
            this.RbSaturno.UseVisualStyleBackColor = true;
            // 
            // RbUrano
            // 
            this.RbUrano.AutoSize = true;
            this.RbUrano.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbUrano.Location = new System.Drawing.Point(175, 220);
            this.RbUrano.Name = "RbUrano";
            this.RbUrano.Size = new System.Drawing.Size(57, 20);
            this.RbUrano.TabIndex = 6;
            this.RbUrano.TabStop = true;
            this.RbUrano.Text = "Urano";
            this.RbUrano.UseVisualStyleBackColor = true;
            // 
            // RbJúpiter
            // 
            this.RbJúpiter.AutoSize = true;
            this.RbJúpiter.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbJúpiter.Location = new System.Drawing.Point(45, 161);
            this.RbJúpiter.Name = "RbJúpiter";
            this.RbJúpiter.Size = new System.Drawing.Size(62, 20);
            this.RbJúpiter.TabIndex = 7;
            this.RbJúpiter.TabStop = true;
            this.RbJúpiter.Text = "Júpiter";
            this.RbJúpiter.UseVisualStyleBackColor = true;
            // 
            // RbVênus
            // 
            this.RbVênus.AutoSize = true;
            this.RbVênus.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbVênus.Location = new System.Drawing.Point(175, 106);
            this.RbVênus.Name = "RbVênus";
            this.RbVênus.Size = new System.Drawing.Size(58, 20);
            this.RbVênus.TabIndex = 8;
            this.RbVênus.TabStop = true;
            this.RbVênus.Text = "Vênus";
            this.RbVênus.UseVisualStyleBackColor = true;
            // 
            // LblSelecionar
            // 
            this.LblSelecionar.AutoSize = true;
            this.LblSelecionar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelecionar.Location = new System.Drawing.Point(42, 75);
            this.LblSelecionar.Name = "LblSelecionar";
            this.LblSelecionar.Size = new System.Drawing.Size(115, 16);
            this.LblSelecionar.TabIndex = 9;
            this.LblSelecionar.Text = "Selecione o planeta:";
            // 
            // Atividade_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 281);
            this.Controls.Add(this.LblSelecionar);
            this.Controls.Add(this.RbVênus);
            this.Controls.Add(this.RbJúpiter);
            this.Controls.Add(this.RbUrano);
            this.Controls.Add(this.RbSaturno);
            this.Controls.Add(this.RbMarte);
            this.Controls.Add(this.RbMercúrio);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtPeso);
            this.Controls.Add(this.LblTitluo);
            this.Name = "Atividade_2";
            this.Text = "Atividade_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitluo;
        private System.Windows.Forms.TextBox TxtPeso;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.RadioButton RbMercúrio;
        private System.Windows.Forms.RadioButton RbMarte;
        private System.Windows.Forms.RadioButton RbSaturno;
        private System.Windows.Forms.RadioButton RbUrano;
        private System.Windows.Forms.RadioButton RbJúpiter;
        private System.Windows.Forms.RadioButton RbVênus;
        private System.Windows.Forms.Label LblSelecionar;
    }
}