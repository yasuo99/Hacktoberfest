using System.Collections.Generic;

namespace CuaHangSuaXe
{
    public class Xe
    {
        public int xeId { get; set; }
        public string hangXe { get; set; }
        public string mauXe { get; set; }   
        //public int? kHId { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
