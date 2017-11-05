using AutoMapper;
using BusinessLogic.Domain;
using BusinessLogic.Model;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Mappings
{
    /// <summary>
    /// Конфигурация маппинга, выполняющегося при помощи библиотеки AutoMapper.
    /// </summary>
    public static class MapperConfigurator
    {

        public static void Configure()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<City, CityDto>();
                cfg.CreateMap<CityDto, City>();

                cfg.CreateMap<Advert, AdvertDto>();
                cfg.CreateMap<AdvertDto, Advert>();
            });

        }
    }
}
