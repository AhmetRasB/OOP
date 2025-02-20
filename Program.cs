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
