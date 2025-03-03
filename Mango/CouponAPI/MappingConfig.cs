using AutoMapper;
using CouponAPI.Models.Dto;
using CouponAPI.Models;

namespace CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() { 
        
            var mappingConfig = new MapperConfiguration(
                config =>
                {
                    config.CreateMap<CouponDto, Coupon>();
                    config.CreateMap<Coupon, CouponDto>();
                });

            return mappingConfig;
        
        }
    }
}
