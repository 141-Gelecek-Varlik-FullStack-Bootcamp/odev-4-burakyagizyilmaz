using AutoMapper;
using Odev4_Data.DTOs;
using Odev4_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4_Service
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
