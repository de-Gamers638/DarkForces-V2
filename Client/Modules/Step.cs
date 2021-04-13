using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Modules
{
    public class Step
    {
        public static string Name = "Step";
        public static Keys Key;
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
            Client.Form1.m.WriteMemory(SDK.Entity.StepHeight, "float", "2");
        }
        public static void onDisable()
        {
            Client.Form1.m.WriteMemory(SDK.Entity.StepHeight, "float", "0.56");
        }
        public static void onTick()
        {
            Client.Form1.m.WriteMemory(SDK.Entity.StepHeight, "float", "2");
        }
    }
}
