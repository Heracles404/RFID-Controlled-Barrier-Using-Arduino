using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_8_Bianca_s_Apostles
{
    public partial class formsub2GateStatus : Form
    {
        public formsub2GateStatus()
        {
            InitializeComponent();
        }

        public void CloseSerialPort()
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        private void form2GateStatus_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            serialPort1.Open();
        }

        private void timerGateStatus_Tick(object sender, EventArgs e)
        {
            // Check if the serial port is closed before opening it
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                    // Read data if available
                    string s = serialPort1.ReadExisting().ToString();

                    Console.WriteLine("Received data: " + s); // Debug statement

                    if (!string.IsNullOrEmpty(s))
                    {
                        // Update the label based on the received data
                        if (s.Contains("UP"))
                        {
                            labelGateStatus.Text = "Gate is OPEN!";
                        }
                        else if (s.Contains("DOWN"))
                        {
                            labelGateStatus.Text = "Gate is CLOSED!";
                        }
                        else
                        {
                            Console.WriteLine("Unknown data received: " + s); // Debug statement
                        }
                    }
                }
                finally
                {
                    // Close the serial port after reading
                    serialPort1.Close();
                }
            }

            serialPort1.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // wag tanggalin magloloko design
            // napindot arduino to pc label sa design
        }

        private void labelGateStatus_Click(object sender, EventArgs e)
        {
            // napindot label ng gate status
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
