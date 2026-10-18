namespace EFT.Interactive.Commands;

public sealed class SmartEnableCommand : Command
{
	private readonly LampController _lampController; //Field offset: 0x18

	public SmartEnableCommand(LampController lampController) { }

	public void Execute() { }

}

