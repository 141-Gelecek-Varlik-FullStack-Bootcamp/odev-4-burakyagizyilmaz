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
    public class ProductServices
    {
        private readonly AppDBContext _context;

        public ProductServices(AppDBContext context)
        {
            _context = context;
            AutoMapperConfig.Configure();
        }


        public IEnumerable<ProductDTO> GetAllProducts()
        {
            return MapperWrapper.Mapper.Map<IEnumerable<ProductDTO>>(_context.Products.ToList());
        }


        public ProductDTO GetById(int Id)
        {
            ProductDTO productDTO = new ProductDTO();
            if (_context.Products.Any(x => x.Id == Id))
            {
                productDTO = MapperWrapper.Mapper.Map<ProductDTO>(_context.Products.Single(x => x.Id == Id));
            }
            return productDTO;
        }
    }
}
