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

namespace PlantillTallerArduino
{
    public partial class Form1 : Form
    {
        List<Image> sprites = new List<Image>();
        List<PictureBox> lights = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getLights();
            getSprites();
            this.pb_Door.BackgroundImage = Resources.PuertaCerrada;
            this.btnCloseDoor.Enabled = false;
            this.pb_Garage.BackgroundImage = Resources.c1;
            this.pb_Garage.BackgroundImageLayout = ImageLayout.Stretch;
            this.pb_Door.BackgroundImageLayout = ImageLayout.Stretch;
        }

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
        void getSprites()
        {
            sprites.Add(Resources.c1);
            sprites.Add(Resources.c2);
            sprites.Add(Resources.c3);
            sprites.Add(Resources.c4);
            sprites.Add(Resources.c5);
            sprites.Add(Resources.c6);
            sprites.Add(Resources.c7);
            sprites.Add(Resources.c8);
            sprites.Add(Resources.c9);
            sprites.Add(Resources.c10);
            sprites.Add(Resources.c11);
            sprites.Add(Resources.c12);
            sprites.Add(Resources.c13);
            sprites.Add(Resources.c14);
            sprites.Add(Resources.c15);
            sprites.Add(Resources.c17);
            sprites.Add(Resources.C18);

        }
        
        void switchLight(bool status, int light )
        {

            try
            {
                if (light<lights.Count)
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

        private void btnOpenDoor_Click(object sender, EventArgs e)
        {
            door(true);
        }

        private void door(bool status)
        {
            this.pb_Door.SizeMode = PictureBoxSizeMode.StretchImage;

            if (status)
            {
                this.pb_Door.BackgroundImage = Resources.PuertaAbierta;
                this.btnOpenDoor.Enabled = false;
                this.btnCloseDoor.Enabled = true;


            }
            else
            {
                this.pb_Door.BackgroundImage = Resources.PuertaCerrada;
                this.btnOpenDoor.Enabled = true;
                this.btnCloseDoor.Enabled = false;
            }

        }

        private void btnCloseDoor_Click(object sender, EventArgs e)
        {
            door(false);
        }

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

                        pb_Garage.BackgroundImage = sprites[i];
                    }
                }
                else
                {
                    for (int i = 16; i >= 0; i--)
                    {
                        pb_Garage.BackgroundImage = sprites[i];
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }
        private void btnOpenG_Click(object sender, EventArgs e)
        {
            btnCloseG.Enabled = true;
            btnOpenG.Enabled = false;
            new Thread(new ParameterizedThreadStart(garage)).Start(true);
        }
        
        private void btnCloseG_Click(object sender, EventArgs e)
        {
            btnCloseG.Enabled = false;
            btnOpenG.Enabled = true;
            new Thread(new ParameterizedThreadStart(garage)).Start(false);
        }

        private void light_6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < lights.Count; i++)
                {
                    switchLight(true, i);
                    Thread.Sleep(50);
                }
            })).Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(() =>
            {
                for (int i = 0; i < lights.Count; i++)
                {
                    switchLight(false, i);
                    Thread.Sleep(50);
                }
            })).Start();
        }
    }
}
