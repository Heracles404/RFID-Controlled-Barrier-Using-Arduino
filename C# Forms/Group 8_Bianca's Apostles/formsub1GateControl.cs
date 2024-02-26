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
    public partial class formsub1GateControl : Form
    {
        public formsub1GateControl()
        {
            InitializeComponent();
        }

        private void form1GateControl_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void btnOpenGate_Click(object sender, EventArgs e)
        {
            serialPort1.Open();
            // Open Gate - '3'
            serialPort1.Write("UP");
            serialPort1.Close();
        }

        private void btnCloseGate_Click(object sender, EventArgs e)
        {
            // Close Gate - '4'
            serialPort1.Open();
            serialPort1.Write("DOWN");
            serialPort1.Close();
        }

    }
}
