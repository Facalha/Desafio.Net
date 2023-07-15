using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Teste 03");
        Console.WriteLine("Informe o nome do aluno:");
        string nomeDoAluno = Console.ReadLine();
        if (string.IsNullOrEmpty(nomeDoAluno))
        {
            Console.WriteLine("Nome inválido. Por favor, digite novamente.");
            return; // Encerra o programa se o nome for inválido
        }

        Console.WriteLine($"Qual foi a nota do primeiro semestre do aluno {nomeDoAluno}");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Qual foi a nota do primeiro semestre do aluno {nomeDoAluno}");
        double nota2 = double.Parse(Console.ReadLine());

        double notaMedia = (nota1 + nota2) / 2;
        string Aprovacao = (notaMedia <= 6.5) ? "Reprovado" : "Aprovado";

        Console.WriteLine($"Nome de aluno: {nomeDoAluno}");
        Console.WriteLine($"Média: {notaMedia}");
        Console.WriteLine($"O aluno foi: {Aprovacao}");
    }
}