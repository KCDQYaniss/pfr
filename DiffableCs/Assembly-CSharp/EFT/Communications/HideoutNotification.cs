namespace EFT.Communications;

public abstract class HideoutNotification : InteractiveNotification
{
	[CompilerGenerated]
	private struct <Show>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutNotification <>4__this; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[JsonProperty("alert")]
	public bool Alert; //Field offset: 0x40
	[JsonProperty("eventType")]
	public EHideoutNotificationType EventType; //Field offset: 0x44
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x48

	[JsonIgnore]
	public private bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public virtual ENotificationIconType Icon
	{
		 get { } //Length: 18
	}

	protected HideoutNotification(EHideoutNotificationType eventType, Action onClick) { }

	[CompilerGenerated]
	public bool get_Active() { }

	public virtual ENotificationIconType get_Icon() { }

	public void Hide() { }

	public void Init(EHideoutNotificationType eventType, Action onClick) { }

	public virtual void OnClick() { }

	[CompilerGenerated]
	private void set_Active(bool value) { }

	[AsyncStateMachine(typeof(<Show>d__11))]
	public void Show() { }

}

