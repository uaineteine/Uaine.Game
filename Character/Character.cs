using Uaine.Objects.Primitives;
using Uaine.Users;

namespace Uaine.Game.Characters
{
    public class Character : User
    {
        public TextObject Description;
        public CharacterStats Stats;

        public Character(User charinfo, TextObject desc, CharacterStats stats) : 
            base(charinfo.Name, charinfo.Credentials.Password, charinfo.UserGroupID, charinfo.Rank, charinfo.ID)
        {
            this.Description = desc;
            this.Stats = stats;
        }
        public Character(User charinfo, CharacterStats stats) : 
            base(charinfo.Name, charinfo.Credentials.Password, charinfo.UserGroupID, charinfo.Rank, charinfo.ID)
        {
            this.Description = new TextObject("");
            this.Stats = stats;
        }
    }
}
