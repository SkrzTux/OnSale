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
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        /*
        public ICollection<State> States { get; set; }
        [DisplayName("States Number")]
        public int stateNumber => States == null ? 0 : States.Count;

        public ICollection<Department> Departments { get; set; }
        [DisplayName("Departments Number")] 
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;
        */
    }
}
