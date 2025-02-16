X();
void X(int a = 1 )
{
    Console.WriteLine("Merhaba");
    if (a < 7)
    {
        X(++a);
    }

    Console.WriteLine("Dünya");
    
    
}