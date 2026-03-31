using System;
class Program
{
    static void Main(string[] args)
    {
        Penjumlahan p = new Penjumlahan();

        long a = 10;
        long b = 30;
        long c = 82;

        long hasil = p.JumlahTigaAngka(a, b, c);

        Console.WriteLine("Hasil Penjumlahan: " + hasil);
    }
}