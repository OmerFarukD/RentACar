using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories.Configurations;

public class ColorConfiguration : IEntityTypeConfiguration<Color>
{
    public void Configure(EntityTypeBuilder<Color> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.Name).HasMaxLength(30);
        
        builder.HasMany(c => c.Cars)
            .WithOne(car => car.Color)
            .HasForeignKey(car => car.ColorId);
    }
}