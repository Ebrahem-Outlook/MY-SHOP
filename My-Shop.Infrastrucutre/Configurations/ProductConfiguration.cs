using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using My_Shop.Domain.Products;

namespace My_Shop.Infrastrucutre.Configurations;

internal sealed class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(product => product.Id);

        builder.Property(product => product.Name).HasMaxLength(50).IsRequired();

        builder.Property(product => product.Description).HasMaxLength(50).IsRequired();

        builder.Property(product => product.Price).HasColumnType("decimal(18,2)").IsRequired();

        builder.Property(product => product.Stock).IsRequired();

        builder.Property(product => product.CreatedOn).IsRequired();

        builder.Property(product => product.UpdatedOn);
    }
}
