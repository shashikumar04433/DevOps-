using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProtivitiTaskManagement.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [Column("CustomerFirstName", TypeName = "varchar(100)")]
        [Display(Name = "First Name")]
        [Required]
        public string CustomerFirstName { get; set; }

        [Column("CustomerMiddleName", TypeName = "varchar(100)")]
        [Display(Name = "Middle Name")]
        public string? CustomerMiddleName { get; set; }

        [Column("CustomerLastName", TypeName = "varchar(100)")]
        [Display(Name = "Last Name")]
        [Required]
        public string CustomerLastName { get; set; }

        [Column("CustomerDescription", TypeName = "varchar(250)")]
        [Display(Name = "Description")]
        public string CustomerDescription { get; set; }

    }
}
