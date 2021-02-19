using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Country
    {
        [Key]

        public int CountryID { get; set; }

        [DisplayName("Codigo Pais")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Por favor digire un numero valido")]
        public int CountryCode { get; set; }

        [DisplayName("Nombre Pais")]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CountryName { get; set; }


        public virtual ICollection<City> Cities { get; set; }


        [DisplayName("Moneda")]
        public int CurrencyID { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual ICollection<Currency> Currencies { get; set; }


        [DisplayName("States Number")]
        public ICollection<State> States { get; set; }



        [DisplayName("Departments Number")]
        public ICollection<Department> Departments { get; set; }
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;





        
    }
}
