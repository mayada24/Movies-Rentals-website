using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Home_Of_Movies.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name = "MembershipType")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of birth")]
        [Min12YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}