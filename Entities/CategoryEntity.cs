using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CategoryEntity
    {
        [Key]  //DataAnotations, key indica llave promaria
        [StringLength(50)]    //Indicamos el tamanio de CategoriaId
        public string CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        //Relacion de categoria con producto
        public ICollection<ProductEntity> Product { get; set; }
    }
}
