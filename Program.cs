using System;
using System.Collections.Generic;
using System.Linq;

namespace plan_your_heist
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Plan Your Heist!");
      
      Hacker Wes = new Hacker()
      {
        Name = "Wes",
        SkillLevel = 80,
        PercentageCut = 25
      };
      Hacker Thomas = new Hacker()
      {
        Name = "Thomas",
        SkillLevel = 70,
        PercentageCut = 25
      };

      Muscle Tommy = new Muscle()
      {
        Name = "Tommy",
        SkillLevel = 75,
        PercentageCut = 25
      };

      LockSpecialist Jordan = new LockSpecialist()
      {
        Name = "Jordan",
        SkillLevel = 70,
        PercentageCut = 25
      };
      Muscle Courtney = new Muscle()
      {
        Name = "Courtney",
        SkillLevel = 60,
        PercentageCut = 25
      };
      List<IRobber> rolodex = new List<IRobber>() { Wes, Thomas, Tommy, Jordan, Courtney };

      Random random = new Random();

      Bank targetBank = new Bank()
      {
        AlarmScore = random.Next(0, 100),
        VaultScore = random.Next(0, 100),
        SecurityGuardScore = random.Next(0, 100),
        CashOnHand = random.Next(50000, 1000000),
      };
      List<int> security = new List<int>(){
        targetBank.AlarmScore,
        targetBank.VaultScore,
        targetBank.SecurityGuardScore
      };
      security.OrderBy(i => i);

      int hackerCount = 0;
      int muscleCount = 0;
      int lockCount = 0;
      foreach(IRobber robber in rolodex)
      {
        if(robber is Hacker)
        {
          hackerCount += 1;
        } else if (robber is Muscle)
        {
          muscleCount += 1;
        } else 
        {
          lockCount += 1;
        }
      }
      Console.WriteLine($"Your crew currently consists of {hackerCount} hacker, {muscleCount} muscle, and {lockCount} lock specialists");

      bool addMore = true;
      while (addMore == true)
      {
        Console.Write($"Add a new member! Enter their name or leave empty to continue.  ");
        string newName = Console.ReadLine();
        if (string.IsNullOrEmpty(newName))
        {
          addMore = false;
          break;
        }

        Console.WriteLine($@"Pick a specialty for {newName}:
      Hacker (Disables alarms) 
      Muscle (Disarms guards)
      Lock Specialist (cracks vault)");
        string newSpecialty = Console.ReadLine().ToLower();

        Console.Write($"What's {newName}'s skill level (1-100)? ");
        int newSkill = int.Parse(Console.ReadLine());

        Console.Write($"What percentage of the money will {newName} receive? ");
        int newCut = int.Parse(Console.ReadLine());

        if (newSpecialty == "hacker")
        {
          Hacker newGuy = new Hacker()
          {
            Name = newName,
            SkillLevel = newSkill,
            PercentageCut = newCut
          };
          rolodex.Add(newGuy);
        }
        else if (newSpecialty == "muscle")
        {
          Muscle newGuy = new Muscle()
          {
            Name = newName,
            SkillLevel = newSkill,
            PercentageCut = newCut
          };
          rolodex.Add(newGuy);
        }
        else
        {
          LockSpecialist newGuy = new LockSpecialist()
          {
            Name = newName,
            SkillLevel = newSkill,
            PercentageCut = newCut
          };
          rolodex.Add(newGuy);
        }
      }
      

      targetBank.CompareScores();

      foreach (var robber in rolodex)
      {
        Console.WriteLine($@"
        {robber.Name}
        {robber.Specialty}
        Skill Level: {robber.SkillLevel}
        Cut: {robber.PercentageCut}%
        Index: {rolodex.IndexOf(robber)}");
      }

      List < IRobber > crew = new List<IRobber>();
      List<int> selectedIndices = new List<int>();
      bool addToCrew = true;
      while (addToCrew)
      {
        Console.WriteLine("Pick a crew member to include in the heist! Type their index to select or leave empty to continue: ");

        string selectedMember = Console.ReadLine();

        if (string.IsNullOrEmpty(selectedMember))
        {
          addToCrew = false;
          break;
        }

        crew.Add(rolodex[int.Parse(selectedMember)]);
        int cutLeft = 100;

        foreach (var robber in crew)
        {
          cutLeft -= robber.PercentageCut;
        }

        foreach (var robber in rolodex)
        {
          if (!crew.Contains(robber))
          {
            if (cutLeft - robber.PercentageCut >= 0)
            {
              Console.WriteLine($@"
        {robber.Name}
        {robber.Specialty}
        Skill Level: {robber.SkillLevel}
        Cut: {robber.PercentageCut}%
        Index: {rolodex.IndexOf(robber)}");
            }
          }
        }
      }
    }
    }
}
