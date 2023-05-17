using Balta.ContentContext;
using System;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course(); //criando um objeto

            course.Id = 2500; //Consigo utilzar a propriedade ID, porque a classe "Course" está herdando de "Content"
        }
    }
}