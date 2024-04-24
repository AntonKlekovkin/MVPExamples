using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnimationExample
{
    public class MovableObject : FieldObj
    {
        float linearVelocity = 0;
        float angularVelocity = 0;
        int rad = 20;
        Vector2 frontPoint;
                
        public float LinearVelocity { get => linearVelocity; private set => linearVelocity = value; }
        public float AngularVelocity { get => angularVelocity; private set => angularVelocity = value; }
        public int Rad { get => rad; private set => rad = value; }
        public Vector2 FrontPoint { get => frontPoint; private set => frontPoint = value; }
                
        public MovableObject(Vector2 center, float angle) : base(center, angle)
        {
            FrontPoint = Vector2.Transform(new Vector2(rad, 0), Phisycs.GetTransformationMatrix(this));
        }

        public void SetVelocities(float linVel, float angVel)
        {
            linearVelocity = linVel;
            angularVelocity = angVel;
        }

        public override void SetCoords(Vector2 center, float ang)
        {
            base.SetCoords(center, ang);
            FrontPoint = Vector2.Transform(new Vector2(rad, 0), Phisycs.GetTransformationMatrix(this));
        }
    }
}
