namespace Quiz_Windows_Forms
{
    partial class FrmPerguntas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProximo = new System.Windows.Forms.Button();
            this.res4 = new System.Windows.Forms.RadioButton();
            this.res3 = new System.Windows.Forms.RadioButton();
            this.res2 = new System.Windows.Forms.RadioButton();
            this.res1 = new System.Windows.Forms.RadioButton();
            this.lblPerguntas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.res4);
            this.panel1.Controls.Add(this.res3);
            this.panel1.Controls.Add(this.res2);
            this.panel1.Controls.Add(this.res1);
            this.panel1.Controls.Add(this.lblPerguntas);
            this.panel1.Location = new System.Drawing.Point(181, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 334);
            this.panel1.TabIndex = 0;
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(327, 281);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(112, 34);
            this.btnProximo.TabIndex = 5;
            this.btnProximo.Text = "Proxímo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // res4
            // 
            this.res4.AutoSize = true;
            this.res4.Location = new System.Drawing.Point(24, 237);
            this.res4.Name = "res4";
            this.res4.Size = new System.Drawing.Size(170, 29);
            this.res4.TabIndex = 4;
            this.res4.Text = "Cogumelo Verde";
            this.res4.UseVisualStyleBackColor = true;
            this.res4.CheckedChanged += new System.EventHandler(this.res4_CheckedChanged);
            // 
            // res3
            // 
            this.res3.AutoSize = true;
            this.res3.Location = new System.Drawing.Point(24, 202);
            this.res3.Name = "res3";
            this.res3.Size = new System.Drawing.Size(98, 29);
            this.res3.TabIndex = 3;
            this.res3.Text = "O yoshi";
            this.res3.UseVisualStyleBackColor = true;
            this.res3.CheckedChanged += new System.EventHandler(this.res3_CheckedChanged);
            // 
            // res2
            // 
            this.res2.AutoSize = true;
            this.res2.Location = new System.Drawing.Point(24, 167);
            this.res2.Name = "res2";
            this.res2.Size = new System.Drawing.Size(159, 29);
            this.res2.TabIndex = 2;
            this.res2.Text = "Cogumelo Azul";
            this.res2.UseVisualStyleBackColor = true;
            this.res2.CheckedChanged += new System.EventHandler(this.res2_CheckedChanged);
            // 
            // res1
            // 
            this.res1.AutoSize = true;
            this.res1.Location = new System.Drawing.Point(24, 132);
            this.res1.Name = "res1";
            this.res1.Size = new System.Drawing.Size(101, 29);
            this.res1.TabIndex = 1;
            this.res1.Text = "Moedas";
            this.res1.UseVisualStyleBackColor = true;
            this.res1.CheckedChanged += new System.EventHandler(this.res1_CheckedChanged);
            // 
            // lblPerguntas
            // 
            this.lblPerguntas.AutoSize = true;
            this.lblPerguntas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPerguntas.Location = new System.Drawing.Point(3, 15);
            this.lblPerguntas.Name = "lblPerguntas";
            this.lblPerguntas.Size = new System.Drawing.Size(421, 76);
            this.lblPerguntas.TabIndex = 0;
            this.lblPerguntas.Text = "1) Qual item permite ao mario \r\nreceber uma vida extra, na hora?\r\n";
            // 
            // FrmPerguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Windows_Forms.Properties.Resources.b139bf5298a3b1008647c7d80b0d4f28;
            this.ClientSize = new System.Drawing.Size(823, 405);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPerguntas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.FrmPerguntas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnProximo;
        public RadioButton res4;
        public RadioButton res3;
        public RadioButton res2;
        public RadioButton res1;
        public Label lblPerguntas;
    }
}