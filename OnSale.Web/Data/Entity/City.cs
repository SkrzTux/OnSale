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
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        public ICollection<Neighborhood> Neighborhoods { get; set; }
        [DisplayName("Neighborhoods Number")]
        public int NeighborhoodsNumber => Neighborhoods == null ? 0 : Neighborhoods.Count;
        
    }
}

