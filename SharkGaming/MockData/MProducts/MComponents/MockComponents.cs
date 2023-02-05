using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Storage.Case;

namespace SharkGaming.MockData.Products.Components
{
    public class MockComponents
    {
        public static List<ComponentsClass> _components = new List<ComponentsClass>();

        public static List<ComponentsClass> GetMockComponentsClass()
        {
            return _components;
        }
    }
}
