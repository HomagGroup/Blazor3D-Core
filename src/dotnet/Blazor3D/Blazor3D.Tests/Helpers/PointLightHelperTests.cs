using Blazor3D.Helpers;
using Blazor3D.Lights;

namespace Blazor3D.Tests.Helpers
{
    [TestClass]
    public class PointLightHelperTests
    {
        [TestMethod]
        public void DefaultConstuctorShouldCreateWithPredefinedValues()
        {
            var helper = new PointLightHelper();
            Assert.AreEqual("PointLightHelper", helper.Type);
            Assert.IsNotNull(helper.Light);
            Assert.IsNull(helper.Color);
            Assert.AreEqual(1, helper.SphereSize);
        }

        [TestMethod]
        public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
        {
            var light = new PointLight()
            {
                Color = "red"
            };

            var helper = new PointLightHelper(light, 2, "blue");
            Assert.AreEqual("PointLightHelper", helper.Type);
            Assert.IsNotNull(helper.Light);
            Assert.AreEqual("red", helper.Light.Color);
            Assert.AreEqual(2, helper.SphereSize);
            Assert.AreEqual("blue", helper.Color);
        }
    }
}
