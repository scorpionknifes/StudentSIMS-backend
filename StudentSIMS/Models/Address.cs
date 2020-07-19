using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentSIMS.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }
        [ForeignKey("Student")]
        public int studentId { get; set; }
        [Required]
        public string streetNumber { get; set; }
        [Required]
        public string street { get; set; }
        public string suburb { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string postcode { get; set; }
        [Required]
        public string country { get; set; }
        [Timestamp]
        public DateTime timeCreated { get; set; }
    }
}
