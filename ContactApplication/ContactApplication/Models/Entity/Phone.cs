using ContactApplication.Enums;
using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Models.Entity
{
    public class Phone : Base
    {     
        [Key]
        public int PhoneId { get; set; }
        public long PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
