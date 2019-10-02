using System;
using System.Collections.Generic;

namespace CuaHangSuaXe
{
    public class PhieuThu
    {
        public int PhieuThuId { get; set; }
        public DateTime? ngayNop { get; set; }
        public string nguoiNop { get; set; }
        public float soTienNop { get; set; }
        public virtual ICollection<HopDong> HopDongs { get; set; }
    }
}
