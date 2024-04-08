namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
        if (nota <= 0) nota = 0;
        if (nota >= 10) nota = 10;
    }

    public int Nota { get;}

    public static Avaliacao Parse(string texto) 
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }

}
