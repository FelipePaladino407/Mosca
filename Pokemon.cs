namespace Pokemon_Mine;

public class Pokemon
{
    private string nombre;
    private int salud;
    private int saludMaxima;
    private string tipo;
    private List<Ataques> ataque;

    public Pokemon(string nombre, int salud, int saludMaxima, string tipo, List<Ataques> ataque)
    {
        this.nombre = nombre;
        this.salud = salud;
        this.tipo = tipo;
        this.ataque = ataque;
        this.saludMaxima = saludMaxima;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public int Salud
    {
        get => salud;
        set => salud = value;
    }

    public int SaludMaxima
    {
        get => saludMaxima;
        set => saludMaxima = value;
    }

    public string Tipo
    {
        get => tipo;
        set => tipo = value;
    }

    public List<Ataques> Ataques
    {
        get => ataque;
        set => ataque = value;
    }


    public void RecivirDaño(int Daño)
    {
        Salud -= Daño;
        if (Salud < 0)
        {
            Salud = 0;
        }
    }


    public bool SeHaDebilitado()
    {
        return Salud == 0;
    }

}