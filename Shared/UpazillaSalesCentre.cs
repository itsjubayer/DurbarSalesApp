using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurbarSalesApp.Shared
{
    public class UpazillaSalesCentre
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Upazilla")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? UpazillaName { get; set; } = string.Empty;

        public virtual RegionalOffice RegionalOffice { get; set; }
        public virtual RegionalStore RegionalStore { get; set; }

        [DisplayName("Ctg Type")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? CtgType { get; set; } = string.Empty;
       // public int GenerateListDataId { get; set; }

    }
}
