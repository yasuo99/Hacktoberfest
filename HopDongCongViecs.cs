using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSuaXe
{
    public class HopDongCongViecs
    {
        public string HopDongId { get; set; }
        public virtual HopDong HopDong { get; set; }
        public int? CongViecId { get; set; }
        public virtual CongViec CongViec { get; set; }
        public string thoId { get; set; }
        public virtual Tho Tho { get; set; }
        public float GiaTri { get; set; }
    }
}
