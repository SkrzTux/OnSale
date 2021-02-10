using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class State
    {
        public int IdSt { get; set; }

        [MaxLength(50)]
        [Required]
        public string NameSt { get; set; }
    }
}
