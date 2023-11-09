using BikeSale.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeSale.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

     
    }
}
