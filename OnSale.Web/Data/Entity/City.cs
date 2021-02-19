using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class City
    {
        [Key]

        public int CityID { get; set; }

        [DisplayName("Codigo Ciudad")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int CityCode { get; set; }


        [DisplayName("Nombre Ciudad")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CityName { get; set; }



        public ICollection<Neighborhood> Neighborhoods { get; set; }
        [DisplayName("Neighborhoods Number")]
        public int NeighborhoodsNumber => Neighborhoods == null ? 0 : Neighborhoods.Count;


        public int CountryID { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Courier> Couriers { get; set; }
        public virtual ICollection<Supplier> Suppliers { get; set; }

    }
}

