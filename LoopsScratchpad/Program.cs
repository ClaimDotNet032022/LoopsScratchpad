int max = 1000;

// Print out all even numbers up to
// (and including) max
int n = 0;
while(n < max)
{
    ++n;
    if (n % 2 == 1)
    {
        continue;
    }

    Console.WriteLine(n);
}


// Print out all the numbers
// until we find an even number
// that's divisible by 3.
n = 0;
while (true)
{
    ++n;
    
    if (n % 2 == 0 && n % 3 == 0)
    {
        break;
    }

    Console.WriteLine(n);
}


while (false)
{
    Console.WriteLine("False loop");
}


//string password = "Passw0rd";
//string attemptedPassword = "";
//do
//{
//    Console.WriteLine("Enter password:");
//    attemptedPassword = Console.ReadLine();
//} while (attemptedPassword != password);


//while (true)
//{
//    int m = 0;
//    ++m;

//    if (m > 5)
//    {
//        break;
//    }
//}

while (true)
{
    string m = "Hello";
    break;
}



{
    int n2 = 0;
    while (n2 < max)
    {
        Console.WriteLine(n2);


        ++n2;
    }
}

for (int i = 0; i < 10; ++i)
{
    Console.WriteLine(i);
}

for (int i = 10; i > 0; --i)
{
    Console.WriteLine(i);
}

for (; n < 5000; ++n)
{
    Console.WriteLine(n);
}



Console.WriteLine("All done");
