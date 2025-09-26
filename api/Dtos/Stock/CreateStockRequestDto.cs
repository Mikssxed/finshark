using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MinLength(1, ErrorMessage = "Symbol must be at least 1 character long.")]
        [MaxLength(10, ErrorMessage = "Symbol cannot exceed 10 characters.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MinLength(2, ErrorMessage = "Company name must be at least 2 characters long.")]
        [MaxLength(100, ErrorMessage = "Company name cannot exceed 100 characters.")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Industry must be at least 2 characters long.")]
        [MaxLength(50, ErrorMessage = "Industry cannot exceed 50 characters.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}