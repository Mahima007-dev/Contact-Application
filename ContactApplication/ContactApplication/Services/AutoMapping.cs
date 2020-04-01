using AutoMapper;
using ContactApplication.Models;
using ContactApplication.Models.Entity;
using System;

namespace ContactApplication.Services
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //Response
            CreateMap<Phone, PhoneResponseDto>();
            CreateMap<PhoneResponseDto, Phone>();
            CreateMap<Contact, ContactResponseDto>();
            CreateMap<ContactResponseDto, Contact>();

            //Request
            CreateMap<Phone, PhoneRequestDto>();
            CreateMap<PhoneRequestDto, Phone>()
                .AfterMap((x, y) =>
                {
                    y.EntryDate = DateTime.Now;
                    y.IsActive = true;
                });

            CreateMap<Contact, ContactRequestDto>();
            CreateMap<ContactRequestDto, Contact>()
                .AfterMap((x, y) =>
                {
                    y.EntryDate = DateTime.Now;
                    y.IsActive = true;
                });
        }
    }
}
