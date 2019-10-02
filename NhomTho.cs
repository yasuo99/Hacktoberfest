using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CuaHangSuaXe
{
    public class NhomTho
    {
        [Key]
        public int NhomThoId { get; set; }
        public string tenNhom { get; set; }
        public string ThoId { get; set; }
        public virtual Tho Tho { get; set; }
        public virtual ICollection<Tho> Thos { get; set; }
    }
}
