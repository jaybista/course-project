﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeedMilk.Models;

namespace NeedMilk.Models.ViewModels
{
    public class CartIndexViewModels
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}
