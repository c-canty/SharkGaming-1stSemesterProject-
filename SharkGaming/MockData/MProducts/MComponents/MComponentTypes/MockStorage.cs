using SharkGaming.Products.Components.ComponentTypes.Storage;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockStorage
    {
        public static List<StorageClass> _storage = new List<StorageClass>();

        public static List<StorageClass> GetMockStorage()
        {
            return _storage;
        }
    }
}
