using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimationExample
{
    internal class Field
    {
        public MovableObject myObject;
        float dt = 0.01f;

        public Field() 
        {            
            myObject = new(new System.Numerics.Vector2(50, 50), 0);
            myObject.SetVelocities(100, 0);
        }

        public void Update()
        {
            Phisycs.CalcMovement(myObject, dt);
        }
    }
}
