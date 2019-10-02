namespace CuaHangSuaXe
{
    public class QuanLy
    {
        public string QuanLyId { get; set; }
        public string tenQuanLy { get; set; }
        public QuanLyMode modeOfQuanLy { get; set; }
    }
    public enum QuanLyMode
    {
        Online,
        Worker
    }
}
