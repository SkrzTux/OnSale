using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnSale.Web.Data.Entity
{
    public class Department
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public int BusinessID { get; set; }

        [DisplayName("Codigo Negocio")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int BusinessCode { get; set; }

        [DisplayName("Nombre Negocio")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string BusinessName { get; set; }

        [DisplayName("Categoria Negocio")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string BusinessCategory { get; set; }


        public ICollection<City> Cities { get; set; }

        [DisplayName("Cities Number")]
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
        
    }
}