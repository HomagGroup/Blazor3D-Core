using HomagGroup.Blazor3D.Helpers;

namespace HomagGroup.Blazor3D.Tests.Helpers;

[TestClass]
public class AxesHelperTests
{
    [TestMethod]
    public void DefaultConstuctorShouldCreateWithPredefinedValues()
    {
            var helper = new AxesHelper();
            Assert.AreEqual("AxesHelper", helper.Type);
            Assert.AreEqual(1, helper.Size);
        }

    [TestMethod]
    public void ConstuctorWithParamsShouldCreateWithSpecifiedValues()
    {
            var helper = new AxesHelper(5);
            Assert.AreEqual("AxesHelper", helper.Type);
            Assert.AreEqual(5, helper.Size);
        }
}