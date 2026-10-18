namespace EFT.Console.Core;

public struct CommandRegisterData
{
	public IConsoleCommand Command; //Field offset: 0x0
	public CompleteCallback Callback; //Field offset: 0x8

	public CommandRegisterData(IConsoleCommand command) { }

	public CommandRegisterData(IConsoleCommand command, CompleteCallback callback) { }

}

