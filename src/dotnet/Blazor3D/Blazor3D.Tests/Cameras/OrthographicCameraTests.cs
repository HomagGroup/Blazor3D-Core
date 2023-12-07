using HomagGroup.Blazor3D.Cameras;

namespace HomagGroup.Blazor3D.Tests.Cameras
{
    [TestClass]
    public class OrthographicCameraTests
    {
        [TestMethod]
        public void DefaultConstuctorShouldCreateWithPredefinedValues()
        {
            var camera = new OrthographicCamera();
            Assert.AreEqual("OrthographicCamera", camera.Type);
            Assert.AreEqual(0.1, camera.Near);
            Assert.AreEqual(2000, camera.Far);
            Assert.AreEqual(-1, camera.Left);
            Assert.AreEqual(1, camera.Right);
            Assert.AreEqual(1, camera.Top);
            Assert.AreEqual(-1, camera.Bottom);
            Assert.AreEqual(1, camera.Zoom);
            Assert.IsNotNull(camera.AnimateRotationSettings);
            Assert.IsNotNull(camera.LookAt);
            Assert.IsNotNull(camera.Up);
        }

        [TestMethod]
        public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
        {
            var camera = new OrthographicCamera(left: -2, right: 2, top: 2, bottom: -2, near: 0, far: 100, zoom: 0.5);
            Assert.AreEqual("OrthographicCamera", camera.Type);
            Assert.AreEqual(0, camera.Near);
            Assert.AreEqual(100, camera.Far);
            Assert.AreEqual(-2, camera.Left);
            Assert.AreEqual(2, camera.Right);
            Assert.AreEqual(2, camera.Top);
            Assert.AreEqual(-2, camera.Bottom);
            Assert.AreEqual(0.5, camera.Zoom);
        }
    }
}