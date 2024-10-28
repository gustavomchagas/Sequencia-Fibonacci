using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um número para verificar se pertence à sequência de Fibonacci: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (PertenceSequenciaFibonacci(numero))
        {
            Console.WriteLine($"O número {numero} pertence à sequência de Fibonacci!");
        }
        else
        {
            Console.WriteLine($"O número {numero} NÃO pertence à sequência de Fibonacci!");
        }

        // Aguarda uma entrada do usuário antes de fechar o console
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static bool PertenceSequenciaFibonacci(int numero)
    {
        // Casos base
        if (numero == 0 || numero == 1)
            return true;

        // Inicializa os primeiros números da sequência
        int anterior = 0;
        int atual = 1;

        // Calcula a sequência até encontrar ou ultrapassar o número
        while (atual <= numero)
        {
            if (atual == numero)
                return true;
            int proximo = anterior + atual;
            anterior = atual;
            atual = proximo;
        }

        return false;
    }
}
