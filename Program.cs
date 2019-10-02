using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangSuaXe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using(var ctx = new CuaHang())
            {
                List<KhachHang> khachHangs = new List<KhachHang>();
                var xe = new Xe() { xeId = 1, hangXe = "honda", mauXe = "do" };
                khachHangs.Add(new KhachHang() { KhachHangID = 1, tenKH = "Hung", sdtKH = "0921312321" });
                ctx.KhachHangs.Add(khachHangs[0]);
                ctx.SaveChanges();
            }
            Console.WriteLine("Completed");
            Console.ReadLine();
        }
    }
}
