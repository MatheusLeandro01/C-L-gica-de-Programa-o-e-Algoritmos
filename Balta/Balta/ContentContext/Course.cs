using Balta.ContentContext.Enums;
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
        public EContentLevel Level { get; set; }
    }    
}