using SwPatterns.Creacionales.Interfaces;
using SwPatterns.Creacionales.Interfaces;
using SwPatterns.Creacionales.Models;

namespace SwPatterns.Creacionales.Constructor
{
    public class CharacterBuilder : ICharacterBuilder
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
            var character = new Character(name, race, characterClass);
            this.Clear();
            return character;
        }

        public void Clear()
        {
            this.name = string.Empty;
            this.race = string.Empty;
            this.characterClass = string.Empty;
        }
    }
}
