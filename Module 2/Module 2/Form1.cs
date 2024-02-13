using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("UP");
        }

        private void CloseGate_Click(object sender, EventArgs e)
        {
            serialPort1.Write("DOWN");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            string s = serialPort1.ReadExisting().ToString();

            if (s.Contains("UP"))
            {
                gateStat.Text = "Barrier is UP";
            }
            else if (s.Contains("DOWN"))
            {
                gateStat.Text = "Barrier is DOWN";
            }
        }
    }
}
