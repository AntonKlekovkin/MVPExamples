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
            center.X += MathF.Cos(ang) * obj.LinearVelocity * dt;
            center.Y += MathF.Sin(ang) * obj.LinearVelocity * dt;

            obj.SetCoords(center, ang);            
        }

        private static float LimAngle(float ang)
        {
            while (ang > MathF.PI) { ang -= 2 * MathF.PI; }
            while (ang < -MathF.PI) { ang += 2 * MathF.PI; }
            return ang;
        }

        public static Matrix3x2 GetTransformationMatrix(MovableObject o)
        {
            var ang = o.Angle;
            return new Matrix3x2(MathF.Cos(ang), MathF.Sin(ang),
                                -MathF.Sin(ang), MathF.Cos(ang),
                                o.Center.X, o.Center.Y);
        }
    }
}
