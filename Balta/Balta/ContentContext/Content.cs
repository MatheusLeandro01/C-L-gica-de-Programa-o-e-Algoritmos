using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public abstract class Content : Base
    {        
        //propriedades        
        public string Title { get; set; }
        public string Url { get; set; }

        public Content(string title, string url)
        {            
            Title = title;
            Url = url;
        }
    }
}
