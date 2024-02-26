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
using static Group_8_Bianca_s_Apostles.Form1;

namespace Group_8_Bianca_s_Apostles
{
    public partial class formsub1LightSwitch : Form
    {
        public formsub1LightSwitch()
        {
            InitializeComponent();
        }

        private void form1LightSwitch_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnLightOn_Click(object sender, EventArgs e)
        {
            // On Light 
            serialPort1.Open();
            serialPort1.Write("ON");
            serialPort1.Close();

        }

        private void btnLightOff_Click(object sender, EventArgs e)
        {
            // Off Light
            serialPort1.Open();
            serialPort1.Write("OFF");
            serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Autolights
            serialPort1.Open();
            serialPort1.Write("AUTO");
            serialPort1.Close();
        }
    }
}
