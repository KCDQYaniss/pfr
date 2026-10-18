namespace EFT.NextObservedPlayer;

public class ReceiveMessageStatistics
{
	private static TimeSpanStatistics _snapshotStatistics; //Field offset: 0x0
	private static TimeSpanStatistics _commandsStatistics; //Field offset: 0x8
	private static TimeSpanStatistics _playerStatistics; //Field offset: 0x10
	private static TimeSpanStatistics _worldStatistics; //Field offset: 0x18
	private static TimeSpanStatistics _updateStatistics; //Field offset: 0x20
	private static TimeSpanStatistics _lateUpdateStatistics; //Field offset: 0x28
	private static double _lateUpdateFinishedMaximumTime; //Field offset: 0x30
	private static double _lastCommitTime; //Field offset: 0x38

	private static ReceiveMessagesLogger Logger
	{
		private get { } //Length: 311
	}

	public ReceiveMessageStatistics() { }

	private static ReceiveMessagesLogger get_Logger() { }

	public static void Initialization() { }

	public static void OnCommands() { }

	public static void OnLateUpdate() { }

	public static void OnLateUpdateFinished(double time) { }

	public static void OnPlayer() { }

	public static void OnSnapshot() { }

	public static void OnUpdate() { }

	public static void OnWorld() { }

	public static void Update() { }

}

