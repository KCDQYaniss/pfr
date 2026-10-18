namespace EFT.UI;

public sealed class NotesTaskDescriptionShort : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0`2
	{
		public NotesTaskDescriptionShort <>4__this; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0

		public <>c__DisplayClass10_0`2() { }

		internal void <Show>b__0() { }

	}

	[CompilerGenerated]
	private struct <LoadSprite>d__13`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public TConditional conditional; //Field offset: 0x0
		public IImageLoader session; //Field offset: 0x0
		public CancellationToken cancellationToken; //Field offset: 0x0
		public NotesTaskDescriptionShort <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TextMeshProUGUI _description; //Field offset: 0x70
	[SerializeField]
	private GameObject _loader; //Field offset: 0x78
	[SerializeField]
	private Image _image; //Field offset: 0x80
	[SerializeField]
	private IConditionalObjectivesView _objectivesView; //Field offset: 0x88
	[SerializeField]
	private GameObject _initialsContainer; //Field offset: 0x90
	[SerializeField]
	private GameObject _rewardsContainer; //Field offset: 0x98
	[SerializeField]
	private GameObject _rewardsInfoContainer; //Field offset: 0xA0
	[SerializeField]
	private GameObject _rewardListPrefab; //Field offset: 0xA8
	private InventoryController _inventoryController; //Field offset: 0xB0
	private RichTextMarkWrapper _descriptionMarkWrapper; //Field offset: 0xB8

	public NotesTaskDescriptionShort() { }

	private void ClearRewardContainer(GameObject container) { }

	public virtual void Close() { }

	private static IReadOnlyList GetRewardsInfo(TConditional conditional) { }

	private static IReadOnlyList GetStatusRewards(Dictionary rewardsByStatus, EQuestStatus status) { }

	private bool HasRewards(TConditional conditional, EQuestStatus status) { }

	private bool HasRewardsContent(TConditional conditional) { }

	[AsyncStateMachine(typeof(<LoadSprite>d__13`1))]
	private Task LoadSprite(TConditional conditional, IImageLoader session, CancellationToken cancellationToken) { }

	public void SetMask(HashSet mask) { }

	public void Show(TConditional conditional, InventoryController inventoryController, TController conditionalController, IImageLoader session) { }

	private void ShowDescription(TConditional conditional, ConditionalController conditionalController, IImageLoader session) { }

	private void ShowInitialBlock(TConditional conditional, bool show) { }

	private void ShowRewardList(GameObject container, string title, IReadOnlyList rewards, bool showUnknown) { }

	private void ShowRewardsBlock(TConditional conditional, bool show) { }

}

