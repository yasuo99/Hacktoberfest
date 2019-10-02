using System.Collections.Generic;
namespace CuaHangSuaXe
{
    public class CongViec
    {
        public CongViec()
        {
            this.HopDongCongViecs = new HashSet<HopDongCongViecs>();
            this.ThoCongViecs = new HashSet<ThoCongViecs>();
        }
        public int CongViecId { get; set; }
        public int tenCV { get; set; }
        public int? NhomCongViecId { get; set; }
        public virtual NhomCongViec NhomCongViec { get; set; }
        public virtual ICollection<HopDongCongViecs> HopDongCongViecs { get; set; }
        public virtual ICollection<ThoCongViecs> ThoCongViecs { get; set; }
    }
}
