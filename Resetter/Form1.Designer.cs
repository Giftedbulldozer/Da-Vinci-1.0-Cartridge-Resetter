namespace Resetter
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.cmbxSerialPorts = new System.Windows.Forms.ComboBox();
            this.lblPorts = new System.Windows.Forms.Label();
            this.cmbxFilementLength = new System.Windows.Forms.ComboBox();
            this.lblFilementLength = new System.Windows.Forms.Label();
            this.lblBaudRate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbxExtruderTemp = new System.Windows.Forms.ComboBox();
            this.lblExtrudeTemp = new System.Windows.Forms.Label();
            this.lblBedTemp = new System.Windows.Forms.Label();
            this.cmbxBedTemp = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReadSettings = new System.Windows.Forms.Button();
            this.grpbxArdSettings = new System.Windows.Forms.GroupBox();
            this.cmbxFilementType = new System.Windows.Forms.ComboBox();
            this.lblFilementType = new System.Windows.Forms.Label();
            this.btnUpdateBoard = new System.Windows.Forms.Button();
            this.txtSerialMonitor = new System.Windows.Forms.TextBox();
            this.lblSerialMonitor = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpbxArdSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // cmbxSerialPorts
            // 
            this.cmbxSerialPorts.FormattingEnabled = true;
            this.cmbxSerialPorts.Location = new System.Drawing.Point(6, 51);
            this.cmbxSerialPorts.Name = "cmbxSerialPorts";
            this.cmbxSerialPorts.Size = new System.Drawing.Size(121, 21);
            this.cmbxSerialPorts.TabIndex = 0;
            // 
            // lblPorts
            // 
            this.lblPorts.AutoSize = true;
            this.lblPorts.Location = new System.Drawing.Point(6, 32);
            this.lblPorts.Name = "lblPorts";
            this.lblPorts.Size = new System.Drawing.Size(77, 13);
            this.lblPorts.TabIndex = 1;
            this.lblPorts.Text = "Available Ports";
            // 
            // cmbxFilementLength
            // 
            this.cmbxFilementLength.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxFilementLength.FormattingEnabled = true;
            this.cmbxFilementLength.Items.AddRange(new object[] {
            "120",
            "240",
            "400"});
            this.cmbxFilementLength.Location = new System.Drawing.Point(12, 219);
            this.cmbxFilementLength.Name = "cmbxFilementLength";
            this.cmbxFilementLength.Size = new System.Drawing.Size(121, 21);
            this.cmbxFilementLength.TabIndex = 4;
            // 
            // lblFilementLength
            // 
            this.lblFilementLength.AutoSize = true;
            this.lblFilementLength.Location = new System.Drawing.Point(12, 203);
            this.lblFilementLength.Name = "lblFilementLength";
            this.lblFilementLength.Size = new System.Drawing.Size(82, 13);
            this.lblFilementLength.TabIndex = 3;
            this.lblFilementLength.Text = "Filement Length";
            // 
            // lblBaudRate
            // 
            this.lblBaudRate.AutoSize = true;
            this.lblBaudRate.Location = new System.Drawing.Point(6, 98);
            this.lblBaudRate.Name = "lblBaudRate";
            this.lblBaudRate.Size = new System.Drawing.Size(55, 13);
            this.lblBaudRate.TabIndex = 4;
            this.lblBaudRate.Text = "BaudRate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // cmbxExtruderTemp
            // 
            this.cmbxExtruderTemp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxExtruderTemp.FormattingEnabled = true;
            this.cmbxExtruderTemp.Items.AddRange(new object[] {
            "210",
            "220",
            "230",
            "240",
            "250"});
            this.cmbxExtruderTemp.Location = new System.Drawing.Point(12, 284);
            this.cmbxExtruderTemp.Name = "cmbxExtruderTemp";
            this.cmbxExtruderTemp.Size = new System.Drawing.Size(121, 21);
            this.cmbxExtruderTemp.TabIndex = 5;
            // 
            // lblExtrudeTemp
            // 
            this.lblExtrudeTemp.AutoSize = true;
            this.lblExtrudeTemp.Location = new System.Drawing.Point(9, 268);
            this.lblExtrudeTemp.Name = "lblExtrudeTemp";
            this.lblExtrudeTemp.Size = new System.Drawing.Size(100, 13);
            this.lblExtrudeTemp.TabIndex = 7;
            this.lblExtrudeTemp.Text = "Extruder Tempature";
            // 
            // lblBedTemp
            // 
            this.lblBedTemp.AutoSize = true;
            this.lblBedTemp.Location = new System.Drawing.Point(198, 203);
            this.lblBedTemp.Name = "lblBedTemp";
            this.lblBedTemp.Size = new System.Drawing.Size(80, 13);
            this.lblBedTemp.TabIndex = 8;
            this.lblBedTemp.Text = "Bed Tempature";
            // 
            // cmbxBedTemp
            // 
            this.cmbxBedTemp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxBedTemp.FormattingEnabled = true;
            this.cmbxBedTemp.Location = new System.Drawing.Point(198, 219);
            this.cmbxBedTemp.Name = "cmbxBedTemp";
            this.cmbxBedTemp.Size = new System.Drawing.Size(121, 21);
            this.cmbxBedTemp.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnReadSettings
            // 
            this.btnReadSettings.Location = new System.Drawing.Point(164, 75);
            this.btnReadSettings.Name = "btnReadSettings";
            this.btnReadSettings.Size = new System.Drawing.Size(84, 23);
            this.btnReadSettings.TabIndex = 3;
            this.btnReadSettings.Text = "Read Arduino";
            this.btnReadSettings.UseVisualStyleBackColor = true;
            this.btnReadSettings.Click += new System.EventHandler(this.btnReadSettings_Click);
            // 
            // grpbxArdSettings
            // 
            this.grpbxArdSettings.Controls.Add(this.cmbxSerialPorts);
            this.grpbxArdSettings.Controls.Add(this.btnReadSettings);
            this.grpbxArdSettings.Controls.Add(this.lblPorts);
            this.grpbxArdSettings.Controls.Add(this.lblBaudRate);
            this.grpbxArdSettings.Controls.Add(this.comboBox1);
            this.grpbxArdSettings.Location = new System.Drawing.Point(12, 33);
            this.grpbxArdSettings.Name = "grpbxArdSettings";
            this.grpbxArdSettings.Size = new System.Drawing.Size(328, 167);
            this.grpbxArdSettings.TabIndex = 12;
            this.grpbxArdSettings.TabStop = false;
            this.grpbxArdSettings.Text = "Arduino Settings";
            // 
            // cmbxFilementType
            // 
            this.cmbxFilementType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbxFilementType.FormattingEnabled = true;
            this.cmbxFilementType.Items.AddRange(new object[] {
            "ABS",
            "PLA"});
            this.cmbxFilementType.Location = new System.Drawing.Point(198, 278);
            this.cmbxFilementType.Name = "cmbxFilementType";
            this.cmbxFilementType.Size = new System.Drawing.Size(121, 21);
            this.cmbxFilementType.TabIndex = 7;
            // 
            // lblFilementType
            // 
            this.lblFilementType.AutoSize = true;
            this.lblFilementType.Location = new System.Drawing.Point(198, 262);
            this.lblFilementType.Name = "lblFilementType";
            this.lblFilementType.Size = new System.Drawing.Size(70, 13);
            this.lblFilementType.TabIndex = 14;
            this.lblFilementType.Text = "FilementType";
            // 
            // btnUpdateBoard
            // 
            this.btnUpdateBoard.Location = new System.Drawing.Point(114, 367);
            this.btnUpdateBoard.Name = "btnUpdateBoard";
            this.btnUpdateBoard.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBoard.TabIndex = 8;
            this.btnUpdateBoard.Text = "Update";
            this.btnUpdateBoard.UseVisualStyleBackColor = true;
            this.btnUpdateBoard.Click += new System.EventHandler(this.btnUpdateBoard_Click);
            // 
            // txtSerialMonitor
            // 
            this.txtSerialMonitor.Location = new System.Drawing.Point(402, 46);
            this.txtSerialMonitor.Multiline = true;
            this.txtSerialMonitor.Name = "txtSerialMonitor";
            this.txtSerialMonitor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSerialMonitor.Size = new System.Drawing.Size(386, 392);
            this.txtSerialMonitor.TabIndex = 16;
            // 
            // lblSerialMonitor
            // 
            this.lblSerialMonitor.AutoSize = true;
            this.lblSerialMonitor.Location = new System.Drawing.Point(399, 33);
            this.lblSerialMonitor.Name = "lblSerialMonitor";
            this.lblSerialMonitor.Size = new System.Drawing.Size(68, 13);
            this.lblSerialMonitor.TabIndex = 17;
            this.lblSerialMonitor.Text = "SerialMonitor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSerialMonitor);
            this.Controls.Add(this.txtSerialMonitor);
            this.Controls.Add(this.btnUpdateBoard);
            this.Controls.Add(this.lblFilementType);
            this.Controls.Add(this.cmbxFilementType);
            this.Controls.Add(this.grpbxArdSettings);
            this.Controls.Add(this.cmbxBedTemp);
            this.Controls.Add(this.lblBedTemp);
            this.Controls.Add(this.lblExtrudeTemp);
            this.Controls.Add(this.cmbxExtruderTemp);
            this.Controls.Add(this.lblFilementLength);
            this.Controls.Add(this.cmbxFilementLength);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbxArdSettings.ResumeLayout(false);
            this.grpbxArdSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cmbxSerialPorts;
        private System.Windows.Forms.Label lblPorts;
        private System.Windows.Forms.ComboBox cmbxFilementLength;
        private System.Windows.Forms.Label lblFilementLength;
        private System.Windows.Forms.Label lblBaudRate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbxExtruderTemp;
        private System.Windows.Forms.Label lblExtrudeTemp;
        private System.Windows.Forms.Label lblBedTemp;
        private System.Windows.Forms.ComboBox cmbxBedTemp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnReadSettings;
        private System.Windows.Forms.GroupBox grpbxArdSettings;
        private System.Windows.Forms.ComboBox cmbxFilementType;
        private System.Windows.Forms.Label lblFilementType;
        private System.Windows.Forms.Button btnUpdateBoard;
        private System.Windows.Forms.TextBox txtSerialMonitor;
        private System.Windows.Forms.Label lblSerialMonitor;
    }
}

