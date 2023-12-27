using Uaine.Objects.Primitives;
using Uaine.Users;

namespace Uaine.Game.Characters
{
    public class Character : User
    {
        public TextObject Description;
        public CharacterStats Stats;
        public Treasury playerMoney;

        public Character(User charinfo, TextObject desc, CharacterStats stats, Treasury plmoney) : 
            base(charinfo.Name, charinfo.Credentials.Password, charinfo.UserGroupID, charinfo.Rank, charinfo.ID)
        {
            this.Description = desc;
            this.Stats = stats;
            this.playerMoney = plmoney;
        }
        public Character(User charinfo, CharacterStats stats, Treasury plmoney) : 
            base(charinfo.Name, charinfo.Credentials.Password, charinfo.UserGroupID, charinfo.Rank, charinfo.ID)
        {
            this.Description = new TextObject("");
            this.Stats = stats;
            this.playerMoney = plmoney;
        }
    }
}
