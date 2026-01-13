using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Item.Domain.Entities;

namespace Item.Infrastructure.Db.Configurations
{
    public class ItemTypeMasterConfiguration : IEntityTypeConfiguration<ItemTypeMaster>
    {
        public void Configure(EntityTypeBuilder<ItemTypeMaster> builder)
        {
            builder.ToTable("item_type_master");

            // PK を指定
            builder.HasKey(x => x.Code);

            // PK は DB で自動採番しない場合は ValueGeneratedNever を指定
            builder.Property(x => x.Code)
                .HasColumnName("code")
                .HasMaxLength(10)
                .IsRequired()
                .ValueGeneratedNever();

            builder.Property(x => x.Name)
                .HasColumnName("code_name")
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}