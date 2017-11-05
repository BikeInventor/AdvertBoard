using System.Data.Entity;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Services;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using DataAccess.Abstraction;
using DataAccess.EntityFramework;

namespace IoC
{
    public static class WindsorWrapper
    {
        public static WindsorContainer Container = new WindsorContainer();
        public static void Init()
        {
            Container.Register(Component.For<IAdvertService>().ImplementedBy<AdvertService>()
                .LifestyleScoped());

            Container.Register(Component.For(typeof(IRepository<>))
                .ImplementedBy(typeof(RepositoryBase<>))
                .LifestyleScoped());

            Container.Register(Component.For<DbContext>().ImplementedBy<AdvertDbContext>().LifestyleScoped());

            Container.Register(Component.For(typeof(IDataSession)).ImplementedBy<EntityDataSession>().LifestyleScoped());
        }
    }
}
