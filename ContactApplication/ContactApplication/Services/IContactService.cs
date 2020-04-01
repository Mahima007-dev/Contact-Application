using ContactApplication.Models;
using ContactApplication.Models.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactApplication.Services
{
    public interface IContactService
    {
        Task<ContactResponseDto> CreateContact(ContactRequestDto contact);
        Task<ContactResponseDto> UpdateContact(ContactRequestDto contact);
        Task<int> RemoveContact(int id);
        Task<List<ContactResponseDto>> GetAllContact();
        Task<ContactResponseDto> GetContact(int id);
    }
}
