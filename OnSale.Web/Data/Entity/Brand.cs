using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Brand
    {
        public int BrandID { get; set; }

        public int BrandCode { get; set; }

        public string BrandName { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}
