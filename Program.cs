// using System.Net.Mime;
//
// string test = "Hello World";
// int lenght = test.Length;
// Console.WriteLine(lenght);
// string subString = test.Substring(3,7);
// Console.WriteLine(subString);
//
// string Uppertest = test.ToUpper();
// Console.WriteLine(Uppertest);
// string Lowertest = test.ToLower();
// Console.WriteLine(Lowertest);
// string replacedText = test.Replace("Hello", "World");
// Console.WriteLine(replacedText);
// string[] words = test.Split(new char[]
// {
//     ' ', ','}, StringSplitOptions.RemoveEmptyEntries
// );
// Console.WriteLine(words);
// {
//     
// }
//
// int a = 5;
// Console.WriteLine(a);
// int b = X(ref a);
//
// Console.WriteLine(a);
// Console.WriteLine(b);
//
// ref int X(ref int y)
// {
//     y = 25;
//     return ref y;
// }


// int a = X();
//
// int X(out int b)
// {
//     return 0;
// }

// int i;
//
// Addition(out i);
//  
//
// Console.WriteLine("The addition of the value is: {0}", i);
//
// static void Addition(out int i)
// {
//     i = 30;
//     i += i;
// }

using System;

//
//
//
//  static string CountSheep(int n)
// {
//     if (n > 0)
//     {
//         var value = "";
//         for(int i=1;i<=n;i++)
//         {
//
//             value += $"{i} sheep...";
//
//         }
//         return value;
//     }
//     return "";
// }
//
//
// string test = CountSheep(3);
// Console.WriteLine(test);
// public class Kata
// {
//     public static string MakeUpperCase(string str)
//     {
//         var modified = str.ToUpper();
//         return modified;
//     }
//
// }

// string test = "selam! ben mehemet?";
//
// Console.WriteLine(test.Replace("?",""));
//
// Console.WriteLine(SpinWords("Selam ben ahmet")
//     );
// static string SpinWords(string sentence)
// {
//     char[] cArray = sentence.ToCharArray();
//     string reverse = String.Empty;
//     string[] split = sentence.Split("\\s");
//     for (int i = 0; i < split.Length; i++)
//     {
//         if (split[i].Length >= 5)
//         {
//             
//         }
//     }
//     
//     return reverse;
// }

using System;
using System.Threading.Channels;

//
// class Program
// {
//     static void Main()
//     {
//         string sentence = "Hello world this is a test sentence";
//         Console.WriteLine(SpinWords(sentence));
//     }
//
//     static string SpinWords(string sentence)
//     {
//         string[] words = sentence.Split(' ');
//         for (int i = 0; i < words.Length; i++)
//         {
//             if (words[i].Length >= 5)
//             {
//                 // Kelimeyi ters çevir
//                 char[] charArray = words[i].ToCharArray();
//                 Array.Reverse(charArray);
//                 words[i] = new string(charArray);
//             }
//         }
//         return string.Join(" ", words);
//     }
// }
//
// public class Kata
// {
//     public static string[] SpinWords(string sentence)
//     {
//         string[] words = sentence.Split(' ');
//         for(int i= 0; i< words.Length;i++){
//             if(words[i].Length >=5){
//                 char[] charArray = words[i].ToCharArray();
//                 Array.Reverse(charArray);
//                 words[i] = new string(charArray);
//         
//             }
//         }
//         return Console.WriteLine(words);
//     }
//     
// }
// MyClass myClass = new MyClass();
// Console.WriteLine(myClass.Yasi = 15);
//
//
// class MyClass
// {
//     public int Yasi { get; set; }
// }

// class Test
// {
//     public int Yasi { get; set; }
//     
//     
//     private string adi = "Ahmet Beyhan";
//     public ref readonly string Adi => ref adi;
//     
// }