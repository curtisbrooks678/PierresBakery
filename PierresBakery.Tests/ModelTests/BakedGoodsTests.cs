using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;

namespace PierresBakery.Tests 
{
  [TestClass]
  public class BakedGoodsTests
  {
    [TestMethod]
    public void BreadCost_ReturnsIntWithStringInput_0()
    {
      Assert.AreEqual(0, Bread.BreadCost("1"));
    }

    [TestMethod]
    public void PastryCost_ReturnsIntWithStringInput_0()
    {
      Assert.AreEqual(0, Pastry.PastryCost("1"));
    }
  }
}