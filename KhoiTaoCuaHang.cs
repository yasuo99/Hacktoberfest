using System.Collections.Generic;
using System.Data.Entity;
namespace CuaHangSuaXe
{
    public class KhoiTaoCuaHang: DropCreateDatabaseAlways<CuaHang>
    {
        protected override void Seed(CuaHang context)
        {
            IList<NhomTho> nhomThos = new List<NhomTho>();
            nhomThos.Add(new NhomTho() { NhomThoId = 1 });
            nhomThos.Add(new NhomTho() { NhomThoId = 2 });
            context.NhomThos.AddRange(nhomThos);
            IList<Tho> thos = new List<Tho>();
            thos.Add(new Tho() { thoId = "BX1", tenTho = "Nguyen Thanh Nhu", sdtTho = "093271382"});
            thos.Add(new Tho() { thoId = "RX1", tenTho = "Nguyen Thanh Lap", sdtTho = "083271382"});
            context.Thos.AddRange(thos);       
            thos[0].NhomThoId = nhomThos[0].NhomThoId;
            thos[0].NhomTho = nhomThos[0];
            thos[1].NhomThoId = nhomThos[1].NhomThoId;
            thos[1].NhomTho = nhomThos[1];
            base.Seed(context); 

        }
    }
}
