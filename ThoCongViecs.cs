using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CuaHangSuaXe
{
    public class ThoCongViecs
    {
        public string ThoId { get; set; }
        public int CongViecId { get; set; }
        public string capDo { get; set; }
        public virtual CongViec CongViec { get; set; }
        public virtual Tho Tho { get; set; }
    } 
}
