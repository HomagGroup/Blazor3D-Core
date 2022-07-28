using Blazor3D.Settings;

namespace Blazor3D.Tests.Settings
{
    [TestClass]
    public class AnimateRotationSettingsTests
    {
        [TestMethod]
        public void DefaultConstuctorShouldCreateWithPredefinedValues()
        {
            var settings = new AnimateRotationSettings();

            Assert.AreEqual(false, settings.AnimateRotation);
            Assert.AreEqual(0.1, settings.ThetaX);
            Assert.AreEqual(0.1, settings.ThetaY);
            Assert.AreEqual(0.1, settings.ThetaZ);
            Assert.AreEqual(5, settings.Radius);
           
        }

        [TestMethod]
        public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
        {
            var settings = new AnimateRotationSettings(true, 1, 1, 1, 1);

            Assert.AreEqual(true, settings.AnimateRotation);
            Assert.AreEqual(1, settings.ThetaX);
            Assert.AreEqual(1, settings.ThetaY);
            Assert.AreEqual(1, settings.ThetaZ);
            Assert.AreEqual(1, settings.Radius);
        }
    }
}
