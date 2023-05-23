using Balta.ContentContext;
using Balta.ContentContext.Enums;
using System;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Adicionando cursos
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCSharp = new Course("Fundamentos C#", "fundamentos-csharp");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
            courses.Add(courseOOP);
            courses.Add(courseCSharp);
            courses.Add(courseAspNet);            
            
            //Adicionando carreira
            var careers = new List<Career>();
            var careerDotnet = new Career("Especialista .NET","especialista-dotnet");
            careers.Add(careerDotnet);

            var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
            var careerItem = new CareerItem(1, "Comece por aqui", "", courseCSharp);
            var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
            careerDotnet.Items.Add(careerItem);
            careerDotnet.Items.Add(careerItem2);
            careerDotnet.Items.Add(careerItem3);
            

            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                foreach (var item in career.Items)
                {
                    Console.WriteLine($"{item.Ordem} - {item.Title}");
                    Console.WriteLine(item.Course.Title);
                    Console.WriteLine(item.Course.Level);
                }
            }             
        }
    }
}