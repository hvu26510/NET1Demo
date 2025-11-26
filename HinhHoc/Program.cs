// See https://aka.ms/new-console-template for more information

using HinhHoc;

HinhTron a = new HinhTron();
a.bankinh = 1;
a.TinhDienTich();
a.TinhChuVi();
Console.WriteLine("Dien tich:" + a.Dientich);
Console.WriteLine("Chu vu:" + a.ChuVi);


HinhVuong hinhVuong = new HinhVuong();
hinhVuong.canh = 3;
hinhVuong.TinhDienTich();
hinhVuong.TinhChuVi();
Console.WriteLine("Dien tich hinh vuong:" + hinhVuong.Dientich);
Console.WriteLine("Chu vi hinh vuong:" + hinhVuong.ChuVi);


TinhToan t = new TinhToan();
Console.WriteLine("Tong 2 so 1,2:" + t.tinhtong(1, 2));
Console.WriteLine("Tong 3 so 1,2,3:" + t.tinhtong(1, 2, 3));
Console.WriteLine("Hello, World!");

