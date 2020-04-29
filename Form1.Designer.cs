namespace MonitorSerial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxPorta = new System.Windows.Forms.ComboBox();
            this.cbxVelocidade = new System.Windows.Forms.ComboBox();
            this.cbxParidade = new System.Windows.Forms.ComboBox();
            this.cbxBitsDados = new System.Windows.Forms.ComboBox();
            this.cbxBitParada = new System.Windows.Forms.ComboBox();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btFechar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btEnvia = new System.Windows.Forms.Button();
            this.txbTransmite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridade :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = " Bits de Dados :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bit de parada";
            // 
            // cbxPorta
            // 
            this.cbxPorta.FormattingEnabled = true;
            this.cbxPorta.Location = new System.Drawing.Point(13, 28);
            this.cbxPorta.Name = "cbxPorta";
            this.cbxPorta.Size = new System.Drawing.Size(102, 21);
            this.cbxPorta.TabIndex = 5;
            // 
            // cbxVelocidade
            // 
            this.cbxVelocidade.FormattingEnabled = true;
            this.cbxVelocidade.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200"});
            this.cbxVelocidade.Location = new System.Drawing.Point(121, 28);
            this.cbxVelocidade.Name = "cbxVelocidade";
            this.cbxVelocidade.Size = new System.Drawing.Size(102, 21);
            this.cbxVelocidade.TabIndex = 6;
            // 
            // cbxParidade
            // 
            this.cbxParidade.FormattingEnabled = true;
            this.cbxParidade.Location = new System.Drawing.Point(229, 28);
            this.cbxParidade.Name = "cbxParidade";
            this.cbxParidade.Size = new System.Drawing.Size(102, 21);
            this.cbxParidade.TabIndex = 7;
            // 
            // cbxBitsDados
            // 
            this.cbxBitsDados.FormattingEnabled = true;
            this.cbxBitsDados.Location = new System.Drawing.Point(337, 28);
            this.cbxBitsDados.Name = "cbxBitsDados";
            this.cbxBitsDados.Size = new System.Drawing.Size(102, 21);
            this.cbxBitsDados.TabIndex = 8;
            // 
            // cbxBitParada
            // 
            this.cbxBitParada.FormattingEnabled = true;
            this.cbxBitParada.Location = new System.Drawing.Point(443, 28);
            this.cbxBitParada.Name = "cbxBitParada";
            this.cbxBitParada.Size = new System.Drawing.Size(102, 21);
            this.cbxBitParada.TabIndex = 9;
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(584, 12);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(121, 26);
            this.btAbrir.TabIndex = 10;
            this.btAbrir.Text = "Abre Porta";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btFechar
            // 
            this.btFechar.Location = new System.Drawing.Point(584, 44);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(121, 26);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "Fecha Porta";
            this.btFechar.UseVisualStyleBackColor = true;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(630, 76);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 26);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Transmição :";
            // 
            // btEnvia
            // 
            this.btEnvia.Location = new System.Drawing.Point(444, 76);
            this.btEnvia.Name = "btEnvia";
            this.btEnvia.Size = new System.Drawing.Size(101, 26);
            this.btEnvia.TabIndex = 15;
            this.btEnvia.Text = "Envia";
            this.btEnvia.UseVisualStyleBackColor = true;
            this.btEnvia.Click += new System.EventHandler(this.btEnvia_Click);
            // 
            // txbTransmite
            // 
            this.txbTransmite.Location = new System.Drawing.Point(15, 82);
            this.txbTransmite.Name = "txbTransmite";
            this.txbTransmite.Size = new System.Drawing.Size(316, 20);
            this.txbTransmite.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 129);
            this.Controls.Add(this.txbTransmite);
            this.Controls.Add(this.btEnvia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btFechar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.cbxBitParada);
            this.Controls.Add(this.cbxBitsDados);
            this.Controls.Add(this.cbxParidade);
            this.Controls.Add(this.cbxVelocidade);
            this.Controls.Add(this.cbxPorta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxPorta;
        private System.Windows.Forms.ComboBox cbxVelocidade;
        private System.Windows.Forms.ComboBox cbxParidade;
        private System.Windows.Forms.ComboBox cbxBitsDados;
        private System.Windows.Forms.ComboBox cbxBitParada;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btFechar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btEnvia;
        private System.Windows.Forms.TextBox txbTransmite;
    }
}

