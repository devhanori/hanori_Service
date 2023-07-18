using Hanori.Service.EFCore;

namespace Hanori.Service.UuitTest.EFCore
{
    [TestClass]
    public class EFCoreUnitTest : EFCoreManager<Sample>
    {
        [TestMethod]
        public void TestCreateOne()
        {
            // Arrange
            var entity = new Sample();

            // Act
            CreateOne(entity);

            // Assert
            var result = ReadOne(entity.Id); 
            Assert.IsNotNull(result);
        }
    }
}