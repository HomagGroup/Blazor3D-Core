using HomagGroup.Blazor3D.Helpers;

namespace HomagGroup.Blazor3D.Tests.Helpers;

[TestClass]
public class PolarGridHelperTests
{
    [TestMethod]
    public void DefaultConstuctorShouldCreateWithPredefinedValues()
    {
            var grid = new PolarGridHelper();
            Assert.AreEqual("PolarGridHelper", grid.Type);
            Assert.AreEqual(10, grid.Radius);
            Assert.AreEqual(16, grid.Radials);
            Assert.AreEqual(8, grid.Circles);
            Assert.AreEqual(64, grid.Divisions);
            Assert.AreEqual("0x444444", grid.Color1);
            Assert.AreEqual("0x888888", grid.Color2);

        }

    [TestMethod]
    public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
    {
            var grid = new PolarGridHelper(2, 2, 6, 32, "red", "orange");
            Assert.AreEqual("PolarGridHelper", grid.Type);
            Assert.AreEqual(2, grid.Radius);
            Assert.AreEqual(2, grid.Radials);
            Assert.AreEqual(6, grid.Circles);
            Assert.AreEqual(32, grid.Divisions);
            Assert.AreEqual("red", grid.Color1);
            Assert.AreEqual("orange", grid.Color2);
        }
}