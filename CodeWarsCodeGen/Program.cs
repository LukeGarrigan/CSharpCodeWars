// See https://aka.ms/new-console-template for more information

var difficulty = 8;
var difficultySet = false;
while (!difficultySet)
{
    Console.WriteLine("What is the difficulty? e.g: 8 or 1");
    difficultySet = Int32.TryParse(Console.ReadLine(), out difficulty);

    if (difficulty is <= 0 or > 9)
    {
        Console.WriteLine("Difficulty must be between 1 and 8");
        difficultySet = false;
    }
}

Console.WriteLine("What is the Kata name?");
var kataName = Console.ReadLine();

Console.WriteLine("What is the method name?");
var methodName = Console.ReadLine();

Console.WriteLine("What is the return type?");
var returnType = Console.ReadLine();

Console.WriteLine("What is the argument type?");
var argumentType = Console.ReadLine();

Console.WriteLine($"{difficulty} Kyu, with method name {methodName}, return type of {returnType} and an argument of {argumentType}");


var parent = Directory.GetParent(Directory.GetCurrentDirectory().Replace("\\CodeWarsCodeGen\\bin\\Debug", ""));

var newFolder = $"{parent}\\CSharpCodeWars\\Kyu{difficulty}\\{kataName}";

Console.WriteLine($"new folder {newFolder}");
Directory.CreateDirectory(newFolder);

var filePath = $"{newFolder}\\{kataName}.cs";
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine( "using System;");
    writer.WriteLine($"namespace CSharpCodeWars.Kyu{difficulty}.{kataName}");
    writer.WriteLine( "{");
    writer.WriteLine( "    public class Kata");
    writer.WriteLine( "    {");
    writer.WriteLine($"        public {returnType} {methodName}({argumentType} myArg)");
    writer.WriteLine( "        {");
    writer.WriteLine(GetReturnValue());
    writer.WriteLine( "        }");
    writer.WriteLine( "    }");
    writer.WriteLine( "}");
}

string GetReturnValue()
{
    var output = "";

    switch (returnType)
    {
        case "string":
            output += "\"\"";
            break;
        case "int":
            output += "0";
            break;
        case "double":
            output += "0.0";
            break;
        case "bool":
            output += "true";
            break;
    }
    return $"             return {output};";
}