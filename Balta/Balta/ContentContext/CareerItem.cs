using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public class CareerItem
    {
        public CareerItem(int ordem, string title, string description, Course course)
        {
            if (course == null)
                throw new Exception("O curso não pode ser nulo");//tratamento de exceção
            Ordem = ordem;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Ordem { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Course Course { get; set; }
    }
}
