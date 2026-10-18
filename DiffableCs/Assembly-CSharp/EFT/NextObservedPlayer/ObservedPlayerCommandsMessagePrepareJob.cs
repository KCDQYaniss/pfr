namespace EFT.NextObservedPlayer;

public struct ObservedPlayerCommandsMessagePrepareJob : IJob
{
	public static int ByteMessageCount; //Field offset: 0x0
	public static readonly ArraySegment[] ByteMessages; //Field offset: 0x8
	private static NetworkReader _networkReader; //Field offset: 0x10
	private static readonly int[] _observedKeyToIndexMap; //Field offset: 0x18
	public static int ObservedPlayerCount; //Field offset: 0x20
	public static int[] ObservedPlayers; //Field offset: 0x28
	public static readonly ObservedPlayerCommandsMessage[,] Messages; //Field offset: 0x30
	public static readonly bool[,] MessageExists; //Field offset: 0x38

	private static ObservedPlayerCommandsMessagePrepareJob() { }

	public override void Execute() { }

}

