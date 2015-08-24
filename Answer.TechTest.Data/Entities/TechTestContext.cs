namespace Answer.TechTest.Data.Entities
{
    using System.Data.Entity;

    using Mapings;

    using Models.Mapping;

    public partial class TechTestContext : DbContext
    {
        static TechTestContext()
        {
            Database.SetInitializer<TechTestContext>(null);
        }

        public TechTestContext()
            : base("Name=TechTestContext")
        {
        }

        public DbSet<Colour> Colours { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ColourMap());
            modelBuilder.Configurations.Add(new PersonMap());
        }
    }
}
