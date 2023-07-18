using Hanori.Service.EFCore;
using System.Diagnostics;

namespace Hanori.Service.UuitTest.EFCore
{
    [TestClass]
    public class EFCoreUnitTest : EFCoreManager<Sample>
    {
        [TestMethod]
        public void TestSyncAsync()
        {
            //TestMethod();

            //TestMethodAsync().Wait();
        }

        public void TestMethod()
        {
            for(int i = 0; i < 5000; i++)
            {
                TestCRUD();
            }
        }

        
        public async Task TestMethodAsync()
        {
            for (int i = 0; i < 5000; i++)
            {
                await TestCRUDAsync();
            }
        }
        
        public void TestCRUD()
        {
            // Arrange
            var entity = new Sample();

            // Act
            CreateOne(entity);
        }

        public async Task TestCRUDAsync()
        {
            var entity = new Sample();

            await CreateOneAsync(entity);
        }
    }
}