namespace PlantillTallerArduino
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_Door = new System.Windows.Forms.PictureBox();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.btnCloseDoor = new System.Windows.Forms.Button();
            this.btnOpenG = new System.Windows.Forms.Button();
            this.btnCloseG = new System.Windows.Forms.Button();
            this.pb_Garage = new System.Windows.Forms.PictureBox();
            this.light_5 = new System.Windows.Forms.PictureBox();
            this.light_7 = new System.Windows.Forms.PictureBox();
            this.light_6 = new System.Windows.Forms.PictureBox();
            this.light_4 = new System.Windows.Forms.PictureBox();
            this.light_1 = new System.Windows.Forms.PictureBox();
            this.light_2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.light_3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Garage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_3)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Door
            // 
            this.pb_Door.BackColor = System.Drawing.Color.Transparent;
            this.pb_Door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Door.Location = new System.Drawing.Point(405, 439);
            this.pb_Door.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Door.Name = "pb_Door";
            this.pb_Door.Size = new System.Drawing.Size(56, 123);
            this.pb_Door.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Door.TabIndex = 1;
            this.pb_Door.TabStop = false;
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.Location = new System.Drawing.Point(16, 15);
            this.btnOpenDoor.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(100, 28);
            this.btnOpenDoor.TabIndex = 2;
            this.btnOpenDoor.Text = "Open D";
            this.btnOpenDoor.UseVisualStyleBackColor = true;
            this.btnOpenDoor.Click += new System.EventHandler(this.btnOpenDoor_Click);
            // 
            // btnCloseDoor
            // 
            this.btnCloseDoor.Enabled = false;
            this.btnCloseDoor.Location = new System.Drawing.Point(141, 14);
            this.btnCloseDoor.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseDoor.Name = "btnCloseDoor";
            this.btnCloseDoor.Size = new System.Drawing.Size(100, 28);
            this.btnCloseDoor.TabIndex = 3;
            this.btnCloseDoor.Text = "Close D";
            this.btnCloseDoor.UseVisualStyleBackColor = true;
            this.btnCloseDoor.Click += new System.EventHandler(this.btnCloseDoor_Click);
            // 
            // btnOpenG
            // 
            this.btnOpenG.Location = new System.Drawing.Point(571, 15);
            this.btnOpenG.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpenG.Name = "btnOpenG";
            this.btnOpenG.Size = new System.Drawing.Size(100, 28);
            this.btnOpenG.TabIndex = 4;
            this.btnOpenG.Text = "Open G";
            this.btnOpenG.UseVisualStyleBackColor = true;
            this.btnOpenG.Click += new System.EventHandler(this.btnOpenG_Click);
            // 
            // btnCloseG
            // 
            this.btnCloseG.Enabled = false;
            this.btnCloseG.Location = new System.Drawing.Point(700, 15);
            this.btnCloseG.Margin = new System.Windows.Forms.Padding(4);
            this.btnCloseG.Name = "btnCloseG";
            this.btnCloseG.Size = new System.Drawing.Size(100, 28);
            this.btnCloseG.TabIndex = 5;
            this.btnCloseG.Text = "Close G";
            this.btnCloseG.UseVisualStyleBackColor = true;
            this.btnCloseG.Click += new System.EventHandler(this.btnCloseG_Click);
            // 
            // pb_Garage
            // 
            this.pb_Garage.BackColor = System.Drawing.Color.Transparent;
            this.pb_Garage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Garage.Location = new System.Drawing.Point(663, 425);
            this.pb_Garage.Margin = new System.Windows.Forms.Padding(4);
            this.pb_Garage.Name = "pb_Garage";
            this.pb_Garage.Size = new System.Drawing.Size(367, 134);
            this.pb_Garage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Garage.TabIndex = 6;
            this.pb_Garage.TabStop = false;
            // 
            // light_5
            // 
            this.light_5.BackColor = System.Drawing.Color.Transparent;
            this.light_5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light_5.BackgroundImage")));
            this.light_5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_5.Location = new System.Drawing.Point(147, 132);
            this.light_5.Margin = new System.Windows.Forms.Padding(4);
            this.light_5.Name = "light_5";
            this.light_5.Size = new System.Drawing.Size(107, 49);
            this.light_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_5.TabIndex = 7;
            this.light_5.TabStop = false;
            this.light_5.Click += new System.EventHandler(this.light_5_Click);
            // 
            // light_7
            // 
            this.light_7.BackColor = System.Drawing.Color.Transparent;
            this.light_7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light_7.BackgroundImage")));
            this.light_7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_7.Location = new System.Drawing.Point(355, 101);
            this.light_7.Margin = new System.Windows.Forms.Padding(4);
            this.light_7.Name = "light_7";
            this.light_7.Size = new System.Drawing.Size(107, 49);
            this.light_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_7.TabIndex = 8;
            this.light_7.TabStop = false;
            this.light_7.Click += new System.EventHandler(this.light_7_Click);
            // 
            // light_6
            // 
            this.light_6.BackColor = System.Drawing.Color.Transparent;
            this.light_6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light_6.BackgroundImage")));
            this.light_6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_6.Location = new System.Drawing.Point(400, 172);
            this.light_6.Margin = new System.Windows.Forms.Padding(4);
            this.light_6.Name = "light_6";
            this.light_6.Size = new System.Drawing.Size(120, 62);
            this.light_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_6.TabIndex = 9;
            this.light_6.TabStop = false;
            this.light_6.Click += new System.EventHandler(this.light_6_Click);
            // 
            // light_4
            // 
            this.light_4.BackColor = System.Drawing.Color.Transparent;
            this.light_4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light_4.BackgroundImage")));
            this.light_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_4.Location = new System.Drawing.Point(380, 346);
            this.light_4.Margin = new System.Windows.Forms.Padding(4);
            this.light_4.Name = "light_4";
            this.light_4.Size = new System.Drawing.Size(133, 74);
            this.light_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_4.TabIndex = 11;
            this.light_4.TabStop = false;
            this.light_4.Click += new System.EventHandler(this.light_4_Click);
            // 
            // light_1
            // 
            this.light_1.BackColor = System.Drawing.Color.Transparent;
            this.light_1.BackgroundImage = global::PlantillTallerArduino.Properties.Resources.lightOff;
            this.light_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_1.Location = new System.Drawing.Point(47, 479);
            this.light_1.Margin = new System.Windows.Forms.Padding(4);
            this.light_1.Name = "light_1";
            this.light_1.Size = new System.Drawing.Size(120, 74);
            this.light_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_1.TabIndex = 12;
            this.light_1.TabStop = false;
            this.light_1.Click += new System.EventHandler(this.light_1_Click);
            // 
            // light_2
            // 
            this.light_2.BackColor = System.Drawing.Color.Transparent;
            this.light_2.BackgroundImage = global::PlantillTallerArduino.Properties.Resources.lightOff;
            this.light_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_2.Location = new System.Drawing.Point(193, 479);
            this.light_2.Margin = new System.Windows.Forms.Padding(4);
            this.light_2.Name = "light_2";
            this.light_2.Size = new System.Drawing.Size(120, 74);
            this.light_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_2.TabIndex = 13;
            this.light_2.TabStop = false;
            this.light_2.Click += new System.EventHandler(this.light_2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 479);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Turn on";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "Turn off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // light_3
            // 
            this.light_3.BackColor = System.Drawing.Color.Transparent;
            this.light_3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("light_3.BackgroundImage")));
            this.light_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.light_3.Location = new System.Drawing.Point(108, 346);
            this.light_3.Margin = new System.Windows.Forms.Padding(4);
            this.light_3.Name = "light_3";
            this.light_3.Size = new System.Drawing.Size(133, 74);
            this.light_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.light_3.TabIndex = 10;
            this.light_3.TabStop = false;
            this.light_3.Click += new System.EventHandler(this.light_3_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort
            // 
            this.serialPort.PinChanged += new System.IO.Ports.SerialPinChangedEventHandler(this.serialPort_PinChanged);
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 558);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.light_2);
            this.Controls.Add(this.light_1);
            this.Controls.Add(this.light_4);
            this.Controls.Add(this.light_3);
            this.Controls.Add(this.light_6);
            this.Controls.Add(this.light_7);
            this.Controls.Add(this.light_5);
            this.Controls.Add(this.pb_Garage);
            this.Controls.Add(this.btnCloseG);
            this.Controls.Add(this.btnOpenG);
            this.Controls.Add(this.btnCloseDoor);
            this.Controls.Add(this.btnOpenDoor);
            this.Controls.Add(this.pb_Door);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 605);
            this.MinimumSize = new System.Drawing.Size(1061, 605);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Garage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.light_3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_Door;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.Button btnCloseDoor;
        private System.Windows.Forms.Button btnOpenG;
        private System.Windows.Forms.Button btnCloseG;
        private System.Windows.Forms.PictureBox pb_Garage;
        private System.Windows.Forms.PictureBox light_5;
        private System.Windows.Forms.PictureBox light_7;
        private System.Windows.Forms.PictureBox light_6;
        private System.Windows.Forms.PictureBox light_4;
        private System.Windows.Forms.PictureBox light_1;
        private System.Windows.Forms.PictureBox light_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox light_3;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort;
    }
}

