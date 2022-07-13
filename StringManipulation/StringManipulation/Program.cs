using System.Diagnostics;
using System.Globalization;
using System.Text;

Main();

static void Main()
{
    Console.WriteLine();
    //StringConversion();
    //StringAsArray();
    //EscapeString();
    //AppendingStrings();
    //StringInterpolationAndLiteral();
    //StringBuilderDemo();
    //WorkingsArrays();
    //PadAndTrim();
    //SearchingStrings();
    //OrderingString();
    //TestEquality();
    //GettingASubstring();
    //ReplacingText();
    //IsertingText();
    RemovingText();

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

    result = "a a a";
    Console.WriteLine(result.Trim());

    test = "1.50";

    result = test.PadLeft(5, '0');
    Console.WriteLine(result);

    result = test.PadRight(5, '0');
    Console.WriteLine(result);
}

static void SearchingStrings()
{
    string testString = "This is a test of the search. Let's see how its testing works out.";
    bool resultsBoolean;
    int resultsInt;

    resultsBoolean = testString.StartsWith("This is a test"); // A string testString inicia com o valor de string passado por parâmetro? Se sim teremos como retorno true, senão teremos como retorno false.
    Console.WriteLine($"Starts with \"This is a test\" : {resultsBoolean}");

    resultsBoolean = testString.EndsWith("works out.");
    Console.WriteLine($"Ends with \"works out.\" : {resultsBoolean}");

    resultsBoolean = testString.EndsWith("works out"); // Aqui teremos como retorno false, porque esqueci propositalmente o ponto "." no final.
    Console.WriteLine($"Ends with \"works out.\" : {resultsBoolean}");

    resultsBoolean = testString.Contains("of the search");
    Console.WriteLine($"Contains \"of the search\" : {resultsBoolean}");

    resultsInt = testString.IndexOf("of");
    Console.WriteLine($"Index \"of\" {resultsInt}");

    resultsInt = testString.IndexOf("of", 21);  //  Aqui nós temos como retorno -1, porque não existe um grupo de caractere 'of' após o index 21
    Console.WriteLine($"Index \"of\" after caracter 21 {resultsInt}");

    resultsInt = testString.LastIndexOf("of");
    Console.WriteLine($"Last Index \"of\" {resultsInt}");

    resultsInt = testString.LastIndexOf("of", 50);
    Console.WriteLine($"Last Index \"of\" {resultsInt}");

    Console.WriteLine();

    int i = 0;
    while (testString.IndexOf("test", i) > -1)
    {
        Console.WriteLine($"Position {i} = {testString[i]}");
        i++;
    }
}

static void OrderingString()
{
    CompareToHelper("Mary", "Bob");
    CompareToHelper("Mary", null);
    CompareToHelper("Adam", "Bob");
    CompareToHelper("Bob", "Bob");

    Console.WriteLine();

    CompareHelper("Mary", "Bob");
    CompareHelper("Mary", null);
    CompareHelper("Adam", "Bob");
    CompareHelper(null, "Bob");
    CompareHelper("Bob", "Bob");
    CompareHelper("Bob", "Bobby");
    CompareHelper(null, null);
}

static void CompareToHelper(string testA, string? testB)
{
    int resultsInt = testA.CompareTo(testB);
    switch (resultsInt)
    {
        case > 0:
            Console.WriteLine($"CompareTo: {testB ?? "null"} comes before {testA}");
            break;
        case < 0:
            Console.WriteLine($"CompareTo: {testA} comes before {testB}");
            break;
        case 0:
            Console.WriteLine($"CompareTo: {testA} is the same as {testB}");
            break;
    }
}

static void CompareHelper(string? testA, string? testB)
{
    int resultsInt = String.Compare(testA, testB);

    switch (resultsInt)
    {
        case > 0:
            Console.WriteLine($"Compare: {testB ?? "null"} comes before {testA}");
            break;
        case < 0:
            Console.WriteLine($"Compare: {testA ?? "null"} comes before {testB}");
            break;
        case 0:
            Console.WriteLine($"Compare: {testA ?? "null"} is the same as {testB ?? "null"}");
            break;
    }
}

