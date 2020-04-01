using ContactApplication.Models.Entity;
using System.Collections.Generic;

namespace ContactApplication.Models
{
    public class ContactRequestDto : BaseContactDto
    {
        public IEnumerable<PhoneRequestDto> Phones { get; set; }

    }
}
