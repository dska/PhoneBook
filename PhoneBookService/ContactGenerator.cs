// helper class to generate sample data

using PhoneBookService;

namespace PhoneBookService
{
    public class ContactGenerator
    {
        private readonly ContactDataContext ctx;
        public ContactGenerator(ContactDataContext dbContext)
        {
            ctx = dbContext;
        }

        // sample data
        public void ContactDataSeed()
        {

            if (ctx.ContactDbItems.Any())
            {
                return;
            }

            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "Federer",
                FirstName = "Roger",
                EmailAddr = "roger@federer.com",
                PhoneNumber = "1234567890",
                City = "Basel",
                Street = "Federer Strasse 20",
                PostalCode = "12345",
                Country = "Switzerland"
            });
            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "Jordan",
                FirstName = "Michael",
                EmailAddr = "michael@jordan.com",
                PhoneNumber = "1234567890",
                City = "Chicago",
                Street = "Bulls Street 6",
                PostalCode = "54321",
                Country = "USA"

            });
            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "Scholes",
                FirstName = "Paul",
                EmailAddr = "paul@scholes.com",
                PhoneNumber = "1234567890",
                City = "Manchester",
                Street = "Old Trafford Str 20",
                PostalCode = "60000",
                Country = "England"

            });
            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "Crosby",
                FirstName = "Sidney",
                EmailAddr = "sidney@crosby.com",
                PhoneNumber = "1234567890",
                City = "Pittsbourgh",
                Street = "PGP Paints Arena",
                PostalCode = "30000",
                Country = "USA"
            });
            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "Rossi",
                FirstName = "Valentino",
                EmailAddr = "valenino@rossi.com",
                PhoneNumber = "1234567890",
                City = "Milano",
                Street = "Belisima Street",
                PostalCode = "40000",
                Country = "Italy"
            });
            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "O'Sullivan",
                FirstName = "Ronnie",
                EmailAddr = "ronnie@osullivan.com",
                PhoneNumber = "1234567890",
                City = "London",
                Street = "Trafalgar Sqr",
                PostalCode = "35500",
                Country = "England"
            });
            ctx.ContactDbItems.Add(new ContactData()
            {
                LastName = "Kvitova",
                FirstName = "Petra",
                EmailAddr = "petra@kviova.com",
                PhoneNumber = "1234567890",
                City = "Fulnek",
                Street = "U tenisu 12",
                PostalCode = "73222",
                Country = "Czech Republic"
            });
            ctx.SaveChanges();
        }
    }
}
