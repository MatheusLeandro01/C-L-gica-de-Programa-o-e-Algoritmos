﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public abstract class Content
    {        
        //propriedades
        public Guid Id { get; set; } //O guid vai gerar um ID hexadecimal aleatório
        public string Title { get; set; }
        public string Url { get; set; }

        public Content(string title, string url)
        {
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
    }
}
