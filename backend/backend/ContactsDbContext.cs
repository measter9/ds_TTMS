using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend
{
    public class ContactsDbContext : DbContext
    {
        private DbContextOptions _options;

        public ContactsDbContext(DbContextOptions options)
        {
            _options = options;
        }

        DbSet<Contact> contacts;
    }
}
