using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    [Table("Table Articulo")]
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }

        [DisplayName("Codigo Articulo")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int ArticleCode { get; set; }

        [DisplayName("Nombre Articulo")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string ArticleName { get; set; }

        [DisplayName("Precio Articulo")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int ArticlePrice { get; set; }


        [DisplayName("Marca Articulo")]
        [MaxLength(60)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string ArticleMark { get; set; }

        [DisplayName("Cualidad Articulo")]
        [MaxLength(60)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string ArticleCuality { get; set; }


        [DataType(DataType.Date)]
        public DateTime ArticleEntryDate { get; set; }

        public ICollection<Brand> Brands { get; set; }

    }
}
