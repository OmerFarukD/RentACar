using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentACar.WebApp.Models.Entities;

namespace RentACar.WebApp.Repositories.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.HasKey(c => c.Id);
        
        builder.Property(c => c.ColorId).IsRequired();
        builder.Property(c => c.FuelId).IsRequired();
        builder.Property(c => c.TransmissionId).IsRequired();
        
        builder.Property(c => c.CarState).IsRequired();
        
        builder.Property(c => c.KiloMeter);
        
        builder.Property(c => c.ModelYear);
        
        builder.Property(c => c.Plate).HasMaxLength(10);
        
        builder.Property(c => c.BrandName).HasMaxLength(50);
        
        builder.Property(c => c.ModelName).HasMaxLength(50);
        
        builder.Property(c => c.DailyPrice).HasColumnType("decimal(18,2)");
        
        builder.Property(c => c.ImageUrl).HasMaxLength(200);
        
        builder.HasOne(c => c.Transmission)
            .WithMany(t => t.Cars)
            .HasForeignKey(c => c.TransmissionId);
        
        builder.HasOne(c => c.Fuel)
            .WithMany(f => f.Cars)
            .HasForeignKey(c => c.FuelId);
        
        builder.HasOne(c => c.Color)
            .WithMany(col => col.Cars)
            .HasForeignKey(c => c.ColorId);
    }
}