﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouseAndCat
{
    internal class Settings
    {

        //getterit ja setterit
        public static int Width { get; set; }
        public static int Height { get; set; }

        public Settings()
        {
            Width = 16;
            Height = 16;
        }
    }
}
