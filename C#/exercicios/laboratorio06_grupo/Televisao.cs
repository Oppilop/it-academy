public class Televisao : IEstadoBinario
{
    private bool ligado;
    private int volume;]

    EstadoBinario IEstadoBinario.Estado => throw new System.NotImplementedException();

    void IEstadoBinario.Desligar()
    {
        throw new System.NotImplementedException();
    }

    void IEstadoBinario.Ligar()
    {
        throw new System.NotImplementedException();
    }

    public EstadoBinario Estado
    {
        get 
        {
            if(ligado) {
                return EstadoBinario.Ligado;
            }
            else return EstadoBinario.Desligado;
        }    
    }
}

public class Canal
{
        
}
