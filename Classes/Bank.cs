using System;
using System.Collections.Generic;
using System.Reflection;

namespace plan_your_heist
{
  public class Bank
  {
    public int CashOnHand { get; set; }
    public int AlarmScore { get; set; }
    public int VaultScore { get; set; }
    public int SecurityGuardScore { get; set; }
    public bool IsSecure(Bank bank)
    {
      if(bank.CashOnHand >= 0 | bank.AlarmScore >=0 | bank.VaultScore >= 0| bank.SecurityGuardScore >= 0)
      {
        return true;
      } else {
        return false;
      }
    }
    public void CompareScores()
    {
      string mostSecure;
      string leastSecure;

      if(AlarmScore > VaultScore && AlarmScore > SecurityGuardScore)
      {
        mostSecure = "Alarm";
      } else if (VaultScore > AlarmScore && VaultScore > SecurityGuardScore)
      {
        mostSecure = "Vault";
      } else {
        mostSecure = "Security Guard";
      }

      if(AlarmScore < VaultScore && AlarmScore < SecurityGuardScore)
      {
        leastSecure = "Alarm";
      } else if (VaultScore < AlarmScore && VaultScore < SecurityGuardScore)
      {
        leastSecure = "Vault";
      } else {
        leastSecure = "Security Guard";
      }

      Console.WriteLine($@"
      Most Secure: {mostSecure}
      Least secure: {leastSecure}");
    }
  }
}