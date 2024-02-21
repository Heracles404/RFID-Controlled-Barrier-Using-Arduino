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

        private void form2GateStatus_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void timerGateStatus_Tick(object sender, EventArgs e)
        {
            serialPort1.Open();
            string s = serialPort1.ReadExisting().ToString();


            if (s.Contains("UP"))
            {
                labelGateStatus.Text = "GATE is: OPEN!";
            }
            else if (s.Contains("DOWN"))
            {
                labelGateStatus.Text = "GATE is: CLOSED!";
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
