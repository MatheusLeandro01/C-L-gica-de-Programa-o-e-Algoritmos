using Balta.ContentContext;
using System;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            //criando um objeto
            Course course = new Course();

            foreach (var item in course.Modules)
            {
             
            }

            //var content = new Content(); // não posso instanciar content poque é abastrato
            //Console.WriteLine(course.Id); //gerará um código guid hexadecimal;
        }
    }
}