namespace Pokemon_Mine;

public class Pokedex
{
    private List<Pokemon> pokemonsDisponibles;

    public Pokedex()
    {
        pokemonsDisponibles = new List<Pokemon>
        {
            new Pokemon("Blastoise", 450, 450, "Agua", new List<Ataques>
                { new Ataques("Hidropulso", "Agua", 90, true), new Ataques("Burbuja", "Agua", 60, true) }), 
            
            new Pokemon("Greninja", 385, 385, "Agua", new List<Ataques>
                { new Ataques("Shuriken de agua", "Agua", 75, true)}), 
            
            




        };
        
    }
}