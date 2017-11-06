using System;
using System.Linq;
using IoC;
using BusinessLogicLayer.Interfaces;
using BusinessLogicLayer.Mappings;
using Castle.MicroKernel.Lifestyle;

namespace AdvertBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorWrapper.Init();
            MapperConfigurator.Configure();

            var container = WindsorWrapper.Container;
            using (WindsorWrapper.Container.BeginScope())
            {
                var service = container.Resolve<IAdvertService>();
                var allAdverts = service.GetAllAdverts();
                foreach (var advert in allAdverts)
                {
                    Console.WriteLine($"{advert.Title, 30}  |  { advert.Cities.FirstOrDefault()?.Name, 15 }  |" +
                                      $"  {advert.Price} {(advert.Price.HasValue ? "руб." : string.Empty)}");
                }
            }
        
            Console.ReadLine();
        }
    }
}
