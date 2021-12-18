using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev4_Data.DTOs
{
    public class ProductDTO
    {
        [Required(ErrorMessage ="Name is required")]
        [MaxLength(150)]
        public string Name { get; set; }

        [DataType(DataType.Currency,ErrorMessage ="Please use currency datatype")]
        public double Price { get; set; }
    }
}
