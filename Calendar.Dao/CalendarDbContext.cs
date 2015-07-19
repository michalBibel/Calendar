using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Calendar.Models;

namespace Calendar.DataAccese
{
    public class CalendarDbContext : DbContext
    {
        public CalendarDbContext() : base("CalendarDbContext")
        {
        }

        public DbSet<Models.Calendar> Calendars { get; set; }
        public DbSet<CalendarEvent> Events { get; set; }
        public DbSet<CalendarUser> Users { get; set; }
        public DbSet<Reminder> Reminders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}