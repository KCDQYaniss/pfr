namespace EFT.UI.Matchmaker;

public sealed class MatchmakerMapPointsScreen : MatchmakerEftScreen
{
	internal sealed class MapPointScreenController : EftMatchmakerScreenController
	{
		public readonly bool AllowSelection; //Field offset: 0x78
		public readonly MapPoints MapPoints; //Field offset: 0x80
		public readonly Location Location; //Field offset: 0x88
		public readonly InventoryController InventoryController; //Field offset: 0x90

		public virtual bool KeyScreen
		{
			 get { } //Length: 3
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public MapPointScreenController(bool allowSelection, MapPoints mapPoints, Location location, InventoryController inventoryController, MatchmakerPlayersController matchmakerPlayersController, EGameMode gameMode) { }

		public virtual bool get_KeyScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

	}

	[SerializeField]
	private TextMeshProUGUI _substring; //Field offset: 0xB0
	[SerializeField]
	private TextMeshProUGUI _warningDescription; //Field offset: 0xB8
	[SerializeField]
	private GameObject[] _enableWhenNoMap; //Field offset: 0xC0
	[SerializeField]
	private GameObject[] _enableWhenMap; //Field offset: 0xC8
	[SerializeField]
	private GameObject _mapIcon; //Field offset: 0xD0
	[SerializeField]
	private SelectEntryPointPanel _entryPointPanel; //Field offset: 0xD8
	[SerializeField]
	private MapPointsManager _mapPointsManager; //Field offset: 0xE0
	[SerializeField]
	private DefaultUIButton _acceptButton; //Field offset: 0xE8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xF0
	[SerializeField]
	private DefaultUIButton _readyButton; //Field offset: 0xF8
	[SerializeField]
	private SimplePocketMap _pocketMap; //Field offset: 0x100
	[SerializeField]
	private CustomToggle _legendButton; //Field offset: 0x108
	[SerializeField]
	private GameObject _legend; //Field offset: 0x110
	private MapPoints _mapPoints; //Field offset: 0x118
	private Location _location; //Field offset: 0x120
	private readonly Dictionary _locationNames; //Field offset: 0x128

	public MatchmakerMapPointsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__17_0() { }

	[CompilerGenerated]
	private void <Awake>b__17_1() { }

	[CompilerGenerated]
	private void <Awake>b__17_2() { }

	[CompilerGenerated]
	private void <Awake>b__17_3(bool arg) { }

	[CompilerGenerated]
	private bool <CheckForMap>b__20_0(MapComponent map) { }

	[CompilerGenerated]
	private void <Show>b__19_0(EntryPoint arg) { }

	private void Awake() { }

	[CanBeNull]
	private MapComponent CheckForMap(IEnumerable maps) { }

	public virtual void Close() { }

	public virtual void Show(MapPointScreenController controller) { }

	private void Show(bool allowSelection, MapPoints mapPoints, Location location, InventoryController inventoryController) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

