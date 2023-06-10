using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwPatterns.Creacionales.Models
{
    public class Character
    {
        public string Name { get; private set; }
        public string Race { get; private set; }
        public string CharacterClass { get; private set; }

        public Character(string name, string race, string characterClass)
        {
            Name = name;
            Race = race;
            CharacterClass = characterClass;
            // Inicialización de otros atributos del personaje
        }
    }
}
