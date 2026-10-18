namespace EFT.NextObservedPlayer;

public struct ObservedPlayerChangeModelJob : IJobParallelFor
{
	public static int ObservedPlayerCount; //Field offset: 0x0
	public static int[] ObservedPlayers; //Field offset: 0x8
	public static ObservedPlayerModel[] ObservedPlayerModels; //Field offset: 0x10
	public static int CommandsMessageCount; //Field offset: 0x18
	public static ObservedPlayerCommandsMessage[,] CommandsMessages; //Field offset: 0x20
	public static bool[,] CommandsMessageExists; //Field offset: 0x28

	private static ObservedPlayerChangeModelJob() { }

	public override void Execute(int observedPlayerIndex) { }

}

