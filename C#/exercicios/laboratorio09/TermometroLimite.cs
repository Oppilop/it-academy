namespace laboratorio09
{
    //classe termometrolimite está herdando a classe termometro
    public class TermometroLimite : Termometro
    {
        //declaração de um delegate para eventos
        public delegate void MeuDelegate(string msg);

        //declaração de membro de evento
        public event MeuDelegate LimiteSuperiorEvent;
        //criado o evento para a Temperatura Normal
        public event MeuDelegate TemperaturaNormalEvent;
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

        
        //método auxiliar para disparar o evento
        private void OnLimiteSuperiorEvent()
        {
            //verifica se a temperatura ultrapassou o limite e 
            //verifica se o evento já foi disparado, para não disparar continuamente???????
            if ((this.Temperatura > limiteSuperior) && (!disparadoEventoLimiteSuperior))
                //verifica se há tratador
                if (LimiteSuperiorEvent != null)
                {
                    LimiteSuperiorEvent($"Atenção: temperatura {this.Temperatura - limiteSuperior} acima do limite!!!");
                    disparadoEventoLimiteSuperior = true;
                }
            
        }
        //criado o método para temperatura normal
        private void OnTemperaturaNormalizada()
        {
            if ((this.Temperatura <= LimiteSuperior) && (disparadoEventoLimiteSuperior))
            {
                if (TemperaturaNormalEvent != null)
                {
                    TemperaturaNormalEvent($"Atenção: Temperatura {this.Temperatura} graus normalizada!!!");
                    disparadoEventoLimiteSuperior = false;
                }
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
            // if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            // {
            //     disparadoEventoLimiteSuperior = false;
            // }
            OnTemperaturaNormalizada();
        }

        public override void Diminuir(double quantia)
        {
            base.Diminuir(quantia);
            // if((this.Temperatura <= limiteSuperior) && (disparadoEventoLimiteSuperior))
            // {
            //     disparadoEventoLimiteSuperior = false;
            // }
            OnTemperaturaNormalizada();
        }
    }
}
