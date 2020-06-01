using System;

namespace bank_heist
{
    public class TeamMember
    {
        private string _name;

        private int _skillLevel;

        private double _courageFactor;

        public TeamMember(string name, int skill, double courage)
        {
            this._name = name;
            this._skillLevel = skill;
            this._courageFactor = courage;
        }

        public override string ToString()
        {
            return $@"
            Name: {_name}
            Skill Level: {_skillLevel}
            Courage Factor: {_courageFactor}
            ";
        }

        public int MemberSkillLevel()
        {
            return _skillLevel;
        }
    }
}