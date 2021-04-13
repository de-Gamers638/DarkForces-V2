using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Modules
{
    public class BounceGlide
    {
        public static string Name = "AirJump";
        public static System.Windows.Forms.Keys key = System.Windows.Forms.Keys.V;
        public static bool toggeld;

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
            Utils.TimeUtil.Tick();
            if(Utils.TimeUtil.timerHasReached(40, true))
            {
                Client.Form1.m.WriteMemory(SDK.Entity.VelocityY, "float", "0.5");
            }
        }
    }
}
