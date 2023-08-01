using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProtivitiTaskManagement.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column("UserFirstName", TypeName = "varchar(100)")]
        [Required]
        [Display(Name ="First Name")]
        public string UserFirstName { get; set; }

        [Column("UserMiddleName", TypeName = "varchar(100)")]
        [Display(Name ="Middle Name")]
        public string? UserMiddleName { get; set; }

        [Column("UserLastName", TypeName = "varchar(100)")]
        [Display(Name ="Last Name")]
        [Required]
        public string UserLastName { get; set; }

        [Column("UserPassword", TypeName = "varchar(100)")]
        [Display(Name = "Password")]
        [Required]
        public string UserPassoword { get; set; }

        [Column("UserRole", TypeName = "varchar(100)")]
        [Display(Name = "Role")]
        [Required]
        public string UserRole { get; set; }
    }
}
