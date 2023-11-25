﻿using System.ComponentModel.DataAnnotations;

namespace LibApp.Models
{
    public class MembershipType
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public byte SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
