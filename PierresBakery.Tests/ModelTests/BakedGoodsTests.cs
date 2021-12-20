using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BakedGoodsTests
  {
    
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread("1");
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry("1");
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
    [TestMethod]
    public void BreadCost_ReturnsIntWithStringInput_Int()
    {
      Assert.AreEqual(typeof(int), Bread.BreadCost("1").GetType());
    }

    [TestMethod]
    public void PastryCost_ReturnsIntWithStringInput_Int()
    {
      Assert.AreEqual(typeof(int), Pastry.PastryCost("1").GetType());
    }

    [TestMethod]
    public void BreadCost_ReturnsCostOfBreadWithStringAmountInputForOneLoafNoDiscount_int()
    {
      Bread newBread = new Bread("1");
      Assert.AreEqual(5, Bread.BreadCost(newBread.NumBread));
    }

    [TestMethod]
    public void PastryCost_ReturnsCostOfPastryWithStringAmountInputForOnePastryNoDiscount_int()
    {
      Pastry newPastry = new Pastry("1");
      Assert.AreEqual(2, Pastry.PastryCost(newPastry.NumPastry));
    }

    [TestMethod]
    public void BreadCost_ReturnsCostOfBreadWithStringAmountInputForMultipleLoavesIncludingDiscount_int()
    {
      Bread newBread = new Bread("3");
      Assert.AreEqual(10, Bread.BreadCost(newBread.NumBread));
    }

    [TestMethod]
    public void PastryCost_ReturnsCostOfPastryWithStringAmountInputForMultiplePastiesIncludingDiscount_int()
    {
      Pastry newPastry = new Pastry("4");
      Assert.AreEqual(7, Pastry.PastryCost(newPastry.NumPastry));
    }
  }
}