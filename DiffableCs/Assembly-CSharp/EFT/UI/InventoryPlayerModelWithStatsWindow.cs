namespace EFT.UI;

public class InventoryPlayerModelWithStatsWindow : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass45_0
	{
		public string endingId; //Field offset: 0x10

		public <>c__DisplayClass45_0() { }

		internal bool <AddEndingOptions>b__0(ProfileDisplayOption option) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass46_0
	{
		public EndingInfo ending; //Field offset: 0x10
		public string endingId; //Field offset: 0x18
		public InventoryPlayerModelWithStatsWindow <>4__this; //Field offset: 0x20

		public <>c__DisplayClass46_0() { }

		internal void <OnEndingSelected>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public ProfileInfo info; //Field offset: 0x10
		public EGameMode mode; //Field offset: 0x18
		public InventoryPlayerModelWithStatsWindow <>4__this; //Field offset: 0x20
		public string id; //Field offset: 0x28

		public <>c__DisplayClass61_0() { }

		internal void <OnPrestigeOptionSelected>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public PlayerVisualRepresentation playerVisualRepresentation; //Field offset: 0x10
		public InventoryPlayerModelWithStatsWindow <>4__this; //Field offset: 0x18
		public InventoryController inventoryController; //Field offset: 0x20

		public <>c__DisplayClass63_0() { }

		internal void <ShowClothingPanel>b__0(CustomizationSuite suite) { }

	}

	private const string ENDING_PROFILE_HEADER = "Ending/Profile/Header"; //Field offset: 0x0
	private const string PRESTIGE_PROFILE_HEADER = "Prestige/Profile/Header"; //Field offset: 0x0
	[SerializeField]
	private CustomTextMeshProUGUI _nicknameLabel; //Field offset: 0x70
	[SerializeField]
	private ChatSpecialIcon _specialIcon; //Field offset: 0x78
	[SerializeField]
	private CustomTextMeshProUGUI _experienceLabel; //Field offset: 0x80
	[SerializeField]
	private PlayerExperienceIcon _expIcon; //Field offset: 0x88
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0x90
	[SerializeField]
	private XCoordRotation _rotator; //Field offset: 0x98
	[SerializeField]
	private PlayerLevelPanel _playerLevelPanel; //Field offset: 0xA0
	[SerializeField]
	private ShortStatsPanel _shortStatsPanel; //Field offset: 0xA8
	[SerializeField]
	private Image _sideImage; //Field offset: 0xB0
	[SerializeField]
	private Sprite _bearSprite; //Field offset: 0xB8
	[SerializeField]
	private Sprite _usecSprite; //Field offset: 0xC0
	[SerializeField]
	private Sprite _noSprite; //Field offset: 0xC8
	[SerializeField]
	private Image _prestigeImage; //Field offset: 0xD0
	[SerializeField]
	private GameObject _emptyPrestige; //Field offset: 0xD8
	[SerializeField]
	private SeasonRankView _seasonRankView; //Field offset: 0xE0
	[SerializeField]
	private GameObject _finalImageHolder; //Field offset: 0xE8
	[SerializeField]
	private Image _finalImage; //Field offset: 0xF0
	[SerializeField]
	private SlotViewHeader _endingHeader; //Field offset: 0xF8
	[SerializeField]
	private ProfileDisplaySelector _endingSelector; //Field offset: 0x100
	[SerializeField]
	private HoverTooltipArea _endingHover; //Field offset: 0x108
	[SerializeField]
	private HoverTooltipArea _prestigeHover; //Field offset: 0x110
	[SerializeField]
	private ProfileDisplaySelector _prestigeSelector; //Field offset: 0x118
	[SerializeField]
	private DragTrigger _dragTrigger; //Field offset: 0x120
	[SerializeField]
	private InventoryClothingSelectionPanel _clothingPanel; //Field offset: 0x128
	[CompilerGenerated]
	private Action OnCustomizationChanged; //Field offset: 0x130
	private PlayerVisualRepresentation _playerVisualRepresentation; //Field offset: 0x138
	private InventoryController _inventoryController; //Field offset: 0x140
	private IEftSession _session; //Field offset: 0x148
	private EMemberCategory _memberCategory; //Field offset: 0x150
	private bool _isInMatching; //Field offset: 0x154
	private string _gameVersion; //Field offset: 0x158
	private bool _displaySelectorsBound; //Field offset: 0x160

	public event Action OnCustomizationChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public InventoryPlayerModelWithStatsWindow() { }

	[CompilerGenerated]
	private void <ShowPreview>b__64_0() { }

	[CompilerGenerated]
	private void <ShowPreview>b__64_1() { }

	[CompilerGenerated]
	public void add_OnCustomizationChanged(Action value) { }

	private void AddEndingOptions(List options, MongoID[] endingIds, bool isPve, FinalsResponse finals) { }

	private void AddPrestigeOption(List options, EGameMode gameMode, int level) { }

	private void ApplyOwnPrestigeVisuals(ProfileInfo info) { }

	private void ApplyPrestigeIcon(int prestigeLevel, EGameMode gameMode) { }

	private void ApplyViewedPrestigeVisuals(int prestigeLevel, EGameMode gameMode) { }

	private void AvailableCustomizationsChangedHandler() { }

	private void BindDisplaySelectors() { }

	public virtual void Close() { }

	private static bool ContainsEndingId(MongoID[] endingIds, MongoID endingId) { }

	private List CreateEndingOptions(EndingInfo ending, FinalsResponse finals) { }

	private List CreatePrestigeOptions(ProfileInfo info) { }

	private List CreateViewedPrestigeOption(int level, EGameMode gameMode) { }

	private void DragHandler(PointerEventData pointerData) { }

	private static ProfileInfo GetOwnPrestigeInfo(IPlayerProfileDataContainer profile, IEftSession session, bool ownProfile) { }

	private Sprite GetPrestigeIcon(int prestigeLevel, EGameMode gameMode) { }

	private static bool HasAvailableOption(List options) { }

	private void OnEndingSelected(string endingId) { }

	private void OnEndingSelectorOpened() { }

	private static string OnlineTimeText(long seconds) { }

	private void OnPrestigeOptionSelected(string id) { }

	private void OnPrestigeSelectorOpened() { }

	[CompilerGenerated]
	public void remove_OnCustomizationChanged(Action value) { }

	private static void ResolvePrestige(IPlayerProfileDataContainer profile, IEftSession session, bool ownProfile, out int level, out EGameMode gameMode, out ProfileInfo ownInfo) { }

	private void SetFinalImage(IPlayerProfileDataContainer profile, IEftSession session, bool canSelect) { }

	private void SetImages(IPlayerProfileDataContainer profile, IEftSession session, bool canSelectPrestigeDisplay, bool ownProfile) { }

	private void SetShortStatsPanel(ProfileStats stats) { }

	public void Show(IPlayerProfileDataContainer profileDataContainer, IEftSession session, int experience, EMemberCategory memberCategory, ProfileStats stats, PlayerVisualRepresentation playerVisualRepresentation, InventoryController inventoryController, bool isInMatching, string gameVersion, bool canSelectPrestigeDisplay = false, bool ownProfile = false) { }

	public void Show(Profile profile, IEftSession session, InventoryController inventoryController, bool isInMatching, bool canSelectPrestigeDisplay = false) { }

	private void ShowClothingPanel(PlayerVisualRepresentation playerVisualRepresentation, InventoryController inventoryController, bool isInMatching, string gameVersion) { }

	private void ShowPrestigeSelector(List options, string selectedId, bool canSelect) { }

	private void ShowPreview(PlayerVisualRepresentation playerVisualRepresentation, InventoryController inventoryController) { }

	private static bool TryGetEndingIcon(Nullable endingId, EndingInfo ending, FinalsResponse finals, out Sprite icon, out string tooltip) { }

	private static bool TryGetEndingIcon(MongoID endingId, bool isPve, FinalsResponse finals, out Sprite icon, out string tooltip) { }

}

