using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Atividade
{
    class Aposta
    {
        private int id;
        private DateTime dt;
        private String data, hora;
        private List<int> numeros;

        public Aposta(int id)
        {
            this.numeros = new List<int>();
            this.dt = DateTime.Now;
            this.id = id;
        }

        public int getId()
        {
            return id;
        }

        public String getDataHora()
        {
            this.data = dt.ToString();
            return data + " " + hora;
        }

        public List<int> getNumeros()
        {
            return numeros;
        }

        public void setNumeros(List<int> numeros)
        {
            this.numeros = numeros;
        }
    }
}
