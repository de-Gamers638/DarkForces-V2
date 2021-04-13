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
            if (Modules.Step.toggeld)
            {
                Modules.Step.onTick();
            }
            if (Modules.TriggerBot.toggeld)
            {
                Modules.TriggerBot.onTick();
            }
            if (Modules.BounceGlide.toggeld)
            {
                Modules.BounceGlide.onTick();
            }

            onLoop();
        }
        private void AirWalk_Click(object sender, EventArgs e)
        {
            Modules.AirWalk.Toggle();
        }
        private void AirJump_Click(object sender, EventArgs e)
        {
            Modules.AirJump.Toggle();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Glide_Click(object sender, EventArgs e)
        {
            Modules.Glide.Toggle();
        }

        private void Flight_Click(object sender, EventArgs e)
        {
            Modules.Flight.Toggle();
        }

        public void onLoop()
        {
            if (Imports.GetAsyncKeyState(Modules.Flight.key) < 0)
            {
                if (!Modules.Flight.isPressed)
                {
                    Modules.Flight.Toggle();
                    Modules.Flight.isPressed = true;
                }
            }
            else
            {
                Modules.Flight.isPressed = false;
            }

            if (Imports.GetAsyncKeyState(Modules.Glide.key) < 0)
            {
                if (!Modules.Glide.isPressed)
                {
                    Modules.Glide.Toggle();
                    Modules.Glide.isPressed = true;
                }
            }
            else
            {
                Modules.Glide.isPressed = false;
            }

            if (Imports.GetAsyncKeyState(Modules.BounceGlide.key) < 0)
            {
                if (!Modules.BounceGlide.isPressed)
                {
                    Modules.BounceGlide.Toggle();
                    Modules.BounceGlide.isPressed = true;
                }
            }
            else
            {
                Modules.BounceGlide.isPressed = false;
            }
        }

        private void Step_Click(object sender, EventArgs e)
        {
            Modules.Step.Toggle();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TriggerBot_Click(object sender, EventArgs e)
        {
            Modules.TriggerBot.Toggle();
        }

        private void BounceFly_Click(object sender, EventArgs e)
        {
            Modules.BounceGlide.Toggle();
        }
    }
}
