using ContactApplication.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Models
{
    public abstract class BasePhoneDto
    {
        [Required]
        public long PhoneNumber { get; set; }

        [Required]
        public PhoneType PhoneType { get; set; }
    }
}
