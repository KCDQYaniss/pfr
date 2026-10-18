namespace EFT.GameTriggers;

public struct MultipleInteractionTriggerRequirement : ITriggerRequirement, IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8
		public static Func <>9__7_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Start>b__7_0(string elem) { }

		internal int <Start>b__7_1(string element) { }

	}

	[CompilerGenerated]
	private struct <OnEventTrigger>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public MultipleInteractionTriggerRequirement <>4__this; //Field offset: 0x28
		public TriggerEvent triggerEvent; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private string _triggerId; //Field offset: 0x0
	[SerializeField]
	private string[] _requirementInteractionIds; //Field offset: 0x8
	[SerializeField]
	private bool _isAutoTurnOff; //Field offset: 0x10
	[SerializeField]
	private int _secondsTurnOffDelay; //Field offset: 0x14
	private List _satisfiedInteractionIds; //Field offset: 0x18
	private List _unsub; //Field offset: 0x20
	private int[] _requirementInteractionIdsHashes; //Field offset: 0x28

	public override bool Check(InventoryController inventoryController, SkillManager skillManager) { }

	private bool Check() { }

	public override void Dispose() { }

	private bool IsSatisfied(string id) { }

	[AsyncStateMachine(typeof(<OnEventTrigger>d__8))]
	private void OnEventTrigger(TriggerEvent triggerEvent) { }

	public override void Start() { }

	public override bool TryRedeem(InventoryController inventoryController, SkillManager skillManager) { }

}

