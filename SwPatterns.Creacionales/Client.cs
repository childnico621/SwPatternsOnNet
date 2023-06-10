using SwPatterns.Creacionales.Constructor;
using SwPatterns.Creacionales.Director;
using SwPatterns.Creacionales.Models;

namespace SwPatterns.Creacionales
{
    public static class Client
    {
        public static void Run()
        {
            CharacterBuilder builder = new CharacterBuilder();
            CharacterDirector director = new CharacterDirector(builder);

            director.CreateBasicCharacter("Little John");
            Character basicCharacter = builder.Build();
                       

            director.CreateAdvancedCharacter("Fat Joe");            
            Character complexCharacter = builder.Build();


            Console.WriteLine($"Nombre: {basicCharacter.Name}");
            Console.WriteLine($"Tipo: {basicCharacter.Race}");
            Console.WriteLine($"Clase: {basicCharacter.CharacterClass}");

            Console.WriteLine($"\n ------------------------------------------------ \n");
            Console.WriteLine($"Nombre: {complexCharacter.Name}");
            Console.WriteLine($"Tipo: {complexCharacter.Race}");
            Console.WriteLine($"Clase: {complexCharacter.CharacterClass}");
        }

    }
}
