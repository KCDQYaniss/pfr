namespace EFT;

public sealed class ProfileBan
{
	[CompilerGenerated]
	private struct <StartWaitingAsync>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfileBan <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string EXHIBITION_BLOCKED_MESSAGE = "Exhibition/BlockedMessage"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnBanExpired; //Field offset: 0x10
	public readonly EBanType Type; //Field offset: 0x18
	public readonly long ExpirationTime; //Field offset: 0x20
	private readonly CancellationTokenSource _cancellationTokenSource; //Field offset: 0x28
	private Task _waitingTask; //Field offset: 0x30

	public event Action OnBanExpired
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	[JsonIgnore]
	public DateTime BanUntil
	{
		 get { } //Length: 87
	}

	[JsonIgnore]
	public bool Expired
	{
		 get { } //Length: 108
	}

	[JsonIgnore]
	public TimeSpan TimeLeft
	{
		 get { } //Length: 286
	}

	public ProfileBan(ProfileBanDescriptor descriptor) { }

	public ProfileBan(EBanType type, long expirationTime) { }

	private ProfileBan() { }

	[CompilerGenerated]
	private void <StartWaitingAsync>b__19_0() { }

	[CompilerGenerated]
	public void add_OnBanExpired(Action value) { }

	public void Dispose() { }

	public DateTime get_BanUntil() { }

	public bool get_Expired() { }

	public TimeSpan get_TimeLeft() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	[CompilerGenerated]
	public void remove_OnBanExpired(Action value) { }

	private void StartWaiting() { }

	[AsyncStateMachine(typeof(<StartWaitingAsync>d__19))]
	private Task StartWaitingAsync() { }

}