static void TestEquality()
{
    EqualityHelper("Bob", "Mary");
    EqualityHelper("Bob", "Bob");
    EqualityHelper(null, "");
    EqualityHelper(" ", "Mary");
    EqualityHelper("Bob", "bob");

    Console.WriteLine();

    EqualityHelperIgnoreCase("Bob", "Mary");
    EqualityHelperIgnoreCase("Bob", "Bob");
    EqualityHelperIgnoreCase(null, "");
    EqualityHelperIgnoreCase(" ", "Mary");
    EqualityHelperIgnoreCase("Bob", "bob");

    Console.WriteLine();

    EqualityEqualsEquals("Bob", "Mary");
    EqualityEqualsEquals("Bob", "Bob");
    EqualityEqualsEquals(null, "");
    EqualityEqualsEquals(" ", "Mary");
    EqualityEqualsEquals("Bob", "bob");
}

static void EqualityHelper(string? testA, string? testB)
{
    bool resultsBoolean;

    resultsBoolean = String.Equals(testA, testB);

    if (resultsBoolean)
    {
        Console.WriteLine($"Equals: '{testA ?? "null"}' equals '{testB ?? "null"}'");
    }
    else
    {
        Console.WriteLine($"Equals: '{testA ?? "null"}' does not equal '{testB ?? "null"}'");
    }   
}

static void EqualityHelperIgnoreCase(string? testA, string? testB)
{
    bool resultsBoolean;

    resultsBoolean = String.Equals(testA, testB, StringComparison.InvariantCultureIgnoreCase);

    if (resultsBoolean)
    {
        Console.WriteLine($"Equals (Ignore case): '{testA ?? "null"}' equals '{testB ?? "null"}'");
    }
    else
    {
        Console.WriteLine($"Equals (Ignore case): '{testA ?? "null"}' does not equal '{testB ?? "null"}'");
    }
}

static void EqualityEqualsEquals(string? testA, string? testB) // Não é recomendado este tipo de comparação
{
    bool resultsBoolean;

    resultsBoolean = String.Equals(testA, testB, StringComparison.InvariantCultureIgnoreCase);

    if (resultsBoolean)
    {
        Console.WriteLine($"== : '{testA ?? "null"}' equals '{testB ?? "null"}'");
    }
    else
    {
        Console.WriteLine($"== : '{testA ?? "null"}' does not equal '{testB ?? "null"}'");
    }
}

static void GettingASubstring()
{
    // Remove uma parte da string e armazena em uma variável, sendo o primeiro parâmetro a posição
    // do caractere [inicial excludente] e o segundo parâmetro o último indice a ser capturado/recortado
    Console.WriteLine("This is a test of substring. Let's see how its testing works out.");
    string testString = "This is a test of substring. Let's see how its testing works out.";
    string results;

    results = testString.Substring(5);
    results = testString.Substring(5, 4); // Temos como retorno: is a
    Console.WriteLine(results);
}

static void ReplacingText()
{
    Console.WriteLine("This is a test of replace. Let's see how is testing works out.");
    string testString = "This is a test of replace. Let's see how is testing works out.";
    string results;

    results = testString.Replace(".", " |--| ");
    Console.WriteLine(results);

    Console.WriteLine();
    Console.WriteLine("This is a test of replace. Let's see how is testing works out.");
    results = testString.Replace(" test ", "...");
    Console.WriteLine(results);

    Console.WriteLine();
    Console.WriteLine("This is a test of replace. Let's see how is testing works out.");
    results = testString.Replace(" TEST ", "...", StringComparison.InvariantCultureIgnoreCase);
    Console.WriteLine(results);
}

static void IsertingText()
{
    string testString = "This is test of isert. Let's see how is testing works out for test.";
    string results;

    results = testString.Insert(5, "(test)");
    Console.WriteLine(results);
}

static void RemovingText()
{
    string testString = "This a large message. Problaly need slice a little part.";
    string results;

    results = testString.Remove(5); // Remove uma parte da string e armazena na variável
    Console.WriteLine(results);

    results = testString.Remove(25); 
    Console.WriteLine(results);
}