using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Moq;
using Ninject;
using System.Web.Mvc;
using ElectronicCigarette.Domain.Abstract;
using ElectronicCigarette.Domain.Entities;
using ElectronicCigarette.Domain.Concrete;

namespace ElectronicCigarette.WebUI.Infrastructure
{
    public class NinjaDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjaDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
           return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            kernel.Bind<IProductRepository>().To<EFProductRepository>();
        }
    }
}