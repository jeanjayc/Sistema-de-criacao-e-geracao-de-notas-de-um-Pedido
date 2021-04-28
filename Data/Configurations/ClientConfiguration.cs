using ExModulo9.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExModulo9.Data.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
           builder.ToTable("Clientes");
           builder.HasKey(p => p.Id);
           builder.Property(p => p.Name).HasColumnType("VARCHAR(40)").IsRequired();
           builder.Property(p => p.Email).HasColumnType("VARCHAR(40)").IsRequired();
           builder.Property(p => p.BirthDate).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd();
        }
    }
}