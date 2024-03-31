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
    public class RegionalStore
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Regional Store")]
        [Required(ErrorMessage = "field is required.")]
        [Column(TypeName = "nvarchar(250)")]
        public string? RegionalStoreName { get; set; } = string.Empty;

    }
}
