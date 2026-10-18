//Type is in global namespace

public class PlayerVoiceLoader
{
	[CompilerGenerated]
	private struct <BringVoice>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerVoiceLoader <>4__this; //Field offset: 0x20
		public string voiceName; //Field offset: 0x28
		public EPhraseTrigger trigger; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InstantiateSingleton>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadVoiceInternal>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerVoiceLoader <>4__this; //Field offset: 0x20
		public string name; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TakeVoice>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public PlayerVoiceLoader <>4__this; //Field offset: 0x20
		public string voiceName; //Field offset: 0x28
		public EPhraseTrigger trigger; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Dictionary _voices; //Field offset: 0x10
	private readonly Dictionary _loadingVoices; //Field offset: 0x18
	private readonly List _token; //Field offset: 0x20
	private readonly object _loadLock; //Field offset: 0x28
	private IEasyAssets _easyAssets; //Field offset: 0x30

	public PlayerVoiceLoader() { }

	[AsyncStateMachine(typeof(<BringVoice>d__10))]
	private Task BringVoice(string voiceName, EPhraseTrigger trigger) { }

	private void Init() { }

	[AsyncStateMachine(typeof(<InstantiateSingleton>d__0))]
	public static Task InstantiateSingleton() { }

	public Task LoadVoice(string name) { }

	[AsyncStateMachine(typeof(<LoadVoiceInternal>d__8))]
	private Task LoadVoiceInternal(string name) { }

	[AsyncStateMachine(typeof(<TakeVoice>d__9))]
	public Task TakeVoice(string voiceName, EPhraseTrigger trigger = 28) { }

	public void UnloadVoices() { }

}

