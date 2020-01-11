using System;
using System.ComponentModel.DataAnnotations;

namespace net_core_bootcamp_b1_aydinozhan.Models
{
    public class Event
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required, MaxLength(250)]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime FinishDate { get; set; }
        public string Address { get; set; }
        public bool IsFree { get; set; }
        public double Price { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
    }
}