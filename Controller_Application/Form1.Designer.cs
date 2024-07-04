namespace _230V_Device_USB_Controller
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox_RelayControl = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Relay1ON = new System.Windows.Forms.Button();
            this.button_Relay1OFF = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_Relay2OFF = new System.Windows.Forms.Button();
            this.button_Relay2ON = new System.Windows.Forms.Button();
            this.groupBox_DimmerControl = new System.Windows.Forms.GroupBox();
            this.label_luminosity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_dimmer = new System.Windows.Forms.TrackBar();
            this.comboBox_ports = new System.Windows.Forms.ComboBox();
            this.groupBox_connectivity = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_disconnect = new System.Windows.Forms.Button();
            this.button_connect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox_RelayControl.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox_DimmerControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_dimmer)).BeginInit();
            this.groupBox_connectivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_RelayControl
            // 
            this.groupBox_RelayControl.Controls.Add(this.groupBox3);
            this.groupBox_RelayControl.Controls.Add(this.groupBox4);
            this.groupBox_RelayControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_RelayControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox_RelayControl.Location = new System.Drawing.Point(284, 12);
            this.groupBox_RelayControl.Name = "groupBox_RelayControl";
            this.groupBox_RelayControl.Size = new System.Drawing.Size(465, 156);
            this.groupBox_RelayControl.TabIndex = 0;
            this.groupBox_RelayControl.TabStop = false;
            this.groupBox_RelayControl.Text = "Relay Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Relay1ON);
            this.groupBox3.Controls.Add(this.button_Relay1OFF);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(16, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 112);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relay 1";
            // 
            // button_Relay1ON
            // 
            this.button_Relay1ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Relay1ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Relay1ON.Location = new System.Drawing.Point(40, 24);
            this.button_Relay1ON.Name = "button_Relay1ON";
            this.button_Relay1ON.Size = new System.Drawing.Size(100, 37);
            this.button_Relay1ON.TabIndex = 0;
            this.button_Relay1ON.Text = "ON";
            this.button_Relay1ON.UseVisualStyleBackColor = true;
            this.button_Relay1ON.Click += new System.EventHandler(this.button_Relay1ON_Click);
            // 
            // button_Relay1OFF
            // 
            this.button_Relay1OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Relay1OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Relay1OFF.Location = new System.Drawing.Point(40, 67);
            this.button_Relay1OFF.Name = "button_Relay1OFF";
            this.button_Relay1OFF.Size = new System.Drawing.Size(100, 37);
            this.button_Relay1OFF.TabIndex = 1;
            this.button_Relay1OFF.Text = "OFF";
            this.button_Relay1OFF.UseVisualStyleBackColor = true;
            this.button_Relay1OFF.Click += new System.EventHandler(this.button_Relay1OFF_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_Relay2OFF);
            this.groupBox4.Controls.Add(this.button_Relay2ON);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox4.Location = new System.Drawing.Point(226, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 112);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relay 2";
            // 
            // button_Relay2OFF
            // 
            this.button_Relay2OFF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Relay2OFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Relay2OFF.Location = new System.Drawing.Point(50, 67);
            this.button_Relay2OFF.Name = "button_Relay2OFF";
            this.button_Relay2OFF.Size = new System.Drawing.Size(100, 37);
            this.button_Relay2OFF.TabIndex = 3;
            this.button_Relay2OFF.Text = "OFF";
            this.button_Relay2OFF.UseVisualStyleBackColor = true;
            this.button_Relay2OFF.Click += new System.EventHandler(this.button_Relay2OFF_Click);
            // 
            // button_Relay2ON
            // 
            this.button_Relay2ON.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Relay2ON.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_Relay2ON.Location = new System.Drawing.Point(50, 25);
            this.button_Relay2ON.Name = "button_Relay2ON";
            this.button_Relay2ON.Size = new System.Drawing.Size(100, 37);
            this.button_Relay2ON.TabIndex = 2;
            this.button_Relay2ON.Text = "ON";
            this.button_Relay2ON.UseVisualStyleBackColor = true;
            this.button_Relay2ON.Click += new System.EventHandler(this.button_Relay2ON_Click);
            // 
            // groupBox_DimmerControl
            // 
            this.groupBox_DimmerControl.Controls.Add(this.label_luminosity);
            this.groupBox_DimmerControl.Controls.Add(this.label2);
            this.groupBox_DimmerControl.Controls.Add(this.label1);
            this.groupBox_DimmerControl.Controls.Add(this.trackBar_dimmer);
            this.groupBox_DimmerControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_DimmerControl.Location = new System.Drawing.Point(284, 174);
            this.groupBox_DimmerControl.Name = "groupBox_DimmerControl";
            this.groupBox_DimmerControl.Size = new System.Drawing.Size(465, 134);
            this.groupBox_DimmerControl.TabIndex = 1;
            this.groupBox_DimmerControl.TabStop = false;
            this.groupBox_DimmerControl.Text = "Sine Wave Control";
            // 
            // label_luminosity
            // 
            this.label_luminosity.AutoSize = true;
            this.label_luminosity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_luminosity.Location = new System.Drawing.Point(154, 52);
            this.label_luminosity.Name = "label_luminosity";
            this.label_luminosity.Size = new System.Drawing.Size(89, 18);
            this.label_luminosity.TabIndex = 3;
            this.label_luminosity.Text = "Power = 0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(382, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "100%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(34, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "0%";
            // 
            // trackBar_dimmer
            // 
            this.trackBar_dimmer.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_dimmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar_dimmer.Location = new System.Drawing.Point(68, 75);
            this.trackBar_dimmer.Maximum = 9000;
            this.trackBar_dimmer.Minimum = 300;
            this.trackBar_dimmer.Name = "trackBar_dimmer";
            this.trackBar_dimmer.Size = new System.Drawing.Size(308, 45);
            this.trackBar_dimmer.TabIndex = 0;
            this.trackBar_dimmer.Value = 300;
            this.trackBar_dimmer.Scroll += new System.EventHandler(this.trackBar_dimmer_Scroll);
            // 
            // comboBox_ports
            // 
            this.comboBox_ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_ports.FormattingEnabled = true;
            this.comboBox_ports.Location = new System.Drawing.Point(36, 59);
            this.comboBox_ports.Name = "comboBox_ports";
            this.comboBox_ports.Size = new System.Drawing.Size(128, 28);
            this.comboBox_ports.Sorted = true;
            this.comboBox_ports.TabIndex = 2;
            this.comboBox_ports.DropDown += new System.EventHandler(this.comboBox_ports_DropDown);
            // 
            // groupBox_connectivity
            // 
            this.groupBox_connectivity.Controls.Add(this.label3);
            this.groupBox_connectivity.Controls.Add(this.button_disconnect);
            this.groupBox_connectivity.Controls.Add(this.button_connect);
            this.groupBox_connectivity.Controls.Add(this.comboBox_ports);
            this.groupBox_connectivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_connectivity.Location = new System.Drawing.Point(21, 12);
            this.groupBox_connectivity.Name = "groupBox_connectivity";
            this.groupBox_connectivity.Size = new System.Drawing.Size(200, 181);
            this.groupBox_connectivity.TabIndex = 3;
            this.groupBox_connectivity.TabStop = false;
            this.groupBox_connectivity.Text = "Connectivity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(57, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "COM Port";
            // 
            // button_disconnect
            // 
            this.button_disconnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_disconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_disconnect.Location = new System.Drawing.Point(36, 149);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.Size = new System.Drawing.Size(128, 26);
            this.button_disconnect.TabIndex = 4;
            this.button_disconnect.Text = "Disconnect";
            this.button_disconnect.UseVisualStyleBackColor = true;
            this.button_disconnect.Click += new System.EventHandler(this.button_disconnect_Click);
            // 
            // button_connect
            // 
            this.button_connect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_connect.Location = new System.Drawing.Point(36, 117);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(128, 26);
            this.button_connect.TabIndex = 3;
            this.button_connect.Text = "Connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(21, 211);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox_connectivity);
            this.Controls.Add(this.groupBox_DimmerControl);
            this.Controls.Add(this.groupBox_RelayControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "230V USB Controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_RelayControl.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox_DimmerControl.ResumeLayout(false);
            this.groupBox_DimmerControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_dimmer)).EndInit();
            this.groupBox_connectivity.ResumeLayout(false);
            this.groupBox_connectivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_RelayControl;
        private System.Windows.Forms.Button button_Relay1OFF;
        private System.Windows.Forms.Button button_Relay1ON;
        private System.Windows.Forms.GroupBox groupBox_DimmerControl;
        private System.Windows.Forms.Button button_Relay2OFF;
        private System.Windows.Forms.Button button_Relay2ON;
        private System.Windows.Forms.TrackBar trackBar_dimmer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_luminosity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox_ports;
        private System.Windows.Forms.GroupBox groupBox_connectivity;
        private System.Windows.Forms.Button button_connect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_disconnect;
        private System.Windows.Forms.Label label3;
    }
}

