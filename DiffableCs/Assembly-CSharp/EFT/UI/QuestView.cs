namespace EFT.UI;

[Obfuscation(Exclude = True)]
public sealed class QuestView : UIElement
{
	[CompilerGenerated]
	private struct <FinishQuestAsync>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestView <>4__this; //Field offset: 0x20
		public Quest quest; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowChangeQuestConfirmation>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestView <>4__this; //Field offset: 0x20
		private DialogWindowContext <context>5__2; //Field offset: 0x28
		private Task <acceptTask>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartQuest>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QuestView <>4__this; //Field offset: 0x20
		public Quest selectedQuest; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private TextMeshProUGUI _title; //Field offset: 0x70
	[SerializeField]
	private TextMeshProUGUI _status; //Field offset: 0x78
	[SerializeField]
	private GameObject _rewardListPrefab; //Field offset: 0x80
	[SerializeField]
	private GameObject _initialsContainer; //Field offset: 0x88
	[SerializeField]
	private GameObject _rewardsContainer; //Field offset: 0x90
	[SerializeField]
	private GameObject _rewardsInfoContainer; //Field offset: 0x98
	[SerializeField]
	private NotesTaskDescription _descriptionPanel; //Field offset: 0xA0
	[SerializeField]
	private QuestRequirementsView _requirementsBlock; //Field offset: 0xA8
	[SerializeField]
	private QuestObjectivesView _objectivesBlock; //Field offset: 0xB0
	[SerializeField]
	private SpriteMap _buttonIcons; //Field offset: 0xB8
	[SerializeField]
	private DefaultUIButton _button; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _buttonReRoll; //Field offset: 0xC8
	private MultiLineTooltip _multiLineTooltip; //Field offset: 0xD0
	private QuestController _questController; //Field offset: 0xD8
	private Quest _quest; //Field offset: 0xE0
	private Quest _cachedQuest; //Field offset: 0xE8
	private IEftSession _backendSession; //Field offset: 0xF0
	private Trader _trader; //Field offset: 0xF8
	private readonly BindableState _isPerformingAction; //Field offset: 0x100
	private InventoryController _inventoryController; //Field offset: 0x108
	private Dictionary _moneySums; //Field offset: 0x110
	private float _charismaDiscount; //Field offset: 0x118
	private Queue _newQuestsQueue; //Field offset: 0x120

	private bool IsPerformingAction
	{
		private get { } //Length: 45
		private set { } //Length: 45
	}

	public string QuestId
	{
		 get { } //Length: 70
	}

	public QuestView() { }

	[CompilerGenerated]
	private void <Show>b__29_0() { }

	[CompilerGenerated]
	private void <Show>b__29_1(bool _) { }

	private void Awake() { }

	private bool CheckChangeItemsRequirement(QuestChangeCost questChangeCost) { }

	private bool CheckChangeStandingRequirement(QuestChangeRequirement changeRequirement) { }

	private void ClearRewardContainer(GameObject container) { }

	public virtual void Close() { }

	private void ExpireQuestLocal() { }

	private void FinishQuest() { }

	[AsyncStateMachine(typeof(<FinishQuestAsync>d__57))]
	private Task FinishQuestAsync(Quest quest) { }

	private bool get_IsPerformingAction() { }

	public string get_QuestId() { }

	private int GetDiscountedPrice(int price) { }

	private IReadOnlyList GetStatusRewards(Dictionary rewardsByStatus, EQuestStatus status) { }

	private int GetTotalCurrency(QuestChangeCost questChangeCost) { }

	private bool HasRewardsContent() { }

	private bool IsChangeRequirementsSatisfied() { }

	private bool IsQuestChangeFree(out int freeChanges, out int maxFreeChanges) { }

	private void LinkedQuestHandler(Quest quest) { }

	private void OnQuestStatusChanged(Quest quest, bool notify) { }

	private void OnReRollButtonClick() { }

	private MultiLineInfo QuestChangePriceInfos() { }

	private QuestChangeRequirement QuestChangeRequirement() { }

	private void set_IsPerformingAction(bool value) { }

	public void Show(IEftSession backendSession, InventoryController inventoryController, QuestController questController, Quest quest, Trader trader) { }

	private void ShowButtonBlock() { }

	[AsyncStateMachine(typeof(<ShowChangeQuestConfirmation>d__40))]
	private Task ShowChangeQuestConfirmation() { }

	private void ShowInitialBlock(bool show) { }

	private void ShowObjectivesBlock(bool show) { }

	private void ShowQuestMessage(QuestTemplate questTemplate, string message) { }

	private void ShowQuestMessagesRecursively() { }

	private void ShowRequirementsBlock(bool show) { }

	private void ShowReRollTooltip() { }

	private void ShowRewardList(GameObject container, string title, IReadOnlyList rewards, bool showUnknown, string infoText = null) { }

	private void ShowRewardsBlock(bool show) { }

	private void StartQuest() { }

	[AsyncStateMachine(typeof(<StartQuest>d__54))]
	private Task StartQuest(Quest selectedQuest) { }

	private void UpdateView() { }

}

