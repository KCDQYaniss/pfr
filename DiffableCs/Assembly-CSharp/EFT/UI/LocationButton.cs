namespace EFT.UI;

public class LocationButton : UIElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public LocationButton <>4__this; //Field offset: 0x10
		public Location location; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Show>b__0(bool isOn) { }

	}

	[SerializeField]
	private GameObject _infoPanel; //Field offset: 0x70
	[SerializeField]
	private CustomTextMeshProUGUI _infoText; //Field offset: 0x78
	[SerializeField]
	private RectTransform _secretBorder; //Field offset: 0x80
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0x88
	[SerializeField]
	private GameObject _overloadedIcon; //Field offset: 0x90
	[SerializeField]
	private GameObject _availableIcon; //Field offset: 0x98
	[SerializeField]
	private GameObject _newIcon; //Field offset: 0xA0
	[SerializeField]
	private GameObject _bossIcon; //Field offset: 0xA8
	[SerializeField]
	private UISpawnableToggle _spawnableToggle; //Field offset: 0xB0
	[SerializeField]
	private ZombieEventLocationInfectionInfo _halloweenInfectionInfo; //Field offset: 0xB8
	[SerializeField]
	private Image _iconImage; //Field offset: 0xC0
	[SerializeField]
	private Color _specialColor; //Field offset: 0xC8
	[SerializeField]
	private Color _defaultColor; //Field offset: 0xD8
	private Action _onSelected; //Field offset: 0xE8
	private LocationBlockedForPlayersTooltip _tooltip; //Field offset: 0xF0
	private List _lockedForPlayersList; //Field offset: 0xF8
	private string _playerAccountId; //Field offset: 0x100

	public ZombieEventLocationInfectionInfo HalloweenInfectionInfo
	{
		 get { } //Length: 8
	}

	public LocationButton() { }

	public ZombieEventLocationInfectionInfo get_HalloweenInfectionInfo() { }

	private static string GetUnavailableText(bool locationIsLocked, bool unavailableByQuest) { }

	public override void OnPointerEnter(PointerEventData eventData) { }

	public override void OnPointerExit(PointerEventData eventData) { }

	public void Select(bool value) { }

	public void Show(Location location, LocationSettings locationSettings, ESideType chosenSideType, bool onAtStart, int playerLevel, bool isOverloaded, bool isNew, Action onSelected, bool special, bool showBoss, List lockedForPlayersList, string playerAccountId) { }

}

