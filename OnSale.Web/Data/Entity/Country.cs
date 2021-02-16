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
        public int CountryID { get; set; }

        [DisplayName("Codigo Pais")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El campo {0} es Requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Por favor digire un numero valido")]
        public int CountryCode { get; set; }

        public ICollection<State> States { get; set; }
        [DisplayName("States Number")]
        public int StateNumber => States == null ? 0 : States.Count;

        public ICollection<Department> Departments { get; set; }
        [DisplayName("Departments Number")] 
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;


        
    }
}
