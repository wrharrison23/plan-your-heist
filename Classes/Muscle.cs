using System;
using System.Collections.Generic;

namespace plan_your_heist
{
  public class Muscle : IRobber
  {
    public string Name {get; set;}

    public int SkillLevel {get; set;}

    public int PercentageCut {get; set;}
    public string Specialty { get; } = "Muscle";
    public void PerformSkill(Bank bank)
    {
      bank.SecurityGuardScore -= SkillLevel;
      Console.WriteLine($"{Name} is fighting the security guard. Decreased security {SkillLevel} points");
      if(bank.SecurityGuardScore <= 0)
      {
        Console.WriteLine($"{Name} has knocked out the securiity guard!");
      }
    }

  }
}