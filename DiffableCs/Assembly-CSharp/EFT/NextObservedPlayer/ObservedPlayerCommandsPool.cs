namespace EFT.NextObservedPlayer;

public static class ObservedPlayerCommandsPool
{
	private static Dictionary _commandsPool; //Field offset: 0x0
	private static bool _poolInited; //Field offset: 0x8

	public static void ClearPool() { }

	public static T GetCommand(CommandMessageType commandType) { }

	public static ICommandMessage GetCommand(CommandMessageType commandType) { }

	private static ObjectPool GetPool(CommandMessageType commandType) { }

	private static void InitializePool() { }

	public static void ReturnCommand(ICommandMessage commandMessage) { }

}

