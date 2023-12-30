namespace HomagGroup.Blazor3D.Tests.Helpers;

[TestClass]
public class GridHelperTests
{
    [TestMethod]
    public void DefaultConstuctorShouldCreateWithPredefinedValues()
    {
        var grid = new GridHelper();
        Assert.AreEqual("GridHelper", grid.Type);
        Assert.AreEqual(10, grid.Size);
        Assert.AreEqual(10, grid.Divisions);
        Assert.AreEqual("0x444444", grid.ColorCenterLine);
        Assert.AreEqual("0x888888", grid.ColorGrid);
    }

    [TestMethod]
    public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
    {
        var grid = new GridHelper(6, 6, "red", "orange");
        Assert.AreEqual("GridHelper", grid.Type);
        Assert.AreEqual(6, grid.Size);
        Assert.AreEqual(6, grid.Divisions);
        Assert.AreEqual("red", grid.ColorCenterLine);
        Assert.AreEqual("orange", grid.ColorGrid);
    }
}