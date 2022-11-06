namespace Zad_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 987;
                int s, d, j;
            s = liczba / 100;
            
            liczba = liczba - s * 100;
            d = liczba / 10;
            liczba = liczba - d * 10;
            j = liczba;
            //Console.WriteLine(s+ " " + d + " " + j);
            if ((s + d + j) % 3 == 0)
                Console.WriteLine("podzielna przez 3");
        }
    }
}