using SwPatterns.Creacionales.Interfaces;
using SwPatterns.Creacionales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwPatterns.Creacionales.Constructor
{
    public class OtherCharacterBuilder : ICharacterBuilder
    {
        private string name;
        private string race;
        private string characterClass;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetRace(string race)
        {
            this.race = race;
        }

        public void SetCharacterClass(string characterClass)
        {
            this.characterClass = characterClass;
        }

        public Character Build()
        {
            return new Character(name, race, characterClass);
        }

        public void Clear()
        {
            this.name = string.Empty;
            this.race = string.Empty;
            this.characterClass = string.Empty;
        }
    }
}
