namespace EFT.UI;

public sealed class HierarchyFilterTab : FilterTab
{
	[CompilerGenerated]
	private struct <Deselect>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HierarchyFilterTab <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private Sprite _subtabNormal; //Field offset: 0xA0
	[SerializeField]
	private Sprite _subtabHover; //Field offset: 0xA8
	[SerializeField]
	private Sprite _subtabSelected; //Field offset: 0xB0
	[SerializeField]
	private Image _subgroupArrow; //Field offset: 0xB8
	[SerializeField]
	private Color _normalArrowColor; //Field offset: 0xC0
	[SerializeField]
	private Color _selectedArrowColor; //Field offset: 0xD0
	private HierarchyFilterTab Parent; //Field offset: 0xE0
	[CompilerGenerated]
	private IEnumerable <SubTabs>k__BackingField; //Field offset: 0xE8

	public private IEnumerable SubTabs
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public HierarchyFilterTab() { }

	[AsyncStateMachine(typeof(<Deselect>d__16))]
	public virtual Task Deselect() { }

	[CompilerGenerated]
	public IEnumerable get_SubTabs() { }

	public virtual void Hover(bool isHovered) { }

	public void Init(IEnumerable subTabs) { }

	public void Init(HierarchyFilterTab parent) { }

	public virtual void Select(bool sendCallback = true, bool uiOnly = true) { }

	[CompilerGenerated]
	private void set_SubTabs(IEnumerable value) { }

	protected virtual void UpdateVisual(bool selected, bool uiOnly = false) { }

}

