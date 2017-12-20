using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    class MegaSena : JogoAbstrato
    {
        private List<Aposta> apostas;
        public MegaSena(List<Aposta> apostas)
        {
            this.apostas = apostas;
        }

        public override void conferirResultado()
        {
            int ganhadores = 0;
            // loop para verificar o número de acertos
            foreach (Aposta p in apostas)
            {
                for (int i = 0; i < p.getNumeros().Count; i++)
                {
                    if (numerosSorteados.Contains(p.getNumeros()[i]))
                    {
                        acertos.Add(p.getNumeros()[i]);
                    }
                }

                // apresentando os resultados
                if (acertos.Count == 6)
                {
                    Console.WriteLine("Aposta ganhadora id: " + p.getId());
                    Console.WriteLine("Tipo de prêmio: Sena");
                    Console.Write("Numeros apostados: ");
                    for (int i = 0; i < p.getNumeros().Count; i++)
                    {
                        Console.Write(p.getNumeros()[i] + "-");
                    }
                    Console.WriteLine("");
                    Console.Write("Data/hora: " + p.getDataHora());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    ganhadores++;
                }
                if (acertos.Count == 5)
                {
                    Console.WriteLine("Aposta ganhadora id: " + p.getId());
                    Console.WriteLine("Tipo de prêmio: Quina");
                    Console.Write("Numeros apostados: ");
                    for (int i = 0; i < p.getNumeros().Count; i++)
                    {
                        Console.Write(p.getNumeros()[i] + "-");
                    }
                    Console.WriteLine("");
                    Console.Write("Data/hora: " + p.getDataHora());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    ganhadores++;
                }
                if (acertos.Count == 4)
                {
                    Console.WriteLine("Aposta ganhadora id: " + p.getId());
                    Console.WriteLine("Tipo de prêmio: Quadra");
                    Console.Write("Numeros apostados: ");
                    for (int i = 0; i < p.getNumeros().Count; i++)
                    {
                        Console.Write(p.getNumeros()[i] + "-");
                    }
                    Console.WriteLine("");
                    Console.Write("Data/hora: " + p.getDataHora());
                    Console.WriteLine("");
                    Console.WriteLine("");
                    ganhadores++;
                }
                acertos.Clear();
            }
            if (ganhadores == 0)
                Console.WriteLine("Não há ganhadores");
        }

        public override void sortear()
        {
            ApoioSorteioAleatorio.sorteioAleatorio(this.numerosSorteados, 60, 6);
            // loop para apresentar o sorteio da mega-sena
            Console.Write("Numeros sorteados: ");
            for (int i = 0; i < numerosSorteados.Count; i++)
            {
                Console.Write(numerosSorteados[i] + "-");
            }
            Console.WriteLine("");
            Console.WriteLine("");
        }
    }
}
