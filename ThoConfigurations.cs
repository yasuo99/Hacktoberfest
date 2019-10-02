using System.Data.Entity.ModelConfiguration;
namespace CuaHangSuaXe
{
    public class ThoConfigurations:EntityTypeConfiguration<Tho>
    {
        public ThoConfigurations()
        {
            this.Property(s => s.tenTho).IsRequired().HasMaxLength(50);
            this.Property(s => s.tenTho).IsConcurrencyToken();
            this.HasOptional(s => s.NhomTho).WithRequired(ad => ad.Tho);
        }
    }
}
