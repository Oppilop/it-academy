using System;
public class Pessoa : IComparable<Pessoa>
{ 
    private string meuNome; 
    private int minhaIdade; 
    private bool comparador = true;
    public Pessoa(string n, int i, bool c = true)
    {
        comparador = c;
        meuNome = n; 
        minhaIdade = i; 
    } 
    public string Nome
    { 
        get{ return meuNome; } 
    } 
    public int Idade
    {
         get{ return minhaIdade; } 
         set{ minhaIdade = value; } 
    }

    //método da interface Icomparable
    public int CompareTo(Pessoa outro)
    { 
        if (comparador)
        {
            return minhaIdade.CompareTo(outro.minhaIdade);
        } 
        else 
        {
            return meuNome.CompareTo(outro.meuNome);
        }
    }
}