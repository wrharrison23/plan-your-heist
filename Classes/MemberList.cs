
using System;
using System.Collections.Generic;

namespace plan_your_heist
{
  public class MemberList {
    public List<Member> Members { get; set; } = new List< Member>();
    public int difficulty = 100;
    public void AddMember(Member member)
    {
      try
      {
        Members.Add(member);
      }
      catch (ArgumentException)
      {
        Console.WriteLine("A member with the same name has already been added.");
      }
    }

     public Member GetByName(string name)
    {
      Member memberResult = null;
      foreach (Member member in Members)
      {
        if (member.Name == name)
        {
          memberResult = member;
        }
        else
        {
          memberResult = null;
        }
        return memberResult;
      }
      return memberResult;
    }

  public void GetAllMembers()
    {
        foreach(Member member in Members)
        {
        Console.WriteLine($"{member.Name}");
        Console.WriteLine($"Skill Level: {member.SkillLevel}");
        Console.WriteLine($"Courage Factor: {member.CourageFactor}");
      }
  }

  public bool CheckSuccess()
  {
      Random random = new Random();
      int luckValue = random.Next(-10, 10);
      difficulty += luckValue;
      int totalSkill = 0;
      foreach (Member member in Members)
      {
        totalSkill += member.SkillLevel;
      }
      Console.WriteLine($"Team's total skill: {totalSkill}");
      Console.WriteLine($"Bank's difficulty: {difficulty}");
      if (totalSkill >= difficulty)
        {
          return true;
        }
        else
        {
          return false;
        }
    }
  }

  
}