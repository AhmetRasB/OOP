class Program
    {
        static void Main(string[] args)
        {
            Matematik mat = new Matematik();
            int sonuc = mat.Cikar(5, 2);
            Console.WriteLine(sonuc);
            X(a:2,b:3,c:"selam");
        }

        static void X(int a, int b, string c)
        {
            
        }
    }

    class Matematik
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Bol(int sayi1, int sayi2)
        {
            return sayi1 / sayi2;
        }
    }
