using SharkGaming.Products.Components;
using SharkGaming.Products.Components.ComponentTypes.Motherboard;

namespace SharkGaming.MockData
{
    public class MockItems
    {
        public static List<ComponentsClass> components = new List<ComponentsClass>()
        {
            //new ComponentsClass("Asus 570XX", 12999, true, false, "Very gut")
        };

        public static List <ComponentsClass> GetComponentsClasses()
        {
            return components;
        }

        

    }
}
