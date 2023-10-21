namespace lekcja2
{
    internal class Program
    {
        //statnic, co funkcja ma zwracac, nazwa, paramtry
        //static void - nic nie zwraca
        static int dodaj(int a, int b)
        {
            int c = a + b;
            return c;
        }


        //true, false patrzysta niepatzysta
        static bool isEven(int number)
        {
            if (number % 2 == 0)
                return true;
            return false;
        }



        //wywolywanie
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Wynik: " + dodaj(1, 2));
            Console.WriteLine(isEven(9));

        }
    }
}