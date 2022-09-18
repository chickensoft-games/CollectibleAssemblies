using Godot;
using Moq;

namespace CollectibleAssemblies
{

  public interface IMyObject { }

  public partial class Main : Node2D
  {
    public override void _Ready()
    {
      Mock<IMyObject> mock = new();
      _ = mock.Object;
      GD.Print("You will get an error on the line above.");
    }
  }
}
