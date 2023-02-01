string selection;
do
{
    Console.Clear();
    Console.WriteLine("What do you want to execute?");
    Console.WriteLine("============================");
    Console.WriteLine();
    Console.WriteLine("0. Calculate Circle Area");
    Console.WriteLine("1. Random in Range");
    Console.WriteLine("2. To FizzBuzz");
    Console.WriteLine("3. Fibonacci by Index");
    Console.WriteLine("4. Ask for Number in Range");
    Console.WriteLine("5. Is palindrome?");
    Console.WriteLine("6. Is palindrome? (advanced)");
    Console.WriteLine("7. Chart Bar");
    Console.WriteLine("8. Count Smiling Faces");
    Console.WriteLine("q to Quit");
    selection = Console.ReadLine()!;

    if (selection != "q")
    {
        Console.Clear();
        switch (selection)
        {
            case "0": RunCalculateCircleArea(); break;
            case "1": RunRandomInRange(); break;
            case "2": RunToFizzBuzz(); break;
            case "3":
                Console.WriteLine(FibonacciByIndex(50));
                break;
            case "4": RunAskForNumberInRange();
                break;
            case "5":
                RunIsPalindrome();
                break;
            case "6":
                RunIsPalindromeAdvanced();
                break;

            default: break;
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
while (selection != "q");

// TODO: Create one code region for each level
#region Calculate Circle Area
void RunCalculateCircleArea()
{
    Console.Write("Enter radius:");
    var radius = double.Parse(Console.ReadLine()!);
    var area = CalculateCircleArea(radius);
    Console.WriteLine($"Area of circle with radius {radius} is {area}");
}

double CalculateCircleArea(double radius)
{
    return radius * radius * Math.PI;
}
#endregion

#region Level 1

void RunRandomInRange()
{
    Console.Write("Maximum: ");
    int max = int.Parse(Console.ReadLine()!);
    Console.Write("Minimum: ");
    int min = int.Parse(Console.ReadLine()!);
    int random = RandomInRange(min, max);
    Console.WriteLine($"Ergebnis: {random}");
    
}

// ReturnType Name(parameter)
int RandomInRange(int min, int max)
{
    int random = Random.Shared.Next(min, max + 1);
    return random;
}
void TestRandomInRange(int min, int max)
{
    for (int i = 0; i < 1000000; i++)
    {
        int random=RandomInRange(min,max);
        Console.WriteLine(random);
    }
}
#endregion

#region Level 2

void RunToFizzBuzz()
{
    Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine()!);
    string result = ToFizzBuzz(number);
    Console.WriteLine($"Ergebnis: {result}");
    
}

string ToFizzBuzz(int value)
{
    //result="1"
    string result=value.ToString();
    //1%5==0&&1%3==0 => false
    if(value%5==0&&value%3==0)
    {
        
        result = "FizzBuzz"; 
    }
    //1%3==0 => false
    else if (value%3==0)
    {
        result = "Fizz";
    }
    //1%5==0 => false
    else if (value%5==0)
    {
        result ="Buzz";
    }
    return result;
}

#endregion

#region Level 3

int FibonacciByIndex(int n)
{
    if (n == 0 || n == 1)
        return n;
    else
        return FibonacciByIndex(n - 1) + FibonacciByIndex(n - 2);
}

#endregion

#region Level 4
void RunAskForNumberInRange()
{
    Console.Write("Maximum: ");
    int max = int.Parse(Console.ReadLine()!);
    Console.Write("Minimum: ");
    int min = int.Parse(Console.ReadLine()!);
    int result = AskForNumberInRange(min, max);
    Console.WriteLine("Thank you, your input is valid.");
    
}
int AskForNumberInRange(int min, int max)
{
    Console.WriteLine($"Please enter a value between {min} and {max}");
    int input = int.Parse(Console.ReadLine()!);
    while (input < min || input > max)
    {
        if (input < min)
        {
            Console.WriteLine($"Wrong number. Your input is too low. The minimum is {min}. Try again!");
        }

        if (input > max)
        {
            Console.WriteLine($"Wrong number. Your input is too high. The maximum is {max}. Try again!");
        }
        input = int.Parse(Console.ReadLine()!);

    } 

    return input;
}


#endregion

#region Level 5

void RunIsPalindrome()
{
    Console.Write("Enter your word: ");
    string input = Console.ReadLine()!;

    Console.WriteLine(IsPalindrome(input));
}

bool IsPalindrome(string word)
{
    string reverse = "";
    for (int i = word.Length-1; i >=0 ; i--)
    {
        
        reverse = reverse + word[i];
    }
    return word==reverse;
}

#endregion

#region Level 6

void RunIsPalindromeAdvanced()
{
    Console.Write("Enter your word: ");
    string input = Console.ReadLine()!;

    Console.WriteLine(IsPalindromeAdvanced(input));
}

bool IsPalindromeAdvanced(string word)
{
    string reverse = "";
    string newWord="";

    for (int i = 0; i < word.Length; i++)
    {
        if (word[i]!=' '&&word[i]!=','&&word[i]!='-')
        {
            newWord = newWord+word[i];
        }
    }
    
    for (int i = newWord.Length-1; i >=0 ; i--)
    {
        
        reverse = reverse + newWord[i];
    }
    return newWord.ToUpper()==reverse.ToUpper();
}

#endregion
