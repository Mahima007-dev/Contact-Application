using AutoMapper;
using ContactApplication.Models;
using ContactApplication.Models.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApplication.Services
{
    public class ContactService : IContactService
    {
        private readonly IRepository<Contact> _repository;
        private readonly IMapper _mapper;

        public ContactService(IRepository<Contact> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ContactResponseDto> CreateContact(ContactRequestDto contact)
        {
            var model = _mapper.Map<Contact>(contact);
            await _repository.AddAsync(model);
            return _mapper.Map<ContactResponseDto>(model);
        }

        public async Task<ContactResponseDto> UpdateContact(ContactRequestDto contact)
        {
            var model = _mapper.Map<Contact>(contact);
            await _repository.UpdateAsync(model);
            return _mapper.Map<ContactResponseDto>(model);
        }

        public async Task<List<ContactResponseDto>> GetAllContact()
        {
            var contacts = await _repository.ListAsync();
            return _mapper.Map<List<ContactResponseDto>>(contacts);
        }

        public async Task<ContactResponseDto> GetContact(int id)
        {
            var contact = await _repository.ListAsync(x => x.ContactId == id, true);
            if (contact.ToList().Count > 0)
            {
                return _mapper.Map<ContactResponseDto>(contact.FirstOrDefault());
            }

            return null;
        }

        public async Task<int> RemoveContact(int id)
        {
            var contact = await GetContact(id);
            if (contact == null)
                return 0;

            return await _repository.DeleteAsync(_mapper.Map<Contact>(contact));
        }
    }
}
