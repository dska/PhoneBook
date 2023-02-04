using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhoneBookService;

namespace PhoneBookService
{
    public class ContactDataContext : DbContext
    {
        public ContactDataContext(DbContextOptions<ContactDataContext> options) : base(options)
        {
        }

        public DbSet<ContactData> ContactDbItems { get; set; }
    }
}