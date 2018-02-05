using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        [Required]
        public bool isSuscribedToNewsletter { get; set; }
        
        [Required]
        public byte MembershipTypeId { get; set; }
        
        //[Min18YearsIfAMember]
        public DateTime? DateOfBirthday { get; set; }

        public MembershipTypeDto MembershipType { get; set; }
    }
}