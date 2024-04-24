using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnimationExample
{
    public static class Phisycs
    {
        public static void CalcMovement(MovableObject obj, float dt)
        {
            float ang = obj.Angle;

            ang += obj.AngularVelocity * dt;
            ang = LimAngle(ang);

            var center = obj.Center;
            center.X += (float)Math.Cos(ang) * obj.LinearVelocity * dt;
            center.Y += (float)Math.Sin(ang) * obj.LinearVelocity * dt;

            obj.SetCoords(center, ang);
        }

        private static float LimAngle(float ang)
        {
            while (ang > Math.PI) { ang -= (float)(2 * Math.PI); }
            while (ang < -Math.PI) { ang += (float)(2 * Math.PI); }
            return ang;
        }

        public static Matrix3x2 GetTransformationMatrix(MovableObject o)
        {
            var ang = o.Angle;
            return new Matrix3x2((float)Math.Cos(ang), (float)Math.Sin(ang),
                                -(float)Math.Sin(ang), (float)Math.Cos(ang),
                                o.Center.X, o.Center.Y);
        }
    }
}
