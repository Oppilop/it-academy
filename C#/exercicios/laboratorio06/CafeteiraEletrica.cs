public class CafeteiraEletrica : IEstadoBinario
{
    private bool ligado = false;
    
    public void Desligar()
    {
        ligado = false;
    }

    public void Ligar()
    {
        ligado = true;
    }

    public EstadoBinario Estado
    {
        get
        {
            if (ligado) return EstadoBinario.Ligado;
            else return EstadoBinario.Desligado;
        }
    }

}