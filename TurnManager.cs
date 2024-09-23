namespace Pokemon_Mine;

public class TurnManager
{
    private Entrenador _entrenadorActual;
    private Entrenador _entrenador1;
    private Entrenador _entrenador2;
    private int _contadorTurno = 1;

    public TurnManager(Entrenador entrenador1, Entrenador entrenador2)
    {
        _entrenador2 = entrenador2;
        _entrenador1 = entrenador1;
        _entrenadorActual = entrenador1;
        
    }


    public Entrenador ObtenerEntrenadorActual()
    {
        return _entrenadorActual;
    }
    

    public Entrenador ObtenerEntrenadorRival()
    {
        return _entrenadorActual == _entrenador1 ? _entrenador2 : _entrenador1;
    }
    // Si _entrenadorActual es _entrenador1, significa que el turno pertenece a este ultimo, ergo el rival sera el _entrenador2.
    // Si el actual es el _entrenador2, entonces el rival sera el _entrenador1.
    

    public void SiguienteTurno()
    {
        _entrenadorActual = ObtenerEntrenadorRival();
        _contadorTurno++;
    }


    public bool PuedeUsarAtaqueEspecial()
    {
        return _contadorTurno % 2 == 0;              // Si contadorTurno es par, devuelve True, osea se puede usar un ataque especial
    }                                               // si es false, osea es impar, no puede.

}