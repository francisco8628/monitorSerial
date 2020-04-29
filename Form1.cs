using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MonitorSerial
{
   
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)   //carrega fomulario
        {

            #region carrega portas
            foreach (string portaDisponivel in SerialPort.GetPortNames())//pega o nome da porta "com1" por exemplo
            {
                int parit = 0;
                cbxPorta.Items.Add(portaDisponivel);   //adiciona ao combobox
                if (portaDisponivel == "COM8")         //se a 8 estiver disponivel carrega ela
                {
                    cbxPorta.SelectedIndex = parit;
                   
                }
                parit++;


            }
            #endregion fim carrega portas


            cbxVelocidade.SelectedText = "9600";

            #region carrega paridade
            int i = 0;
            foreach (string paridade in Enum.GetNames(typeof(Parity)))
            {

                cbxParidade.Items.Add(paridade);
                if (paridade == "None")
                {
                    cbxParidade.SelectedIndex = i;
                 
                }
                i++;

            }

            #endregion fim carrega paridade 
            cbxBitsDados.SelectedText = "8";

            #region carrega Stopbitis
            int st = 0;
            foreach (string stopbits in Enum.GetNames(typeof(StopBits)))
            {

                cbxBitParada.Items.Add(stopbits);

                if (stopbits == "One")  //quando achar "one"
                {
                    cbxBitParada.SelectedIndex = st; //seta o indice da lista com o valor dele
                   
                }
                st++;


            }

           #endregion fim carrega stop bits
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen == true)
            {
                serial.Close(); //se t
            }

            serial.PortName = cbxPorta.Text;                     /*seta os valores do formulario na serial*/
            serial.BaudRate = Int32.Parse(cbxVelocidade.Text);
            serial.Parity = (Parity)cbxParidade.SelectedIndex;
            serial.DataBits = Int32.Parse(cbxBitsDados.Text);
            serial.StopBits = (StopBits)cbxBitParada.SelectedIndex;

            try
            {

                serial.Open();                       /*abre a porta*/
                btAbrir.Enabled = false;
                btFechar.Enabled = true;
                btSair.Enabled = false;





            }
            catch
            {
                MessageBox.Show("não foi possivel abrir a porta");
                btAbrir.Enabled = true;
                btFechar.Enabled = false;
                btSair.Enabled = true;


            }

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            serial.Close();
            btAbrir.Enabled = true;
            btFechar.Enabled = false;
            btSair.Enabled = true;

        }

        private void btEnvia_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen) // se a serial estiver aberta
            {

                serial.Write(txbTransmite.Text); //escreve na serial
            }
        }
    }
}
