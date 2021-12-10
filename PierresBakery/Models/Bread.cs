using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int BreadCost(string input)
    {
      int totalCost = 0; 
      int intInput = int.Parse(input); 
      totalCost = intInput * 5; 
      if (intInput % 3 == 0) 
      {
        int multOf3 = intInput / 3; 
        totalCost -= (multOf3 * 5); 
      }
      return totalCost; 
    }
  }
}

