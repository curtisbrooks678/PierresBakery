using System;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public static Dictionary<int, int> pastryPrices = new Dictionary<int, int>()
    {
      {0, 0}, {1, 2}, {2, 4}, {3, 5}, {4, 7}, {5, 9}, {6, 10}
    };
    public static int PastryCost(string input)
    {
      int totalCost = 0; 
      int dividedBy = 0;
      int intInput = int.Parse(input);
      if (intInput < 6)
      {
        totalCost = pastryPrices[intInput];
      }
      else if (intInput >= 6 && intInput % 6 == 0)
      {
        dividedBy = intInput / 6;
        totalCost = dividedBy * pastryPrices[6];
      } else if (intInput > 6 && intInput % 6 == 1)
      {
        dividedBy = (intInput - 1) / 6;
        totalCost = (dividedBy * pastryPrices[6]) + pastryPrices[1];
      }
      else if (intInput > 6 && intInput % 6 == 2)
      {
        dividedBy = (intInput - 2) / 6;
        totalCost = (dividedBy * pastryPrices[6]) + pastryPrices[2];
      }
      else if (intInput > 6 && intInput % 6 == 3)
      {
        dividedBy = (intInput - 3) / 6;
        totalCost = (dividedBy * pastryPrices[6]) + pastryPrices[3];
      }
      else if (intInput > 6 && intInput % 6 == 4)
      {
        dividedBy = (intInput - 4) / 6;
        totalCost = (dividedBy * pastryPrices[6]) + pastryPrices[4];
      }
      else if (intInput > 6 && intInput % 6 == 5)
      {
        dividedBy = (intInput - 5) / 6;
        totalCost = (dividedBy * pastryPrices[6]) + pastryPrices[5];
      }
      return totalCost;
    }
  }
}

