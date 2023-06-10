using SwPatterns.Creacionales.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwPatterns.Creacionales.Director
{
    public class CharacterDirector
    {
        private ICharacterBuilder builder;

        public CharacterDirector(ICharacterBuilder builder)
        {
            this.builder = builder;
        }

        public void CreateBasicCharacter(string name)
        {
            builder.SetName(name);
            builder.SetCharacterClass("Fiction");
            builder.SetRace("Junior");

        }

        public void CreateAdvancedCharacter(string name)
        {
            builder.SetName(name);            
        }
    }
}
