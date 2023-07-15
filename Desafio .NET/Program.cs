using System;

Console.WriteLine("Digite a nota do primeiro semestre:");
float notaPrimeiroSemestre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a nota do segundo semestre:");
float notaSegundoSemestre = Convert.ToInt32(Console.ReadLine());

float media = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;

Console.WriteLine($"Sua média é de {media}");