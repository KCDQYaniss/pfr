namespace EFT.Development;

public static class ProfileStorage
{
	[CompilerGenerated]
	private struct <LoadProfile>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string fileName; //Field offset: 0x20
		private string <resourcePath>5__2; //Field offset: 0x28
		private ResourceRequest <loadingFile>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string MAIN_PROFILE = "MainProfile"; //Field offset: 0x0
	public const string MAIN_PROFILE_IN_FOLDER = "LocalProfiles/MainProfile"; //Field offset: 0x0
	private static readonly List PossibleTypes; //Field offset: 0x0
	private static int _j; //Field offset: 0x8
	private static int _profilesLoaded; //Field offset: 0xC

	private static ProfileStorage() { }

	public static Task GenerateProfile(BotCreationData data) { }

	public static Task GenerateProfile(EPlayerSide side, DebugBotProfileChooser type) { }

	internal static Task GenerateProfile(EPlayerSide side, WildSpawnType wildSpawnType) { }

	public static DebugBotProfileChooser GetRnd() { }

	[AsyncStateMachine(typeof(<LoadProfile>d__7))]
	internal static Task LoadProfile(string fileName) { }

}

