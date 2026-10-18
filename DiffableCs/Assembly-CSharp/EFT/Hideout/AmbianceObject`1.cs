namespace EFT.Hideout;

public abstract class AmbianceObject`1 : SerializedMonoBehaviour, IAmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AmbianceObject <>4__this; //Field offset: 0x0
		public ELightStatus status; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private bool _isActive; //Field offset: 0x0
	[SerializeField]
	private EAreaType _areaType; //Field offset: 0x0
	[SerializeField]
	protected Dictionary Patterns; //Field offset: 0x0
	private Dictionary _defaultDelays; //Field offset: 0x0

	public override EAreaType AreaType
	{
		 get { } //Length: 4
	}

	protected AmbianceObject`1() { }

	public override EAreaType get_AreaType() { }

	protected override bool ImmediateInteraction(ELightStatus status) { }

	public override void Init(AreaTemplate areaTemplate) { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__8))]
	public override Task PerformInteraction(ELightStatus status) { }

}

