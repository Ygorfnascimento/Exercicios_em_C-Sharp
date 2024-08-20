namespace LOPAL_Ygor
{
    partial class Menu
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
            this.BtnAtividade1 = new System.Windows.Forms.Button();
            this.BtnAtividade2 = new System.Windows.Forms.Button();
            this.BtnAtividade3 = new System.Windows.Forms.Button();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAtividade1
            // 
            this.BtnAtividade1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtividade1.Location = new System.Drawing.Point(155, 94);
            this.BtnAtividade1.Name = "BtnAtividade1";
            this.BtnAtividade1.Size = new System.Drawing.Size(202, 54);
            this.BtnAtividade1.TabIndex = 0;
            this.BtnAtividade1.Text = "Atividade 1";
            this.BtnAtividade1.UseVisualStyleBackColor = true;
            this.BtnAtividade1.Click += new System.EventHandler(this.BtnAtividade1_Click);
            // 
            // BtnAtividade2
            // 
            this.BtnAtividade2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtividade2.Location = new System.Drawing.Point(155, 202);
            this.BtnAtividade2.Name = "BtnAtividade2";
            this.BtnAtividade2.Size = new System.Drawing.Size(202, 54);
            this.BtnAtividade2.TabIndex = 1;
            this.BtnAtividade2.Text = "Atividade 2";
            this.BtnAtividade2.UseVisualStyleBackColor = true;
            this.BtnAtividade2.Click += new System.EventHandler(this.BtnAtividade2_Click);
            // 
            // BtnAtividade3
            // 
            this.BtnAtividade3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtividade3.Location = new System.Drawing.Point(155, 318);
            this.BtnAtividade3.Name = "BtnAtividade3";
            this.BtnAtividade3.Size = new System.Drawing.Size(202, 55);
            this.BtnAtividade3.TabIndex = 2;
            this.BtnAtividade3.Text = "Atividade 3";
            this.BtnAtividade3.UseVisualStyleBackColor = true;
            this.BtnAtividade3.Click += new System.EventHandler(this.BtnAtividade3_Click);
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.Location = new System.Drawing.Point(122, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(261, 33);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "Menu das Atividades ";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 404);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.BtnAtividade3);
            this.Controls.Add(this.BtnAtividade2);
            this.Controls.Add(this.BtnAtividade1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAtividade1;
        private System.Windows.Forms.Button BtnAtividade2;
        private System.Windows.Forms.Button BtnAtividade3;
        private System.Windows.Forms.Label LblTitulo;
    }
}