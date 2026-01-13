using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Item.Domain.Entities;

namespace Item.Infrastructure.Db.Configurations
{
    public class UnitMasterConfiguration : IEntityTypeConfiguration<UnitMaster>
    {
        public void Configure(EntityTypeBuilder<UnitMaster> builder)
        {
            builder.ToTable("unit_master");

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