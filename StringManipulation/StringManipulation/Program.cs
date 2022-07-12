using System.Diagnostics;
using System.Globalization;
using System.Text;

Main();

static void Main()
{
    //StringConversion();
    //StringAsArray();
    //EscapeString();
    //AppendingStrings();
    //StringInterpolationAndLiteral();
    //StringBuilderDemo();
    //WorkingsArrays();
    PadAndTrim();
}

static void StringConversion()
{
    string testString = "This is the FBI Calling!";
    TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
    TextInfo russTextInfo = new CultureInfo("pt-br", false).TextInfo;
    string result;

    result = testString.ToLower();
    Console.WriteLine(result);

    result = testString.ToUpper();
    Console.WriteLine(result);

    result = currentTextInfo.ToTitleCase(testString);
    Console.WriteLine(result);

    result = russTextInfo.ToTitleCase(testString);
    Console.WriteLine(result);

}

static void StringAsArray()
{
    string name = "Danilo";

    for (int i = 0; i < name.Length; i++)
    {
        Console.WriteLine(name[i]);
    }
}

static void EscapeString()
{
    string mg;

    mg = "This is my \"test\" solution";
    Console.WriteLine(mg);

    mg = "This is my \\new\\ test solution";
    Console.WriteLine(mg);

    mg = @"C:\mycomputer\project.";
    Console.WriteLine(mg);

    mg = "This is the last, i promess"; 
    Console.WriteLine(mg);
}// String Literal

static void AppendingStrings()
{
    string name = "Danilo";
    string lastName = "Borges";

    string result;

    result = name + ", my name is" + " " + name + " " + lastName + ".";
    Console.WriteLine(result);

    result = string.Format("{0}, my name is {0} {1}.", name, lastName);
    Console.WriteLine(result);

    result = $"{name}, my name is {name} {lastName}.";
    Console.WriteLine(result);
}

static void StringInterpolationAndLiteral()
{
    string name = "Danilo";
    string result = @$"C:\demo\{name}\{"\""}folder{"\""}\.";

    Console.WriteLine(result);
}

static void StringBuilderDemo()
{
    Stopwatch regularStopwach = new();
    regularStopwach.Start();

    string test = ""; // É ideal não incializar uma variável de string com algum valor

    for (int i = 0; i < 100_000; i++)
    {
        test += 1;
    }

    regularStopwach.Stop();

    Console.WriteLine($"Tempo para realizar a rotina {regularStopwach.ElapsedMilliseconds}ms");

    Console.WriteLine();

    regularStopwach.Start();

    StringBuilder sb = new();

    for (int i = 0; i < 100_000; i++)
    {
        sb.Append(i);
    }

    regularStopwach.Stop();

    Console.WriteLine($"Tempo para realizar a rotina com StringBuilder {regularStopwach.ElapsedMilliseconds}ms");
}

static void WorkingsArrays()
{
    int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

    string result;

    result = String.Concat(number);

    Console.WriteLine(result);
    Console.WriteLine(result.Length);

    Console.WriteLine();

    result = String.Join(", ", number);

    Console.WriteLine(result);
    Console.WriteLine(result[0]);
    Console.WriteLine(result[1]);
    Console.WriteLine(result.Length);

    Console.WriteLine();

    string names = "Danilo, Joana, Marques, Jhony, Natália, Michelle, Bruna, Daniele";

    string[] namesInArrays = names.Split(',');

    Array.ForEach(namesInArrays, x => Console.WriteLine(x));
}

static void PadAndTrim()
{
    string test = "    Helo World!  ";

    string result = test.TrimStart();
    Console.WriteLine($"'{result}'");

    result = test.TrimEnd();
    Console.WriteLine($"'{result}'");

    result = test.Trim();
    Console.WriteLine($"'{result}'");

    test = "1.50";

    result = test.PadLeft(5, '0');
    Console.WriteLine(result);

    result = test.PadRight(5, '0');
    Console.WriteLine(result);


}