using ClassLibrary1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Test
{
	public class MedicalContext : DbContext
    {
        public MedicalContext(DbContextOptions<MedicalContext> options) : base(options)
        {

        }
        public DbSet<A_State> StateTB { get; set; }
    }
}
