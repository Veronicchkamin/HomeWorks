string ConsoleText = "Hi111111111! My na111me i76534s Veroni66543222ka.";
var ArrayWords = ConsoleText.Split(new char[]
{
    ' ',',','!','.' }, StringSplitOptions.RemoveEmptyEntries);
var counter = 0;
var result = string.Empty;
var maxCounter = 0;

foreach (var word in ArrayWords)
{
    for (int i = 0; i < word.Length; i++)
    {
        if (char.IsDigit(word[i]))
        {
            counter++;
        }
    }
    if (maxCounter < counter)
    {
        result = word;
        maxCounter = counter;
    }

    counter = 0;

}

Console.WriteLine(result);

