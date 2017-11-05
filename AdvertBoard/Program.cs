﻿using System;
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
            }
        
            Console.ReadLine();
        }
    }
}
