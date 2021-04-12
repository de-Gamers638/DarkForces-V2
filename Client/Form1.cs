using Client.Utils;
using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public static Mem m = new Mem();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            m.OpenProcess("Minecraft.Windows.exe");
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Modules.AirWalk.toggeld)
            {
                Modules.AirWalk.onTick();
            }
            if (Modules.AirJump.toggeld)
            {
                Modules.AirJump.onTick();
            }
            if (Modules.Glide.toggeld)
            {
                Modules.Glide.onTick();
            }
            if (Modules.Flight.toggeld)
            {
                Modules.Flight.onTick();
            }

            onLoop();
        }
        private void AirWalk_Click(object sender, EventArgs e)
        {
            Modules.AirWalk.Toggle();
            if (Modules.AirWalk.toggeld)
            {
                AirWalk.Text = "AirWalk " + "[ON]";
            }
            else
            {
                AirWalk.Text = "AirWalk " + "[OFF]";
            }
        }
        private void AirJump_Click(object sender, EventArgs e)
        {
            Modules.AirJump.Toggle();
            if (Modules.AirJump.toggeld)
            {
                AirJump.Text = "AirJump " + "[ON]";
            }
            else
            {
                AirJump.Text = "AirJump " + "[OFF]";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Glide_Click(object sender, EventArgs e)
        {
            Modules.Glide.Toggle();
            if (Modules.Glide.toggeld)
            {
                Glide.Text = "Glide " + "[ON]";
            }
            else
            {
                Glide.Text = "Glide " + "[OFF]";
            }
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            Modules.Flight.Toggle();
            if (Modules.Flight.toggeld)
            {
                Flight.Text = "Flight " + "[ON]";
            }
            else
            {
                Flight.Text = "Flight " + "[OFF]";
            }
        }

        public void onLoop()
        {
            if (Imports.GetAsyncKeyState(Modules.Flight.key) < 0)
            {
                if (!Modules.Flight.isPressed)
                {
                    Modules.Flight.Toggle();
                    if (Modules.Flight.toggeld)
                    {
                        Flight.Text = "Flight " + "[ON]";
                    }
                    else
                    {
                        Flight.Text = "Flight " + "[OFF]";
                    }
                    Modules.Flight.isPressed = true;
                }
            }
            else
            {
                Modules.Flight.isPressed = false;
            }
        }
    }
}
