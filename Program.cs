using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Chương trình giải phương trình bậc 2");
        double a, b, c;

        Console.Write("Nhập hệ số a: ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập hệ số b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập hằng số c: ");
        c = Convert.ToDouble(Console.ReadLine());

        string ketqua = GiaiPTbac2(a, b, c);
        Console.WriteLine(ketqua);

        Console.ReadLine(); // Dừng màn hình console
    }

    /// <summary>
    /// Hàm giải phương trình bậc 2
    /// </summary>
    /// <param name="a">Hệ số a</param>
    /// <param name="b">Hệ số b</param>
    /// <param name="c">Hằng số c</param>
    /// <returns>Kết quả dạng chuỗi</returns>
    private static string GiaiPTbac2(double a, double b, double c)
    {
        if (a == 0)
        {
            return GiaiPTbac1_cach1(b, c);
        }

        double delta = b * b - 4 * a * c;

        if (delta < 0)
        {
            return "Phương trình vô nghiệm";
        }
        else if (delta == 0)
        {
            double ketqua = -b / (2 * a);
            return "Phương trình có nghiệm kép  = " + ketqua.ToString();
        }
        else
        {
            double ketqua1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double ketqua2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return "Phương trình có hai nghiệm phân biệt: = " + ketqua1.ToString() + ", x2 = " + ketqua2.ToString();
        }
    }

    /// <summary>
    /// Hàm giải phương trình bậc 2 (sử dụng khi a = 0)
    /// </summary>
    /// <param name="b">Hệ số b</param>
    /// <param name="c">Hằng số c</param>
    /// <returns>Kết quả dạng chuỗi</returns>
    private static string GiaiPTbac1_cach1(double b, double c)
    {
        if (b == 0)
        {
            if (c == 0) return "Phương trình vô số nghiệm";
            else return "Phương trình vô nghiệm";
        }
        else
        {
            return "Phương trình có 2 nghiệm là " + (-c / b).ToString();
        }
    }
}