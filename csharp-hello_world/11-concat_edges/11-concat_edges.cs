using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		string a = str.Substring(49, 15); // "object-oriented",
                string b = str.Substring(80, 11); // "programming",string c = str.Substring(101, 3); // "in C#",str = a + " " + b + " " + "in" + c ;,Console.WriteLine(str);
        }
}
