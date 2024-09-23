namespace Pokemon_Mine;

public class Batalla
{
    private Entrenador _entrenador1;
    private Entrenador _entrenador2;
    private TurnManager _turnManager;
    private EfectividadDeTipos _efectividadDeTipos;


    public Batalla(Entrenador entrenador1, Entrenador entrenador2)
    {
        _entrenador1 = entrenador1;
        _entrenador2 = entrenador2;
        _turnManager = new TurnManager(entrenador1, entrenador2);
        _efectividadDeTipos = new EfectividadDeTipos();
    }

    public void Atacar(Ataques ataque)
    {
        Entrenador atacante = _turnManager.ObtenerEntrenadorActual();
        Entrenador defensor = _turnManager.ObtenerEntrenadorRival();

        int daño = _efectividadDeTipos.CalcularDaño(ataque, atacante.PokemonActivo, defensor.PokemonActivo);
        defensor.PokemonActivo.RecivirDaño(daño);
        
        Console.WriteLine($"{defensor.PokemonActivo} ha recibido {daño} puntos de daño de {atacante.PokemonActivo}.");

        if (defensor.PokemonActivo.SeHaDebilitado())
        {
            Console.WriteLine($"{defensor.PokemonActivo} se ha debilitado y ya no puede continuar.");
        }

        if (!defensor.TienePokemonsRestantes())
        {
            Console.WriteLine($"A {defensor.Nombre} no le quedan mas Pokemon, eso quiere decir que {atacante.Nombre} ha ganado la batalla!");
            return;
        }
        
        _turnManager.SiguienteTurno();
    }
    
    




}