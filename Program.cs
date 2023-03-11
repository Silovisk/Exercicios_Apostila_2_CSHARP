using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercicios_Apostila_2_CSHARP
{
    internal class Program
    {
        // Classe usada para retornar a média e a situação do aluno.
        public class ResultadoNotas
        {
            public double media
            {
                get; set;
            }

            public string situacao
            {
                get; set;
            }
        }

        // Método para calcular a média e a situação do aluno.
        public static ResultadoNotas med(double N1, double N2)
        {
            double media = (N1 + N2) / 2;
            string situacao;


            if (media > 7)
            {
                situacao = "Aprovado";
            }
            else
            {
                situacao = "Reprovado";
            }

            // Retorna um novo objeto ResultadoNotas com a média e a situação do aluno.
            return new ResultadoNotas
            {
                media = media,
                situacao = situacao
            };
        }

        // Método para calcular a sequência de Fibonacci até o número n.
        public static List<int> Fibonacci(int n)
        {
            List<int> sequencia = new List<int> { 0, 1 }; // Cria uma lista com os dois primeiros números da sequência.
            for (int i = 2; i < n; i++)
            {
                sequencia.Add(sequencia[i - 1] + sequencia[i - 2]); // Adiciona o próximo número da sequência.
            }
            return sequencia;
        }

        // Método para calcular o MDC entre dois números.
        static int MDC(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

        static void Main(string[] args)
        {
            string caminhoArquivo = @"Arquivos\Exercicios.txt";
            List<string> conteudoArquivo = new List<string>();
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                string linha;
                while ((linha = reader.ReadLine()) != null)
                {
                    conteudoArquivo.Add(linha); // Lê as linhas do arquivo e adiciona a uma lista.
                }
            }

            // Variáveis para armazenar o texto de cada exercício.
            string exercicio1 = "";
            string exercicio2 = "";
            string exercicio3 = "";
            string exercicio4 = "";
            string exercicio5 = "";
            string exercicio6 = "";
            string exercicio7 = "";
            string exercicio8 = "";
            string exercicio9 = "";

            string exercicioAtual = ""; // Variável para identificar qual exercício está sendo lido no momento.
            foreach (string linha in conteudoArquivo)
            {
                // Verifica qual é o exercício atual.
                if (linha.StartsWith("Exercício 1"))
                {
                    exercicioAtual = "1";
                    continue;
                }
                else if (linha.StartsWith("Exercício 2"))
                {
                    exercicioAtual = "2";
                    continue;
                }
                else if (linha.StartsWith("Exercício 3"))
                {
                    exercicioAtual = "3";
                    continue;
                }
                else if (linha.StartsWith("Exercício 4"))
                {
                    exercicioAtual = "4";
                    continue;
                }
                else if (linha.StartsWith("Exercício 5"))
                {
                    exercicioAtual = "5";
                    continue;
                }
                else if (linha.StartsWith("Exercício 6"))
                {
                    exercicioAtual = "6";
                    continue;
                }
                else if (linha.StartsWith("Exercício 7"))
                {
                    exercicioAtual = "7";
                    continue;
                }
                else if (linha.StartsWith("Exercício 8"))
                {
                    exercicioAtual = "8";
                    continue;
                }
                else if (linha.StartsWith("Exercício 9"))
                {
                    exercicioAtual = "9";
                    continue;
                }

                //Compara o número do exercício atual com os números possíveis de exercício e, em seguida, concatena a linha atual do arquivo de texto com a variável correta.
                switch (exercicioAtual)
                {
                    case "1":
                        exercicio1 += linha + "\n";
                        break;
                    case "2":
                        exercicio2 += linha + "\n";
                        break;
                    case "3":
                        exercicio3 += linha + "\n";
                        break;
                    case "4":
                        exercicio4 += linha + "\n";
                        break;
                    case "5":
                        exercicio5 += linha + "\n";
                        break;
                    case "6":
                        exercicio6 += linha + "\n";
                        break;
                    case "7":
                        exercicio7 += linha + "\n";
                        break;
                    case "8":
                        exercicio8 += linha + "\n";
                        break;
                    case "9":
                        exercicio9 += linha + "\n";
                        break;
                }
            }

            string escolha = "-1";

            // Converte a variável escolha para inteiro e enquanto não for digitado 0 ele não finalizara
            while (int.Parse(escolha) != 0)
            {
                Console.WriteLine("Escolha qual exercício deseja visualizar (1 a 9):");
                Console.WriteLine("0 Para Finalizar");
                escolha = Console.ReadLine();

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("Exercício 1");
                        Console.WriteLine(exercicio1);

                        // Função que verifica se um número inteiro é par ou ímpar
                        string par_ou_impar(int N)
                        {
                            string resp;
                            if (N % 2 == 0 || N == 0) // verifica se o número é divisível por 2 ou igual a 0
                            {
                                resp = "e PAR";
                            }
                            else
                            {
                                resp = "e IMPAR";
                            }
                            return resp;
                        }

                        int num;
                        Console.WriteLine("Informe um numero: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine($"O numero {par_ou_impar(num)}");

                        break;
                    case "2":
                        Console.WriteLine("Exercício 2");
                        Console.WriteLine(exercicio2);

                        // Declaração de um array de inteiros com tamanho 3
                        int[] numeros = new int[3];
                        int menor_numero;

                        // Criação de um HashSet para armazenar os números digitados e evitar duplicatas
                        //o HashSet "categoriza" os seus elementos, de forma a encontrá-los rapidamente
                        HashSet<int> numerosDigitados = new HashSet<int>();
                        // Loop para ler os 3 números digitados pelo usuário
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine("Digite o {0}° numero", i + 1);
                            int numero = int.Parse(Console.ReadLine());

                            // Verificação se o número já foi digitado anteriormente, se sim, exibe mensagem e decrementa o contador
                            if (numerosDigitados.Contains(numero))
                            {
                                Console.WriteLine("Numero ja digitado");
                                i--;
                            }
                            // Se o número não foi digitado anteriormente, adiciona o número ao array e ao HashSet
                            else
                            {
                                numeros[i] = numero;
                                numerosDigitados.Add(numero);
                            }
                        }
                        // Encontra o menor número do array de números digitados
                        menor_numero = numeros.Min();
                        Console.WriteLine($"Menor numero: {menor_numero}");

                        break;
                    case "3":
                        Console.WriteLine("Exercício 3");
                        Console.WriteLine(exercicio3);

                        double n1, n2;

                        Console.WriteLine("Digite o valor da 1° Nota: ");
                        n1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor da 2° Nota: ");
                        n2 = double.Parse(Console.ReadLine());

                        // Chama o método "med" para calcular a média e a situação do aluno, armazenando o resultado no objeto "resultado"
                        ResultadoNotas resultado = med(n1, n2);
                        Console.WriteLine($"O valor de n1: {n1} \nvalor de n2: {n2} \nMedia: {resultado.media:F2}\nSituacao: {resultado.situacao}");
                        break;
                    case "4":
                        Console.WriteLine("Exercício 4");
                        Console.WriteLine(exercicio4);

                        // Método para definir a situação do aluno com base na média
                        string Situacao(double m)
                        {
                            string situacao = " ";

                            if (m >= 7)
                            {
                                situacao = "Aluno Aprovado";
                            }
                            else if (m >= 5)
                            {
                                situacao = "Aluno de Recuperação";
                            }
                            else if (m < 5)
                            {
                                situacao = "Aluno Reprovado";
                            }

                            return situacao;
                        }

                        double nota1, nota2, media;

                        Console.WriteLine("Digite o valor da 1° Nota: ");
                        nota1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o valor da 2° Nota: ");
                        nota2 = double.Parse(Console.ReadLine());

                        // Chama o método para calcular a média e armazena o resultado em uma variável
                        ResultadoNotas pega_media = med(nota1, nota2);
                        media = pega_media.media;
                        // Chama o método para definir a situação do aluno com base na média
                        string situacao_notas = Situacao(media);

                        Console.WriteLine($"Media Aluno: {media:F2} \nSituacao: {situacao_notas}");
                        break;
                    case "5":
                        Console.WriteLine("Exercício 5");
                        Console.WriteLine(exercicio5);

                        int num1, num2, soma, menor = 0;
                        Console.WriteLine("Informe o 1° numero: ");
                        num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Informe o 2° numero: ");
                        num2 = int.Parse(Console.ReadLine());

                        soma = num1 + num2;
                        // Identifica o menor número informado.
                        if (num1 == num2)
                        {
                            menor = num1;
                        }
                        else if (num1 > num2)
                        {
                            menor = num2;
                        }
                        else if (num1 < num2)
                        {
                            menor = num1;
                        }
                        else
                        {
                            Console.WriteLine("Invalido");
                        }
                        Console.WriteLine($"A Soma entre {num1} + {num2} = {soma} \nMenor Numero e: {menor}");
                        break;
                    case "6":
                        Console.WriteLine("Exercício 6");
                        Console.WriteLine(exercicio6);

                        // Define uma função para calcular o fatorial de um número inteiro.
                        int Fat(int N)
                        {
                            int r = 1;
                            for (int i = 2; i <= N; i++)
                            {
                                r *= i;
                            }
                            return r;
                        }
                        int fatorial, num6;

                        Console.WriteLine("Informe um numero: ");
                        num6 = int.Parse(Console.ReadLine());
                        // Calcula o fatorial do número informado e exibe o resultado.
                        fatorial = Fat(num6);
                        Console.WriteLine($"O Fatorial de {num6} e {fatorial}");

                        break;
                    case "7":
                        Console.WriteLine("Exercício 7");
                        Console.WriteLine(exercicio7);

                        int a, b, result;
                        Console.WriteLine("Digite o valor de a: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor de b: ");
                        b = int.Parse(Console.ReadLine());

                        // Calcula o MDC dos dois números informados.
                        result = MDC(a, b);
                        Console.WriteLine($"A = {a}\nB = {b}\nMdc = {result}");

                        break;
                    case "8":
                        Console.WriteLine("Exercício 8");
                        Console.WriteLine(exercicio8);

                        int maior = 0, valor = 0;

                        while (valor != -1)
                        {
                            Console.WriteLine("Informe um valor: (-1 para finalizar)");
                            valor = int.Parse(Console.ReadLine());

                            // Identifica o maior valor informado.
                            if (valor > maior)
                            {
                                maior = valor;
                            }
                        }
                        Console.WriteLine($"O maior valor e : {maior}");
                        break;
                    case "9":
                        Console.WriteLine("Exercício 9");
                        Console.WriteLine(exercicio9);

                        Console.WriteLine("Informe um numero: ");
                        int n = int.Parse(Console.ReadLine());

                        // Chama a função Fibonacci passando o número informado pelo usuário como parâmetro e armazena o retorno em uma lista 'fibonacciList'
                        List<int> fibonacciList = Fibonacci(n);

                        // Percorre a lista 'fibonacciList' e imprime cada número na tela
                        foreach (int numb in fibonacciList)
                        {
                            Console.WriteLine(numb);
                        }
                        Console.WriteLine();

                        break;
                    default:
                        Console.WriteLine("Escolha inválida.");
                        break;
                }
            }
        }
    }
}