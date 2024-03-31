using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DurbarSalesApp.Shared
{
    public class RegionalOffice
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Regional Office")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? RegionalOfficeName { get; set; } = string.Empty;

    }
}
