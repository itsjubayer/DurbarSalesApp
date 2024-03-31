using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace DurbarSalesApp.Shared
{
    public class DistrictSalesCentre
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("District")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? DistrictName { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Something wrong! Please check your input...")]
        public int RegionalOfficeId { get; set; }
        public virtual RegionalOffice RegionalOffice { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Something wrong! Please check your input...")]
        public int RegionalStoreId { get; set; }
        public virtual RegionalStore RegionalStore { get; set; }

        [DisplayName("Ctg Type")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? CtgType { get; set; } = string.Empty;
        //public int GenerateListDataId { get; set; }

        
    }
}
