using ContactApplication.Models.Entity;
using System.Collections.Generic;

namespace ContactApplication.Models
{
    public class ContactResponseDto : BaseContactDto
    {
        public long ContactId { get; set; }
        public IList<PhoneResponseDto> Phones { get; set; }

    }
}
