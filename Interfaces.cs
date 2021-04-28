using System;
using System.Collections.Generic;

namespace plan_your_heist
{
  public interface IRobber
  {
    string Name { get; }
    int SkillLevel { get; }
    int PercentageCut { get; }
    string Specialty { get; }
    void PerformSkill(Bank bank);
  }
}