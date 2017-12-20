using System;
using System.Collections.Generic;

namespace Atividade
{
    class Aplicacao
    {
        static void Main(string[] args)
        {
            int numAposta = 0;
            int escolha = 0;
            int num = 0;
            Aposta aposta;
            List<Aposta> apostas = new List<Aposta>();
            List<int> numeros = new List<int>();

            Console.WriteLine("------Sistema de apostas da Mega-Sena------");
            Console.WriteLine("Opções de jogo:");
            Console.WriteLine("1 - aposta manual");
            Console.WriteLine("2 - aposta automática");
            Console.WriteLine("0 - sair e ver resultado");
            Console.WriteLine("Digite sua opção de jogo:");
            Console.WriteLine("");
            escolha = int.Parse(Console.ReadLine());

            while (escolha == 1 || escolha == 2)
            {

                if (escolha == 1)
                {
                    Console.WriteLine("Aposta manual");

                    aposta = new Aposta(numAposta++);

                    for (int i = 0; i < 6; i++)
                    {
                        Console.WriteLine(i + 1 + "º número:");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        if (num > 0 && num < 61)
                        {
                            if (!numeros.Contains(num))
                            {
                                numeros.Add(num);
                            }
                            else
                            {
                                Console.WriteLine("Número repetido");
                                i--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido");
                            i--;
                        }
                    }
                    aposta.setNumeros(numeros);
                }
                else
                {
                    aposta = new Aposta(numAposta++);
                    ApoioSorteioAleatorio.sorteioAleatorio(aposta.getNumeros(), 60, 6);
                    Console.WriteLine("Aposta automática");
                }
                apostas.Add(aposta);
                Console.WriteLine("Sucesso!");
                Console.WriteLine("Digite sua opção de jogo:");
                escolha = int.Parse(Console.ReadLine());
            }
            if (escolha == 0 && apostas.Count > 0)
            {
                Console.Clear();
                JogoAbstrato megasena = new MegaSena(apostas);
                CaixaEconomica sorteio = new CaixaEconomica(megasena);
                sorteio.realizarSorteio();
                sorteio.exibirResultado();
            }

        }
    }
}
