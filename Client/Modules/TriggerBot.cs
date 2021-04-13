
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Client.Modules
{
    public class TriggerBot
    {
        public static string Name = "TriggerBot";
        public static Keys key = Keys.V;
        public static bool toggeld;

        public static bool isPressed;

        private const int LEFTUP = 0x0004;
        private const int LEFTDOWN = 0x0002;
        public int interval = 20;

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
            int check = Form1.m.ReadByte(SDK.Level.LookingActor);
            if(check != 0)
            {
                Client.Utils.Imports.mouse_event(dwFlags: LEFTUP, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
                Thread.Sleep(25);
                Client.Utils.Imports.mouse_event(dwFlags: LEFTDOWN, dx: 0, dy: 0, cButtons: 0, dwExtraInfo: 0);
            }
        }
    }
}
