using Grpc.Net.Client;
using Grpc.Net.Client.Web;
using PhoneBookService;

namespace PhoneBookClient.Services
{
    public class ContactDataService
    {
        private PhoneBook.PhoneBookClient GetServiceClient()
        {
            try
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7088/", new GrpcChannelOptions
                {
                    HttpHandler = new GrpcWebHandler(new HttpClientHandler())
                });
                return new PhoneBook.PhoneBookClient(channel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception(ex.Message);
            }
        }
        public async Task<ContactList> GetContactList()
        {
            try
            {
                var client = GetServiceClient();
                return await client.GetContactListAsync(new Google.Protobuf.WellKnownTypes.Empty(), null);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public async Task<ContactData> GetContactData(int id)
        {
            try
            {
                var client = GetServiceClient();
                var contact = await client.GetContactAsync(new ContactQuery() { Id = Convert.ToInt32(id) }, null);

                return contact;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }
        public async Task<ContactPostResponse> AddContactData(ContactData contact)
        {
            try
            {
                var client = GetServiceClient();

                var response = await client.AddContactAsync(contact, null);
                return response;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }

        }
        public async Task<bool> UpdateContact(ContactData contact)
        {
            try
            {
                var client = GetServiceClient();
                var updateData = new ContactUpdateQuery();
                updateData.Id = contact.Id;
                updateData.Contact = contact;
                var response = await client.UpdateContactAsync(updateData, null);
                return response.Status;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }
        public async Task<bool> DeleteContact(int contactId)
        {
            try
            {
                var client = GetServiceClient();
                var response = await client.DeleteContactAsync(new ContactQuery() { Id = contactId }, null);
                return response.Status;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception(ex.Message);
            }
        }

    }
}
