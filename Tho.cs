using System.Collections.Generic;
namespace CuaHangSuaXe
{
    public class Tho
    {
        public string thoId { get; set; }
        public string tenTho { get; set; }
        public string sdtTho { get; set; }
        public int? NhomThoId { get; set; }
        public virtual NhomTho NhomTho { get; set; }
        public virtual ICollection<HopDongCongViecs> HopDongCongViecs { get; set; }
        public virtual ICollection<ThoCongViecs> ThoCongViecs { get; set; }
    }
}
