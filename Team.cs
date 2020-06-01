using System;
using System.Collections.Generic;

namespace bank_heist
{
    public class Team
    {
        public List<TeamMember> newTeam = new List<TeamMember>();

        public void AddMember(TeamMember name)
        {
            newTeam.Add(name);
        }

        public int ShowMemberCount()
        {
            return newTeam.Count;
        }

        public void ShowTeam()
        {
            foreach (TeamMember member in newTeam)
            {
                Console.WriteLine(member);
            }
        }
        public int TotalSkillLevel()
        {
            int skillSum = 0;
            foreach (TeamMember member in newTeam)
            {
                skillSum = skillSum + member.MemberSkillLevel();
            }
            return skillSum;
        }
    }
}