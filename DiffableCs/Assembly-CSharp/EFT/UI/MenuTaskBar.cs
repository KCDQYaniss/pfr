namespace EFT.UI;

public sealed class MenuTaskBar : UIInputNode, ISerializationCallbackReceiver, ISupportsPrefabSerialization
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__93_3; //Field offset: 0x8
		public static Func <>9__100_0; //Field offset: 0x10
		public static Func <>9__113_0; //Field offset: 0x18
		public static Action <>9__116_0; //Field offset: 0x20
		public static Action <>9__116_1; //Field offset: 0x28
		public static Func <>9__123_0; //Field offset: 0x30
		public static Func <>9__123_1; //Field offset: 0x38
		public static Func <>9__123_2; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal bool <Awake>b__93_3(KeyValuePair x) { }

		internal bool <GetProducedItemsHandler>b__113_0(ItemsProducerBase p) { }

		internal int <InitHideout>b__100_0(ItemsProducerBase x) { }

		internal bool <SetNewMessagesCount>b__123_0(UpdatableChatDialogue x) { }

		internal int <SetNewMessagesCount>b__123_1(UpdatableChatDialogue item) { }

		internal int <SetNewMessagesCount>b__123_2(UpdatableChatDialogue item) { }

		internal void <UpdateExpansionsAvailability>b__116_0(PointerEventData _) { }

		internal void <UpdateExpansionsAvailability>b__116_1(PointerEventData _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass101_0
	{
		public MatchmakerPlayersController matchmakerPlayersController; //Field offset: 0x10
		public MenuTaskBar <>4__this; //Field offset: 0x18

		public <>c__DisplayClass101_0() { }

		internal void <InitGroupPanel>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass110_0
	{
		private struct <<OnScreenChanged>g__SelectToggle|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass110_0 <>4__this; //Field offset: 0x20
			private YieldAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public MenuTaskBar <>4__this; //Field offset: 0x10
		public AnimatedToggle toggleToSelect; //Field offset: 0x18

		public <>c__DisplayClass110_0() { }

		[AsyncStateMachine(typeof(<<OnScreenChanged>g__SelectToggle|0>d))]
		internal Task <OnScreenChanged>g__SelectToggle|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public ItemsProducerBase producer; //Field offset: 0x10
		public MenuTaskBar <>4__this; //Field offset: 0x18

		public <>c__DisplayClass112_0() { }

		internal void <RegisterProducer>b__0() { }

		internal void <RegisterProducer>g__GetProducedItems|1(IEnumerable items) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		public MenuTaskBar <>4__this; //Field offset: 0x10
		public EftScreenManager screenManager; //Field offset: 0x18

		public <>c__DisplayClass93_0() { }

		internal void <Awake>b__0() { }

		internal void <Awake>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_1
	{
		public EMenuType menuType; //Field offset: 0x10
		public <>c__DisplayClass93_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass93_1() { }

		internal void <Awake>b__2(bool arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public MenuTaskBar <>4__this; //Field offset: 0x10
		public Handbook handbook; //Field offset: 0x18

		public <>c__DisplayClass97_0() { }

		internal void <InitHandbook>b__0() { }

		internal void <InitHandbook>b__1() { }

		internal void <InitHandbook>b__2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public BonusController bonusController; //Field offset: 0x10
		public MenuTaskBar <>4__this; //Field offset: 0x18

		public <>c__DisplayClass99_0() { }

		internal void <InitBonusController>b__0() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__CloseTooltip; //Field offset: 0x0

	}

	private const string NOT_AVAILABLE_IN_RAID = "Not available in raid"; //Field offset: 0x0
	private const string UNAVAILABLE = "Taskbar/Unavailable"; //Field offset: 0x0
	[SerializeField]
	private GameObject[] _newInformation; //Field offset: 0x80
	[SerializeField]
	private Dictionary _hoverTooltipAreas; //Field offset: 0x88
	[SerializeField]
	private Dictionary _toggleButtons; //Field offset: 0x90
	[SerializeField]
	private GameObject _failedItemsObject; //Field offset: 0x98
	[SerializeField]
	private CustomTextMeshProUGUI _failedItemsLabel; //Field offset: 0xA0
	[SerializeField]
	private GameObject _producedItemsObject; //Field offset: 0xA8
	[SerializeField]
	private Button _producedItemsButton; //Field offset: 0xB0
	[SerializeField]
	private CustomTextMeshProUGUI _producedItemsLabel; //Field offset: 0xB8
	[SerializeField]
	private GameObject _newMessagesObject; //Field offset: 0xC0
	[SerializeField]
	private CustomTextMeshProUGUI _newMessagesLabel; //Field offset: 0xC8
	[SerializeField]
	private GameObject _newAttachmentsMessagesObject; //Field offset: 0xD0
	[SerializeField]
	private CustomTextMeshProUGUI _newAttachmentsMessagesLabel; //Field offset: 0xD8
	[SerializeField]
	private GameObject _newDialoguesMessagesObject; //Field offset: 0xE0
	[SerializeField]
	private GameObject _newFriendRequestsObject; //Field offset: 0xE8
	[SerializeField]
	private CustomTextMeshProUGUI _newFriendsRequestsLabel; //Field offset: 0xF0
	[SerializeField]
	private GameObject _newCompletableObject; //Field offset: 0xF8
	[SerializeField]
	private CustomTextMeshProUGUI _newCompletableLabel; //Field offset: 0x100
	[SerializeField]
	private GameObject _newNodesObject; //Field offset: 0x108
	[SerializeField]
	private CustomTextMeshProUGUI _newNodesLabel; //Field offset: 0x110
	[SerializeField]
	private GameObject _newNewsObject; //Field offset: 0x118
	[SerializeField]
	private CustomTextMeshProUGUI _newNewsLabel; //Field offset: 0x120
	[SerializeField]
	private GameObject _newShopOffersObject; //Field offset: 0x128
	[SerializeField]
	private CustomTextMeshProUGUI _newShopOffersLabel; //Field offset: 0x130
	[SerializeField]
	private GameObject _freeShopOffersObject; //Field offset: 0x138
	[SerializeField]
	private CustomTextMeshProUGUI _freeShopOffersLabel; //Field offset: 0x140
	[SerializeField]
	private GameObject _saleShopOffersObject; //Field offset: 0x148
	[SerializeField]
	private CustomTextMeshProUGUI _saleShopOffersLabel; //Field offset: 0x150
	[SerializeField]
	private LocalizedText[] _labels; //Field offset: 0x158
	[SerializeField]
	private Button _readAllButton; //Field offset: 0x160
	[SerializeField]
	private Button _showCompletableButton; //Field offset: 0x168
	[SerializeField]
	private GroupPanel _groupPanel; //Field offset: 0x170
	[SerializeField]
	private MainQuestUnreadWarning _unreadQuestWarning; //Field offset: 0x178
	[SerializeField]
	private Button _openMainQuests; //Field offset: 0x180
	private readonly Dictionary _screenToMenuTypesIndex; //Field offset: 0x188
	[CompilerGenerated]
	private Action OnHideoutCraftsButtonClick; //Field offset: 0x190
	[CompilerGenerated]
	private Action OnTaskBarButtonPressed; //Field offset: 0x198
	private SocialNetwork _social; //Field offset: 0x1A0
	private Handbook _handbook; //Field offset: 0x1A8
	private RagFair _ragfair; //Field offset: 0x1B0
	private MatchmakerPlayersController _matchmaker; //Field offset: 0x1B8
	private ProductionController _productionController; //Field offset: 0x1C0
	private NewsHub _newsHub; //Field offset: 0x1C8
	private ExpansionsPlayerInfo _expansionsInfo; //Field offset: 0x1D0
	private readonly Dictionary _producers; //Field offset: 0x1D8
	private int _newMessagesCount; //Field offset: 0x1E0
	private int _newAttachmentsMessagesCount; //Field offset: 0x1E4
	private int _newFriendsRequestsCount; //Field offset: 0x1E8
	private int _producedItemsCount; //Field offset: 0x1EC
	private int _failedItemsCount; //Field offset: 0x1F0
	private int _newNewsCount; //Field offset: 0x1F4
	private bool _isEditBuildActive; //Field offset: 0x1F8
	private bool _isExpansionsEnabled; //Field offset: 0x1F9
	private bool _isExpansionsAvailable; //Field offset: 0x1FA
	private bool _inventoryMenuButtonAvailable; //Field offset: 0x1FB
	private bool _taskBarInteractable; //Field offset: 0x1FC
	private string _taskBarTooltipText; //Field offset: 0x200
	private HoverTrigger _expansionsHoverTrigger; //Field offset: 0x208
	private readonly CompositeDisposable _socialDisposables; //Field offset: 0x210
	private readonly CompositeDisposable _handbookDisposables; //Field offset: 0x218
	private readonly CompositeDisposable _bonusDisposables; //Field offset: 0x220
	private readonly CompositeDisposable _questDisposables; //Field offset: 0x228
	private HashSet _areasWithCompletedProductsOrder; //Field offset: 0x230
	private CanvasGroup _canvasGroup; //Field offset: 0x238
	[CompilerGenerated]
	private bool <Visible>k__BackingField; //Field offset: 0x240
	[HideInInspector]
	[SerializeField]
	private SerializationData _serializationData; //Field offset: 0x248

	public event Action OnHideoutCraftsButtonClick
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	internal event Action OnTaskBarButtonPressed
	{
		[CompilerGenerated]
		internal add { } //Length: 278
		[CompilerGenerated]
		internal remove { } //Length: 278
	}

	private CanvasGroup CanvasGroup
	{
		private get { } //Length: 405
	}

	public AnimatedToggle ChatToggle
	{
		 get { } //Length: 81
	}

	public int FailedItemsCount
	{
		 set { } //Length: 303
	}

	private bool IsExpansionsManagedByAvailability
	{
		private get { } //Length: 29
	}

	private int NewAttachmentsMessagesCount
	{
		private get { } //Length: 7
		private set { } //Length: 297
	}

	private int NewMessagesCount
	{
		private get { } //Length: 7
		private set { } //Length: 297
	}

	public int NewNewsCount
	{
		 get { } //Length: 7
		 set { } //Length: 303
	}

	public int ProducedItemsCount
	{
		 get { } //Length: 7
		 set { } //Length: 303
	}

	private override SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.SerializationData
	{
		private get { } //Length: 47
		private set { } //Length: 114
	}

	public private bool Visible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public MenuTaskBar() { }

	[CompilerGenerated]
	private void <GroupStatusChangedHandler>b__107_0() { }

	[CompilerGenerated]
	private void <InitExpansionsPlayerInfo>b__105_0() { }

	[CompilerGenerated]
	private void <InitHideout>b__100_1() { }

	[CompilerGenerated]
	private void <InitHideout>b__100_2() { }

	[CompilerGenerated]
	private void <InitHideout>b__100_3() { }

	[CompilerGenerated]
	private void <InitNewsHub>b__104_0() { }

	[CompilerGenerated]
	private void <InitQuests>g__ShowMainQuestHandler|102_0() { }

	[CompilerGenerated]
	private void <InitRagfair>b__98_0(ERagFairStatus status) { }

	[CompilerGenerated]
	private void <InitSocial>b__96_0() { }

	[CompilerGenerated]
	public void add_OnHideoutCraftsButtonClick(Action value) { }

	[CompilerGenerated]
	internal void add_OnTaskBarButtonPressed(Action value) { }

	private void AtCraftsCountButtonClick() { }

	private void Awake() { }

	private void BonusChangedHandler(bool isActive, EBonusType bonusType) { }

	public virtual void Close() { }

	private void DeselectAllToggles() { }

	private void DialogueSelectedHandler(UpdatableChatDialogue dialogue) { }

	private void DisableExpansionsExtensionsTooltip() { }

	private CanvasGroup get_CanvasGroup() { }

	public AnimatedToggle get_ChatToggle() { }

	private bool get_IsExpansionsManagedByAvailability() { }

	private int get_NewAttachmentsMessagesCount() { }

	private int get_NewMessagesCount() { }

	public int get_NewNewsCount() { }

	public int get_ProducedItemsCount() { }

	[CompilerGenerated]
	public bool get_Visible() { }

	private void GetProducedItemsHandler(EAreaType areaType) { }

	private void GroupStatusChangedHandler() { }

	private void HandleProcessingReadyButtonPress(bool isProcessingReady) { }

	public void InitBonusController(BonusController bonusController) { }

	public void InitExpansionsPlayerInfo(ExpansionsPlayerInfo expansionsInfo) { }

	public void InitGroupPanel(MatchmakerPlayersController matchmakerPlayersController) { }

	public void InitHandbook(Handbook handbook) { }

	public void InitHideout(HideoutRepresentation hideout) { }

	public void InitNewsHub(NewsHub newsHub) { }

	public void InitQuests(QuestController questController) { }

	public void InitRagfair(RagFair ragfair) { }

	public void InitSocial(SocialNetwork social) { }

	private static bool IsScavInventoryScreenActive() { }

	private void LastMessageUpdatedHandler(KeyValuePair pair) { }

	private void OnDestroy() { }

	private void OnLocaleUpdatedHandler() { }

	private void OnNewCompletableChangedHandler() { }

	private void OnNodesCountChangedHandler() { }

	private void OnScreenChanged(EEftScreenType eftScreenType) { }

	public void PreparingRaid() { }

	private void ProductionCompleteHandler(ItemsProducerBase producer) { }

	private void RaidReadyButtonPressedHandler() { }

	private void RegisterProducer(ItemsProducerBase producer) { }

	[CompilerGenerated]
	public void remove_OnHideoutCraftsButtonClick(Action value) { }

	[CompilerGenerated]
	internal void remove_OnTaskBarButtonPressed(Action value) { }

	public void set_FailedItemsCount(int value) { }

	private void set_NewAttachmentsMessagesCount(int value) { }

	private void set_NewMessagesCount(int value) { }

	public void set_NewNewsCount(int value) { }

	public void set_ProducedItemsCount(int value) { }

	[CompilerGenerated]
	private void set_Visible(bool value) { }

	public void SetButtonsInteractable(bool interactable, string customTooltip = null) { }

	public void SetCustomButtonsAvailability(Dictionary states, string customTooltip = null) { }

	private void SetExpansionsLabelsInfo() { }

	internal void SetMenuChatBarVisibility(bool value) { }

	public void SetNewDialoguesVisibility(bool value) { }

	private void SetNewFriendsRequestsCount() { }

	private void SetNewMessagesCount() { }

	private void SetNewNewsCount() { }

	private void SetProducedItemsCount(ProductionController productionController) { }

	private void SetTaskBarInteractable(bool interactable) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	private override SerializationData Sirenix.Serialization.ISupportsPrefabSerialization.get_SerializationData() { }

	private override void Sirenix.Serialization.ISupportsPrefabSerialization.set_SerializationData(SerializationData value) { }

	public void SyncExpansionsSettings() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	private void UpdateExpansionsAvailability() { }

	private void UpdateRagfairAvailability() { }

}

