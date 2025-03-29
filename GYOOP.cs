
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

//record MyRecord
//{
//    public MyRecord()
//    {

//    }
//    public MyRecord(int a) : this()
//    {
//    }
//}




//X();
//GC.Collect();
//Console.ReadLine();

//int sayi = 100;
//while (sayi>=1)
//{
//    new MyClass2(sayi--);
//}
//GC.Collect();
//Console.ReadLine();

//static void X()
//{
//    MyClass myClass = new MyClass();


//}
//class MyClass
//{
//    public MyClass()
//    {
//        Console.WriteLine("Nesne Uretildi");
//    }
//    ~MyClass()
//    {
//        Console.WriteLine("Imha ediliyor...");
//    }
//}

//class MyClass2
//{
//    private int no;

//    public MyClass2(int no)
//    {
//        this.no = no;
//        Console.WriteLine($"{no}. nesne olusturuldu");
//    }
//    ~MyClass2()
//    {
//        Console.WriteLine($"{no}. nesne imha ediliyor...");
//    }
//}
//Person person = new Person()
//{
//    Name = "Ahmet",
//    Age = 25
//};
//Person person2 = new Person
//{
//    Name = "David",
//    Age = 24,
//    citycode = 5
//};
//var (x,y) = person;
//var (x2,y2,z2) = person2;
//Console.WriteLine(person.Age);
//Console.WriteLine(person.Name);
//Console.WriteLine(x);
//Console.WriteLine(y);
//Console.WriteLine(x2);
//Console.WriteLine(y2);
//Console.WriteLine(z2);
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public int citycode { get; set; }

//    public void Deconstruct(out string name, out int age)
//    {
//        name = this.Name;
//        age = this.Age;
//    }
//    public void Deconstruct(out string name, out int age,out int citycode)
//    {
//        name = this.Name;
//        age = this.Age;
//        citycode = this.citycode;
//    }

//    public Person()
//    {
//        Console.WriteLine("Bu bir constructor");
//    }
//    static Person()
//    {
//        Console.WriteLine("Bu bir static constructor");
//    }
//}

//class MyClass
//{
//    public MyClass()
//    {

//    }
//    static MyClass()
//    {

//    }
//}
//var database = Database.GetInstance;
//class Database
//{
//    Database()
//    {

//    }

//    private static Database database;
//    static public Database GetInstance
//    {
//        get
//        {
//            return database;
//        }
//    }

//    static Database()
//    {
//        database = new Database();
//    }
//}
//MyRecord myRecord = new MyRecord("Ahmet", "Beyhan");
//var(name, surname) = myRecord;




//record MyRecord(string name, string surname)
//{
//    public MyRecord(string name): this()
//    {

//    }

//    public MyRecord(): this("Ahmet", "Beyhan")
//    {
//    }


//}

//using System.Threading.Channels;

//new Fiat();

//class Car
//{
//    public string Brand { get; set; }
//    public string Model { get; set; }
//    public int KM { get; set; }
//}

//class Mercedes : Car
//{
//    public Mercedes()
//    {
//    Console.WriteLine($"{nameof(Mercedes)} olusturuldu ");
//    }
//}

//class Opel : Mercedes
//{
//    public Opel()
//    {
//        Console.WriteLine($"{nameof(Opel)} olusturuldu");
//    }
//}
//class Fiat : Opel
//{
//    public Fiat()
//    {
//        Console.WriteLine($"{nameof(Fiat)} olusturuldu");
//    }
//}

//class MyClass
//{
//    public MyClass(int a)
//    {

//    }

//    public MyClass()
//    {

//    }
//}
//class MyClass2 : MyClass
//{
//    public MyClass2():base(5)
//    {

//    }

//    public MyClass2(int a) : base(5)
//    {

//    }
//}

//class A
//{
//    private int a;
//    public int b;
//    public int MyProperty { get; set; }

//}

//class B : A
//{
//    private int c;

//    public void X()
//    {
//        MyProperty = 5;
//    }

//}

//class A
//{
//    public void X()
//    {

//    }
//}

//class B : A
//{
//}

//class C : B
//{

//}

//class D : C
//{
//    public void X()
//    {

//    }
//}


// Virtual and Override


//Terlik terlik = new Terlik();
//terlik.Information();
//Kalem kalem = new Kalem();
//kalem.Information();
//Object obj = new Object();
//obj.Information();

//class Object
//{
//    virtual public void Information()
//    {
//        Console.WriteLine("Ben bir objeyim");
//    }
//}

//class Terlik : Object
//{

//}

//class Kalem : Terlik
//{
//    override public void Information()
//    {
//        Console.WriteLine("Ben bir kalem objesiyim");
//    }
//}

// Ornek 2 s

//Memeli meme = new Memeli();
//meme.Konus();
//Maymun maymun = new Maymun();
//maymun.Konus();
//Inek inek = new Inek();
//inek.Konus();



//class Memeli
//{
//    virtual public void Konus()
//    {
//        Console.WriteLine("Ben Konusmuyorum");
//    }
//}

//class Maymun : Memeli
//{
//    public override void Konus()
//    {
//        Console.WriteLine("Ben Maymunum");
//    }
//}
//class Inek : Memeli
//{
//    public override void Konus()
//    {
//        Console.WriteLine("Ben Inegim");
//    }
//}


// Ornek 3 

//Ucgen u = new Ucgen(3, 4);
//Dikdortgen d = new Dikdortgen(4, 3);
//Console.WriteLine(u.AlanHesapla());
//Console.WriteLine(d.AlanHesapla());


//class Sekil
//{
//    protected int _boy;
//    protected int _genislik;
//    public Sekil(int boy, int genislik)
//    {
//        _boy = boy;
//        _genislik = genislik;
//    }

//    virtual public int AlanHesapla()
//    {
//        return _boy * _genislik;
//    }
//}

//class Ucgen : Sekil
//{
//    public Ucgen(int boy, int en) : base(boy, en)
//    {

//    }

//    public override int AlanHesapla()
//    {
//        return _boy* _genislik / 2;
//    }
//}

//class Dikdortgen : Sekil
//{
//    public Dikdortgen(int boy, int en) : base(boy, en)
//    {

//    }

//    public override int AlanHesapla()
//    {
//        return _boy * _genislik;
//    }
//}



