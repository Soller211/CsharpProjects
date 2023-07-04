using System;

namespace TestProject
{
  class Program
  {
    static void Main(string[] args)
    {
      int heroHealth = 10;
      int monsterHealth = 10;
      Random random = new Random();

      Console.WriteLine("The fight is starting!");

      do
      {
        //Ataque del heroe
        int heroAttack = random.Next(1, 11);
        monsterHealth -= heroAttack;

        Console.WriteLine($"Monster was damaged and lost {heroAttack} and now has {monsterHealth} health");

        if (monsterHealth <= 0)
          break;

        //Ataque del monstruo
        int monsterAttack = random.Next(1, 11);
        heroHealth -= monsterAttack;

        Console.WriteLine($"Hero was damaged and lost {monsterAttack} and now has {heroHealth} health");

      } while (heroHealth > 0 && monsterHealth > 0);

      Console.WriteLine("The fight is over!");

      if (heroHealth > 0)
        Console.WriteLine("The hero wins!");
      else if (monsterHealth > 0)
        Console.WriteLine("The monster wins!");
      else
        Console.WriteLine("Both dont have health, its a draw!");
    }
  }
}