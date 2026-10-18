namespace EFT.Console.Commands;

[ConsoleCommand("ui.waitscreen", null, null, null, new IL2CPP_TYPE_STRING[] {})]
public class WaitScreenCommand : AsyncCommand
{
	private EEftScreenType _eftScreenType; //Field offset: 0x18

	public virtual object[] ArgumentsValue
	{
		 get { } //Length: 188
	}

	public WaitScreenCommand(EEftScreenType eftScreenType) { }

	public virtual Task Execute() { }

	public virtual object[] get_ArgumentsValue() { }

}

