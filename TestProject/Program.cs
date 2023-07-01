using System;

// for (int i = 10; i >= 0; i--)
// {
//     Console.WriteLine(i);
// }


// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

// Explicación de break en un for
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

// string[] names = { "Adam", "Barry", "Charlie", "Michael" };

// for (int i = 0; i < names.Length; i++)
//   if (names[i] == "Charlie")
//     names[i] = "Sammy";

// foreach (var name in names)
//   Console.WriteLine(name);

// desafío fizzbuzz
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine($"{i} FizzBuzz");
//     } else if (i % 3 == 0)
//     {
//         Console.WriteLine($"{i} Fizz");
//     } else if (i % 5 == 0)
//     {
//         Console.WriteLine($"{i} Buzz");
//     } else
//     {
//         Console.WriteLine(i);
//     }
// }
// Console.WriteLine("Presione cualquier tecla para salir");
// Console.ReadLine();

// Console.WriteLine("Presione cualquier tecla para salir");
// Console.ReadLine();

// Quiero un programa que haga el desafio de fizz buzz
//Conviertelo a una funcion

internal class Program
{
  private static void Main(string[] args)
  {
    Func<int, string> fizzBuzz = (i) =>
{
  if (i % 3 == 0 && i % 5 == 0)
  {
    return $"{i} FizzBuzz";
  }
  else if (i % 3 == 0)
  {
    return $"{i} Fizz";
  }
  else if (i % 5 == 0)
  {
    return $"{i} Buzz";
  }
  else
  {
    return $"{i}";
  }
};

    for (int i = 1; i <= 100; i++)
    {
      Console.WriteLine(fizzBuzz(i));
    }
  }
}