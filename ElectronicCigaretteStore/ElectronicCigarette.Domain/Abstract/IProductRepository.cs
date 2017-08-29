﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElectronicCigarette.Domain.Entities;

namespace ElectronicCigarette.Domain.Abstract
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products {get;} 
    }
}
