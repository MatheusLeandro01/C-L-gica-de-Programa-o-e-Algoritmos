﻿using Exercicio7.Entities.Enums;

namespace Exercicio7.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle () { }
        public Rectangle (double width, double height, Color color) 
            :base (color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
