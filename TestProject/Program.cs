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

        Console.WriteLine($"The hero attacks and deals {heroAttack} damage to the monster!");
        Console.WriteLine($"The monster has {monsterHealth} health left.");

        if (monsterHealth <= 0)
          break;

        //Ataque del monstruo
        int monsterAttack = random.Next(1, 11);
        heroHealth -= monsterAttack;
        
        Console.WriteLine($"The monster attacks and deals {monsterAttack} damage to the hero!");
        Console.WriteLine($"The hero has {heroHealth} health left.");

      } while (heroHealth > 0 && monsterHealth > 0);

      Console.WriteLine("The fight is over!");

      if (heroHealth > 0)
        Console.WriteLine("The hero won!");
      else if (monsterHealth > 0)
        Console.WriteLine("The monster won!");
      else
        Console.WriteLine("Both dont have health, its a draw!");
    }
  }
}