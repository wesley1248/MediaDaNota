using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaDaNota {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola,vamos, fazer a media das notas!");
            Console.WriteLine("Abaixo você ira digitar seu nome, a primeira, segunda e terceira nota.");
            DadosAluno dadosAluno = new DadosAluno();

            Console.WriteLine("Digite abaixo seus dados");
            Console.Write("Nome: ");
            dadosAluno.nome = Console.ReadLine();
            Console.Write("Primeira nota: ");
            dadosAluno.notaUm = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            dadosAluno.notaDois = double.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            dadosAluno.notaTres = double.Parse(Console.ReadLine());

            string situacao = Resultado.ResultadoA(dadosAluno.notaUm, dadosAluno.notaDois, dadosAluno.notaTres);
            double nota = Nota.NotaA(dadosAluno.notaUm, dadosAluno.notaDois, dadosAluno.notaTres);
            double contagem = Contagem.contagemA(dadosAluno.notaUm, dadosAluno.notaDois, dadosAluno.notaTres);

            switch (situacao)
            {
                case "APROVADO":
                    Console.WriteLine("ALUNO: " + dadosAluno.nome);
                    Console.WriteLine("SUA NOTA: " + nota.ToString("N1", CultureInfo.GetCultureInfo("pt-BR")));
                    Console.WriteLine("SITUAÇAO: " + situacao);
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                case "REPROVADO":
                    Console.WriteLine("ALUNO: " + dadosAluno.nome);
                    Console.WriteLine("SUA NOTA: " + nota.ToString("N1", CultureInfo.GetCultureInfo("pt-BR")));
                    Console.WriteLine("SITUAÇAO: " + situacao);
                    Console.WriteLine("Faltam " + contagem + " pontos para alcançar a media!.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}
