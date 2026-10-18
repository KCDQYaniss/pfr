namespace EFT;

internal sealed class AnticheatValidationOperation : IBattlEyeClientRequestHandler
{
	[CompilerGenerated]
	private struct <RunValidation>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AnticheatValidationOperation <>4__this; //Field offset: 0x20
		public LogDelegate logDelegate; //Field offset: 0x28
		public IsLogLevelEnabledDelegate isLogLevelEnabledDelegate; //Field offset: 0x30
		private int <framesLeft>5__2; //Field offset: 0x38
		private YieldAwaiter <>u__1; //Field offset: 0x3C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int FRAMES_COUNT = 10; //Field offset: 0x0
	private Nullable _restartReason; //Field offset: 0x10
	[CompilerGenerated]
	private bool <Succeed>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private string <Error>k__BackingField; //Field offset: 0x20

	public private string Error
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool Succeed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AnticheatValidationOperation() { }

	private override void BattlEye.IBattlEyeClientRequestHandler.OnRequestRestart(ERestartReason reason) { }

	private override void BattlEye.IBattlEyeClientRequestHandler.OnSendPacket(byte[] bePacket, int packetOffset, int packetLength) { }

	[CompilerGenerated]
	public string get_Error() { }

	[CompilerGenerated]
	public bool get_Succeed() { }

	[AsyncStateMachine(typeof(<RunValidation>d__10))]
	public Task RunValidation(LogDelegate logDelegate, IsLogLevelEnabledDelegate isLogLevelEnabledDelegate) { }

	[CompilerGenerated]
	private void set_Error(string value) { }

	[CompilerGenerated]
	private void set_Succeed(bool value) { }

}

