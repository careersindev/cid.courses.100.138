// See https://aka.ms/new-console-template for more information

// REQUIRED FOR STRINGBUILDER EXAMPLE
using System.Text;

Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - DECLARING");
Console.WriteLine("-------------------------");
DelcaringExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - COMPARISON");
Console.WriteLine("-------------------------");
ComparisonExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - NULL OR EMPTY");
Console.WriteLine("-------------------------");
NullOrEmptyExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("EXAMPLE - TRIM");
Console.WriteLine("-------------------------");
TrimmingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - CASING");
Console.WriteLine("-------------------------");
CasingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - CONCATENATING");
Console.WriteLine("-------------------------");
ConcatenatingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - REPLACING");
Console.WriteLine("-------------------------");
ReplacingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - PARSING");
Console.WriteLine("-------------------------");
ParsingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - SEARCHING");
Console.WriteLine("-------------------------");
SearchingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - SPLITTING");
Console.WriteLine("-------------------------");
SplittingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - FORMATTING");
Console.WriteLine("-------------------------");
FormattingExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - STRINGBUILDER");
Console.WriteLine("-------------------------");
StringBuilderExample();
Console.WriteLine(Environment.NewLine);


Console.WriteLine("-------------------------");
Console.WriteLine("EXAMPLE - REAL WORLD");
Console.WriteLine("-------------------------");
RealWorldExample();


Console.ReadLine();


static void DelcaringExample()
{
    string declaredString = "Teaching about strings";
    Console.WriteLine(declaredString);
}

static void ComparisonExample()
{
    string declaredString = "Teaching about strings";

    if (declaredString == "Teaching about strings")
    {
        Console.WriteLine("The strings are equal using ==");
    }


    // Here the strings are not equal so we are using the "!" (NOT) operator to say they are not equal.
    if (!declaredString.Equals("Learning about strings"))
    {
        Console.WriteLine("The strings are not equal using Equals method.");
    }
}

static void NullOrEmptyExample()
{
    string declaredString = "Teaching about strings";
    bool isNullOrEmpty = string.IsNullOrEmpty(declaredString);
    Console.WriteLine("Is null or empty: " + isNullOrEmpty);
}

static void ConcatenatingExample()
{
    string declaredString = "Teaching about strings";

    string concatenatingString = declaredString + " and then concatenating strings together using +";
    Console.WriteLine(concatenatingString);
}

static void TrimmingExample()
{
    string declaredString = " Teaching about strings ";

    // EXAMPLE - TRIM
    string trimmingString = declaredString.Trim();
    Console.WriteLine("-" + trimmingString + "-");
    
    // EXAMPLE - TRIM START
    string trimStartString = declaredString.TrimStart();
    Console.WriteLine("-" + trimStartString + "-");

    // EXAMPLE - TRIM END
    string trimEndString = declaredString.TrimEnd();
    Console.WriteLine("-" + trimEndString + "-");
}

static void ReplacingExample()
{
    string declaredString = "Teaching about strings";

    string replacingString = declaredString.Replace("Teaching", "Learning");
    Console.WriteLine(replacingString);
}

static void ParsingExample()
{
    string declaredString = "Teaching about strings";

    string replacingString = declaredString.Substring(0, 5);
    Console.WriteLine(replacingString);
}

static void SearchingExample()
{
    string declaredString = "Teaching about strings";

    // EXAMPLE - STARTSWITH
    bool startsWithTeach = declaredString.StartsWith("Teach");
    Console.WriteLine("Does the phrase start with 'Teach'?   Answer: " + startsWithTeach);

    // EXAMPLE - ENDSWITH
    bool endsWithTeach = declaredString.EndsWith("Teach");
    Console.WriteLine("Does the phrase end with 'Teach'?   Answer: " + endsWithTeach);

    // EXAMPLE - CONTAINS
    bool containsTeach = declaredString.Contains("Teach");
    Console.WriteLine("Does the phrase contain the word 'Teach'?   Answer: " + containsTeach);
}

static void CasingExample()
{
    string declaredString = "Teaching about strings";
    string casedString = declaredString.ToUpper();
    Console.WriteLine(casedString);
}

static void SplittingExample()
{
    string declaredString = "Teaching about strings,Learning about string";

    string[] splitStrings = declaredString.Split(',');

    foreach (var splitString in splitStrings)
    {
        Console.WriteLine(splitString);
    }
}

static void FormattingExample()
{
    string declaredString = "{0} about strings{1}";
    string formattedString = string.Format(declaredString, "Teaching", "!");
    Console.WriteLine(formattedString);
}

static void StringBuilderExample()
{
    StringBuilder builder = new StringBuilder("Teaching about strings");
    builder.Append(" is a lot of fun");
    builder.Append(" and very rewarding");
    Console.WriteLine(builder.ToString());
}


static void RealWorldExample()
{
    // Setting up a template for what we want each line to be output as after we process it.
    string templateOutput = "My favorite {0} team is the {1}.  My favorite player from that team {2}: {3}";

    // Declaring and concatenating a string to build a file path for loading the KCSportsTeams.txt file.
    string filePath = Environment.CurrentDirectory + "/KCSportsTeams.txt";

    // Reading a list of strings into an array for processing.
    string[] sportsTeams = System.IO.File.ReadAllLines(filePath);

    // Loop through each of the lines in the text file and reformat the output to make it read better.
    foreach (string sportTeam in sportsTeams)
    {
        // Splitting each line into its parts so we can rebuild it in a new way.
        string[] teamSplit = sportTeam.Split("-");

        // Lowering the sport name since it isn't a proper noun.
        string sportName = teamSplit[0];
        sportName = string.Concat(sportName.ToLower());

        // Rebuilding the team with Pascal casing because it is a proper noun.
        string teamName = teamSplit[1];
        teamName = string.Concat(teamName.Substring(0, 1), teamName.Substring(1, teamName.Length - 1).ToLower());

        // Rebuilding the player with Pascal casing because it is a proper noun.
        string playerName = teamSplit[2];
        playerName = string.Concat(playerName.Substring(0, 1), playerName.Substring(1, playerName.Length - 1).ToLower());

        // Determine past or present tense depending on player name.
        string tense = "was";
        if (playerName.Contains("Patrick"))
        {
            tense = "is";
        }

        // Reformatting the entry to make it read better.
        string output = string.Format(templateOutput, sportName, teamName, tense, playerName);
        
        // EXTRA CREDIT - The players last name in the output is not cased properly.  Instead of "Patrick mahomes", it should be "Patrick Mahomes".
        // See if you can change the logic above to fix that bug.
        Console.WriteLine(output);
    }
}