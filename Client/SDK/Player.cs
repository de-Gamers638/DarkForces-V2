using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.SDK
{
    public class Entity
    {
        public static string Player = "Minecraft.Windows.exe+03CDD138,0,18,B8,";

        //looking vec
        public static string Yaw = Player + "124";
        public static string Pitch = Player + "128";

        //can be modified
        public static string OnGround = Player + "1C0";
        public static string StepHeight = Player + "220";
        public static string CanFly = Player + "934";
        public static string IsFlying = Player + "928";

        public static string VelocityX = Player + "4DC";
        public static string VelocityY = Player + "4E0";
        public static string VelocityZ = Player + "4E4";

        //position values
        public static string PosX = Player + "4A0";
        public static string PosY = Player + "4A4";
        public static string PosZ = Player + "4A8";

        public static string PosX2 = Player + "4AC";
        public static string PosY2 = Player + "4B0";
        public static string PosZ2 = Player + "4B4";
    }
}
