using AutoMapper;
using ContactService.Core.Abstract;
using ContactService.Core.Contracts;
using ContactService.Core.Dto;
using ContactService.Core.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactService.Core.Concrete
{
    public class ContactRepository : IContactRepository
    {
        private readonly IMongoCollection<ContactPerson> _contactPersons;
        private readonly IMongoCollection<ContactInfo> _contactInfos;
        private readonly Mapper contactMapper;

        public ContactRepository(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _contactPersons = database.GetCollection<ContactPerson>("contacts");
            _contactInfos = database.GetCollection<ContactInfo>("contactinfos");

            var mapConfig = new MapperConfiguration(cfg => {
                cfg.AddProfile<ContactPersonProfile>();
                cfg.AddProfile<ContactInfoProfile>();
            });
        }

        public async Task<ContactPersonDto> CreateAsync(ContactPersonDto entity)
        {
            var newPerson = contactMapper.Map<ContactPersonDto, ContactPerson>(entity);
            await _contactPersons.InsertOneAsync(newPerson);
            return contactMapper.Map<ContactPerson, ContactPersonDto>(newPerson); 
        }

        public async Task<ContactInfoDto> CreateDetailAsync(Guid uuid, ContactInfoDto model)
        {
            var newInfo = contactMapper.Map<ContactInfoDto, ContactInfo>(model);
            await _contactInfos.InsertOneAsync(newInfo);
            return contactMapper.Map<ContactInfo, ContactInfoDto>(newInfo);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var deleteResult = await _contactPersons.DeleteOneAsync(person => person.Id == id.ToString());
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount>0;
        }

        public async Task<bool> DeleteDetailAsync(Guid id)
        {
            var deleteResult = await _contactInfos.DeleteOneAsync(person => person.Id == id.ToString());
            return deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
        }

        public async Task<IEnumerable<ContactPersonDto>> FindAsync(ContactFindRequest model)
        {
            var result = await _contactPersons.FindAsync(person => (person.FirstName.Contains(model.Name) || string.IsNullOrEmpty(model.Name)) &&
                    (person.LastName.Contains(model.Lastname) || string.IsNullOrEmpty(model.Lastname))
            );
            var dto = contactMapper.Map<IList<ContactPerson>, IList<ContactPersonDto>>(result.ToList());
            return dto;
        }

        public async Task<ContactPersonDto> GetAsync(Guid uid)
        {
            var result = await _contactPersons.FindAsync(person => person.Id == uid.ToString());
            var dto = contactMapper.Map<ContactPerson, ContactPersonDto>(result.First());
            return dto;
        }

        public async Task<ContactPersonDetailDto> GetDetailAsync(Guid uuid)
        {
            var detail = new ContactPersonDetailDto();
            var result = await _contactPersons.FindAsync(person => person.Id == uuid.ToString());
            var personDto = contactMapper.Map<ContactPerson, ContactPersonDto>(result.First());

            detail.FirstName = personDto.FirstName;
            detail.LastName = personDto.LastName;
            detail.Company = personDto.Company;
            detail.UUID = uuid;


            return detail;
        }

        public async Task<ContactPersonDto> UpdateAsync(ContactPersonDto entity)
        {
            var person = contactMapper.Map<ContactPersonDto, ContactPerson>(entity);
            var result = await _contactPersons.ReplaceOneAsync(person => person.Id == entity.UUID.ToString(), person);
            if (result.IsAcknowledged)
            {
                return entity;
            }
            
            return null;
        }

        public async Task<ContactInfoDto> UpdateDetailAsync(Guid uuid, ContactInfoDto model)
        {
            var detail = contactMapper.Map<ContactInfoDto, ContactInfo>(model);
            var result = await _contactInfos.ReplaceOneAsync(person => person.Id == model.uuid.ToString(), detail);
            if (result.IsAcknowledged)
            {
                return model;
            }

            return null;
        }
    }
}
