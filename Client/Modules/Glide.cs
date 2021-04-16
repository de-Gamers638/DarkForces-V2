using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Modules
{
    public class Glide
    {
        public static string Name = "AirJump";
        public static System.Windows.Forms.Keys key = System.Windows.Forms.Keys.C;
        public static bool toggeld;

        public static float GlideValue = -0.04f;
        public static bool isPressed;

        public static void Toggle()
        {
            toggeld = !toggeld;

            if (toggeld)
            {
                onEnable();
            }
            else
            {
                onDisable();
            }
        }

        public static void onEnable()
        {

        }
        public static void onDisable()
        {

        }
        public static void onTick()
        {
            Client.Form1.m.WriteMemory(SDK.Entity.VelocityY, "float", GlideValue.ToString());
            if(Utils.TimeUtil.timerHasReached(25, true))
            {
                Client.Form1.m.WriteMemory(SDK.Entity.VelocityY, "float", "0.5");
            }
        }
    }
}
