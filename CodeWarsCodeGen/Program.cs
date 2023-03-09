// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;

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

Console.WriteLine("What are the arguments, for multiple seperate by a comma e.g string,List<int>?");
var argumentTypes = Console.ReadLine();

var parent = Directory.GetParent(Directory.GetCurrentDirectory().Replace("\\CodeWarsCodeGen\\bin\\Debug", ""));

var newFolder = $"{parent}\\CSharpCodeWars\\Kyu{difficulty}\\{kataName}";

Console.WriteLine($"new folder {newFolder}");
Directory.CreateDirectory(newFolder);

var filePath = $"{newFolder}\\{kataName}.cs";
using (StreamWriter writer = new StreamWriter(filePath))
{
    writer.WriteLine("using System;");
    writer.WriteLine("");
    writer.WriteLine($"namespace CSharpCodeWars.Kyu{difficulty}.{kataName};");
    writer.WriteLine("");
    writer.WriteLine($"public class {kataName}");
    writer.WriteLine("{");
    writer.WriteLine($"    public {returnType} {methodName}({GetArgumentValue()})");
    writer.WriteLine("    {");
    writer.WriteLine(GetReturnValue());
    writer.WriteLine("    }");
    writer.WriteLine("}");
}

var testFilePath = $"{newFolder}\\{kataName}Tests.cs";
using (StreamWriter writer = new StreamWriter(testFilePath))
{
    writer.WriteLine("using NUnit.Framework;");
    writer.WriteLine("using FluentAssertions;");
    writer.WriteLine("");
    writer.WriteLine($"namespace CSharpCodeWars.Kyu{difficulty}.{kataName};");
    writer.WriteLine("");
    writer.WriteLine($"public class {kataName}Tests");
    writer.WriteLine("{");
    writer.WriteLine($"      private {kataName} _sut;");
    writer.WriteLine("      ");
    writer.WriteLine("      [SetUp]");
    writer.WriteLine("      public void Setup()");
    writer.WriteLine("      {");
    writer.WriteLine($"          _sut = new {kataName}();");
    writer.WriteLine("      }");
    writer.WriteLine("");
    writer.WriteLine("      [Test]");
    writer.WriteLine("      public void Test1()");
    writer.WriteLine("      {");
    writer.WriteLine("          ");
    writer.WriteLine("      }");
    writer.WriteLine("}");
}

string GetReturnValue()
{
    var output = "";

    if (returnType == "string")
        output += "\"\"";
    else if (returnType is "int" or "long")
        output += "0";
    else if (returnType == "double")
        output += "0.0";
    else if (returnType == "bool")
        output += "true";
    else if (returnType.StartsWith("IEnumerable"))
    {
        var type = returnType[(returnType.IndexOf("<") + 1)..^1];
        output += $"Enumerable.Empty<{type}>()";
    }
    else if (returnType.EndsWith("[]"))
    {
        var type = returnType.Split("[");
        output += $"Array.Empty<{type[0]}>()";
    }

    return $"         return {output};";
}


string GetArgumentValue()
{
    if (!argumentTypes.Contains(","))
    {
        return $"{argumentTypes} arg1";
    }

    var arguments = argumentTypes.Split(",");

    var output = "";
    for (var i = 0; i < arguments.Length - 1; i++)
    {
        output += $"{arguments[i]} arg{i + 1},";
    }

    output += $" {arguments[^1]} arg{arguments.Length}";

    return output;
}