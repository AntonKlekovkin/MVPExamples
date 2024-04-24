using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AnimationExample
{
    internal interface IViewAnimation
    {
        public event Action ViewTick;
        public void DrawCircle(Pen p, Vector2 center, float rad);
    }
}
