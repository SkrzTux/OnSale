using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Courier
    {
        public int CourierID { get; set; }
        
        [DisplayName("Codigo Courier")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int CourierCode { get; set; }

        [DisplayName("Nombre Courier")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CourierName { get; set; }

        [DisplayName("Pais Courier")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CourierCountry { get; set; }

        [DisplayName("Categoria Courier")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CourierCategory { get; set; }
    }
}
