namespace EFT.NextObservedPlayer;

public static class ObservedPlayerCommandsMessagePool
{
	private const int POOL_SIZE = 256; //Field offset: 0x0
	private static readonly Pool _pool; //Field offset: 0x0

	private static ObservedPlayerCommandsMessagePool() { }

	public static ObservedPlayerCommandsMessage GetInstance() { }

	public static void ReturnInstance(ObservedPlayerCommandsMessage instance) { }

}

