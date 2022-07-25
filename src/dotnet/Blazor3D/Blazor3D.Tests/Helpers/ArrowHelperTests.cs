using Blazor3D.Helpers;
using Blazor3D.Maths;

namespace Blazor3D.Tests.Helpers
{
    [TestClass]
    public class ArrowHelperTests
    {
        [TestMethod]
        public void DefaultConstuctorShouldCreateWithPredefinedValues()
        {
            var arrow = new ArrowHelper();
            Assert.AreEqual("ArrowHelper", arrow.Type);
            Assert.AreEqual(0, arrow.Dir.X);
            Assert.AreEqual(0, arrow.Dir.Y);
            Assert.AreEqual(1, arrow.Dir.Z);
            Assert.AreEqual(0, arrow.Origin.X);
            Assert.AreEqual(0, arrow.Origin.Y);
            Assert.AreEqual(0, arrow.Origin.Z);
            Assert.AreEqual(1, arrow.Length);
            Assert.AreEqual("0xffff00", arrow.Color);
            Assert.AreEqual(0.2, arrow.HeadLength);
            Assert.AreEqual(0.2*0.2, arrow.HeadWidth);
        }

        [TestMethod]
        public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
        {
            var arrow = new ArrowHelper(
                dir: new Vector3(3, 3, 3),
                origin: new Vector3(3,3,3),
                length: 5,
                color: "red",
                headLength: 2,
                headWidth: 4);
            Assert.AreEqual("ArrowHelper", arrow.Type);
            Assert.AreEqual(3, arrow.Dir.X);
            Assert.AreEqual(3, arrow.Dir.Y);
            Assert.AreEqual(3, arrow.Dir.Z);
            Assert.AreEqual(3, arrow.Origin.X);
            Assert.AreEqual(3, arrow.Origin.Y);
            Assert.AreEqual(3, arrow.Origin.Z);
            Assert.AreEqual(5, arrow.Length);
            Assert.AreEqual("red", arrow.Color);
            Assert.AreEqual(2, arrow.HeadLength);
            Assert.AreEqual(4, arrow.HeadWidth);
        }
    }
}
