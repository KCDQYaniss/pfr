namespace EFT.Hideout;

public sealed class GroupBonusPanel : AbstractPanel
{
	[CompilerGenerated]
	private struct <LoadIconTexture>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GroupBonusPanel <>4__this; //Field offset: 0x20
		public string icon; //Field offset: 0x28
		public BonusPanel view; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GroupBonusPanel <>4__this; //Field offset: 0x20
		public IReadOnlyDictionary localizationTexts; //Field offset: 0x28
		public AreaData areaData; //Field offset: 0x30
		public RelatedBonuses relatedBonuses; //Field offset: 0x38
		public ELevelType levelType; //Field offset: 0x40
		public Stage stage; //Field offset: 0x48
		public InventoryController inventoryController; //Field offset: 0x50
		public IEftSession session; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GroupBonusPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private BonusesPanelSettings _settings; //Field offset: 0xA8
	[SerializeField]
	private BonusPanel _bonusPanel; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _bonusesLabel; //Field offset: 0xB8
	[SerializeField]
	private RectTransform _container; //Field offset: 0xC0
	private AsyncViewList _viewList; //Field offset: 0xC8
	private IReadOnlyDictionary _localizationTexts; //Field offset: 0xD0

	public GroupBonusPanel() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(RelatedData relatedData, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session) { }

	[CompilerGenerated]
	private void <Show>b__6_0(ELightStatus status) { }

	[CompilerGenerated]
	private void <Show>b__6_1(bool state) { }

	[CompilerGenerated]
	private BonusPanel <ShowContents>b__7_0(Bonus arg) { }

	[CompilerGenerated]
	private Transform <ShowContents>b__7_1(Bonus arg) { }

	[CompilerGenerated]
	private void <ShowContents>b__7_2(Bonus item, BonusPanel view) { }

	[AsyncStateMachine(typeof(<LoadIconTexture>d__8))]
	private Task LoadIconTexture(string icon, BonusPanel view) { }

	private void SetEnvironmentDetails() { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<Show>d__6))]
	public Task Show(RelatedBonuses relatedBonuses, Stage stage, ELevelType levelType, AreaData areaData, InventoryController inventoryController, IEftSession session, IReadOnlyDictionary localizationTexts) { }

	[AsyncStateMachine(typeof(<ShowContents>d__7))]
	public virtual Task ShowContents() { }

}

