namespace DemException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (false)
            {
                Console.WriteLine("Chon chuc nang");
                Console.WriteLine("1.");
                Console.WriteLine("2.");
                Console.WriteLine("3.");
                Console.WriteLine("4.");
                Console.WriteLine("0. Thoat");
                int cn = 0;
                try
                {
                    cn = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ban chon chuc nang so" + cn);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Hay chon lai chuc nang");
                    continue;
                }

                switch (cn)
                {
                    case 0: Console.WriteLine("Thoat"); break;
                    case 1: Console.WriteLine("CN 1"); break;
                    case 2: Console.WriteLine("CN 2"); break;
                    case 3: Console.WriteLine("CN 3"); break;
                    case 4: Console.WriteLine("CN 4"); break;
                }
                if (cn == 0) break;

            }
            
            
            try
            {
                ShowScore(10);
            }catch (MyException mex)
            {
                Console.WriteLine(mex.Message);
            }
            finally
            {
                Console.WriteLine("Exception Handled");
            }
            

            Console.WriteLine("Hello, World!");
        }

        static void ShowScore(int x)
        {
            if (x < 0 || x > 10) throw new MyException("Diem phai >0");
            Console.WriteLine("Diem cua hoc sinh la:" + x);
        }
    }

    public class MyException: Exception
    {
        public MyException(string msg) : base(msg) {
        
        }
    }
}


