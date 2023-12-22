using HomagGroup.Blazor3D.Helpers;
using HomagGroup.Blazor3D.Maths;

namespace HomagGroup.Blazor3D.Tests.Helpers;

[TestClass]
public class PlaneHelperTests
{
    [TestMethod]
    public void DefaultConstuctorShouldCreateWithPredefinedValues()
    {
            var plane = new PlaneHelper();
            Assert.AreEqual("PlaneHelper", plane.Type);
            Assert.IsNotNull(plane.Plane);
            Assert.IsNotNull(plane.Plane.Normal);
            Assert.AreEqual(1, plane.Plane.Normal.X);
            Assert.AreEqual(0, plane.Plane.Normal.Y);
            Assert.AreEqual(0, plane.Plane.Normal.Z);
            Assert.AreEqual(0, plane.Plane.Constant);
            Assert.AreEqual(1, plane.Size);
            Assert.AreEqual("0xffff00", plane.Color);

        }

    [TestMethod]
    public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
    {
            var plane = new PlaneHelper(new Plane(new Vector3(1, 1, 1), 1));
            Assert.AreEqual("PlaneHelper", plane.Type);
            Assert.IsNotNull(plane.Plane);
            Assert.IsNotNull(plane.Plane.Normal);
            Assert.AreEqual(1, plane.Plane.Normal.X);
            Assert.AreEqual(1, plane.Plane.Normal.Y);
            Assert.AreEqual(1, plane.Plane.Normal.Z);
            Assert.AreEqual(1, plane.Plane.Constant);
            Assert.AreEqual(1, plane.Size);
            Assert.AreEqual("0xffff00", plane.Color);
        }
}