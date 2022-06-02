using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(10)]
        public string PeoductId { get; set; }

        [Required]
        [StringLength(100)]
        public string PeoductName { get; set; }

        [StringLength(600)]
        public string PeoductDescription { get; set; }

        public int TotalQuantity { get; set; }
    }
}
