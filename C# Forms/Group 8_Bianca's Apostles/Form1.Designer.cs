namespace Group_8_Bianca_s_Apostles
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Clock = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panelAboutUs = new System.Windows.Forms.Panel();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.controlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.ctrlButton = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.submenu1GateControl = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.submenu1LightSwitch = new System.Windows.Forms.Button();
            this.statusContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.statusButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.submenu2GateStatus = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.submenu2LightStatus = new System.Windows.Forms.Button();
            this.panelLogout = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.controlTransition = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.statusTransition = new System.Windows.Forms.Timer(this.components);
            this.DigitalClock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panelAboutUs.SuspendLayout();
            this.controlContainer.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.statusContainer.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panelLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Clock);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 80);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1798, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Clock
            // 
            this.Clock.AutoSize = true;
            this.Clock.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clock.ForeColor = System.Drawing.Color.White;
            this.Clock.Location = new System.Drawing.Point(911, 7);
            this.Clock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clock.Name = "Clock";
            this.Clock.Size = new System.Drawing.Size(144, 65);
            this.Clock.TabIndex = 2;
            this.Clock.Text = "Clock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu | Bianca\'s Apostle";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(11, 20);
            this.btnHam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(53, 45);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHam.TabIndex = 0;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Firebrick;
            this.sidebar.Controls.Add(this.panelAboutUs);
            this.sidebar.Controls.Add(this.controlContainer);
            this.sidebar.Controls.Add(this.statusContainer);
            this.sidebar.Controls.Add(this.panelLogout);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.sidebar.Location = new System.Drawing.Point(0, 80);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(301, 604);
            this.sidebar.TabIndex = 1;
            // 
            // panelAboutUs
            // 
            this.panelAboutUs.Controls.Add(this.btnAboutUs);
            this.panelAboutUs.Location = new System.Drawing.Point(2, 2);
            this.panelAboutUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAboutUs.Name = "panelAboutUs";
            this.panelAboutUs.Size = new System.Drawing.Size(308, 110);
            this.panelAboutUs.TabIndex = 4;
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.Firebrick;
            this.btnAboutUs.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = ((System.Drawing.Image)(resources.GetObject("btnAboutUs.Image")));
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(-4, -5);
            this.btnAboutUs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAboutUs.Size = new System.Drawing.Size(316, 125);
            this.btnAboutUs.TabIndex = 2;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // controlContainer
            // 
            this.controlContainer.BackColor = System.Drawing.Color.IndianRed;
            this.controlContainer.Controls.Add(this.panel10);
            this.controlContainer.Controls.Add(this.panel11);
            this.controlContainer.Controls.Add(this.panel12);
            this.controlContainer.Location = new System.Drawing.Point(2, 116);
            this.controlContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.controlContainer.Name = "controlContainer";
            this.controlContainer.Size = new System.Drawing.Size(308, 113);
            this.controlContainer.TabIndex = 11;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.ctrlButton);
            this.panel10.Location = new System.Drawing.Point(2, 2);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(308, 110);
            this.panel10.TabIndex = 7;
            // 
            // ctrlButton
            // 
            this.ctrlButton.BackColor = System.Drawing.Color.Firebrick;
            this.ctrlButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlButton.ForeColor = System.Drawing.Color.White;
            this.ctrlButton.Image = ((System.Drawing.Image)(resources.GetObject("ctrlButton.Image")));
            this.ctrlButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctrlButton.Location = new System.Drawing.Point(-4, -7);
            this.ctrlButton.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlButton.Name = "ctrlButton";
            this.ctrlButton.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ctrlButton.Size = new System.Drawing.Size(314, 125);
            this.ctrlButton.TabIndex = 2;
            this.ctrlButton.Text = "Control";
            this.ctrlButton.UseVisualStyleBackColor = false;
            this.ctrlButton.Click += new System.EventHandler(this.ctrlButton_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.submenu1GateControl);
            this.panel11.Location = new System.Drawing.Point(2, 116);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(308, 110);
            this.panel11.TabIndex = 8;
            // 
            // submenu1GateControl
            // 
            this.submenu1GateControl.BackColor = System.Drawing.Color.IndianRed;
            this.submenu1GateControl.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu1GateControl.ForeColor = System.Drawing.Color.White;
            this.submenu1GateControl.Image = ((System.Drawing.Image)(resources.GetObject("submenu1GateControl.Image")));
            this.submenu1GateControl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1GateControl.Location = new System.Drawing.Point(-4, -7);
            this.submenu1GateControl.Margin = new System.Windows.Forms.Padding(0);
            this.submenu1GateControl.Name = "submenu1GateControl";
            this.submenu1GateControl.Padding = new System.Windows.Forms.Padding(19, 0, 0, 0);
            this.submenu1GateControl.Size = new System.Drawing.Size(314, 125);
            this.submenu1GateControl.TabIndex = 2;
            this.submenu1GateControl.Text = "Gate Control";
            this.submenu1GateControl.UseVisualStyleBackColor = false;
            this.submenu1GateControl.Click += new System.EventHandler(this.submenu1GateControl_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.submenu1LightSwitch);
            this.panel12.Location = new System.Drawing.Point(2, 230);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(308, 110);
            this.panel12.TabIndex = 7;
            // 
            // submenu1LightSwitch
            // 
            this.submenu1LightSwitch.BackColor = System.Drawing.Color.IndianRed;
            this.submenu1LightSwitch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu1LightSwitch.ForeColor = System.Drawing.Color.White;
            this.submenu1LightSwitch.Image = ((System.Drawing.Image)(resources.GetObject("submenu1LightSwitch.Image")));
            this.submenu1LightSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu1LightSwitch.Location = new System.Drawing.Point(-4, -7);
            this.submenu1LightSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.submenu1LightSwitch.Name = "submenu1LightSwitch";
            this.submenu1LightSwitch.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.submenu1LightSwitch.Size = new System.Drawing.Size(314, 125);
            this.submenu1LightSwitch.TabIndex = 2;
            this.submenu1LightSwitch.Text = "Light Switch";
            this.submenu1LightSwitch.UseVisualStyleBackColor = false;
            this.submenu1LightSwitch.Click += new System.EventHandler(this.submenu1LightSwitch_Click);
            // 
            // statusContainer
            // 
            this.statusContainer.BackColor = System.Drawing.Color.IndianRed;
            this.statusContainer.Controls.Add(this.panel6);
            this.statusContainer.Controls.Add(this.panel7);
            this.statusContainer.Controls.Add(this.panel8);
            this.statusContainer.Location = new System.Drawing.Point(2, 233);
            this.statusContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statusContainer.Name = "statusContainer";
            this.statusContainer.Size = new System.Drawing.Size(308, 113);
            this.statusContainer.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.statusButton);
            this.panel6.Location = new System.Drawing.Point(2, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 110);
            this.panel6.TabIndex = 7;
            // 
            // statusButton
            // 
            this.statusButton.BackColor = System.Drawing.Color.Firebrick;
            this.statusButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusButton.ForeColor = System.Drawing.Color.White;
            this.statusButton.Image = ((System.Drawing.Image)(resources.GetObject("statusButton.Image")));
            this.statusButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.statusButton.Location = new System.Drawing.Point(-4, -7);
            this.statusButton.Margin = new System.Windows.Forms.Padding(0);
            this.statusButton.Name = "statusButton";
            this.statusButton.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.statusButton.Size = new System.Drawing.Size(314, 125);
            this.statusButton.TabIndex = 2;
            this.statusButton.Text = "Status";
            this.statusButton.UseVisualStyleBackColor = false;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.submenu2GateStatus);
            this.panel7.Location = new System.Drawing.Point(2, 116);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(308, 110);
            this.panel7.TabIndex = 8;
            // 
            // submenu2GateStatus
            // 
            this.submenu2GateStatus.BackColor = System.Drawing.Color.IndianRed;
            this.submenu2GateStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu2GateStatus.ForeColor = System.Drawing.Color.White;
            this.submenu2GateStatus.Image = ((System.Drawing.Image)(resources.GetObject("submenu2GateStatus.Image")));
            this.submenu2GateStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu2GateStatus.Location = new System.Drawing.Point(-4, -7);
            this.submenu2GateStatus.Margin = new System.Windows.Forms.Padding(0);
            this.submenu2GateStatus.Name = "submenu2GateStatus";
            this.submenu2GateStatus.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.submenu2GateStatus.Size = new System.Drawing.Size(314, 125);
            this.submenu2GateStatus.TabIndex = 2;
            this.submenu2GateStatus.Text = "Gate Status";
            this.submenu2GateStatus.UseVisualStyleBackColor = false;
            this.submenu2GateStatus.Click += new System.EventHandler(this.submenu2GateStatus_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.submenu2LightStatus);
            this.panel8.Location = new System.Drawing.Point(2, 230);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(308, 110);
            this.panel8.TabIndex = 7;
            // 
            // submenu2LightStatus
            // 
            this.submenu2LightStatus.BackColor = System.Drawing.Color.IndianRed;
            this.submenu2LightStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submenu2LightStatus.ForeColor = System.Drawing.Color.White;
            this.submenu2LightStatus.Image = ((System.Drawing.Image)(resources.GetObject("submenu2LightStatus.Image")));
            this.submenu2LightStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.submenu2LightStatus.Location = new System.Drawing.Point(-4, -7);
            this.submenu2LightStatus.Margin = new System.Windows.Forms.Padding(0);
            this.submenu2LightStatus.Name = "submenu2LightStatus";
            this.submenu2LightStatus.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.submenu2LightStatus.Size = new System.Drawing.Size(314, 125);
            this.submenu2LightStatus.TabIndex = 2;
            this.submenu2LightStatus.Text = "Light Status";
            this.submenu2LightStatus.UseVisualStyleBackColor = false;
            this.submenu2LightStatus.Click += new System.EventHandler(this.submenu2LightStatus_Click);
            // 
            // panelLogout
            // 
            this.panelLogout.Controls.Add(this.LogoutButton);
            this.panelLogout.Location = new System.Drawing.Point(2, 350);
            this.panelLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogout.Name = "panelLogout";
            this.panelLogout.Size = new System.Drawing.Size(308, 110);
            this.panelLogout.TabIndex = 8;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.Firebrick;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.Image")));
            this.LogoutButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogoutButton.Location = new System.Drawing.Point(-4, -7);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(0);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LogoutButton.Size = new System.Drawing.Size(314, 125);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Exit";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // controlTransition
            // 
            this.controlTransition.Interval = 3;
            this.controlTransition.Tick += new System.EventHandler(this.controlTransition_Tick);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 3;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // statusTransition
            // 
            this.statusTransition.Interval = 3;
            this.statusTransition.Tick += new System.EventHandler(this.statusTransition_Tick);
            // 
            // DigitalClock
            // 
            this.DigitalClock.Tick += new System.EventHandler(this.DigitalClock_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 684);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panelAboutUs.ResumeLayout(false);
            this.controlContainer.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.statusContainer.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panelLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panelAboutUs;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.Button submenu2GateStatus;
        private System.Windows.Forms.Button submenu2LightStatus;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel statusContainer;
        private System.Windows.Forms.Timer controlTransition;
        private System.Windows.Forms.Panel panelLogout;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Timer sidebarTransition;
        private System.Windows.Forms.Timer statusTransition;
        private System.Windows.Forms.FlowLayoutPanel controlContainer;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button ctrlButton;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button submenu1GateControl;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button submenu1LightSwitch;
        private System.Windows.Forms.Label Clock;
        private System.Windows.Forms.Timer DigitalClock;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

