using AutoMapper;
using Odev4_Data.DTOs;
using Odev4_Data.Models;

namespace Odev4_API
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductDTO, Product>();
            CreateMap<Product, ProductDTO>();
        }
    }
}
