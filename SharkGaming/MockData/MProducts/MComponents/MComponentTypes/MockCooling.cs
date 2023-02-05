using SharkGaming.Products.Components.ComponentTypes.Cooling;

namespace SharkGaming.MockData.MProducts.MComponents.MComponentTypes
{
    public class MockCooling
    {
        public static List<CoolingClass> _cooling = new List<CoolingClass>();

        public static List<CoolingClass> GetMockCooling()
        {
            return _cooling;
        }
    }
}
