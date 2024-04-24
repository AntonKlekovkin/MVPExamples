using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace AnimationExample
{
    public class FieldObj
    {
        Vector2 center = new(0, 0);
        float angle = 0;
        public Vector2 Center { get => center; private set => center = value; }        
        public float Angle { get => angle; private set => angle = value; }
                
        public FieldObj(Vector2 center, float angle)
        {
            this.Center = center;
            this.Angle = angle;
        }

        public virtual void SetCoords(Vector2 center, float ang)
        { 
            Center = center; 
            Angle = ang; 
        }
    }
}
