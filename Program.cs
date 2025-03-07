
/*

using System.Net.Mime;

string test = "Hello World";
int lenght = test.Length;
Console.WriteLine(lenght);
string subString = test.Substring(3, 7);
Console.WriteLine(subString);

string Uppertest = test.ToUpper();
Console.WriteLine(Uppertest);
string Lowertest = test.ToLower();
Console.WriteLine(Lowertest);
string replacedText = test.Replace("Hello", "World");
Console.WriteLine(replacedText);
string[] words = test.Split(new char[]
{
     ' ', ','}, StringSplitOptions.RemoveEmptyEntries
);
Console.WriteLine(words);
{

}

int a = 5;
Console.WriteLine(a);
int b = X(ref a);

Console.WriteLine(a);
Console.WriteLine(b);

ref int X(ref int y)
{
    y = 25;
    return ref y;
}


int a = X();

int X(out int b)
{
    return 0;
}

int i;

Addition(out i);


Console.WriteLine("The addition of the value is: {0}", i);

static void Addition(out int i)
{
    i = 30;
    i += i;
}

using System;




  static string CountSheep(int n)
{
    if (n > 0)
    {
        var value = "";
        for (int i = 1; i <= n; i++)
        {

            value += $"{i} sheep...";

        }
        return value;
    }
    return "";
}


string test = CountSheep(3);
Console.WriteLine(test);
public class Kata
{
    public static string MakeUpperCase(string str)
    {
        var modified = str.ToUpper();
        return modified;
    }

}

string test = "selam! ben mehemet?";

Console.WriteLine(test.Replace("?", ""));

Console.WriteLine(SpinWords("Selam ben ahmet")
    );
static string SpinWords(string sentence)
{
    char[] cArray = sentence.ToCharArray();
    string reverse = String.Empty;
    string[] split = sentence.Split("\\s");
    for (int i = 0; i < split.Length; i++)
    {
        if (split[i].Length >= 5)
        {

        }
    }

    return reverse;
}

using System;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;


 class Program
{
    static void Main()
    {
        string sentence = "Hello world this is a test sentence";
        Console.WriteLine(SpinWords(sentence));
    }

    static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 5)
            {
                // Kelimeyi ters çevir
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);
            }
        }
        return string.Join(" ", words);
    }
}

public class Kata
{
    public static string[] SpinWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length >= 5)
            {
                char[] charArray = words[i].ToCharArray();
                Array.Reverse(charArray);
                words[i] = new string(charArray);

            }
        }
        return Console.WriteLine(words);
    }

}
MyClass myClass = new MyClass();
Console.WriteLine(myClass.Yasi = 15);


class MyClass
{
    public int Yasi { get; set; }
}

class Test
{
    public int Yasi { get; set; }


    private string adi = "Ahmet Beyhan";
    public ref readonly string Adi => ref adi;

}

ArrayList arrayList = new ArrayList()
 {
     "Ahmet",

 };
int s1 = 15;
int s2 = 15;
public int Topla
{
    get
    {
        return s1 + s2;
    }
}
MyClass myClass = new MyClass();
myClass[5] = 2;
class MyClass
{
    public int this[int a]
    {
        get { return a; }
        set
        {
            a = value;
        }
    }
}
MyClass ahmet = new();
MyClass myclass = new MyClass();





class MyClass
{
    public int A { get; set; }

    public void X()
    {

    }
}



for (int i = 1; i <= 10; i += 2)
{
    Console.Write(i + " ");
}




List<int> numbers = new List<int> { 2, 4, 6, 8 };
for (int i = 0; i < numbers.Count; i++)
{
    numbers[i] *= 2;
}
Console.WriteLine(string.Join(", ", numbers));

Console.WriteLine("Bir Sayı Giriniz");


MyClass m = new MyClass();
m.MyProperty = 1;
Console.WriteLine(m.MyProperty);


MyClass m1 = null;
MyClass m2 = new MyClass();
MyClass m3 = m2;
m1 = m3;

MyClass m1 = new MyClass();
MyClass m2 = m1;
MyClass m3 = m1.Clone();



class MyClass
{
    public MyClass Clone()
    {
        return (MyClass)this.MemberwiseClone();
    }
}



#region Eski Encapsulation

class MyClass
{
    private int a;

    public int AGet()
    {
        return this.a;
    }
    public void ASet(int a)
    {
        this.a = a;
    }
}

#endregion
*/
//MyClass myClass = new MyClass()
//{
//    MyProperty = 5
//};
//Console.WriteLine(myClass.MyProperty);

////myClass.MyProperty = 5;
//class MyClass()
//{
//    readonly int a;

//    public int A
//    {
//        get
//        {
//            return A;
//        }
//        init
//        {
//            a = value;
//        }
//    }
//    public int MyProperty { get; set; } = 3;
//}

//MyClass m1 = new MyClass()
//{
//    MyProperty = 5
//};
//MyRecord m2 = new MyRecord()
//{
//    MyProperty = 5
//};


//MyClass m3 = new MyClass()
//{
//    MyProperty = 5
//};
//MyRecord m4 = new MyRecord()
//{
//    MyProperty = 5
//};


//record MyRecord
//{
//    public int MyProperty { get; set; }

//}
//class MyClass
//{
//    public int MyProperty { get; set; }


//}
//new MyClass(5,4);
//class MyClass
//{
//    public MyClass()
//    {
//        Console.WriteLine("1. Constructor");
//    }

//    public MyClass(int a) 
//    {
//        Console.WriteLine($"2. Constructor {a}" );
//    }

//    public MyClass(int a, int b) : this(a)
//    {
//        Console.WriteLine($"3. Constructor {a} {b}");
//    }
//    public void X()
//    {

//    }
   
//}

record MyRecord
{
    public MyRecord()
    {
        
    }
    public MyRecord(int a) : this()
    {
    }
}
