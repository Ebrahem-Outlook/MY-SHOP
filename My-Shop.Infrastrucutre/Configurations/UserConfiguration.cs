using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Shop.Domain.Users;

namespace My_Shop.Infrastrucutre.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.Id);

        builder.Property(user => user.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(user => user.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(user => user.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(user => user.FirstName).HasMaxLength(50).IsRequired();

        builder.Property(user => user.CreatedOn).IsRequired();

        builder.Property(user => user.UpdatedOn);
    }
}
