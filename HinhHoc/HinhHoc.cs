using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhHoc
{
    public abstract class HinhHoc
    {
        public abstract void TinhChuVi();
        public abstract void TinhDienTich();
    }
    public class HinhVuong : HinhHoc
    {
        public int canh {  get; set; }
        public double Dientich { get; set; }
        public double ChuVi { get; set; }
        public override void TinhChuVi()
        {
            this.ChuVi = canh*4;
        }
        public override void TinhDienTich()
        {
            this.Dientich = canh * canh;
        }
    }

    public class HinhTron : HinhHoc
    {
        public int bankinh {  get; set; }
        public double Dientich { get; set; }
        public double ChuVi { get; set; }
        public override void TinhChuVi()
        {
            this.ChuVi = 2 * bankinh * Math.PI;
        }
        public override void TinhDienTich()
        {
            this.Dientich = bankinh * bankinh * Math.PI;
        }
    }
}
