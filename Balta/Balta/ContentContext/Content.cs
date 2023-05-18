﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balta.ContentContext
{
    public abstract class Content
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        //propriedades
        public Guid Id { get; set; } //o que é Guid?
        public string Title { get; set; }
        public string Url { get; set; }
    }
}