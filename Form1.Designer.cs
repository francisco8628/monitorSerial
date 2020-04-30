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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbREcebeSerial = new System.Windows.Forms.TextBox();
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Porta :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Velocidade :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(226, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paridade :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Highlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(334, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = " Bits de Dados :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Highlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label5.Location = new System.Drawing.Point(440, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
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
            this.btAbrir.BackColor = System.Drawing.Color.Blue;
            this.btAbrir.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.btAbrir.FlatAppearance.BorderSize = 0;
            this.btAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btAbrir.Location = new System.Drawing.Point(584, 12);
            this.btAbrir.Margin = new System.Windows.Forms.Padding(0);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(121, 26);
            this.btAbrir.TabIndex = 10;
            this.btAbrir.Text = "Abre Porta";
            this.btAbrir.UseVisualStyleBackColor = false;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btFechar
            // 
            this.btFechar.BackColor = System.Drawing.Color.Blue;
            this.btFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btFechar.Location = new System.Drawing.Point(584, 44);
            this.btFechar.Name = "btFechar";
            this.btFechar.Size = new System.Drawing.Size(121, 26);
            this.btFechar.TabIndex = 11;
            this.btFechar.Text = "Fecha Porta";
            this.btFechar.UseVisualStyleBackColor = false;
            this.btFechar.Click += new System.EventHandler(this.btFechar_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Blue;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.28F, System.Drawing.FontStyle.Bold);
            this.btSair.Location = new System.Drawing.Point(630, 235);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 26);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Highlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label6.Location = new System.Drawing.Point(10, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Transmição :";
            // 
            // btEnvia
            // 
            this.btEnvia.BackColor = System.Drawing.Color.Blue;
            this.btEnvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEnvia.Location = new System.Drawing.Point(444, 76);
            this.btEnvia.Name = "btEnvia";
            this.btEnvia.Size = new System.Drawing.Size(101, 26);
            this.btEnvia.TabIndex = 15;
            this.btEnvia.Text = "Envia";
            this.btEnvia.UseVisualStyleBackColor = false;
            this.btEnvia.Click += new System.EventHandler(this.btEnvia_Click);
            // 
            // txbTransmite
            // 
            this.txbTransmite.Location = new System.Drawing.Point(12, 80);
            this.txbTransmite.Name = "txbTransmite";
            this.txbTransmite.Size = new System.Drawing.Size(316, 20);
            this.txbTransmite.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Controls.Add(this.txbREcebeSerial);
            this.groupBox1.Location = new System.Drawing.Point(15, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 142);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recepção";
            // 
            // txbREcebeSerial
            // 
            this.txbREcebeSerial.Location = new System.Drawing.Point(6, 19);
            this.txbREcebeSerial.Multiline = true;
            this.txbREcebeSerial.Name = "txbREcebeSerial";
            this.txbREcebeSerial.Size = new System.Drawing.Size(515, 117);
            this.txbREcebeSerial.TabIndex = 17;
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.BackColor = System.Drawing.SystemColors.Highlight;
            this.checkBoxCR.Location = new System.Drawing.Point(347, 85);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(41, 17);
            this.checkBoxCR.TabIndex = 18;
            this.checkBoxCR.TabStop = false;
            this.checkBoxCR.Text = "CR";
            this.checkBoxCR.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(714, 291);
            this.ControlBox = false;
            this.Controls.Add(this.checkBoxCR);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Monitor Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbREcebeSerial;
        private System.Windows.Forms.CheckBox checkBoxCR;
    }
}

