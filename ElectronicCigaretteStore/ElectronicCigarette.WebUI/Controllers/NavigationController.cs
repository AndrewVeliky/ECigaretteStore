using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElectronicCigarette.Domain.Abstract;

namespace ElectronicCigarette.WebUI.Controllers
{
    public class NavigationController : Controller
    {
        public IProductRepository repository;

        public NavigationController(IProductRepository repo)
        {
            repository = repo;
        }
        public PartialViewResult Menu()
        {
            IEnumerable<string> categories = repository.Products
                .Select(product => product.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}