using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Models.Entity
{
    public class Contact : Base
    {
        [Key]
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Phone> Phones { get; set; }
    }
}
