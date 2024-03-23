using System;

class Program1 {
  public static void Main (string[] args) {
    //declarando variaveis
   int num1, num2, res; 

    //entrada de dados
    Console.WriteLine ("Digite um numero inteiro");
    num1 = int.Parse(Console.ReadLine());

    Console.WriteLine ("Digite outro numero inteiro");
    num2 = int.Parse(Console.ReadLine());

    //resultado dos dados
    res = num1 + num2;

    //saida de resultados
    Console.WriteLine("A soma dos numeros é: " + res);
  }
}
