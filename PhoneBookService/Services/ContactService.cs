using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using PhoneBookService;

namespace PhoneBookService.Services
{
    public class ContactService : PhoneBook.PhoneBookBase
    {
        private readonly ContactDataContext _dataContext;
        public ContactService(ContactDataContext dataContext)
        {
            _dataContext = dataContext;
            ContactGenerator g = new ContactGenerator(dataContext);
            g.ContactDataSeed();

        }

        /// <summary>  
        /// Get contact list
        /// </summary>  
        /// <param name="request"></param>  
        /// <param name="context"></param>  
        /// <returns></returns>  
        public override Task<ContactList> GetContactList(Empty request, ServerCallContext context)
        {
            ContactList contactList = new ContactList();
            List<ContactData> list = new List<ContactData>();

            foreach (var contact in _dataContext.ContactDbItems)
            {
                //contactList.ContactList_.Add(contact);
                list.Add(contact);
            }

            contactList.ContactList_.AddRange(list.OrderBy(x => x.LastName));

            return Task.FromResult(contactList);
        }

        /// <summary>  
        /// add contact  
        /// </summary>  
        /// <param name="request"></param>  
        /// <param name="context"></param>  
        /// <returns></returns>  
        public override Task<ContactPostResponse> AddContact(ContactData request, ServerCallContext context)
        {
            _dataContext.ContactDbItems.Add(request);
            var result = _dataContext.SaveChanges();
            if (result > 0)
            {
                return Task.FromResult(new ContactPostResponse()
                {
                    Status = true,
                    StatusCode = 100,
                    StatusMessage = "Contact successfully added",
                    Id = request.Id
                });
            }
            else
            {
                return Task.FromResult(new ContactPostResponse()
                {
                    Status = false,
                    StatusCode = 500,
                    StatusMessage = "Error occured, contact not added"
                });
            }

        }
        /// <summary>  
        /// Get contact with the Id  
        /// </summary>  
        /// <param name="request"></param>  
        /// <param name="context"></param>  
        /// <returns></returns>  

        public override Task<ContactData> GetContact(ContactQuery request, ServerCallContext context)
        {
            var result = from data in _dataContext.ContactDbItems
                         where data.Id == request.Id
                         select data;
            return Task.FromResult(result.First());

        }
        /// <summary>  
        /// Deletes contact with id
        /// </summary>  
        /// <param name="request"></param>  
        /// <param name="context"></param>  
        /// <returns></returns>  
        public override Task<ContactPostResponse> DeleteContact(ContactQuery request, ServerCallContext context)
        {

            var item = (from data in _dataContext.ContactDbItems
                        where data.Id == request.Id
                        select data).Single();

            _dataContext.ContactDbItems.Remove(item);

            var result = _dataContext.SaveChanges();

            if (result > 0)
            {
                return Task.FromResult(new ContactPostResponse()
                {
                    Status = true,
                    StatusCode = 100,
                    StatusMessage = "Contact successfully deleted"
                });
            }
            else
            {
                return Task.FromResult(new ContactPostResponse()
                {
                    Status = false,
                    StatusCode = 500,
                    StatusMessage = "Error occured, contact not deleted"
                });
            }
        }
        /// <summary>  
        /// Updates contact 
        /// </summary>  
        /// <param name="request"></param>  
        /// <param name="context"></param>  
        /// <returns></returns>  
        public override Task<ContactPostResponse> UpdateContact(ContactUpdateQuery request, ServerCallContext context)
        {
            _dataContext.ContactDbItems.Update(request.Contact);
            var result = _dataContext.SaveChanges();


            if (result > 0)
            {
                return Task.FromResult(new ContactPostResponse()
                {
                    Status = true,
                    StatusCode = 100,
                    StatusMessage = "Contact successfully updated"
                });
            }
            else
            {
                return Task.FromResult(new ContactPostResponse()
                {
                    Status = false,
                    StatusCode = 500,
                    StatusMessage = "Error occured, contact not updated"
                });
            }
        }
    }
}