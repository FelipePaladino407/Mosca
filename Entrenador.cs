namespace Pokemon_Mine;
using System.Text;

public class Entrenador
{
    private string nombre;
    private List<Pokemon> pokemons;
    private Pokemon pokemonActivo;

    public Entrenador(string nombre, List<Pokemon> pokemons)
    {
        this.nombre = nombre;
        this.pokemons = pokemons;
        pokemonActivo = pokemons[0];  // El primer pokemon es el que queda activo por defecto.
    }

    public string Nombre
    {
        get => nombre;
        set => nombre = value;
    }

    public List<Pokemon> Pokemons
    {
        get => pokemons;
        set => pokemons = value;
    }

    public Pokemon PokemonActivo
    {
        get => pokemonActivo;
        set => pokemonActivo = value;
    }


    public string CambiarPokemon(Pokemon newPokemon)
    {
        PokemonActivo = newPokemon;

        return $"{this.Nombre} ha cambiado a {this.PokemonActivo} por {newPokemon}";  // No se si es correcta esa sintaxis.
    }


    public string ObtenerStatusPokemon()
    {
        StringBuilder statusBuilder = new StringBuilder();      // Es una clase que se usa para construir y manipular cadenas de texto de 
                                                               // de manera eficiente cuando se realizan muchas modificaciones (chatGPT).
        foreach (var pokemon in pokemons)
        {
            statusBuilder.AppendLine($"{pokemon.Nombre}: {pokemon.Salud}/{pokemon.SaludMaxima} HP (Horsepower)");
        }
        
        return statusBuilder.ToString();
    }


    public bool TienePokemonsRestantes()
    {
        return Pokemons.Any(p => !p.SeHaDebilitado());      // Esta sintaxis rara me la hizo Gepetudo al preguntarle sobre como mejorar el metodo.
    }
    
}