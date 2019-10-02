using System.Collections.Generic;

namespace CuaHangSuaXe
{
    public class KhachHang
    {
        public int KhachHangID { get; set; }
        public string tenKH { get; set; }
        public string sdtKH { get; set; }
        public virtual ICollection<Xe> Xes { get; set; }
    }
}
