using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Utils
{
    class Vec3F
    {
        public struct Vec3f
        {
            public float x;
            public float y;
            public float z;
        }

        public static Vec3f directionalVector(float yaw, float pitch)
        {
            Vec3f vec3 = new Vec3f();
            vec3.x = (float)Math.Cos(yaw) * (float)Math.Cos(pitch);
            vec3.y = (float)Math.Sin(pitch);
            vec3.z = (float)Math.Sin(yaw) * (float)Math.Cos(pitch);
            return vec3;
        }
    }
}
