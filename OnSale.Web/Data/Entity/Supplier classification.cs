using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Supplier_classification
    {
        public int Supplier_classificationID { get; set; }

        [DisplayName("Codigo Clasificacion Suplidor")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int Supplier_classificationCode { get; set; }

        [DisplayName("Nombre Clasificacion Suplidor")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string SellerSupplier_classificationName { get; set; }

        [DisplayName("Categoria Clasificacion Suplidor")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string Supplier_classificationCategory { get; set; }
    }
}
