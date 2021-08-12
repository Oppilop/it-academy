namespace laboratorio09
{
    //classe termometrolimite está herdando a classe termometro
    public class TermometroLimite : Termometro
    {
        //declaração de membro de evento
        public event MeuDelegate LimiteSuperiorEvent;
        //atributos
        private double limiteSuperior;
        private bool disparadoEventoLimiteSuperior;

        //construtor
        public TermometroLimite(double ls)
        {
            limiteSuperior = ls;
            disparadoEventoLimiteSuperior = false;
        }

        //propriedade de leitura e escrita do limite superior
        public double LimiteSuperior
        {
            get { return limiteSuperior; }
            set { limiteSuperior = value; }
        }

        //declaração de um delegate para eventos
        public delegate void MeuDelegate(string msg);

        //método auxiliar para disparar o evento
        private void OnLimiteSuperiorEvent()
        {
            //verifica se a temperatura ultrapassou o limite e 
            //verifica se o evento já foi disparado, para não disparar continuamente???????
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
                //verifica se há tratador
                if (LimiteSuperiorEvent != null)
                {
                    LimiteSuperiorEvent("Atenção: temperatura acima do limite!!!");
                    disparadoEventoLimiteSuperior = true;
                }
        }

        public override void Aumentar()
        {
            base.Aumentar();
            OnLimiteSuperiorEvent();
        }

        public override void Aumentar(double quantia)
        {
            base.Aumentar(quantia);
            OnLimiteSuperiorEvent();
        }

        public override void Diminuir()
        {
            base.Diminuir();
            if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            }
        }

        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                disparadoEventoLimiteSuperior = false;
            }
        }
    }
}
