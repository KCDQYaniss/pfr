namespace EFT.Hideout;

public sealed class BonusesPanel : AbstractPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__12_6; //Field offset: 0x8
		public static Func <>9__12_3; //Field offset: 0x10
		public static Func <>9__12_4; //Field offset: 0x18
		public static Func <>9__12_5; //Field offset: 0x20
		public static Func <>9__12_2; //Field offset: 0x28
		public static Func <>9__12_0; //Field offset: 0x30
		public static Func <>9__12_1; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <ShowContents>b__12_0(Bonus x) { }

		internal bool <ShowContents>b__12_1(Bonus x) { }

		internal bool <ShowContents>b__12_2(Bonus v) { }

		internal bool <ShowContents>b__12_3(Improvement v) { }

		internal Bonus[] <ShowContents>b__12_4(Improvement v) { }

		internal bool <ShowContents>b__12_5(Bonus b) { }

		internal bool <ShowContents>b__12_6(Bonus b) { }

	}

	[CompilerGenerated]
	private struct <Show>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BonusesPanel <>4__this; //Field offset: 0x20
		public RelatedData relatedData; //Field offset: 0x28
		public Stage stage; //Field offset: 0x30
		public ELevelType levelType; //Field offset: 0x38
		public AreaData areaData; //Field offset: 0x40
		public InventoryController inventoryController; //Field offset: 0x48
		public IEftSession session; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BonusesPanel <>4__this; //Field offset: 0x20
		private List <positiveBonuses>5__2; //Field offset: 0x28
		private List <negativeBonuses>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string CURRENT_POSITIVE_BONUSES_TEXT = "CURRENT BONUSES:"; //Field offset: 0x0
	private const string FUTURE_POSITIVE_BONUSES_TEXT = "FUTURE BONUSES:"; //Field offset: 0x0
	private const string CURRENT_NEGATIVE_BONUSES_TEXT = "CURRENT NEGATIV BONUSES:"; //Field offset: 0x0
	private const string FUTURE_NEGATIVE_BONUSES_TEXT = "FUTURE NEGATIV BONUSES:"; //Field offset: 0x0
	private static readonly IReadOnlyDictionary POSITIVE_BONUSES_TEXT; //Field offset: 0x0
	private static readonly IReadOnlyDictionary NEGATIVE_BONUSES_TEXT; //Field offset: 0x8
	[SerializeField]
	private GroupBonusPanel _positiveBonusesPanel; //Field offset: 0xA8
	[SerializeField]
	private GroupBonusPanel _negativeBonusesPanel; //Field offset: 0xB0
	[SerializeField]
	private HoverTooltipArea _infoButtonPositiveBonuses; //Field offset: 0xB8
	[SerializeField]
	private HoverTooltipArea _infoButtonNegativeBonuses; //Field offset: 0xC0

	private static BonusesPanel() { }

	public BonusesPanel() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session) { }

	[CompilerGenerated]
	private void <Show>b__10_0() { }

	[CompilerGenerated]
	private void <Show>b__10_1() { }

	private void OnBonusChanged(bool added, EBonusType type) { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<Show>d__10))]
	public virtual Task Show(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session) { }

	[AsyncStateMachine(typeof(<ShowContents>d__12))]
	public virtual Task ShowContents() { }

	private void ShowInfoButton(bool hasPositiveBonus, bool hasNegativeBonus) { }

}

