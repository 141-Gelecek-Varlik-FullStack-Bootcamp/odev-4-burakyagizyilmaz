using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Odev4_Data.DTOs;
using Odev4_Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Odev4_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly AppDBContext _context;
        private readonly IMapper _mapper;

        public ProductController(AppDBContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_mapper.Map<IEnumerable<ProductDTO>>(_context.Products.ToList()));
        }

        [HttpGet("{Id}")]
        public IActionResult GetById([FromRoute] int Id)
        {
            if (_context.Products.Any(x=>x.Id==Id))
            {
                return Ok(_mapper.Map<ProductDTO>(_context.Products.Single(x=>x.Id==Id)));
            }
            else
            {
                return NotFound("Ürün Bulunamadı");
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult Delete([FromRoute] int Id)
        {
            if (_context.Products.Any(x => x.Id == Id))
            {
                Product product = _context.Products.Single(x => x.Id == Id);
                _context.Products.Remove(product);
                _context.SaveChanges();
                return Ok("Ürün Silindi");
            }
            else
            {
                return NotFound("Ürün Bulunamadı.");
            }
        }

        [HttpPost]
        public IActionResult Add ([FromBody]ProductDTO productDTO)
        {
            try
            {
                Product newProduct = new Product();
                _mapper.Map(productDTO, newProduct);    
                newProduct.CreatedBy = 1;
                _context.Products.Add(newProduct);
                _context.SaveChanges();
                return Created(string.Empty, _mapper.Map<ProductDTO>(newProduct));
            }
            catch (System.Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{Id}")]
        public IActionResult Update([FromBody] ProductDTO productDTO, [FromRoute] int Id)
        {
            if (_context.Products.Any(x=>x.Id==Id))
            {
                Product updatedProduct = _context.Products.Single(y => y.Id == Id);
                _mapper.Map(productDTO, updatedProduct);
                updatedProduct.LastModifiedBy = 1;
                updatedProduct.LastModifiedOn = DateTime.Now;

                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return BadRequest("Böyle bir ürün bulunamadı!");
            }
        }
    }
}
