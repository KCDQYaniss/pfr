namespace EFT.NextObservedPlayer;

public struct ObservedPlayerCommandsProcessJob : IJobParallelFor
{
	private const int BREADTH_SIZE = 256; //Field offset: 0x0
	private const int DEPTH_SIZE = 1024; //Field offset: 0x0
	public static int Count; //Field offset: 0x0
	public static bool[,] Exists; //Field offset: 0x8
	public static ObservedPlayerCommandsMessage[,] Messages; //Field offset: 0x10
	public static ObservedPlayerModel[] Models; //Field offset: 0x18

	private static ObservedPlayerCommandsProcessJob() { }

	public override void Execute(int i) { }

}

