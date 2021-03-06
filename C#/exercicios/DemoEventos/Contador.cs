using System;

namespace DemoEventos
{
    public class Contador
    {
        //                         referencia para método(suporta várias referencias)
        public event EventHandler LimiteAtingido;
        public int Valor {get; private set;}
        private int valorLimite;

        public Contador(int vl)
        {
            valorLimite = vl;
        }
        public void Incrementar()
        {
            Valor++;
            if (Valor == valorLimite)
            {
                if(LimiteAtingido != null)
                {
                    //executar o método
                    LimiteAtingido(this, EventArgs.Empty);
                }
            }
        }
    }
}