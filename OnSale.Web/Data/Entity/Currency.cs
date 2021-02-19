using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OnSale.Web.Data.Entity
{
    public class Currency
    {
        public int CurrencyID { get; set; }

        [DisplayName("Codigo Divisa")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int CurrencyCode { get; set; }

        [DisplayName("Nombre Divisa")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CurrencyName { get; set; }

    }
}
