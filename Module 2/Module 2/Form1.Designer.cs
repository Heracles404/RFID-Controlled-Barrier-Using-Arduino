namespace Module_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.OpenGate = new System.Windows.Forms.Button();
            this.CloseGate = new System.Windows.Forms.Button();
            this.LockGate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LightOn = new System.Windows.Forms.Button();
            this.LightOff = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gateStat = new System.Windows.Forms.Label();
            this.lightStat = new System.Windows.Forms.Label();
            this.UnlockGate = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gate Control";
            // 
            // OpenGate
            // 
            this.OpenGate.Location = new System.Drawing.Point(66, 58);
            this.OpenGate.Margin = new System.Windows.Forms.Padding(2);
            this.OpenGate.Name = "OpenGate";
            this.OpenGate.Size = new System.Drawing.Size(56, 19);
            this.OpenGate.TabIndex = 1;
            this.OpenGate.Text = "Open";
            this.OpenGate.UseVisualStyleBackColor = true;
            this.OpenGate.Click += new System.EventHandler(this.button1_Click);
            // 
            // CloseGate
            // 
            this.CloseGate.Location = new System.Drawing.Point(66, 104);
            this.CloseGate.Margin = new System.Windows.Forms.Padding(2);
            this.CloseGate.Name = "CloseGate";
            this.CloseGate.Size = new System.Drawing.Size(56, 19);
            this.CloseGate.TabIndex = 2;
            this.CloseGate.Text = "Close";
            this.CloseGate.UseVisualStyleBackColor = true;
            this.CloseGate.Click += new System.EventHandler(this.CloseGate_Click);
            // 
            // LockGate
            // 
            this.LockGate.Location = new System.Drawing.Point(156, 58);
            this.LockGate.Margin = new System.Windows.Forms.Padding(2);
            this.LockGate.Name = "LockGate";
            this.LockGate.Size = new System.Drawing.Size(56, 19);
            this.LockGate.TabIndex = 3;
            this.LockGate.Text = "Lock ";
            this.LockGate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Light Switch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Status";
            // 
            // LightOn
            // 
            this.LightOn.Location = new System.Drawing.Point(108, 284);
            this.LightOn.Margin = new System.Windows.Forms.Padding(2);
            this.LightOn.Name = "LightOn";
            this.LightOn.Size = new System.Drawing.Size(56, 19);
            this.LightOn.TabIndex = 6;
            this.LightOn.Text = "On";
            this.LightOn.UseVisualStyleBackColor = true;
            // 
            // LightOff
            // 
            this.LightOff.Location = new System.Drawing.Point(110, 327);
            this.LightOff.Margin = new System.Windows.Forms.Padding(2);
            this.LightOff.Name = "LightOff";
            this.LightOff.Size = new System.Drawing.Size(56, 19);
            this.LightOff.TabIndex = 7;
            this.LightOff.Text = "Off";
            this.LightOff.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Barrier / Gate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Light";
            // 
            // gateStat
            // 
            this.gateStat.AutoSize = true;
            this.gateStat.Location = new System.Drawing.Point(543, 86);
            this.gateStat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gateStat.Name = "gateStat";
            this.gateStat.Size = new System.Drawing.Size(35, 13);
            this.gateStat.TabIndex = 10;
            this.gateStat.Text = "label6";
            // 
            // lightStat
            // 
            this.lightStat.AutoSize = true;
            this.lightStat.Location = new System.Drawing.Point(543, 263);
            this.lightStat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lightStat.Name = "lightStat";
            this.lightStat.Size = new System.Drawing.Size(35, 13);
            this.lightStat.TabIndex = 11;
            this.lightStat.Text = "label7";
            // 
            // UnlockGate
            // 
            this.UnlockGate.Location = new System.Drawing.Point(156, 104);
            this.UnlockGate.Margin = new System.Windows.Forms.Padding(2);
            this.UnlockGate.Name = "UnlockGate";
            this.UnlockGate.Size = new System.Drawing.Size(56, 19);
            this.UnlockGate.TabIndex = 12;
            this.UnlockGate.Text = "Unlock";
            this.UnlockGate.UseVisualStyleBackColor = true;
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 459);
            this.Controls.Add(this.UnlockGate);
            this.Controls.Add(this.lightStat);
            this.Controls.Add(this.gateStat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LightOff);
            this.Controls.Add(this.LightOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LockGate);
            this.Controls.Add(this.CloseGate);
            this.Controls.Add(this.OpenGate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button OpenGate;
        private System.Windows.Forms.Button CloseGate;
        private System.Windows.Forms.Button LockGate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LightOn;
        private System.Windows.Forms.Button LightOff;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gateStat;
        private System.Windows.Forms.Label lightStat;
        private System.Windows.Forms.Button UnlockGate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer;
    }
}

