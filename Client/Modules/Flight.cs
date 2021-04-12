using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Modules
{
    public class Flight
    {
        public static string Name = "Flight";
        public static System.Windows.Forms.Keys key = System.Windows.Forms.Keys.F;
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
            Client.Form1.m.WriteMemory(Client.Modules.Actor.IsFlying, "byte", "1");
            Client.Form1.m.WriteMemory(Client.Modules.Actor.CanFly, "byte", "1");
        }
        public static void onDisable()
        {
            Client.Form1.m.WriteMemory(Client.Modules.Actor.IsFlying, "byte", "0");
            Client.Form1.m.WriteMemory(Client.Modules.Actor.CanFly, "byte", "0");
        }
        public static void onTick()
        {
            Client.Form1.m.WriteMemory(Client.Modules.Actor.IsFlying, "byte", "1");
            Client.Form1.m.WriteMemory(Client.Modules.Actor.CanFly, "byte", "1");
        }
    }
    
}
