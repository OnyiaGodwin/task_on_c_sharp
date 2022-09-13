Console.WriteLine("Input the Word to be converted and hit the enter key on your keyboard");
string engword = Console.ReadLine();
string pigLatin = string.Join(" ", engword.Split().Select(word => word.Substring(1, word.Length - 1) + word[0] + "ay"));
Console.WriteLine(pigLatin);