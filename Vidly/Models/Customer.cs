using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingresa un nombre")]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public bool isSuscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Required]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Day of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirthday { get; set; }
    }
}