namespace Group_8_Bianca_s_Apostles
{
    partial class formsub1LightSwitch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsub1LightSwitch));
            this.btnLightOn = new System.Windows.Forms.Button();
            this.btnLightOff = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // btnLightOn
            // 
            this.btnLightOn.BackColor = System.Drawing.Color.Gray;
            this.btnLightOn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLightOn.Location = new System.Drawing.Point(375, 305);
            this.btnLightOn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLightOn.Name = "btnLightOn";
            this.btnLightOn.Size = new System.Drawing.Size(133, 72);
            this.btnLightOn.TabIndex = 1;
            this.btnLightOn.Text = "ON";
            this.btnLightOn.UseVisualStyleBackColor = false;
            this.btnLightOn.Click += new System.EventHandler(this.btnLightOn_Click);
            // 
            // btnLightOff
            // 
            this.btnLightOff.BackColor = System.Drawing.Color.IndianRed;
            this.btnLightOff.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLightOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLightOff.Location = new System.Drawing.Point(1114, 411);
            this.btnLightOff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLightOff.Name = "btnLightOff";
            this.btnLightOff.Size = new System.Drawing.Size(133, 72);
            this.btnLightOff.TabIndex = 2;
            this.btnLightOff.Text = "OFF";
            this.btnLightOff.UseVisualStyleBackColor = false;
            this.btnLightOff.Click += new System.EventHandler(this.btnLightOff_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            // 
            // formsub1LightSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1211, 722);
            this.Controls.Add(this.btnLightOff);
            this.Controls.Add(this.btnLightOn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formsub1LightSwitch";
            this.ShowIcon = false;
            this.Text = "sub1LightSwitch";
            this.Load += new System.EventHandler(this.form1LightSwitch_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLightOn;
        private System.Windows.Forms.Button btnLightOff;
        private System.IO.Ports.SerialPort serialPort1;
    }
}