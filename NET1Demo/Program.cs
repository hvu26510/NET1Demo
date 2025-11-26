using System.Collections;

namespace NET1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nv = new NhanVien();
            nv.DaoLuaKhachHang("012345678", "Chi A");

            var ql = new QuanLy();
            ql.DaoLuaKhachHang("012345678", "Chi b");
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name;
        public int NamSinh;
    }

    public class NhanVien : Person, IDaoLua
    {
        public string EmailNoiBo;
        public string MaNhanVien;

        public string PhoneNumberFake { get; set; }
        public virtual void DaoLuaKhachHang(string phoneNumber, string tenKH)
        {
            Console.WriteLine("Nhan vien lua duoc "+ tenKH + " 5 trieu");
        }

    }

    public class QuanLy : NhanVien, IDaoLua, IQuanLy
    {
        public string trangbi;

        public override void DaoLuaKhachHang(string phoneNumber, string tenKH)
        {
            Console.WriteLine("Quan ly lua duoc " + tenKH + " 10 trieu");
        }

        public void Vut(string MaNhanVien)
        {
            Console.WriteLine("Quan ly vut nhan vien ma:"+ MaNhanVien);
        }
        public void ChichDien(string MaNhanVien, int soVolt)
        {
            Console.WriteLine("Quan ly chich dien nhan vien ma:" + MaNhanVien+ " "+ soVolt+ "von");
        }

    }

    public interface IQuanLy
    {
        void Vut(string MaNhanVien);
        void ChichDien(string MaNhanVien, int soVolt);
    }

    public interface IDaoLua
    {
        string PhoneNumberFake { get; set; }
        void DaoLuaKhachHang(string phoneNumber, string tenKH);
    }

}

