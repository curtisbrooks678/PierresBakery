using System;
using PierresBakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("\nWelcome to Pierre's Bakery!\n");
    Console.WriteLine("We serve bread and pastries. Here are the prices/deals for each: \nLoaf of Bread: Buy 2, get 1 free. A single loaf is $5 (save every third loaf you buy) \nPastries: Buy 1 for $2, 3 for $5, 4 for $7, 5 for $9, or 6 for $10 \nBuy as many as you like of each and you'll receive the best possible discount for your purchase based on the deals above.\n");
    Console.WriteLine("How many loaves of bread would you like?");
    string breadOrderInput = Console.ReadLine();
    if (breadOrderInput == "2")
    {
      breadOrderInput = "3";
      Console.WriteLine("You've ordered 2 loaves of bread. We've added an extra loaf to your order because of our \"Buy 2, get 1 free\" deal.");
    }
    Console.WriteLine("How many pastries would you like?");
    string pastryOrderInput = Console.ReadLine();
    int breadOrderTotal = Bread.BreadCost(breadOrderInput);
    int pastryOrderTotal = Pastry.PastryCost(pastryOrderInput);
    int orderTotal = breadOrderTotal + pastryOrderTotal;
    Console.WriteLine("You've ordered " + breadOrderInput + " loaves of bread and " + pastryOrderInput + " pastries.");
    Console.WriteLine("Here is the total cost for your order: $" + orderTotal + ".00\nThanks for shopping with us! Come again!");
  }
}