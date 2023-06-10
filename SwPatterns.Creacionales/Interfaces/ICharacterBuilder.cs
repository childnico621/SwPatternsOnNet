namespace SwPatterns.Creacionales.Interfaces
{
    public interface ICharacterBuilder
    {        
        void SetCharacterClass(string characterClass);
        void SetName(string name);
        void SetRace(string race);
        void Clear();
    }
}