using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group_8_Bianca_s_Apostles
{
    public partial class Form1 : Form
    {
        formAboutUs FORMAboutUs;

        formsub1GateControl sub1GateControl;
        formsub1LightSwitch sub1LightSwitch;

        formsub2GateStatus sub2GateStatus;
        formsub2LightStatus sub2LightStatus;

        public Form1()
        {
            InitializeComponent();
            mdiProp();

            Clock.Text = DateTime.Now.ToLongTimeString();
            DigitalClock.Start();
        }
        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232,234,237);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        bool controlExpand = false;
        private void controlTransition_Tick(object sender, EventArgs e)
        {
            if(controlExpand == false)
            {
                controlContainer.Height += 10;
                if(controlContainer.Height >= 340)
                {
                    controlTransition.Stop();
                    controlExpand = true;
                }
            }
            else
            {
                controlContainer.Height -= 10;
                if(controlContainer.Height <= 105)
                {
                    controlTransition.Stop();
                    controlExpand = false;
                }
            }
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            controlTransition.Start();
        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if(sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 94)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                    panelAboutUs.Width = sidebar.Width;
                    controlContainer.Width = sidebar.Width;
                    statusContainer.Width = sidebar.Width;
                    panelLogout.Width = sidebar.Width;
                }
            } else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 296)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    panelAboutUs.Width = sidebar.Width;
                    controlContainer.Width = sidebar.Width;
                    statusContainer.Width = sidebar.Width;
                    panelLogout.Width = sidebar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            //sidebarTransition.Start();
        }

        bool statusExpand = false;

        private void statusTransition_Tick(object sender, EventArgs e)
        {
            if (statusExpand == false)
            {
                statusContainer.Height += 10;
                if (statusContainer.Height >= 340)
                {
                    statusTransition.Stop();
                    statusExpand = true;
                }
            }
            else
            {
                statusContainer.Height -= 10;
                if (statusContainer.Height <= 105)
                {
                    statusTransition.Stop();
                    statusExpand = false;
                }
            }
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            statusTransition.Start();
        }

        private void ctrlButton_Click(object sender, EventArgs e)
        {
            controlTransition.Start();

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            if(FORMAboutUs == null)
            {
                FORMAboutUs = new formAboutUs();
                FORMAboutUs.FormClosed += AboutUs_FormClosed;
                FORMAboutUs.MdiParent = this;
                FORMAboutUs.Dock = DockStyle.Fill;
                FORMAboutUs.Show();
            }
            else
            {
                FORMAboutUs.Activate();
            }
        }
        private void AboutUs_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            FORMAboutUs = null;
        }

        private void submenu1GateControl_Click(object sender, EventArgs e)
        {
            if(sub1GateControl == null)
            {
                sub1GateControl = new formsub1GateControl();
                sub1GateControl.FormClosed += submenu1GateControl_FormClosed;
                sub1GateControl.MdiParent = this;
                sub1GateControl.Dock = DockStyle.Fill;
                sub1GateControl.Show();
            }
            else
            {
                sub1GateControl.Activate();
            }
        }
        private void submenu1GateControl_FormClosed(Object sender, FormClosedEventArgs e)
        {
            sub1GateControl = null;
        }

        private void submenu1LightSwitch_Click(object sender, EventArgs e)
        {
            if (sub1LightSwitch == null)
            {
                sub1LightSwitch = new formsub1LightSwitch();
                sub1LightSwitch.FormClosed += sub1LightSwitch_FormClosed;
                sub1LightSwitch.MdiParent = this;
                sub1LightSwitch.Dock = DockStyle.Fill;
                sub1LightSwitch.Show();
            }
            else
            {
                sub1LightSwitch.Activate();
            }
        }
        private void sub1LightSwitch_FormClosed(Object sender, FormClosedEventArgs e)
        {
            sub1LightSwitch = null;
        }

        private void submenu2GateStatus_Click(object sender, EventArgs e)
        {
            if (sub2GateStatus == null)
            {
                sub2GateStatus = new formsub2GateStatus();
                sub2GateStatus.FormClosed += sub2GateStatus_FormClosed;
                sub2GateStatus.MdiParent = this;
                sub2GateStatus.Dock = DockStyle.Fill;
                sub2GateStatus.Show();
            }
            else
            {
                sub2GateStatus.Activate();
            }
        }
        private void sub2GateStatus_FormClosed(Object sender, FormClosedEventArgs e)
        {
            sub2GateStatus = null;
        }

        private void submenu2LightStatus_Click(object sender, EventArgs e)
        {
            if (sub2LightStatus == null)
            {
                sub2LightStatus = new formsub2LightStatus();
                sub2LightStatus.FormClosed += sub2LightStatus_FormClosed;
                sub2LightStatus.MdiParent = this;
                sub2LightStatus.Dock = DockStyle.Fill;
                sub2LightStatus.Show();
            }
            else
            {
                sub2LightStatus.Activate();
            }
        }
        private void sub2LightStatus_FormClosed(Object sender, FormClosedEventArgs e)
        {
            sub2LightStatus = null;
        }

        private void DigitalClock_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToLongTimeString();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Application.Exit();

            }
        }

        public void CloseOtherSerialPorts(Form currentForm)
        {
            foreach (Form form in this.MdiChildren)
            {
                if (form != currentForm && form is IHaveSerialPort)
                {
                    ((IHaveSerialPort)form).CloseSerialPort();
                }
            }
        }

        public interface IHaveSerialPort
        {
            void CloseSerialPort();
        }

    }
}
