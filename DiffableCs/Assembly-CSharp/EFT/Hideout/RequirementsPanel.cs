namespace EFT.Hideout;

public sealed class RequirementsPanel : AbstractPanel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal ERequirementType <ShowContents>b__13_0(Requirement x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public RequirementsPanel <>4__this; //Field offset: 0x10
		public ItemUiContext itemUiContext; //Field offset: 0x18

		public <>c__DisplayClass13_0() { }

		internal void <ShowContents>b__2(Requirement requirement, IRequirementPanel view) { }

		internal bool <ShowContents>g__IgnoreFulfillment|1() { }

	}

	[CompilerGenerated]
	private struct <ShowContents>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RequirementsPanel <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string LEVEL_NUM_UPGRADE_REQUIREMENTS_TEXT = "LEVEL {0} UPGRADE REQUIREMENTS"; //Field offset: 0x0
	private const string LEVEL_NEXT_UPGRADE_REQUIREMENTS_TEXT = "NEXT LEVEL UPGRADE REQUIREMENTS"; //Field offset: 0x0
	private const string CONSTRUCT_REQUIREMENTS_TEXT = "CONSTRUCT REQUIREMENTS"; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _requirementsLabel; //Field offset: 0xA8
	[SerializeField]
	private AreaRequirementPanel _areaRequirementPanel; //Field offset: 0xB0
	[SerializeField]
	private ItemRequirementPanel _itemRequirementPanel; //Field offset: 0xB8
	[SerializeField]
	private TraderRequirementPanel _traderRequirementPanel; //Field offset: 0xC0
	[SerializeField]
	private SkillRequirementPanel _skillRequirementPanel; //Field offset: 0xC8
	[SerializeField]
	private RectTransform _areaContainer; //Field offset: 0xD0
	[SerializeField]
	private RectTransform _itemContainer; //Field offset: 0xD8
	[SerializeField]
	private RectTransform _traderContainer; //Field offset: 0xE0
	[SerializeField]
	private RectTransform _skillContainer; //Field offset: 0xE8
	private AsyncViewList _viewList; //Field offset: 0xF0

	public RequirementsPanel() { }

	private Transform ContainerByRequirement(Requirement requirement) { }

	public virtual void SetInfo() { }

	[AsyncStateMachine(typeof(<ShowContents>d__13))]
	public virtual Task ShowContents() { }

	private IRequirementPanel ViewByRequirement(Requirement requirement) { }

}

