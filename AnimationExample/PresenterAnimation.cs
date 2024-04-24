using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnimationExample
{
    internal class PresenterAnimation
    {
        IViewAnimation view;
        ModelAnimation model;

        public PresenterAnimation(IViewAnimation view)
        {
            

            this.view = view;
            view.ViewTick += ViewUpdate;

            
            model = new ModelAnimation();
        }

        public void Run()
        {            
            Application.Run((Form)view);
        }

        public void ViewUpdate()
        {
            model.field.Update();            
            DrawMovableObject(model.field.myObject);
        }

        private void DrawMovableObject(MovableObject obj)
        {
            view.DrawCircle(new Pen(Color.Black), obj.Center, obj.Rad);
            view.DrawCircle(new Pen(Color.Red), obj.FrontPoint, 3);
        }
    }
}
