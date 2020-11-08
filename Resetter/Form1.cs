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
using System.Threading;

namespace Resetter
{
    public partial class Form1 : Form
    {
        System.Threading.Thread pw; 
        public Form1()
        {
            InitializeComponent();
            pw = new System.Threading.Thread(new System.Threading.ThreadStart(pw_DoWork));
            pw.IsBackground = true;
        }

        private void pw_DoWork()
        {
            while (pw.IsAlive)
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Get all Available COM Ports 
            foreach (string s in SerialPort.GetPortNames())
            {
                cmbxSerialPorts.Items.Add(s);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReadSettings_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 115200;
            serialPort1.PortName = cmbxSerialPorts.Text;


            try
            {
                serialPort1.Open();
                MessageBox.Show("Connection Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed");
            }
            serialPort1.Close();
        }

        private void btnUpdateBoard_Click(object sender, EventArgs e)
        {
            PrinterSettings setts = new PrinterSettings();

            setts.BedTempature = "0x" + Convert.ToInt16(cmbxBedTemp.Text).ToString("X");

            setts.CartridgeLength = "0x" + Convert.ToInt16(cmbxFilementLength.Text).ToString("X");
            
            setts.ExtruderTempature = "0x" + Convert.ToInt16(cmbxExtruderTemp.Text).ToString("X");

            setts.MaterialUsed = "0x" + Convert.ToInt16(cmbxExtruderTemp.Text).ToString("X");

            if(!serialPort1.IsOpen)
            serialPort1.Open();

            if(serialPort1.IsOpen)
            {
                serialPort1.WriteLine(setts.CartridgeLength);
                Thread.Sleep(1000);
                serialPort1.WriteLine(setts.ExtruderTempature);
                Thread.Sleep(1000);
                serialPort1.WriteLine(setts.BedTempature);
                Thread.Sleep(1000);
                serialPort1.WriteLine(setts.MaterialUsed);
            }            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pw.IsAlive)
            {
                pw.Abort();
            }

            serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            txtSerialMonitor.BeginInvoke((MethodInvoker)delegate { txtSerialMonitor.Text += serialPort1.ReadLine() + "\n"; });
            System.Threading.Thread.Sleep(100);
        }
    }
}
