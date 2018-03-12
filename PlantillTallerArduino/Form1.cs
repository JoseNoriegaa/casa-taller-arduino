using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlantillTallerArduino.Properties;
using System.Threading;
using System.IO.Ports;

namespace PlantillTallerArduino
{
    public partial class Form1 : Form
    {
        List<Image> spritesGarage = new List<Image>();
        List<Image> spritesDoor = new List<Image>();
        List<PictureBox> lights = new List<PictureBox>();
        ArduinoConf arduino = new ArduinoConf(9600);
        bool LED1On = false, LED2On = false, LED3On = false, LED4On = false, LED5On = false;
        //SerialPort serialPort;
        string instrucciones = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            serialPort = arduino.getSerialPort();
            try
            {
                serialPort.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Fallo la conexión al puerto serial");
            }

            getLights();
            getSprites();
            this.pb_Door.BackgroundImage = Resources.p1;
            this.pb_Garage.BackgroundImage = Resources.c1;
            this.pb_Garage.BackgroundImageLayout = ImageLayout.Stretch;
            this.pb_Door.BackgroundImageLayout = ImageLayout.Stretch;
        }




        #region Events


        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            new Thread(new ParameterizedThreadStart(door)).Start(true);
            btnOpenDoor.Enabled = false;
            btnCloseDoor.Enabled = true;
            
        }

        
        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            new Thread(new ParameterizedThreadStart(door)).Start(false);
            btnOpenDoor.Enabled = true;
            btnCloseDoor.Enabled = false;

        }

        private void btnOpenG_Click(object sender, EventArgs e)
        {            
            btnOpenG.Enabled = false;
            new Thread(new ParameterizedThreadStart(garage)).Start(true);
            btnCloseG.Enabled = true;
        }
        
        private void btnCloseG_Click(object sender, EventArgs e)
        {
            btnCloseG.Enabled = false;            
            new Thread(new ParameterizedThreadStart(garage)).Start(false);
            btnOpenG.Enabled = true;
        }

        private void light_6_Click(object sender, EventArgs e)
        {
            if (LED3On)
            {
                switchLight(false, 5);
                Thread.Sleep(50);
                serialPort.Write(0 + "");
                LED3On = false;
            }
            else
            {
                switchLight(true, 5);
                Thread.Sleep(50);
                serialPort.Write(4 + "");
                LED3On = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            allLights(true, 50);
            serialPort.Write(1 + "");
            //MessageBox.Show(serialPort.ReadLine());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            allLights(false, 50);
            serialPort.Write(0 + "");
        }


        #endregion


        #region Methods
        /// <summary>
        /// Enciende o apaga todas las luces de la casa
        /// </summary>
        /// <param name="state">Indica verdadero para encenderlas o falso para apagarlas</param>
        /// <param name="time">Establece el intervalo en el que las luces encienden</param>
        void allLights(bool state, int time)
        {
            new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < lights.Count; i++)
                {
                    switchLight(state, i);
                    Thread.Sleep(time);
                }
            })).Start();
        }
        /// <summary>
        /// Llena la lista "lights" para poder acceder con facilidad a los pictureBox
        /// </summary>
        void getLights()
        {
            lights.Add(light_1);
            lights.Add(light_2);
            lights.Add(light_3);
            lights.Add(light_4);
            lights.Add(light_5);
            lights.Add(light_6);
            lights.Add(light_7);

        }
        /// <summary>
        /// Llena la lista "spritesGarage" con las imagenes necesarias para la animación del 'garage',
        /// LLena la lista "spritesDoor" con las imagenes necesarias para la animación de la puerta
        /// </summary>
        void getSprites()
        {
            spritesGarage.Add(Resources.c1);
            spritesGarage.Add(Resources.c2);
            spritesGarage.Add(Resources.c3);
            spritesGarage.Add(Resources.c4);
            spritesGarage.Add(Resources.c5);
            spritesGarage.Add(Resources.c6);
            spritesGarage.Add(Resources.c7);
            spritesGarage.Add(Resources.c8);
            spritesGarage.Add(Resources.c9);
            spritesGarage.Add(Resources.c10);
            spritesGarage.Add(Resources.c11);
            spritesGarage.Add(Resources.c12);
            spritesGarage.Add(Resources.c13);
            spritesGarage.Add(Resources.c14);
            spritesGarage.Add(Resources.c15);
            spritesGarage.Add(Resources.c17);
            spritesGarage.Add(Resources.C18);

            spritesDoor.Add(Resources.p1);
            spritesDoor.Add(Resources.p2);
            spritesDoor.Add(Resources.p3);
            spritesDoor.Add(Resources.p4);
            spritesDoor.Add(Resources.p5);
            spritesDoor.Add(Resources.p6);
            spritesDoor.Add(Resources.p7);
            spritesDoor.Add(Resources.p8);

        }
        /// <summary>
        /// Crea la animación para abrir o cerrar el garage,
        /// este método se utiliza como parámetro en la instrucción 'ParameterizedThreadStart()'
        /// </summary>
        /// <param name="obj">(true) para abrir (false) para cerrar</param>
        public void garage(object obj)
        {
            try
            {
                var status = (bool)obj;

                this.pb_Garage.SizeMode = PictureBoxSizeMode.StretchImage;

                if (status)
                {

                    for (int i = 0; i < 17; i++)
                    {
                        Thread.Sleep(100);

                        pb_Garage.BackgroundImage = spritesGarage[i];
                    }
                }
                else
                {
                    for (int i = 16; i >= 0; i--)
                    {
                        pb_Garage.BackgroundImage = spritesGarage[i];
                        Thread.Sleep(100);
                    }           
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// Crea la animación para abrir la puerta principal
        /// este método se utiliza como parámetro en la instrucción 'ParameterizedThreadStart()'
        /// </summary>
        /// <param name="obj">(true) para abrir puerta y (false) para cerrar</param>
        private void door(object obj)
        {

            try
            {
                var status = (bool)obj;

                if (status)
                {

                    for (int i = 0; i < spritesDoor.Count; i++)
                    {
                        Thread.Sleep(70);

                        pb_Door.BackgroundImage = spritesDoor[i];
                    }
                }
                else
                {
                    for (int i = spritesDoor.Count-1; i >= 0; i--)
                    {
                        pb_Door.BackgroundImage = spritesDoor[i];
                        Thread.Sleep(70);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }


        }
        /// <summary>
        /// Cambia la imagen de un foco
        /// </summary>
        /// <param name="status"> Indica (true) para cambiar al foco encendido y (false) para el foco apagado </param>
        /// <param name="light"> Indica el numero de foco que desea encender en referencia al lista 'lights'</param>
        void switchLight(bool status, int light)
        {
            try
            {
                if (light < lights.Count)
                {
                    lights[light].BackgroundImageLayout = ImageLayout.Stretch;
                    if (status)
                    {
                        lights[light].BackgroundImage = Resources.lightOn;
                    }
                    else
                    {
                        lights[light].BackgroundImage = Resources.lightOff;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        #endregion

        private void light_2_Click(object sender, EventArgs e)
        {
            if (LED1On)
            {
                switchLight(false, 0);
                Thread.Sleep(50);
                switchLight(false, 1);
                serialPort.Write(0 + "");
                LED1On = false;
            }
            else
            {
                switchLight(true, 0);
                Thread.Sleep(50);
                switchLight(true, 1);
                serialPort.Write(2 + "");
                LED1On = true;
            }
            
        }

        private void light_1_Click(object sender, EventArgs e)
        {
            if (LED1On)
            {
                switchLight(false, 0);
                Thread.Sleep(50);
                switchLight(false, 1);
                serialPort.Write(0 + "");
                LED1On = false;
            }
            else
            {
                switchLight(true, 0);
                Thread.Sleep(50);
                switchLight(true, 1);
                serialPort.Write(2 + "");
                LED1On = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                if (!string.IsNullOrEmpty(serialPort.ReadLine().Trim()))
                {
                    instrucciones += serialPort.ReadLine() + "\n";
                    Console.WriteLine("Entrando");
                    //button1.Click += new EventHandler(button1_Click);
                }
            }
        }

        private void serialPort_PinChanged(object sender, SerialPinChangedEventArgs e)
        {
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            MessageBox.Show(serialPort.ReadLine());
        }

        private void light_3_Click(object sender, EventArgs e)
        {
            if (LED2On)
            {
                switchLight(false, 2);
                Thread.Sleep(50);
                switchLight(false, 3);
                serialPort.Write(0 + "");
                LED2On = false;
            }
            else
            {
                switchLight(true, 2);
                Thread.Sleep(50);
                switchLight(true, 3);
                serialPort.Write(3 + "");
                LED2On = true;
            }
        }

        private void light_4_Click(object sender, EventArgs e)
        {
            if (LED2On)
            {
                switchLight(false, 2);
                Thread.Sleep(50);
                switchLight(false, 3);
                serialPort.Write(0 + "");
                LED2On = false;
            }
            else
            {
                switchLight(true, 2);
                Thread.Sleep(50);
                switchLight(true, 3);
                serialPort.Write(3 + "");
                LED2On = true;
            }
        }

        private void light_5_Click(object sender, EventArgs e)
        {
            if (LED4On)
            {
                switchLight(false, 4);
                Thread.Sleep(50);
                serialPort.Write(0 + "");
                LED4On = false;
            }
            else
            {
                switchLight(true, 4);
                Thread.Sleep(50);
                serialPort.Write(5 + "");
                LED4On = true;
            }
        }

        private void light_7_Click(object sender, EventArgs e)
        {
            if (LED5On)
            {
                switchLight(false, 6);
                Thread.Sleep(50);
                serialPort.Write(0 + "");
                LED5On = false;
            }
            else
            {
                switchLight(true, 6);
                Thread.Sleep(50);
                serialPort.Write(6 + "");
                LED5On = true;
            }
        }
    }
}
