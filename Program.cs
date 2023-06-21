internal class Program
{
    static string reversString(string string1) //problem1

    {
        string revstring = string.Empty;//blank string
        for (int i = string1.Length - 1; i >= 0; i--)
        {
            revstring += string1[i];
        }
        return revstring;
    }
    static int _countVowels(string string2)//problem2
    {
        int count = 0;
        for (int i = 0; i < string2.Length; i++)
        {

            if (string2[i] == 'a' || string2[i] == 'e' || string2[i] == 'i' || string2[i] == 'o' || string2[i] == 'u')
            {
                count++;
            }

        }
        return count;
    }
    static string[] _reversSentence(string string3)//problem3

    {

        string[] result = new string[100];
        string tempStr = string.Empty;//blank string
        int arrayIndex = 0;
        for (int i = 0; i < string3.Length; i++)
        {
            tempStr += string3[i].ToString();
            if (string3[i] != ' ')
            {
                result[arrayIndex] = tempStr;
            }
            else
            {
                tempStr = "";
                arrayIndex++;
            }
        }


        return result;

    }
    static string _replacementoFcharacter(string string4, char target, char replace)//problem4
    {

        string totl = string4.Replace(target, replace);
        return totl;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("enter a string");
        string string1 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("the reverse of the string is " + reversString(string1));
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("enter string");
        string string2 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("the number of Vowels in this string  is " + _countVowels(string2));
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("enter string");
        string string3 = Convert.ToString(Console.ReadLine());

        string[] result = new string[100];
        result = _reversSentence(string3);
        Console.Write("the rever of " + string3 + " is: ");
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i] + ' ');
        }
        Console.WriteLine();

        Console.WriteLine("------------------------------------------------");
        Console.WriteLine("enter string");
        string string4 = Convert.ToString(Console.ReadLine());
        Console.WriteLine("enter target char to be replaced");
        char target = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("which cahr you want to  replac it with");
        char replace = Convert.ToChar(Console.ReadLine());

        Console.WriteLine(_replacementoFcharacter(string4, target, replace));
    }
}