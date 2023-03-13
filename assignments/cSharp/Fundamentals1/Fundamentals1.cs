// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



// Create a loop that prints all values from 1-255
// for (int i = 1; i <= 255; i++)
// {
//     Console.WriteLine(i);
// }


// Create a new loop that generates 5 random numbers between 10 and 20.
// Random rand = new Random();
// for (int a = 1; a <= 5; a++)
// {
//     Console.WriteLine(rand.Next(10, 21));
// }



// Modify the previous loop to add the random values together and print the sum after the loop finish
// int sum = 0;
// for (int a = 1; a <= 5; a++)
// {
//     int x = rand.Next(10, 21);
//     Console.WriteLine(x);

//     sum = sum + x;
// }
// Console.WriteLine(sum);


// Create a new loop that prints all values from 1 to 100 that are divisible by 3 or 5, but NOT both.
// for (int b = 1; b <= 100; b++)
// {
//     if (b % 3 == 0 && b % 5 == 0)
//         continue;
//     if (b % 3 == 0 || b % 5 == 0)
//     {
//         Console.WriteLine(b);
//     }
// }


// Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz" for multiples of 5. 
// for (int c = 1; c <= 100; c++)
//     if (c % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (c % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }


// Modify the previous loop once more to now also print "FuzzBuzz" for numbers that are multiples of both 3 and 5
// for (int d = 1; d <= 100; d++)
//     if (d % 3 == 0 && d % 5 == 0)
//     {
//         Console.WriteLine("FizzBuzz");
//     }
//     else if (d % 3 == 0)
//     {
//         Console.WriteLine("Fizz");
//     }
//     else if (d % 5 == 0)
//     {
//         Console.WriteLine("Buzz");
//     }