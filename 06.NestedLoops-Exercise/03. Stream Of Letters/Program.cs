
string input = Console.ReadLine();
string word = string.Empty;

bool isC = false; 
bool isO = false;
bool isN = false;

while (input != "End")
{
    char element = char.Parse(input);
    input = Console.ReadLine();

    if (!((element >= 65 && element <= 90) || (element >= 97 && element <= 122)))
    {
        continue;
    }

    if (element != 'c' && element != 'o' && element != 'n')
    {
        word += element;
    }
    else if (element == 'c')
    {
        if (!isC)
        {
            isC = true;
        }
        else
        {
            word += element;
        }
    }
    else if (element == 'o')
    {
        if (!isO)
        {
            isO = true;
        }
        else
        {
            word += element;
        }
    }
    else if (element == 'n')
    {
        if (!isN)
        {
            isN = true;
        }
        else 
        { 
            word += element; 
        }   
    }

    if (isC && isN && isO)
    {
        Console.Write(word + " ");

        isC = false;
        isO = false;
        isN = false;
        word = string.Empty;

    }
}