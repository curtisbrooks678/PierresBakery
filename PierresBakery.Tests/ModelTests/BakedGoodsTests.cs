using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BakedGoodsTests
  {
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
    public void BreadCost_ReturnsCostOfBreadWithStringAmountInput_int()
    {
      Assert.AreEqual(10, Bread.BreadCost("3"));
      Assert.AreEqual(20, Bread.BreadCost("6"));
    }

    [TestMethod]
    public void PastryCost_ReturnsCostOfPastryWithStringAmountInput_Int()
    {
      Assert.AreEqual(2, Pastry.PastryCost("1"));
      Assert.AreEqual(7, Pastry.PastryCost("4"));
    }
  }
}