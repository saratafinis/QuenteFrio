using System;
 
class Program
{
    static void Main()
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 101); // Número entre 1 e 100
        int tentativas = 0;
        bool acertou = false;
 
        Console.WriteLine("Tente adivinhar o número secreto entre 1 e 100!");
 
        while (!acertou)
        {
            Console.Write("Digite seu palpite: ");
            int palpite = int.Parse(Console.ReadLine()); // Assumindo que o usuário digitará um número
            tentativas++;
 
            if (palpite == numeroSecreto)
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
                acertou = true;
            }
            else
            {
                if (Math.Abs(numeroSecreto - palpite) <= 10)
                {
                    Console.WriteLine("Está quente!");
                }
                else
                {
                    Console.WriteLine("Está frio!");
                }
 
                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior.");
                }
                else
                {
                    Console.WriteLine("O número secreto é menor.");
                }
            }
        }
    }
}