﻿using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public MembershipType MembershipType { get; set; }

        public bool HasNewsletterSubscription { get; set; }
        public Customer() 
        { 
        }
    }
}
