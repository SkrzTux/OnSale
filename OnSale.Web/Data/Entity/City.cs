using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class City
    {
        public int IdCty { get; set; }

        [MaxLength(50)]
        [Required]
        public string NameCty { get; set; }
    }
}
