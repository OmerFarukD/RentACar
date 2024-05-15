using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories.Configurations;

public class FuelConfiguration : IEntityTypeConfiguration<Fuel>
{
    public void Configure(EntityTypeBuilder<Fuel> builder)
    {
        builder.HasKey(f => f.Id);
        
        builder.Property(f => f.Name).HasMaxLength(30);
        
        builder.HasMany(f => f.Cars)
            .WithOne(car => car.Fuel)
            .HasForeignKey(car => car.FuelId);
    }
}