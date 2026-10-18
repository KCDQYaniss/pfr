namespace EFT.Interactive.Commands;

public sealed class DestroyCommand : Command
{
	private readonly LampLights _lampLights; //Field offset: 0x18
	private readonly LampSound _lampSound; //Field offset: 0x20
	private readonly LampController _controller; //Field offset: 0x28

	public DestroyCommand(LampLights lampLights, LampSound lampSound, LampController controller) { }

	public void Execute(float time) { }

	private void PlayDestroyEffect() { }

}

