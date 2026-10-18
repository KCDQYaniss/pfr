namespace EFT.UI;

[Obfuscation(Exclude = True)]
public sealed class PocketMapMarkerManager : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__32_0; //Field offset: 0x8
		public static Func <>9__37_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <IsMarkerTypeVisible>b__37_1(ToggleData toggleData) { }

		internal void <MarkerCreate>b__32_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public ToggleData toggleDataSave; //Field offset: 0x10
		public PocketMapMarkerManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass17_0() { }

		internal void <Awake>b__1(bool value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public int x; //Field offset: 0x10
		public int y; //Field offset: 0x14
		public Func <>9__0; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal bool <RemoveMarkerView>b__0(PocketMapMarker mapMarker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public int x; //Field offset: 0x10
		public int y; //Field offset: 0x14

		public <>c__DisplayClass27_0() { }

		internal bool <GetMarkerView>b__0(PocketMapMarker mapMarker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public PocketMapMarkerManager <>4__this; //Field offset: 0x10
		public Vector2 position; //Field offset: 0x18

		public <>c__DisplayClass32_0() { }

		internal void <MarkerCreate>b__1(MapMarkerType type, string note) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public MapMarker marker; //Field offset: 0x10
		public PocketMapMarkerManager <>4__this; //Field offset: 0x18

		public <>c__DisplayClass33_0() { }

		internal void <MarkerEdit>b__0(MapMarkerType type, string note) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public MapMarkerType type; //Field offset: 0x10

		public <>c__DisplayClass35_0() { }

		internal bool <GetMarkersCount>b__0(MapMarker marker) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass37_0
	{
		public MapMarkerType type; //Field offset: 0x10

		public <>c__DisplayClass37_0() { }

		internal bool <IsMarkerTypeVisible>b__0(ToggleData toggleData) { }

	}

	internal sealed class ToggleData
	{
		public MapMarkerType Type; //Field offset: 0x10
		public Toggle Toggle; //Field offset: 0x18
		public TMP_Text Label; //Field offset: 0x20

		public ToggleData() { }

	}

	[SerializeField]
	private GameObject _markerPrefab; //Field offset: 0x20
	[SerializeField]
	private RectTransform _container; //Field offset: 0x28
	[SerializeField]
	private SpriteMap _spriteMap; //Field offset: 0x30
	[SerializeField]
	private ToggleData[] _toggles; //Field offset: 0x38
	[SerializeField]
	private TMP_Text _markersCounter; //Field offset: 0x40
	[SerializeField]
	private CustomToggle _legendButton; //Field offset: 0x48
	[SerializeField]
	private GameObject _legend; //Field offset: 0x50
	private MapComponent _map; //Field offset: 0x58
	private IItemOwner _mapOwner; //Field offset: 0x60
	private InventoryController _inventoryController; //Field offset: 0x68
	private MapMarkerWindow _markerWindow; //Field offset: 0x70
	[CompilerGenerated]
	private bool <Shown>k__BackingField; //Field offset: 0x78
	private readonly List _markers; //Field offset: 0x80

	public private bool Shown
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public PocketMapMarkerManager() { }

	[CompilerGenerated]
	private void <Awake>b__17_0(bool arg) { }

	private void Awake() { }

	private void CreateMarkerView(MapMarker marker) { }

	private void DiscardEditMarkerView(int x, int y) { }

	private void EditMarkerView(int x, int y, MapMarker marker) { }

	[CompilerGenerated]
	public bool get_Shown() { }

	private int GetMarkersCount(MapMarkerType type) { }

	[CanBeNull]
	private PocketMapMarker GetMarkerView(int x, int y) { }

	public void Hide() { }

	private void HideMarkerWindow() { }

	private bool IsMarkerTypeVisible(MapMarkerType type) { }

	private void MarkerCreate(Vector2 position) { }

	private void MarkerDelete(MapMarker marker) { }

	private void MarkerEdit(Vector2 position, MapMarker marker) { }

	private void OnCreateMapMarkerEvent(CreateMapMarkerEventArgs args) { }

	private void OnDeleteMapMarkerEvent(DeleteMapMarkerEventArgs args) { }

	private void OnEditMapMarkerEvent(EditMapMarkerEventArgs args) { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void RemoveMarkerView(int x, int y) { }

	[CompilerGenerated]
	private void set_Shown(bool value) { }

	private void SetMarkersVisible(MapMarkerType type, bool value) { }

	public void Show(MapComponent map, InventoryController inventoryController, MapMarkerWindow markerWindow) { }

	private void ShowCreateContextMenu(Vector2 position) { }

	public void ShowEditContextMenu(Vector2 position, MapMarker marker) { }

	private void UpdateLegend() { }

}

