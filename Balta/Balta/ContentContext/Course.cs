using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public Course() { Modules = new List<Module>(); }
        public string Tag { get; set; }//curso possui um código
        public IList<Module> Modules { get; set; }// um curso possui vários módulos, daí precisamos utilizar uma lista
    }
    public class Module
    {
        public Module()
        {
            Lectures = new List<Lecture>();
        }
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

    }
    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
    }
}
