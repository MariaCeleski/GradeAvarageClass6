using System;

namespace Grade_avarage
{
    class Program
    {
        /*ATIVIDADE: Fazer um sistema de escola que leia o nome do aluno e as notas dos 4 bimestres e a quantidade total de faltas, calcular a media geral do ano e  decidir baseado nas regras abaixo se o aluno passou, reprovou ou ficou de de recuperacao:

        Se a nota do aluno for maior que 7  aluno aprovado.
        Se nota menor que 5 reprovado.
        Se nota entre 5 e 7 aluno em recuperação.

        Obs: se quantidade de faltas for maior ou igual a  50  aluno também esta  reprovado.*/
        static void Main(string[] args)
        {
            Console.Write("Digite seu nome: ");
            String name = Console.ReadLine();
            Console.WriteLine($"Olá {name}!");

            double nota1, nota2, nota3, nota4, media = 0;
            int falta1, falta2, falta3, falta4, totalFaltas = 0;

            //Digite as notas
            Console.Write("Entre com a nota 1 : ");
            nota1 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 2 : ");
            nota2 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 3 : ");
            nota3 = double.Parse(Console.ReadLine());

            Console.Write("Entre com a nota 4 : ");
            nota4 = double.Parse(Console.ReadLine());


            //Digite o número de faltas

            Console.Write("Entre com o número de faltas do bimestre 1 : ");
            falta1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o número de faltas do bimestre 2 : ");
            falta2 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o número de faltas do bimestre 3 : ");
            falta3 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o número de faltas do bimestre 4 : ");
            falta4 = int.Parse(Console.ReadLine());


            //média ponderada
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média ponderada é: " + media);

            //total de faltas
            totalFaltas = (falta1 + falta2 + falta3 + falta4);
            Console.WriteLine("Você faltou: " + totalFaltas + " vezes");

            // (MÉDIA)>= 7 (APROVADO)  ()< 7 && >5 (recuperação) ()< 5 REPROVADO
            // (FALTA) >= 50 = (REPROVADO) 
            
                       
            if(totalFaltas >= 50)
                 Console.WriteLine("Voce foi reprovado por falta, compareça mais no proximo semestre!");

            else   if (media >= 7)
            {
                 Console.WriteLine("Você esta Aprovado");
            }
            if (media > 5)
            {
                 Console.WriteLine("Você esta de Recuperação");
            }
            
            if (media < 5 )
            {
                 Console.WriteLine("Você esta Reprovado");
            }
                              
           
        }

    }
}
