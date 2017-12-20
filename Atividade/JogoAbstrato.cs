using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    public abstract class JogoAbstrato
    {
        protected List<int> numerosSorteados;
        protected List<int> acertos;

        public JogoAbstrato()
        {
            this.numerosSorteados = new List<int>();
            this.acertos = new List<int>();
        }

        public abstract void sortear();
        public abstract void conferirResultado();
    }
}
