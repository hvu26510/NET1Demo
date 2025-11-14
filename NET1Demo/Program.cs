using System.Collections;

namespace NET1Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Book b2 = new Book("Harry Porter", 100, "Truyen");
            ////b2.PrintInfor
            //string name = "Lao hac";
            //b2.SetTitle(name);
            //Console.WriteLine(b2.PhanLoai);

            TinhToan t = new TinhToan();
            int a = 1;
            Console.WriteLine(t.AddOne(ref a));
            Console.WriteLine("Bien a trong ham main = "+a);

            int output;
            t.OutValue(out output);
            Console.WriteLine("Bien output trong ham main = " + output);
            Console.WriteLine("Ket thuc chuong trinh");
        }
    }

    public class TinhToan
    {
        public int AddOne(ref int a)
        {
            ++a;
            return a;
        }

        public void OutValue(out int x)
        {
            x = 10;
        }
    }

    public class Book
    {
        public Book() { }
        public Book(string tieude, int st, string MoTa)
        {
            Title = tieude;
            SoTrang = st;
            Description = MoTa;
        }

        private string Title;
        public int SoTrang;
        public string Description;

        public string PhanLoai
        {
            get
            {
                if (this.SoTrang > 100) return "Day";
                else return "Mong";
            }
        }

        public string GetTitle()
        {
            return Title;
        }
        public void SetTitle(string title)
        {
            this.Title = title;
        }

        public void PrintInfor()
        {
            Console.WriteLine(Title);
            Console.WriteLine(SoTrang);
            Console.WriteLine(Description);
        }
    }

}

