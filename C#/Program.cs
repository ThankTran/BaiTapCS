using System;
using System.Numerics;
namespace BaiTapCSharp
{
    class PhanSo
    {
        public int Tu;
        public int Mau;
        public PhanSo(int tu, int mau)
        {
            Tu = tu;
            Mau = mau;
        }

        public PhanSo() { }

        static int ucln(int a, int b)
        {
            return Math.Abs((int)BigInteger.GreatestCommonDivisor(a, b));
        }
        static PhanSo Tong(PhanSo a, PhanSo b)
        {
            int tu = a.Tu * b.Mau + b.Tu * a.Mau;
            int mau = a.Mau * b.Mau;
            int UCLN = ucln(tu, mau);
            tu /= UCLN;
            mau /= UCLN;
            return new PhanSo(tu, mau);
        }

        static PhanSo Hieu(PhanSo a, PhanSo b)
        {
            int tu = a.Tu * b.Mau - b.Tu * a.Mau;
            int mau = a.Mau * b.Mau;
            int UCLN = ucln(tu, mau);
            tu /= UCLN;
            mau /= UCLN;
            return new PhanSo(tu, mau);
        }

        static PhanSo Tich(PhanSo a, PhanSo b)
        {
            int tu = a.Tu * b.Tu;
            int mau = a.Mau * b.Mau;
            int UCLN = ucln(tu, mau);
            tu /= UCLN;
            mau /= UCLN;
            return new PhanSo(tu, mau);
        }

        static PhanSo Thuong(PhanSo a, PhanSo b)
        {
            int tu = a.Tu * b.Mau;
            int mau = a.Mau * b.Tu;
            int UCLN = ucln(tu, mau);
            tu /= UCLN;
            mau /= UCLN;
            return new PhanSo(tu, mau);
        }

        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }

        static void Main(string[] args)
        {
            PhanSo a = new PhanSo();
            PhanSo b = new PhanSo();
            Console.WriteLine("Nhap phan so a: ");
            a.Tu = int.Parse(Console.ReadLine()!);
            a.Mau = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap phan so b: ");
            b.Tu = int.Parse(Console.ReadLine()!);
            b.Mau = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Tong hai phan so la: " + Tong(a, b));
            Console.WriteLine("Hieu hai phan so la: " + Hieu(a, b));
            Console.WriteLine("Tich hai phan so la: " + Tich(a, b));
            Console.WriteLine("Thuong hai phan so la: " + Thuong(a, b));
        }
    }
}