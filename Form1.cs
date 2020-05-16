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
using System.IO;

namespace MonitorSerial
{
   
    public partial class Form1 : Form
    {
        SerialPort serial = new SerialPort();
        string bfRecebe = string.Empty;

        public delegate void Fdelegate(string a); //criar a delegate

        string txt_rec = string.Empty; //strinpara recebere dados serial

        List<string> lista = new List<string>(); //lista para armazenar dados temporarios
      
        string txt_list = string.Empty;          //string para adicionar a lista  temporaria

        int qtde_data = 0;                       //variavel para contar tempo de dados recebidos

        public Form1()
        {
            InitializeComponent();
            serial.DataReceived += new SerialDataReceivedEventHandler(SerialCom_DataReceived);//instaciar dados recebidos pela serial
        }

        private void SerialCom_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bfRecebe = serial.ReadLine();//recebe a leitura da serial
            this.BeginInvoke(new Fdelegate(recebe_serial), new object[] { bfRecebe }); //invocar  a delagete e o metodo recebe serial
           
        }

        public void recebe_serial(string a)
        {
               txt_rec = a;
               int volt = 0;
               

            if (txt_rec.Length >=1)
               {
                    label6.Text = a;
                    volt = Convert.ToInt32(a);
                    aGauge1.Value = volt;
                    aGauge2.Value = (volt * 5000) / 1023;
                    label7.Text = aGauge2.Value.ToString() + "mv";
                    txt_list = ((volt * 5000) / 1023).ToString()+" - mv";
            }
                    txt_rec = string.Empty;
        }

        private void btSair_Click(object sender, EventArgs e)
        {                      
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)   //carrega fomulario
        {

            #region carrega portas
            cbxPorta.Text = "COM1";
            salvarToolStripMenuItem.Enabled = false;

            foreach (string portaDisponivel in SerialPort.GetPortNames())//pega o nome da porta "com1" por exemplo
            {
                int parit = 0;
                cbxPorta.Items.Add(portaDisponivel);   //adiciona ao combobox
                if (portaDisponivel == "COM3")         //se a 8 estiver disponivel carrega ela
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

        private void btAbrir_Click(object sender, EventArgs e)//abre a porta serial
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
            timer1.Enabled = true;
            try
            {
                btAbrir.BackColor = Color.LightGreen;
                btFechar.BackColor = Color.Red;
                serial.Open();                       /*abre a porta*/
                btAbrir.Enabled = false;
                btFechar.Enabled = true;
                btSair.Enabled = false;
                salvarToolStripMenuItem.Enabled = true;
            }
            catch
            {
                MessageBox.Show("não foi possivel abrir a porta");
                btAbrir.Enabled = true;
                btFechar.Enabled = false;
                btSair.Enabled = true;
                btAbrir.BackColor = Color.Blue;
                btFechar.BackColor = Color.Blue;
                timer1.Enabled = false;
            }

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            serial.Close();
            btAbrir.Enabled = true;
            btFechar.Enabled = false;
            btSair.Enabled = true;
            btAbrir.BackColor = Color.Blue;
            btFechar.BackColor = Color.Blue;
            salvarToolStripMenuItem.Enabled = false;
        }

        private void btEnvia_Click(object sender, EventArgs e)//inicia
        {
            if (serial.IsOpen)
            {
                serial.Write("IN000000\r");
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            if (serial.IsOpen)
            {
                serial.Write("FN000000\r");
            }
        }

        private void aGauge1_ValueInRangeChanged(object sender, AGaugeApp.AGauge.ValueInRangeChangedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lista.Add(DateTime.Now + " - " + txt_list);
            qtde_data++;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter Arq;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    Arq = File.AppendText(saveFileDialog1.FileName);

                    for (int i = 0; i < qtde_data; i++)
                    {
                        Arq.WriteLine(lista[i]);
                    }
                        Arq.Close();

                    MessageBox.Show("Dados salvos com sucesso");
                }
            }
            catch (Exception erro)
            { 
                MessageBox.Show(erro.ToString());
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
