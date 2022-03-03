using System;
public class adivinarNumero
{
    public static void Main(string[] args)
    {
        var generadorAleatorio = new Random();
        int numeroParaAdivinar = generadorAleatorio.Next(0, 16);
        int numero = Int32.Parse(Console.ReadLine());
        int intentos = 3;
        Console.WriteLine("Introduzca un número aleatorio entre 0 y 16");

        while ((numero != numeroParaAdivinar) && (intentos <= 4))
        {
            if (numero < numeroParaAdivinar)
            {
                Console.WriteLine("¡ERROR! Vuelva a introducir un número");
                Int32.Parse(Console.ReadLine());
            }
            else if (numero > numeroParaAdivinar)
            {
                Console.WriteLine("Ooohh, no has adivinado. Inténtalo una vez más");
                Int32.Parse(Console.ReadLine());
            }
            else if (numero == numeroParaAdivinar)
            {
                Console.WriteLine("¡¡¡ENHORABUENA, HAS ADIVINADO EL NÚMERO!!!");
                Int32.Parse(Console.ReadLine());
                Console.WriteLine($"El numero a adivinar era {numeroParaAdivinar}");
            }
            intentos++;
        }
        Console.WriteLine($"Usted ha perdido");

        Console.ReadLine();




    }
}
