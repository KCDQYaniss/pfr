namespace EFT.UI;

public sealed class OtherPlayerProfileScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__31_0; //Field offset: 0x8
		public static Func <>9__34_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <Show>b__31_0(Item item) { }

		internal float <UpdateAchievementsBlock>b__34_0(AchievementTemplate a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public OtherPlayerProfileScreen <>4__this; //Field offset: 0x10
		public ItemController itemController; //Field offset: 0x18
		public GridLayoutGroup container; //Field offset: 0x20

		public <>c__DisplayClass33_0() { }

		internal ItemView <CreateItemViews>b__0(Item item) { }

		internal void <CreateItemViews>b__1(Item item, ItemView itemView) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public KeyValuePair unlockedAchievement; //Field offset: 0x10

		public <>c__DisplayClass34_0() { }

		internal bool <UpdateAchievementsBlock>b__1(AchievementTemplate a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_1
	{
		public AchievementTemplate template; //Field offset: 0x10
		public OtherPlayerProfileScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass34_1() { }

		internal void <UpdateAchievementsBlock>b__2(PointerEventData e) { }

	}

	internal class OtherPlayerProfileScreenController : EftScreenController
	{
		internal sealed class OnCloseDelegate : MulticastDelegate
		{

			public OnCloseDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(bool moveForward, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(bool moveForward) { }

		}

		public readonly OtherPlayerProfile Profile; //Field offset: 0x58
		public readonly InventoryController InventoryController; //Field offset: 0x60
		public readonly EItemViewType ViewType; //Field offset: 0x68
		public readonly IEftSession Session; //Field offset: 0x70
		[CompilerGenerated]
		private OnCloseDelegate OnClose; //Field offset: 0x78

		public event OnCloseDelegate OnClose
		{
			[CompilerGenerated]
			 add { } //Length: 235
			[CompilerGenerated]
			 remove { } //Length: 235
		}

		public override bool IsVisitHideoutAvailable
		{
			 get { } //Length: 3
		}

		protected virtual EStateSwitcher MenuChatBarVisibility
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public OtherPlayerProfileScreenController(OtherPlayerProfile profile, InventoryController inventoryController, EItemViewType viewType, IEftSession session) { }

		[CompilerGenerated]
		public void add_OnClose(OnCloseDelegate value) { }

		protected virtual void CloseAction(bool moveForward) { }

		public override bool get_IsVisitHideoutAvailable() { }

		protected virtual EStateSwitcher get_MenuChatBarVisibility() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		public void remove_OnClose(OnCloseDelegate value) { }

	}

	internal class RaidOtherPlayerProfileScreenController : OtherPlayerProfileScreenController
	{

		public virtual bool IsVisitHideoutAvailable
		{
			 get { } //Length: 3
		}

		public RaidOtherPlayerProfileScreenController(OtherPlayerProfile profile, InventoryController inventoryController, EItemViewType viewType, IEftSession session) { }

		public virtual bool get_IsVisitHideoutAvailable() { }

	}

	private OtherPlayerProfile _profile; //Field offset: 0xA0
	private IEftSession _session; //Field offset: 0xA8
	private EItemViewType _viewType; //Field offset: 0xB0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB8
	[SerializeField]
	private UIAnimatedToggleSpawner _arenaToggle; //Field offset: 0xC0
	[SerializeField]
	private UIAnimatedToggleSpawner _eftToggle; //Field offset: 0xC8
	[SerializeField]
	private InventoryPlayerModelWithStatsWindow _playerModelWithStatsWindow; //Field offset: 0xD0
	[SerializeField]
	private OverallStatsPanel _overallStatsPanel; //Field offset: 0xD8
	[SerializeField]
	private List _achievementViews; //Field offset: 0xE0
	[SerializeField]
	private LocalizedText _achievementsProgressLabelText; //Field offset: 0xE8
	[SerializeField]
	private TMP_Text _achievementsProgressValueText; //Field offset: 0xF0
	[SerializeField]
	private Image _achievementsProgressBarImage; //Field offset: 0xF8
	[SerializeField]
	private GameObject _achievementsProgressBlock; //Field offset: 0x100
	[SerializeField]
	private GameObject _achievementsBlockPlaceholder; //Field offset: 0x108
	[SerializeField]
	private GameObject _weaponsBlockPlaceholder; //Field offset: 0x110
	[SerializeField]
	private GameObject _nonWeaponItemsBlockPlaceholder; //Field offset: 0x118
	[SerializeField]
	[Space]
	private GameObject _seasonalModifiersPanel; //Field offset: 0x120
	[SerializeField]
	private SeasonalModifiersList _seasonalModifiersList; //Field offset: 0x128
	[SerializeField]
	private GameObject _seasonalModifiersListPlaceHolder; //Field offset: 0x130
	[SerializeField]
	private SeasonWidget _seasonWidget; //Field offset: 0x138
	[SerializeField]
	[Space]
	private GridLayoutGroup _weaponsGridLayoutGroup; //Field offset: 0x140
	[SerializeField]
	private GridLayoutGroup _nonWeaponItemsGridLayoutGroup; //Field offset: 0x148
	[SerializeField]
	[Space]
	private ReportPanel _reportPanel; //Field offset: 0x150
	[SerializeField]
	[Space]
	private DefaultUiButtonNewStyle _hideoutButton; //Field offset: 0x158
	private ViewList _weaponsViewList; //Field offset: 0x160
	private ViewList _nonWeaponItemsViewList; //Field offset: 0x168
	private ItemUiContext _itemUiContext; //Field offset: 0x170

	public OtherPlayerProfileScreen() { }

	[CompilerGenerated]
	private void <Awake>b__29_0(bool value) { }

	[CompilerGenerated]
	private void <Awake>b__29_1(bool value) { }

	[CompilerGenerated]
	private void <Awake>b__29_2() { }

	private void Awake() { }

	public virtual void Close() { }

	private void CreateItemViews(IEnumerable items, ItemController itemController, ref ViewList viewList, GridLayoutGroup container) { }

	public void HideAchievementTooltip(PointerEventData eventData) { }

	private void LoadHideout() { }

	private void SetupSeasonalPanels(IEftSession session) { }

	private void Show(OtherPlayerProfile profile, InventoryController inventoryController, EItemViewType viewType, IEftSession session, bool visitHideoutAvailable) { }

	public virtual void Show(OtherPlayerProfileScreenController controller) { }

	public void ShowAchievementTooltip(PointerEventData eventData, AchievementTemplate template) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void UpdateAchievementsBlock() { }

	private void UpdateNonWeaponItemsBlock(IEnumerable favoriteItems, ItemController itemController) { }

	private void UpdateWeaponsBlock(IEnumerable favoriteItems, ItemController itemController) { }

}

