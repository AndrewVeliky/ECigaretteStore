using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ElectronicCigarette.Domain.Entities;

namespace ElectronicCigarette.WebUI.Models
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products;
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; } 
    }
}