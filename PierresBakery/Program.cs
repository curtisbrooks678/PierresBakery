using System;
using PierresBakery.Models;

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Welcome to Pierre's Bakery! \n We serve bread and pastries. Here are the prices/deals for each: \n Loaf of Bread: Buy 2, get 1 free. A single loaf is $5 (save every third loaf you buy) \n Pastries: Buy 1 for $2, 3 for $5, 4 for $7, 5 for $9, or 6 for $10 \n Buy as many as you like of each and you'll receive the best possible discount for your purchase based on the deals above. \n");
    Console.WriteLine("How many loaves of bread would you like?");
    string breadOrderInput = Console.ReadLine();
    Console.WriteLine("How many pastries would you like?");
    string pastryOrderInput = Console.ReadLine();
    int breadOrderTotal = Bread.BreadCost(breadOrderInput);
    int pastryOrderTotal = Pastry.PastryCost(pastryOrderInput);
    int orderTotal = breadOrderTotal + pastryOrderTotal;
    Console.WriteLine("Here is the total cost for your order: $" + orderTotal + ".\n Thanks for shopping with us! Come again!");
  }
}