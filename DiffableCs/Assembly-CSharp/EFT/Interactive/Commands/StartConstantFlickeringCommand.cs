namespace EFT.Interactive.Commands;

public sealed class StartConstantFlickeringCommand : Command
{
	private readonly LampLights _lampLights; //Field offset: 0x18

	public StartConstantFlickeringCommand(LampLights lampLights) { }

	public void Execute() { }

}

