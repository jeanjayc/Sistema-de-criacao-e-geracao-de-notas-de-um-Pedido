using ExModulo9.Entities;
using Microsoft.EntityFrameworkCore;
namespace ExModulo9.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders"); 
            builder.Property(p => p.Status).HasConversion<string>();          
        }
    }
}