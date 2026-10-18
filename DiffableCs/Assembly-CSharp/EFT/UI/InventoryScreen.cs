namespace EFT.UI;

[UsedImplicitly]
public sealed class InventoryScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_0
	{
		public CompoundItem originalLootItem; //Field offset: 0x10
		public InventoryScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass42_0() { }

		internal void <Show>g__RemoveHandler|0(RemoveItemEventArgs removeArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass42_1
	{
		public IItemOwner itemOwner; //Field offset: 0x10
		public <>c__DisplayClass42_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass42_1() { }

		internal void <Show>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public PrestigeLevel nextPrestigeLevel; //Field offset: 0x10
		public InventoryScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass57_0() { }

		internal void <ConfigurePrestigeTab>b__0() { }

	}

	[CompilerGenerated]
	private struct <ApplyCustomizationSuitesAsync>d__64 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryScreen <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowWithTab>d__44 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryScreen <>4__this; //Field offset: 0x20
		public bool splitInFrames; //Field offset: 0x28
		public EInventoryTab tab; //Field offset: 0x2C
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySwitchTab>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EInventoryTab tab; //Field offset: 0x20
		public InventoryScreen <>4__this; //Field offset: 0x28
		private Tab <targetTab>5__2; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class HideoutInventoryScreenController : LobbyInventoryScreenController
	{

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		public HideoutInventoryScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab inventoryTab) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

	}

	internal abstract class InventoryScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__44 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public InventoryScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30
			private TaskAwaiter <>u__2; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public readonly IEftSession Session; //Field offset: 0x58
		public readonly IHealthController HealthController; //Field offset: 0x60
		public readonly InventoryController InventoryController; //Field offset: 0x68
		public readonly QuestController QuestController; //Field offset: 0x70
		public readonly AchievementsController AchievementsController; //Field offset: 0x78
		[CanBeNull]
		public readonly PrestigeController PrestigeController; //Field offset: 0x80
		public readonly CompoundItem LootItem; //Field offset: 0x88
		[CompilerGenerated]
		private EInventoryTab <InventoryTab>k__BackingField; //Field offset: 0x90
		[CompilerGenerated]
		private Nullable <LastSelectedTab>k__BackingField; //Field offset: 0x94

		protected override EItemUiContextType ContextType
		{
			 get { } //Length: 6
		}

		public EInventoryTab CurrentTab
		{
			 get { } //Length: 238
			 set { } //Length: 244
		}

		public override bool InRaid
		{
			 get { } //Length: 3
		}

		public private EInventoryTab InventoryTab
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public override bool IsCustomizationTabAvailable
		{
			 get { } //Length: 3
		}

		public override bool IsInventoryBlocked
		{
			 get { } //Length: 3
		}

		public abstract ItemContext ItemContext
		{
			 get { } //Length: 0
		}

		public private Nullable LastSelectedTab
		{
			[CompilerGenerated]
			 get { } //Length: 8
			[CompilerGenerated]
			private set { } //Length: 8
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public override Profile Profile
		{
			 get { } //Length: 75
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public override EStashSearchAvailability SearchAvailability
		{
			 get { } //Length: 3
		}

		public override bool ShowAsGridContent
		{
			 get { } //Length: 3
		}

		public override bool ShowSortingTable
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected InventoryScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab inventoryTab) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		protected virtual void CloseAction(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__44))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		protected override EItemUiContextType get_ContextType() { }

		public EInventoryTab get_CurrentTab() { }

		public override bool get_InRaid() { }

		[CompilerGenerated]
		public EInventoryTab get_InventoryTab() { }

		public override bool get_IsCustomizationTabAvailable() { }

		public override bool get_IsInventoryBlocked() { }

		public abstract ItemContext get_ItemContext() { }

		[CompilerGenerated]
		public Nullable get_LastSelectedTab() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public override Profile get_Profile() { }

		public virtual EEftScreenType get_ScreenType() { }

		public override EStashSearchAvailability get_SearchAvailability() { }

		public override bool get_ShowAsGridContent() { }

		public override bool get_ShowSortingTable() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		public void set_CurrentTab(EInventoryTab value) { }

		[CompilerGenerated]
		private void set_InventoryTab(EInventoryTab value) { }

		[CompilerGenerated]
		private void set_LastSelectedTab(Nullable value) { }

		protected virtual void ShowAction(InventoryScreen screen) { }

		public void ShowMap(MapComponent map) { }

	}

	internal class LobbyInventoryScreenController : InventoryScreenController
	{
		[CompilerGenerated]
		private readonly ItemContext <ItemContext>k__BackingField; //Field offset: 0xA0
		[CompilerGenerated]
		private Action OnDialogStart; //Field offset: 0xA8

		public event Action OnDialogStart
		{
			[CompilerGenerated]
			 add { } //Length: 278
			[CompilerGenerated]
			 remove { } //Length: 278
		}

		public virtual bool IsCustomizationTabAvailable
		{
			 get { } //Length: 3
		}

		public virtual ItemContext ItemContext
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public virtual EStashSearchAvailability SearchAvailability
		{
			 get { } //Length: 6
		}

		public virtual bool ShowSortingTable
		{
			 get { } //Length: 3
		}

		public LobbyInventoryScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab inventoryTab) { }

		[CompilerGenerated]
		public void add_OnDialogStart(Action value) { }

		public virtual bool get_IsCustomizationTabAvailable() { }

		[CompilerGenerated]
		public virtual ItemContext get_ItemContext() { }

		public virtual EStashSearchAvailability get_SearchAvailability() { }

		public virtual bool get_ShowSortingTable() { }

		public void InvokeOnDialogStart(DialogStartData dialogData) { }

		[CompilerGenerated]
		public void remove_OnDialogStart(Action value) { }

		protected virtual void ShowAction(InventoryScreen screen) { }

	}

	internal sealed class MatchmakingInventoryScreenController : InventoryScreenController
	{
		[CompilerGenerated]
		private readonly ItemContext <ItemContext>k__BackingField; //Field offset: 0xA0

		public virtual bool IsInventoryBlocked
		{
			 get { } //Length: 3
		}

		public virtual ItemContext ItemContext
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public virtual EStashSearchAvailability SearchAvailability
		{
			 get { } //Length: 6
		}

		public virtual bool ShowSortingTable
		{
			 get { } //Length: 3
		}

		protected virtual string TaskBarButtonCustomTooltip
		{
			 get { } //Length: 49
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 3
		}

		public MatchmakingInventoryScreenController(IEftSession session, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, CompoundItem lootItem, EInventoryTab inventoryTab) { }

		protected virtual void CloseAction(bool moveForward) { }

		protected virtual void CloseAllWindows() { }

		public virtual bool get_IsInventoryBlocked() { }

		[CompilerGenerated]
		public virtual ItemContext get_ItemContext() { }

		public virtual EStashSearchAvailability get_SearchAvailability() { }

		public virtual bool get_ShowSortingTable() { }

		protected virtual string get_TaskBarButtonCustomTooltip() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

	}

	internal abstract class NoTaskBarInventoryScreenController : InventoryScreenController
	{
		[CompilerGenerated]
		private readonly Profile <Profile>k__BackingField; //Field offset: 0xA0
		[CompilerGenerated]
		private readonly ItemContext <ItemContext>k__BackingField; //Field offset: 0xA8

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public virtual bool InRaid
		{
			 get { } //Length: 3
		}

		public virtual ItemContext ItemContext
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 6
		}

		public virtual Profile Profile
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		protected virtual EStateSwitcher TaskBarButtonsAvailability
		{
			 get { } //Length: 6
		}

		protected virtual EStateSwitcher UnrestrictedFrameRate
		{
			 get { } //Length: 6
		}

		protected NoTaskBarInventoryScreenController(IEftSession session, Profile profile, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab inventoryTab, EItemViewType viewType) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public virtual bool get_InRaid() { }

		[CompilerGenerated]
		public virtual ItemContext get_ItemContext() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		[CompilerGenerated]
		public virtual Profile get_Profile() { }

		protected virtual EStateSwitcher get_TaskBarButtonsAvailability() { }

		protected virtual EStateSwitcher get_UnrestrictedFrameRate() { }

	}

	internal sealed class RaidInventoryScreenController : NoTaskBarInventoryScreenController
	{
		[CompilerGenerated]
		private readonly bool <ShowAsGridContent>k__BackingField; //Field offset: 0xB0

		public virtual bool ShowAsGridContent
		{
			[CompilerGenerated]
			 get { } //Length: 8
		}

		public RaidInventoryScreenController(IEftSession session, Profile profile, IHealthController healthController, InventoryController inventoryController, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab inventoryTab, bool showAsGridContent, EItemViewType viewType) { }

		[CompilerGenerated]
		public virtual bool get_ShowAsGridContent() { }

	}

	[Header("Tabs")]
	[SerializeField]
	private OverallScreen _overallScreen; //Field offset: 0xA0
	[SerializeField]
	private ItemsPanel _itemsPanel; //Field offset: 0xA8
	[SerializeField]
	private SkillsAndMasteringScreen _skillsAndMasteringScreen; //Field offset: 0xB0
	[SerializeField]
	private MapScreen _mapScreen; //Field offset: 0xB8
	[SerializeField]
	private TasksScreen _tasksScreen; //Field offset: 0xC0
	[SerializeField]
	private AchievementsScreen _achievementsScreen; //Field offset: 0xC8
	[SerializeField]
	private PrestigeScreen _prestigeScreen; //Field offset: 0xD0
	[SerializeField]
	private CharacterCustomizationScreen CharacterCustomizationScreen; //Field offset: 0xD8
	[SerializeField]
	private IReadOnlyDictionary _tabDictionary; //Field offset: 0xE0
	[Header("Components")]
	[SerializeField]
	private SimpleStashPanel _simpleStashPanel; //Field offset: 0xE8
	[SerializeField]
	private GameObject _prestigeNewLevelIcon; //Field offset: 0xF0
	[SerializeField]
	private MainQuestUnreadWarning _unreadQuestWarning; //Field offset: 0xF8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0x100
	[Header("Config")]
	[SerializeField]
	private bool _playBackpackSounds; //Field offset: 0x108
	private TabGroup _tabs; //Field offset: 0x110
	private InventoryController _inventoryController; //Field offset: 0x118
	private IHealthController _healthController; //Field offset: 0x120
	[CanBeNull]
	private CompoundItem _lootItem; //Field offset: 0x128
	private Profile _profile; //Field offset: 0x130
	private IEftSession _backEndSession; //Field offset: 0x138
	private InsuranceCompany _insurance; //Field offset: 0x140
	private QuestController _questController; //Field offset: 0x148
	private AchievementsController _achievementsController; //Field offset: 0x150
	private PrestigeController _prestigeController; //Field offset: 0x158
	private ItemContext _itemContext; //Field offset: 0x160
	private readonly Dictionary _equippedSuites; //Field offset: 0x168
	private Dictionary _oldCustomization; //Field offset: 0x170
	private Task _applyCustomizationSuitesTask; //Field offset: 0x178
	private bool _isInventoryBlocked; //Field offset: 0x180

	private EInventoryTab CurrentTab
	{
		private get { } //Length: 188
	}

	public InventoryScreen() { }

	[CompilerGenerated]
	private void <Awake>g__CloseScreen|37_0() { }

	[CompilerGenerated]
	private bool <get_CurrentTab>b__36_0(KeyValuePair pair) { }

	private Task ApplyCustomizationSuites() { }

	[AsyncStateMachine(typeof(<ApplyCustomizationSuitesAsync>d__64))]
	private Task ApplyCustomizationSuitesAsync() { }

	[UsedImplicitly]
	private void Awake() { }

	private void CharacterCustomizationRollback() { }

	public virtual void Close() { }

	private void ConfigureCustomizationTab() { }

	private void ConfigurePrestigeTab() { }

	private void ConfigureUnreadQuestWarning() { }

	private ITabController CreateAchievementsTabController() { }

	private ITabController CreateCustomizationTabController() { }

	private static CompoundItem CreateFakeStashWithLootItem(CompoundItem lootItem) { }

	private ITabController CreateGearTabController() { }

	private ITabController CreateHealthTabController() { }

	private ITabController CreateMapTabController() { }

	private ITabController CreateOverallTabController() { }

	private ITabController CreatePrestigeTabController() { }

	private ITabController CreateQuestsTabController() { }

	private ITabController CreateSkillsTabController() { }

	private ITabController CreateTabController(EInventoryTab tab) { }

	private void CustomizationChanged(CustomizationSuite suite) { }

	private EInventoryTab get_CurrentTab() { }

	private void InitTabs(out Tab[] tabs, out Tab initialTab) { }

	private void PrestigeLevelAvailabilityChanged(PrestigeLevel prestigeLevel, bool _) { }

	private void Show(IHealthController healthController, InventoryController controller, QuestController questController, AchievementsController achievementsController, PrestigeController prestigeController, CompoundItem lootItem, EInventoryTab tab, IEftSession session, ItemContext itemContext, bool showAsGridContent) { }

	public virtual void Show(InventoryScreenController controller) { }

	private void ShowMap(MapComponent map) { }

	private void ShowTab(EInventoryTab tab) { }

	[AsyncStateMachine(typeof(<ShowWithTab>d__44))]
	private Task ShowWithTab(EInventoryTab tab, bool splitInFrames) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	[AsyncStateMachine(typeof(<TrySwitchTab>d__40))]
	private Task TrySwitchTab(EInventoryTab tab) { }

}

