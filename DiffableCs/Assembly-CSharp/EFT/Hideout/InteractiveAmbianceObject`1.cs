namespace EFT.Hideout;

public class InteractiveAmbianceObject`1 : AmbianceObject, IInteractiveAmbianceObject
{
	[CompilerGenerated]
	private struct <Interact>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x0
		public InteractiveAmbianceObject <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PerformInteraction>d__24 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ELightStatus status; //Field offset: 0x0
		public InteractiveAmbianceObject <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private bool _immediateInteraction; //Field offset: 0x0
	private bool _firstCall; //Field offset: 0x0
	[CompilerGenerated]
	private ELightStatus <PreviousStatus>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private ELightStatus <CurrentStatus>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x0

	public private bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public ELightStatus CombinedStatus
	{
		 get { } //Length: 237
	}

	protected private ELightStatus CurrentStatus
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override bool Enabled
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	protected private ELightStatus PreviousStatus
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public InteractiveAmbianceObject`1() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	[CompilerGenerated]
	public bool get_Active() { }

	public ELightStatus get_CombinedStatus() { }

	[CompilerGenerated]
	protected ELightStatus get_CurrentStatus() { }

	[CompilerGenerated]
	public override bool get_Enabled() { }

	[CompilerGenerated]
	protected ELightStatus get_PreviousStatus() { }

	[AsyncStateMachine(typeof(<Interact>d__23))]
	protected void Interact() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__24))]
	public virtual Task PerformInteraction(ELightStatus status) { }

	[CompilerGenerated]
	private void set_Active(bool value) { }

	[CompilerGenerated]
	private void set_CurrentStatus(ELightStatus value) { }

	[CompilerGenerated]
	private void set_Enabled(bool value) { }

	[CompilerGenerated]
	private void set_PreviousStatus(ELightStatus value) { }

	public override void SetEnable(bool value) { }

}

