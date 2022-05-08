namespace manipulandoCaixaDeTexto
{
    partial class frmFomulario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblIdad = new System.Windows.Forms.Label();
            this.lblMaiusc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdad = new System.Windows.Forms.TextBox();
            this.txtMaiusc = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(2, 15);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblIdad
            // 
            this.lblIdad.AutoSize = true;
            this.lblIdad.Location = new System.Drawing.Point(2, 41);
            this.lblIdad.Name = "lblIdad";
            this.lblIdad.Size = new System.Drawing.Size(34, 13);
            this.lblIdad.TabIndex = 1;
            this.lblIdad.Text = "Idade";
            // 
            // lblMaiusc
            // 
            this.lblMaiusc.AutoSize = true;
            this.lblMaiusc.Location = new System.Drawing.Point(2, 67);
            this.lblMaiusc.Name = "lblMaiusc";
            this.lblMaiusc.Size = new System.Drawing.Size(83, 13);
            this.lblMaiusc.TabIndex = 2;
            this.lblMaiusc.Text = "Tudo Maiusculo";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(43, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(229, 20);
            this.txtNome.TabIndex = 3;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtIdad
            // 
            this.txtIdad.Location = new System.Drawing.Point(43, 38);
            this.txtIdad.Name = "txtIdad";
            this.txtIdad.Size = new System.Drawing.Size(229, 20);
            this.txtIdad.TabIndex = 4;
            this.txtIdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdad_KeyPress);
            // 
            // txtMaiusc
            // 
            this.txtMaiusc.Location = new System.Drawing.Point(91, 64);
            this.txtMaiusc.Multiline = true;
            this.txtMaiusc.Name = "txtMaiusc";
            this.txtMaiusc.Size = new System.Drawing.Size(181, 156);
            this.txtMaiusc.TabIndex = 5;
            this.txtMaiusc.Leave += new System.EventHandler(this.txtMaiusc_Leave);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(197, 226);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(91, 226);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Apagar";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnDel_MouseClick);
            // 
            // frmFomulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMaiusc);
            this.Controls.Add(this.txtIdad);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblMaiusc);
            this.Controls.Add(this.lblIdad);
            this.Controls.Add(this.lblNome);
            this.Name = "frmFomulario";
            this.Text = "Formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblIdad;
        private System.Windows.Forms.Label lblMaiusc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdad;
        private System.Windows.Forms.TextBox txtMaiusc;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnDel;
    }
}

