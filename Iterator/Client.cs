﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Client(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
