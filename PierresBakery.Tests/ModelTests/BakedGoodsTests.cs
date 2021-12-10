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
    public void PastryCost_ReturnsCostOfBreadWithStringAmountInput_10()
    {
      Assert.AreEqual(10, Bread.BreadCost("3"));
    }

  }
}