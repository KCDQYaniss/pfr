namespace EFT.Animations;

public interface IEffector
{

	public string DebugOutput() { }

	public void Initialize(PlayerSpring playerSpring) { }

	public void Process(float deltaTime) { }

}

