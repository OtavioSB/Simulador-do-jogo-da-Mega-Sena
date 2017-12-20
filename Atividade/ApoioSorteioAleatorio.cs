using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    class ApoioSorteioAleatorio
    {
        protected static Random gerador;
        public static void sorteioAleatorio(List<int> numeros, int limite, int loop)
        {
            gerador = new Random();
            int num;
            for (int i = 0; i < loop; i++)
            {
                num = gerador.Next(1, limite + 1);
                if (!numeros.Contains(num))
                {
                    numeros.Add(num);
                }
                else
                {
                    i--;
                }
            }
        }
    }
}
