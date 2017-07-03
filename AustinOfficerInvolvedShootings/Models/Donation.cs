using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AustinOfficerInvolvedShootings.Models
{
    public class Donation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Case Number")]
        public int CaseNumberId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        [Display(Name = "Donation")]
        public decimal Amount { get; set; }

        public virtual CaseNumber CaseNumber { get; set; }
    }
}
