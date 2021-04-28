using System;
using System.Collections.Generic;

namespace plan_your_heist
{
  public class Member {
    public string Name { get; set; }
    public int SkillLevel { get; set; }
    public double CourageFactor { get; set; }

    // public void PromptMemberEntry() {
    //   string name = "";
    //   while (name == "")
    //   {
    //     Console.Write("Enter a member name: ");
    //     name = Console.ReadLine();
    //   }

    //   int skill = 0;
    //   while (skill == 0)
    //   {
    //     Console.Write($"Enter {name}'s skill level: ");
    //     skill = int.Parse(Console.ReadLine());
    //   }

    //   double courage = 0;
    //   while (courage == 0)
    //   {
    //     Console.Write($"Enter {name}'s courage factor: ");
    //     courage = double.Parse(Console.ReadLine());
    //   }

    //   Member newMember = new Member()
    //   {
    //     Name = name,
    //     SkillLevel = skill,
    //     CourageFactor = courage
    //   };
    //   MemberList members = new MemberList();

    //   members.AddMember(newMember);
    //   // Member enteredMember = members.GetByName(newMember.Name);
    //   // Console.WriteLine($@"
    //   // Member name: {enteredMember.Name}
    //   // Member Skill: {enteredMember.SkillLevel}
    //   // Member Courage: {enteredMember.CourageFactor}");
    // }
  }

  
  
}