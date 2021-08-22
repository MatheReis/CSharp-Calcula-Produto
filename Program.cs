using System;

namespace CSharp_Calcula_Produto
{
    class Program
    {
        static void Main(string[] args)
        {
          //declaração das variáveis do programa
          double Numb1, Num2, Mult;

          //comando "LimpaTela" limpa a tela do monitor de vídeo
          Console.Clear();

          //{Entrada de dado}
          // mensagem para digitar o primeiro número
          Console.Write("Digite o primeiro número:");

          //leitura do primeiro número para a memória
          Numb1 = double.Parse(Console.ReadLine());

          //mensagem para digitar o segundo número
          Console.Write("Digite o segundo número:");
          Num2 = double.Parse(Console.ReadLine());

          //{Processamento}
          //calcula o produto e armazena o resultado na variável Mult
          Mult = Numb1 * Num2;

          //{Saída da informação}
          //apenas salta a linha na tela do monitor de video
          Console.WriteLine();
          Console.WriteLine($"A multiplicação de {Numb1} por {Num2} é {Mult}");

        }
    }
}
