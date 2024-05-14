string letters = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine("What word would you like to use?");
string text = Console.ReadLine().ToLower();

// string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

Dictionary<char, int> charCounter = [];
foreach (char character in text.ToCharArray())
{
    if (letters.Contains(character))
    {
        if (!charCounter.ContainsKey(character))
        {
            charCounter.Add(character, 1);
        }
        else
        {
            charCounter[character]++;
        }
    }
}
foreach (KeyValuePair<char, int> kvp in charCounter)
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}
