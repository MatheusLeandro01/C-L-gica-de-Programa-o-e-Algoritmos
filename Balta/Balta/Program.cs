using Balta.ContentContext;
using Balta.ContentContext.Enums;
using System;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {
            var course = new Course();
            course.Level = EContentLevel.Beginner;
        }
    }
}