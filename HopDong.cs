using System;
using System.Collections.Generic;
namespace CuaHangSuaXe
{
    public class HopDong
    {
        public HopDong()
        {
            this.HopDongCongViecs= new HashSet<HopDongCongViecs>();
        }
        public string HopDongId { get; set; }
        public DateTime? ngayKy { get; set; }
        public DateTime? ngayThanhLy { get; set; }
        public bool tinhTrangHD { get; set; }
        public float giaTriHopDong { get; set; }
        public virtual Xe Xe { get; set; }
        public virtual PhieuThu PhieuThu { get; set; }
        public virtual ICollection<HopDongCongViecs> HopDongCongViecs { get; set; }
    }
}
