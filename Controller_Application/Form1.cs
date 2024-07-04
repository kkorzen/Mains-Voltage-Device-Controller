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

namespace _230V_Device_USB_Controller
{
    public partial class Form1 : Form
    {
        private int luminosity;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_RelayControl.Enabled = false;
            groupBox_DimmerControl.Enabled = false;
            groupBox_connectivity.Text = "Disconnected";
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write("a\n");
                    serialPort1.Write("b\n");
                    serialPort1.Write("L300\n");
                    luminosity = 300;
                    trackBar_dimmer.Value = 300;
                    label_luminosity.Text = string.Format("Power = {0}%", 0);
                    serialPort1.Close();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void comboBox_ports_DropDown(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_ports.Items.Clear();
            comboBox_ports.Items.AddRange(ports);
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_ports.Text;
                serialPort1.BaudRate = 115200;
                serialPort1.Open();

                //MessageBox.Show("Połączenie zestawione poprawnie.");
                groupBox_RelayControl.Enabled = true;
                groupBox_DimmerControl.Enabled = true;
                groupBox_connectivity.Text = "Connected";
                groupBox_connectivity.ForeColor = Color.Green;

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error");
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write("a\n");
                serialPort1.Write("b\n");
                serialPort1.Write("L300\n");
                luminosity = 300;
                trackBar_dimmer.Value = 300;
                label_luminosity.Text = string.Format("Power = {0}%", 0);

                serialPort1.Close();
                groupBox_RelayControl.Enabled = false;
                groupBox_DimmerControl.Enabled = false;
                groupBox_connectivity.ForeColor = Color.Black;
                groupBox_connectivity.Text = "Disconnected";
            }
        }

        private void button_Relay1ON_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A\n");
        }

        private void button_Relay1OFF_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a\n");
        }

        private void button_Relay2ON_Click(object sender, EventArgs e)
        {
            serialPort1.Write("B\n");
        }

        private void button_Relay2OFF_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b\n");
        }

        private void trackBar_dimmer_Scroll(object sender, EventArgs e)
        {
            luminosity = trackBar_dimmer.Value;
            serialPort1.Write("L" + luminosity.ToString() + "\n");
            luminosity = (luminosity - 300) * 100 / 8700;
            label_luminosity.Text = string.Format("Power = {0}%", luminosity);
        }
    }
}
