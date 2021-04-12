using System;
using Memory;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Modules
{
    public class AirWalk
    {
        public static string Name = "AirWalk";
        public static int key;
        public static bool toggeld;

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
            Client.Form1.m.WriteMemory(Client.Modules.Actor.VelocityY, "float", "0");
        }
    }
}
