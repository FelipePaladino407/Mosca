namespace Pokemon_Mine;

public class Ataques
{
    private string nombre;
    private string tipo;
    private int daño;
    private bool isSpecial;

    public Ataques(string nombre, string tipo, int daño, bool isSpecial = false)
    {
        this.daño = daño;
        this.nombre = nombre;
        this.tipo = tipo;
        this.isSpecial = isSpecial;
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public string Tipo
    {
        get => tipo;
        set => tipo = value;
    }

    public int Daño
    {
        get => daño;
        set => daño = value;
    }

    public bool IsSpecial
    {
        get => isSpecial;
        set => isSpecial = value;
    }
}