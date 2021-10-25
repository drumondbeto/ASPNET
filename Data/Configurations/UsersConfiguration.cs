using ASPNET.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNET.Data.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<Users>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Senha).HasColumnType("VARCHAR(80)").IsRequired();
            builder.Property(p => p.Telefone).HasColumnType("VARCHAR(11)");
        }
    }
}