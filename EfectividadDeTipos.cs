namespace Pokemon_Mine;

public class EfectividadDeTipos
{
    private Dictionary<string, Dictionary<string, double>> TablaDeEfectividad;

    public EfectividadDeTipos()
    {
        TablaDeEfectividad = new Dictionary<string, Dictionary<string, double>>
        {
            { "Fuego", new Dictionary<string, double> { { "Agua", 0.5 }, { "Planta", 2.0 }, { "Bicho", 2.0 } } },
            { "Agua", new Dictionary<string, double> { { "Fuego", 2.0 }, { "Planta", 0.5 } } },
            { "Planta", new Dictionary<string, double> { { "Fuego", 0.5 }, { "Agua", 2.0 } } },
            { "Psiquico", new Dictionary<string, double> { { "Bicho", 0.5 }, { "Lucha", 2.0 } } },
            { "Bicho", new Dictionary<string, double> { { "Psiquico", 2.0 }, { "Planta", 2.0 }, { "Fuego", 0.5 } } },
            { "Lucha", new Dictionary<string, double> { { "Psiquico", 0.5 } } },
        };
    }

    public int CalcularDaño(Ataques ataque, Pokemon atacante, Pokemon defensor)
    {
        double multiplicador = 1.0;
        if (TablaDeEfectividad.ContainsKey(ataque.Tipo) && TablaDeEfectividad[ataque.Tipo].ContainsKey(defensor.Tipo))
        {
            multiplicador = TablaDeEfectividad[ataque.Tipo][defensor.Tipo];       // Esta sintaxis de diccionarios la saque de Gepetudo
        }                                                                        // creo que es correcta.

        return (int)(ataque.Daño * multiplicador);
    }
}