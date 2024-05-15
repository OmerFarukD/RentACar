using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories.Configurations;

public class TransmissionConfiguration : IEntityTypeConfiguration<Transmission>
{
    public void Configure(EntityTypeBuilder<Transmission> builder)
    {
        builder.HasKey(t => t.Id);
        
        builder.Property(t => t.Name).HasMaxLength(30);
        
        builder.HasMany(t => t.Cars)
            .WithOne(car => car.Transmission)
            .HasForeignKey(car => car.TransmissionId);
    }
}