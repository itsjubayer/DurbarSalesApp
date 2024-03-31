using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DurbarSalesApp.Shared
{
    public class GenerateList
    {
        [Key]
        public int Id { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Something wrong! Please check your input...")]
        public int RegionalOfficeId { get; set; }
        public virtual RegionalOffice RegionalOffice { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please Select Factory")]
        public int RegionalStoreId { get; set; }
        public virtual RegionalStore RegionalStore { get; set; }


        [DisplayName("Ctg Type")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? CtgType { get; set; } = string.Empty;


        public List<DistrictSalesCentre> DistrictSalesCentreList { get; set; } = new List<DistrictSalesCentre>();
        public List<UpazillaSalesCentre> UpazillaSalesCentreList { get; set; } = new List<UpazillaSalesCentre>();

    }
}
