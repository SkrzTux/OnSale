using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnSale.Web.Data.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }

        [DisplayName("Codigo Categoria")]
        [MaxLength(50)]
        [Range(0, int.MaxValue, ErrorMessage = "Favor Digite un Numero Entero Valido")]
        [Required]
        public int CategoryCode { get; set; }

        [DisplayName("Nombre Negocio")]
        [MaxLength(50)]
        [StringLength(50, ErrorMessage = "Debe tener entre {2} y {1} Caracteres", MinimumLength = 3)]
        [Required(ErrorMessage = "El Campo {0} es Requerido")]
        public string CategoryName { get; set; }

        public Guid CategoryImageId { get; set; }
        //TODO: Pending to put the correct paths
        [Display(Name = "Image")]
        public string ImageFullPath => CategoryImageId == Guid.Empty
            ? $"https://localhost:44390/images/noimage.png"
            : $"https://onsale.blob.core.windows.net/categories/{CategoryImageId}";
    }
}
