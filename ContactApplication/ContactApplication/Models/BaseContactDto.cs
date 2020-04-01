using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ContactApplication.Models.Entity
{
    public class BaseContactDto
    {

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
