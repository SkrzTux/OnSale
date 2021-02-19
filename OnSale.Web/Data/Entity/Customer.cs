using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [DisplayName("Codigo Cliente")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int CustomerCode { get; set; }

        [DisplayName("Nombre Cliente")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CustomerName { get; set; }

        [DisplayName("Categoria Cliente")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CustomerCategory { get; set; }
    }
}
