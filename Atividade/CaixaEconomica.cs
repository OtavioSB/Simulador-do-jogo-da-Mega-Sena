using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    class CaixaEconomica
    {
        private JogoAbstrato jogo;

        public CaixaEconomica(JogoAbstrato jogo)
        {
            this.jogo = jogo;
        }

        public void realizarSorteio()
        {
            jogo.sortear();
        }

        public void exibirResultado()
        {
            jogo.conferirResultado();
        }

        public void setJogo(JogoAbstrato jogo)
        {
            this.jogo = jogo;
        }
    }
}
