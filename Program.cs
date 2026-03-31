// See https://aka.ms/new-console-template for more information
using modul5_103082400005;

public class Program
{
    private static void Main()
    {
        Penjumlahan<double> penjumlahan = new();
        object myDouble = penjumlahan.JumlahTigaAngka(1.0,3.0,8.2);

        Console.WriteLine("Hasil penjumlahan double: " + myDouble);
    }
}