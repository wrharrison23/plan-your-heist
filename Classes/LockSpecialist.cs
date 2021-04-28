using System;
using System.Collections.Generic;

namespace plan_your_heist
{
  public class LockSpecialist : IRobber
  {
    public string Name {get; set;}

    public int SkillLevel {get; set;}

    public int PercentageCut {get; set;}
    public string Specialty { get; } = "Lock Specialist";
    public void PerformSkill(Bank bank)
    {
      bank.VaultScore -= SkillLevel;
      Console.WriteLine($"{Name} is picking the vault lock. Decreased security {SkillLevel} points");
      if(bank.VaultScore <= 0)
      {
        Console.WriteLine($"{Name} has opened the vault!!");
      }
    }

  }
}