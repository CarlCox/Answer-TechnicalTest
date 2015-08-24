namespace Answer.TechTest.Data.Mapings
{
    using System.Data.Entity.ModelConfiguration;

    using Entities;

    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            // Primary Key
            HasKey(t => t.PersonId);

            // Properties
            Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            Property(t => t.LastName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("People");
            Property(t => t.PersonId).HasColumnName("PersonId");
            Property(t => t.FirstName).HasColumnName("FirstName");
            Property(t => t.LastName).HasColumnName("LastName");
            Property(t => t.IsAuthorised).HasColumnName("IsAuthorised");
            Property(t => t.IsValid).HasColumnName("IsValid");
            Property(t => t.IsEnabled).HasColumnName("IsEnabled");

            // Relationships
            HasMany(t => t.Colours)
                .WithMany(t => t.People)
                .Map(m =>
                {
                    m.ToTable("FavouriteColours");
                    m.MapLeftKey("PersonId");
                    m.MapRightKey("ColourId");
                });
        }
    }
}
