//Type is in global namespace

public class BotNightVisionData : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public TaskCompletionSource completion; //Field offset: 0x10

		public <>c__DisplayClass22_0() { }

		internal void <ThrowItem>b__0(IResult arg) { }

	}

	[CompilerGenerated]
	private struct <Activate>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BotNightVisionData <>4__this; //Field offset: 0x28
		private CompoundItem <headwear>5__2; //Field offset: 0x30
		private IEnumerable <nightVision>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ClearPlaceAtSecureContainer>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Item item; //Field offset: 0x20
		public BotNightVisionData <>4__this; //Field offset: 0x28
		private KeyValuePair[] <>7__wrap1; //Field offset: 0x30
		private int <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float CHECK_PERIOD_SEC = 60; //Field offset: 0x0
	public NightVisionComponent NightVisionItem; //Field offset: 0x18
	public Item TradableItem; //Field offset: 0x20
	private bool _nightVisionAtPocket; //Field offset: 0x28
	private float _nextTimeCheck; //Field offset: 0x2C
	private Slot _slotHeadwear; //Field offset: 0x30
	private bool _stopTryingMove; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HaveNightVision>k__BackingField; //Field offset: 0x39
	[CompilerGenerated]
	private bool <UsingNow>k__BackingField; //Field offset: 0x3A

	public private bool HaveNightVision
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool UsingNow
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotNightVisionData(BotOwner owner) { }

	[AsyncStateMachine(typeof(<Activate>d__16))]
	public void Activate() { }

	private void CheckWhatIWant() { }

	[AsyncStateMachine(typeof(<ClearPlaceAtSecureContainer>d__21))]
	private Task ClearPlaceAtSecureContainer(Item item) { }

	[CompilerGenerated]
	public bool get_HaveNightVision() { }

	[CompilerGenerated]
	public bool get_UsingNow() { }

	public void ManualUpdate() { }

	private bool MoveItems(Item item, EquipmentSlot slot) { }

	private void MoveToHeadAndToggleOn() { }

	private void MoveToHeadPocket() { }

	[CompilerGenerated]
	private void set_HaveNightVision(bool value) { }

	[CompilerGenerated]
	private void set_UsingNow(bool value) { }

	private Task ThrowItem(Item item) { }

	private void ToggleOffIfNeed() { }

	private void ToggleOnIfNeed() { }

	public float UpdateVision(float distVision) { }

	private void WearToHead() { }

}

