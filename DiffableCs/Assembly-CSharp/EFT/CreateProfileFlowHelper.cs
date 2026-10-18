namespace EFT;

public static class CreateProfileFlowHelper
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Action onValidated; //Field offset: 0x10
		public Action onValidationFailed; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <ValidateNickname>b__0(Result status) { }

	}

	[CompilerGenerated]
	private struct <LoadDefaultProfiles>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private Profile <bearProfile>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadProfile>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string profileName; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	internal struct DefaultProfiles
	{
		public readonly Profile Bear; //Field offset: 0x0
		public readonly Profile Usec; //Field offset: 0x8

		public DefaultProfiles(Profile bear, Profile usec) { }

	}

	private const string DEFAULT_BEAR_PROFILE = "DefaultBearProfile"; //Field offset: 0x0
	private const string DEFAULT_USEC_PROFILE = "DefaultUsecProfile"; //Field offset: 0x0

	[AsyncStateMachine(typeof(<LoadDefaultProfiles>d__3))]
	public static Task LoadDefaultProfiles() { }

	[AsyncStateMachine(typeof(<LoadProfile>d__5))]
	private static Task LoadProfile(string profileName) { }

	public static void ValidateNickname(IClientSession session, string nickname, Action onValidated, Action onValidationFailed = null) { }

}

