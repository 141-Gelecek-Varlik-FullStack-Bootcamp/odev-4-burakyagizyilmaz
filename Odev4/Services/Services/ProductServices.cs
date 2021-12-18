using AutoMapper;
using Odev4_Data.DTOs;
using Odev4_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductServices
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public ProductServices(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<ProductDTO> GetAllProducts ()
        {
            return _mapper.Map<IEnumerable<ProductDTO>>(_context.Products.ToList());
        }
    }
}
