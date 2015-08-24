namespace Answer.TechTest.Data.Models.Mapping
{
    using System.Data.Entity.ModelConfiguration;

    using Entities;

    public class ColourMap : EntityTypeConfiguration<Colour>
    {
        public ColourMap()
        {
            // Primary Key
            HasKey(t => t.ColourId);

            // Properties
            Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            ToTable("Colours");
            Property(t => t.ColourId).HasColumnName("ColourId");
            Property(t => t.Name).HasColumnName("Name");
            Property(t => t.IsEnabled).HasColumnName("IsEnabled");

            // Relationships
        }
    }
}
