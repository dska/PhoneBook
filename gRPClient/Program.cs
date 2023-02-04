// Testing client console App to try out gRPC comunication with gRPC server

using System.Threading.Tasks;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using GrpcGreeterClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7088");
var client = new PhoneBook.PhoneBookClient(channel);

var addReply = await client.AddContactAsync(new ContactData()
{
    LastName = "Federer",
    FirstName = "Test",
    EmailAddr = "a@a.cz",
    PhoneNumber = "1234567890",
}, null);
addReply = await client.AddContactAsync(new ContactData()
{
    LastName = "Nadal",
    FirstName = "Test",
    EmailAddr = "a@a.cz",
    PhoneNumber = "1234567890",
}, null);

var reply = client.GetContactList(new Empty(), null);

Console.WriteLine(reply.ContactList_);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();