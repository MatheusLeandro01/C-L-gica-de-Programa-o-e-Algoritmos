using Balta.ContentContext;
using Balta.ContentContext.Enums;
using System;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var career = new Career();

            career.Items.Add(new CareerItem());

            Console.WriteLine(career.TotalCourses);
        }
    }
}