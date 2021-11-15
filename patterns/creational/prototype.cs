using System;
using System.Collections.Generic;
using System.Text;

namespace patterns.creational
{
    namespace prototype
    {
        public interface IFigure
        {
            IFigure Clone();

        }

        public class Rectangle : IFigure
        {
            public int Width { get; private set; }
            public int Height { get; private set; }


            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;
            }

            public IFigure Clone()
            {
                return new Rectangle(Width, Height);
            }
        }

        public class Circle : IFigure
        {
            public int Width { get; private set; }

            public Circle(int width) => Width = width;

            public IFigure Clone()
            {
                return new Circle(Width);
            }
        }


    }
}
