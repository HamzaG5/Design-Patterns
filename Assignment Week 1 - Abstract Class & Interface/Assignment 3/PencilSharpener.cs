﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            pencil.AfterSharpening();
        }
    }
}
