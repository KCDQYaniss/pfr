namespace EFT.NextObservedPlayer;

public static class IkBatchScheduler
{
	private static int _frame; //Field offset: 0x0
	private static int _lastExecutedFullBodyCount; //Field offset: 0x4
	private static int _limbExecutedFrame; //Field offset: 0x8
	private static int _pelvisFootExecutedFrame; //Field offset: 0xC
	private static int _spineExecutedFrame; //Field offset: 0x10

	private static IkBatchScheduler() { }

	public static void BeginFrame() { }

	public static void ExecuteFullBodyStage() { }

	public static void ExecuteObservedLimbStage() { }

	public static void ExecutePelvisFootReactionStage() { }

	public static void ExecuteSpineReactionStage() { }

	public static bool RegisterFullBody(FullBodyBipedIK fbbik, out int batchIndex) { }

	public static bool RegisterFullBody(FullBodyBipedIK fbbik, in ObservedPlayerBodyReactionFrameInput reactionInput, out int batchIndex) { }

	public static void RegisterPelvisFootReaction(in ObservedPlayerBodyReactionFrameInput reactionInput) { }

	public static void RegisterSpineReaction(in ObservedPlayerBodyReactionFrameInput reactionInput) { }

}

