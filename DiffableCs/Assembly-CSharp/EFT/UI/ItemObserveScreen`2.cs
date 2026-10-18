namespace EFT.UI;

public abstract class ItemObserveScreen`2 : EftScreen, IItemObserverScreen, IModdingSelectionContext, ISelectionContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__38_0; //Field offset: 0x0
		public static Func <>9__54_0; //Field offset: 0x0
		public static Comparison <>9__61_0; //Field offset: 0x0
		public static Func <>9__71_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal bool <Close>b__71_0(Light x) { }

		internal bool <CreateModSlots>b__54_0(Slot x) { }

		internal bool <Show>b__38_0(Light x) { }

		internal int <UpdatePositions>b__61_0(KeyValuePair pair1, KeyValuePair pair2) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public ItemObserveScreen <>4__this; //Field offset: 0x0
		public CompoundItem compoundItem; //Field offset: 0x0

		public <>c__DisplayClass52_0() { }

		internal void <RefreshWeapon>b__0() { }

		internal void <RefreshWeapon>b__1() { }

		internal void <RefreshWeapon>b__2(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public Vector2 center; //Field offset: 0x0

		public <>c__DisplayClass67_0() { }

		internal Vector2 <ProjectPointsOnEllipse>b__0(Vector2 point) { }

	}

	private const string NO_BUILD_SELECTED_TEXT = "NO BUILD SELECTED"; //Field offset: 0x0
	private HighLightMesh _meshHighlighter; //Field offset: 0x0
	private Transform[] _modTransforms; //Field offset: 0x0
	private Light[] _universeLights; //Field offset: 0x0
	private Vector2 _center; //Field offset: 0x0
	private bool _isHighlightOverriden; //Field offset: 0x0
	private bool _isRotating; //Field offset: 0x0
	private DropdownManipulation _manipulation; //Field offset: 0x0
	private readonly EllipseCalculator _ellipseCalculator; //Field offset: 0x0
	private ModdingScreenSlotView _slotView; //Field offset: 0x0
	private Slot[] _cachedSlots; //Field offset: 0x0
	protected ItemUiContext _itemUiContext; //Field offset: 0x0
	protected bool RefreshingWeapon; //Field offset: 0x0
	protected EModClass VisibleModClasses; //Field offset: 0x0
	private ModdingSelectableItemContext _itemContext; //Field offset: 0x0
	protected readonly Dictionary ModIcons; //Field offset: 0x0
	[CanBeNull]
	protected Item Item; //Field offset: 0x0
	public Camera LineCamera; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0x0
	[SerializeField]
	private GameObject _loader; //Field offset: 0x0
	[SerializeField]
	private RectTransform _ellipseRect; //Field offset: 0x0
	[SerializeField]
	protected Toggle[] ModClassToggles; //Field offset: 0x0
	[SerializeField]
	private CharacteristicsPanel _characteristics; //Field offset: 0x0
	[SerializeField]
	private WeaponPreview _weaponPreview; //Field offset: 0x0
	[SerializeField]
	private RectTransform _slotsContainer; //Field offset: 0x0
	[SerializeField]
	private CameraViewporter _viewporter; //Field offset: 0x0
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0x0
	[SerializeField]
	private DropDownMenu _menu; //Field offset: 0x0
	[SerializeField]
	private TextMeshProUGUI _weaponName; //Field offset: 0x0
	private Item _compareItem; //Field offset: 0x0
	[CompilerGenerated]
	private InventoryController <InventoryController>k__BackingField; //Field offset: 0x0

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected private InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected ItemObserveScreen`2() { }

	[CompilerGenerated]
	private void <Awake>b__36_0() { }

	[CompilerGenerated]
	private void <Awake>b__36_1(PointerEventData pointerData) { }

	[CompilerGenerated]
	private void <Awake>b__36_2(PointerEventData pointerData) { }

	[CompilerGenerated]
	private void <Awake>b__36_3(bool x) { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	protected override void Awake() { }

	private static Vector2[] CastPointsOnEllipse(Vector2[] points, Vector2 center, float a, float b) { }

	protected override void CheckForVitalParts() { }

	private void ClearModSlots() { }

	public virtual void Close() { }

	protected abstract DropdownManipulation CreateBuildManipulation() { }

	private void CreateModSlots(CompoundItem weapon) { }

	private void CreateModSlotViews(CompoundItem weapon) { }

	private override IEnumerable EFT.InventoryLogic.ModdingSelectableItemContext.IModdingSelectionContext.GetAllItems(Slot slot) { }

	private override EEditBuildItemAvailability EFT.InventoryLogic.ModdingSelectableItemContext.IModdingSelectionContext.GetItemAvailability(Item item) { }

	private override void EFT.InventoryLogic.ModdingSelectableItemContext.IModdingSelectionContext.Highlight(ModdingSelectableItemContext context, bool selected) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	[CompilerGenerated]
	protected InventoryController get_InventoryController() { }

	private static float GetAngleFromCoords(Vector2 point, Vector2 center, float a, float b) { }

	private static Vector2 GetCoordsFromAngle(float angle, Vector2 center, float a, float b) { }

	private float GetEllipticalPosition(float angle, float a, float b) { }

	public override void HideModHighlight(bool overriding = false) { }

	public override void HighlightMod(Transform modTransform, Color color, bool overriding = false) { }

	private float InverseEllipticalPosition(float pos, float a, float b) { }

	private void OnCompareRequested(Slot slot, Item item) { }

	private void OnResetCompare(Slot slot) { }

	private static Vector2[] ProjectPointsOnEllipse(Vector2[] points, Vector2 center, float a, float b) { }

	protected void RefreshWeapon() { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	public override Vector3 ScreenToWorldPoint(Vector3 position) { }

	[CompilerGenerated]
	private void set_InventoryController(InventoryController value) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	protected void Show(Item item, InventoryController inventoryController) { }

	protected override void ToggleChangedHandler() { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private void Update() { }

	protected override void UpdateItem(Item newItem) { }

	protected void UpdateManipulation(DropdownManipulation manipulation) { }

	private void UpdateNameLabel() { }

	protected void UpdatePositions() { }

	protected override void WeaponUpdate() { }

}

