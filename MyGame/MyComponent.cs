using Xenko.Core;
using Xenko.Core.Mathematics;
using Xenko.Engine;

namespace MyGame
{
    [DataContract("MyComponent")]
    public class MyComponent: EntityComponent
    {
        public Int3 MyProp { get; set; }
    }
}
