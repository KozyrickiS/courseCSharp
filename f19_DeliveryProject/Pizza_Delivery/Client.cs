﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Pizza_Delivery
{
    public class Client
    {
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Midlname { get; set; }
        public string HomeAddress { get; set; }
        public string Email { get; set; }

        public Client(string lastname, string name, string midlname)
        {
            this.Lastname = lastname;
            this.Name = name;
            this.Midlname = midlname;
        }
    }
}