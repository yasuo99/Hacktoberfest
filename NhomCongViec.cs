using System.Collections.Generic;
namespace CuaHangSuaXe
{
    public class NhomCongViec
    {
        public int? NhomCongViecId { get; set; }
        public string tenNhom { get; set; }
        public virtual ICollection<CongViec> CongViecs { get; set; }
    }
}
