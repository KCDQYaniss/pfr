namespace EFT.UI;

public sealed class InspectClothingWindow : Window
{
	private static readonly Dictionary _fakeHideoutAreaStashes; //Field offset: 0x0
	private static readonly Dictionary _fakeFastAccess; //Field offset: 0x8
	private static readonly Dictionary _fakeDiscardLimits; //Field offset: 0x10
	private static readonly List _fakeFavoriteItems; //Field offset: 0x18
	private static readonly List _fakeDeserializationErrors; //Field offset: 0x20
	[SerializeField]
	private PlayerModelView _modelView; //Field offset: 0xB8
	[SerializeField]
	private TransformClampedTranslateController _cameraMove; //Field offset: 0xC0
	[SerializeField]
	private XCoordRotation _rotator; //Field offset: 0xC8
	[SerializeField]
	private DragTrigger _dragTrigger; //Field offset: 0xD0
	[SerializeField]
	private Image _bearIcon; //Field offset: 0xD8
	[SerializeField]
	private Image _usecIcon; //Field offset: 0xE0
	[SerializeField]
	private GameObject _lockedIcon; //Field offset: 0xE8
	[SerializeField]
	private TMP_Text _description; //Field offset: 0xF0
	[SerializeField]
	private Color _activeSideColor; //Field offset: 0xF8
	[SerializeField]
	private Color _inactiveSideColor; //Field offset: 0x108

	private static InspectClothingWindow() { }

	public InspectClothingWindow() { }

	[CompilerGenerated]
	private void <Show>b__15_1() { }

	[CompilerGenerated]
	private void <Show>g__InitDragTrigger|15_0() { }

	private void DragHandler(PointerEventData pointerData) { }

	public DialogWindowContext Show(CustomizationSuite suite, Profile profile, InventoryController inventoryController, EClothingViewType viewType) { }

	private void Update() { }

}

