using Exercicio7.Entities.Enums;

namespace Exercicio7.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }
        public Shape () { }
        public Shape (Color color) { Color = color; }

        public abstract double Area();

    }
}
