using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Nome do Usuário
        Console.WriteLine("Bem-vindo ao Teste 02, para iniciarmos qual é o seu nome?");
        string nomeDoUsuario = Console.ReadLine();

        // Verificando se a string não está vazia
        if (string.IsNullOrEmpty(nomeDoUsuario))
        {
            Console.WriteLine("Nome inválido. Por favor, digite novamente.");
            return; // Encerra o programa se o nome for inválido
        }

        int numeroDeNotas = 0;
        double totalDasNotas = 0;

        for (int quantidadeDeProvas = 1; ; quantidadeDeProvas++)
        {
            // Pega e armazena nota
            double notaDaProva = PegaNota();

            totalDasNotas += notaDaProva;
            numeroDeNotas++;

            double media = totalDasNotas / numeroDeNotas;

            Console.WriteLine($"Nome: {nomeDoUsuario}");
            Console.WriteLine($"Quantidade de Provas: {quantidadeDeProvas}");
            Console.WriteLine($"Total de Nota: {totalDasNotas}");
            Console.WriteLine($"Sua média é de {media}");
        }

        double PegaNota()
        {
            Console.WriteLine($"{nomeDoUsuario}, por favor, nos informe qual foi sua nota na prova?");
            double notaDaProva = double.Parse(Console.ReadLine());

            return notaDaProva;
        }
    }
}