﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySampleApi.Business
{
    public class Caclulator : ICaclulator
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}