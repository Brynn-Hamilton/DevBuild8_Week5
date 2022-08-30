using Lab5_PrimeNumbers;

bool KeepGoing = true;

while (KeepGoing)
{
    Console.WriteLine("Let's locate some primes!");
    Console.WriteLine("This application will find you any prime, in order, from the first prime number on.");
    Console.WriteLine("Which prime number are you looking for? ");

    int input = Convert.ToInt32(Console.ReadLine());
    int result = PrimeNumbers.GetPrime(input);

    Console.WriteLine($"The number {input} prime is {result}");

    Console.Write("Do you want to find another prime number? y/n ");
    string choice = Console.ReadLine().ToLower();
    if (choice == "yes" || choice == "y")
    {
        Console.WriteLine();
        KeepGoing = true;
    }
    else if (choice == "no" || choice == "n")
    {
        Console.WriteLine();
        Console.WriteLine("Bye");
        KeepGoing = false;
    }
}