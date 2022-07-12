using System.Globalization;

Main();

static void Main()
{
    //StringConversion();
    //StringAsArray();
    //EscapeString();
    //AppendingStrings();
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