using Hanori.Service.EFCore;
using System.Diagnostics;

namespace Hanori.Service.UuitTest.EFCore
{
    [TestClass]
    public class EFCoreUnitTest : EFCoreManager<TestSample>
    {
        [TestMethod]
        public void TestSyncAsync()
        {
            //TestMethod();

            //TestMethodAsync().Wait();

            // Arrange
            var entity = new TestSample();

            // Act
            RemoveAll();
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
            var entity = new TestSample();

            // Act
            CreateOne(entity);
        }

        public async Task TestCRUDAsync()
        {
            var entity = new TestSample();

            await CreateOneAsync(entity);
        }
    }
}