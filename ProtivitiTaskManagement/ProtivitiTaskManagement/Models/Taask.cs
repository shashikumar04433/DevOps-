using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProtivitiTaskManagement.Models
{
    public class Taask
    {
        [Key]
        public int TaskId { get; set; }

        [Column("TaskTitle", TypeName = "varchar(100)")]
        [Display(Name = "Title")]
        [Required]
        public string TaskTitle { get; set; }

        [Column("TaskType", TypeName = "varchar(100)")]
        [Display(Name = "Type")]
        [Required]
        public string TaskType { get; set; }

        [Column("TaskDescription", TypeName = "varchar(250)")]
        [Display(Name = "Description")]
        public string? TaskDescription { get; set; }

        [Column("TaskAssignee", TypeName = "varchar(100)")]
        [Display(Name = "Assignee")]
        [Required]
        public string TaskAssignee { get; set; }

        [Column("TaskCounty", TypeName = "varchar(100)")]
        [Display(Name = "Country")]
        [Required]
        public string TaskCountry { get; set; }

        [Column("TaskCustomer", TypeName = "varchar(100)")]
        [Display(Name = "Customer")]
        [Required]
        public string TaskCustomer { get; set; }

        [Column("TaskStatus", TypeName = "varchar(100)")]
        [Display(Name = "Status")]
        [Required]
        public string TaskStatus { get; set; }
    }
}
