using System;

namespace DesafioIteraciones
{
  class EntradaEnteros
  {
    static void Main(string[] args)
    {
      //Ejercicio 1
      int valorEntero = 0;
      bool valorValido = false;

      do
      {
        Console.WriteLine("Enter a integer value between 5 and 10");
        string valorIngresado = Console.ReadLine();
        valorValido = int.TryParse(valorIngresado, out valorEntero);
        if (valorValido)
        {
          if (valorEntero < 5 || valorEntero > 10)
          {
            valorValido = false;
            Console.WriteLine($"You entered {valorEntero}. Please enter a number between 5 and 10");
          }
        }
      } while (!valorValido);

      Console.WriteLine($"Your input value ({valorEntero}) has been accepted.");


    }
  }
}