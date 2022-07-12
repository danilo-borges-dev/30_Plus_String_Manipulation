using System.Globalization;

Main();

static void Main()
{
    //StringConversion();
    StringAsArray();
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