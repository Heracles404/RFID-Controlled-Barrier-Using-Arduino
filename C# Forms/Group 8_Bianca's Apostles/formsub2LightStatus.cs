using System.Windows.Forms;
using System;

namespace Group_8_Bianca_s_Apostles
{
    public partial class formsub2LightStatus : Form
    {
        public formsub2LightStatus()
        {
            InitializeComponent();
            // Initialize the serial port
            //serialPort1.PortName = "COM9"; // Set the correct COM port
            //serialPort1.BaudRate = 9600;   // Set the correct baud rate
        }

        private void form2LightStatus_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            // Start the timer when the form loads
            // timerLightStatus.Start();
        }

        private void timerLightStatus_Tick(object sender, EventArgs e)
        {
            // Check if the serial port is closed before opening it
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                // Read data if available
                string s = serialPort1.ReadExisting().ToString();

                Console.WriteLine("Received data: " + s); // Debug statement

                if (!string.IsNullOrEmpty(s))
                {
                    // Update the label based on the received data
                    if (s.Contains("ON"))
                    {
                        labelLightStatus.Text = "Light is ON!";
                    }
                    else if (s.Contains("OFF"))
                    {
                        labelLightStatus.Text = "Light is OFF!";
                    }
                    else
                    {
                        Console.WriteLine("Unknown data received: " + s); // Debug statement
                    }
                }

                // Close the serial port after reading
                serialPort1.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // This event handler is for label2, which is not related to the light status display
        }

        private void labelLightStatus_Click(object sender, EventArgs e)
        {
            // This event handler is for labelLightStatus, which is not intended to be clicked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // This event handler is for button1, which is not related to the light status display
        }
    }
}
    