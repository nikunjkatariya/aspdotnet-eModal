using eModal.Models;
namespace eModal
{
    public class MainContext:DbContext
    {
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {

        }

        public DbSet<Appointment>? Appointments { get; set; }
    }
}
