﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product :IEntity
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductVersion { get; set; }
        
    }
}
