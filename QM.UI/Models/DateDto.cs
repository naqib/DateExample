using QM.Domain.Model;
using System;
using System.ComponentModel.DataAnnotations;

namespace QM.UI.Models
{
    public class DateDto
    {
        [Required]        
        public DateTime FirstDate { get; set; } 
        [Required]
        public DateTime SecondDate { get; set; } 
    }
}
