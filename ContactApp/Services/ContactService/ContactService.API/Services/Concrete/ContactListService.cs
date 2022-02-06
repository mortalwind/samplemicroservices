using ContactService.API.Services.Abstract;
using ContactService.Core.Concrete;
using ContactService.Core.Dto;
using MongoDB.Driver;

namespace ContactService.API.Services.Concrete
{
    public class ContactListService : IContactListService
    {
        

        public async Task<ContactPersonDto> CreateAsync(ContactPersonDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactPersonDto> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ContactPersonDto>> FindAsync(ContactFindRequest model)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactPersonDto> GetAsync(Guid uid)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactPersonDetailDto> GetDetailAsync(Guid uuid)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactPersonDto> UpdateAsync(ContactPersonDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
