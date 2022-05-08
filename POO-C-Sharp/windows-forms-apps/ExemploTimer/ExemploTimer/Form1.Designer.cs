namespace ExemploTimer
{
    partial class frmTimer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCont1 = new System.Windows.Forms.Label();
            this.lblCont2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(172, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "1";
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(91, 58);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(100, 23);
            this.btnOnOff.TabIndex = 3;
            this.btnOnOff.Text = "Ligar/Desligar";
            this.btnOnOff.UseVisualStyleBackColor = true;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ExemploTimer.Properties.Resources.sol;
            this.pictureBox1.Location = new System.Drawing.Point(91, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblCont1
            // 
            this.lblCont1.AutoSize = true;
            this.lblCont1.Location = new System.Drawing.Point(9, 9);
            this.lblCont1.Name = "lblCont1";
            this.lblCont1.Size = new System.Drawing.Size(68, 13);
            this.lblCont1.TabIndex = 5;
            this.lblCont1.Text = "Contador + 1";
            // 
            // lblCont2
            // 
            this.lblCont2.AutoSize = true;
            this.lblCont2.Location = new System.Drawing.Point(169, 9);
            this.lblCont2.Name = "lblCont2";
            this.lblCont2.Size = new System.Drawing.Size(68, 13);
            this.lblCont2.TabIndex = 6;
            this.lblCont2.Text = "Contador + 2";
            // 
            // frmTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblCont2);
            this.Controls.Add(this.lblCont1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmTimer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCont1;
        private System.Windows.Forms.Label lblCont2;
    }
}

