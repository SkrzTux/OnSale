using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Neighborhood
    {
        public int IdNbh { get; set; }

        [MaxLength(40)]
        [Required]
        public string NameNbh { get; set; }
    }
}
