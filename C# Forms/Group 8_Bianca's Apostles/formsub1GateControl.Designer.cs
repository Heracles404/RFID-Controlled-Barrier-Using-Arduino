namespace Group_8_Bianca_s_Apostles
{
    partial class formsub1GateControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formsub1GateControl));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenGate = new System.Windows.Forms.Button();
            this.btnCloseGate = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(686, 361);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "GATE CONTROL";
            // 
            // btnOpenGate
            // 
            this.btnOpenGate.BackColor = System.Drawing.Color.Firebrick;
            this.btnOpenGate.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenGate.ForeColor = System.Drawing.Color.White;
            this.btnOpenGate.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenGate.Image")));
            this.btnOpenGate.Location = new System.Drawing.Point(580, 447);
            this.btnOpenGate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenGate.Name = "btnOpenGate";
            this.btnOpenGate.Size = new System.Drawing.Size(191, 113);
            this.btnOpenGate.TabIndex = 1;
            this.btnOpenGate.Text = " ";
            this.btnOpenGate.UseVisualStyleBackColor = false;
            this.btnOpenGate.Click += new System.EventHandler(this.btnOpenGate_Click);
            // 
            // btnCloseGate
            // 
            this.btnCloseGate.BackColor = System.Drawing.Color.Firebrick;
            this.btnCloseGate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseGate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseGate.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseGate.Image")));
            this.btnCloseGate.Location = new System.Drawing.Point(847, 448);
            this.btnCloseGate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseGate.Name = "btnCloseGate";
            this.btnCloseGate.Size = new System.Drawing.Size(191, 113);
            this.btnCloseGate.TabIndex = 2;
            this.btnCloseGate.Text = " ";
            this.btnCloseGate.UseVisualStyleBackColor = false;
            this.btnCloseGate.Click += new System.EventHandler(this.btnCloseGate_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM9";
            // 
            // formsub1GateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 722);
            this.Controls.Add(this.btnCloseGate);
            this.Controls.Add(this.btnOpenGate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formsub1GateControl";
            this.Text = "sub1GateControl";
            this.Load += new System.EventHandler(this.form1GateControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenGate;
        private System.Windows.Forms.Button btnCloseGate;
        private System.IO.Ports.SerialPort serialPort1;
    }
}