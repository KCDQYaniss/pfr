namespace EFT.UI;

public sealed class EquipmentBuildsScreen : EftScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__60_2; //Field offset: 0x8
		public static Func <>9__60_1; //Field offset: 0x10
		public static Action <>9__62_0; //Field offset: 0x18
		public static Action <>9__62_1; //Field offset: 0x20
		public static Action <>9__63_1; //Field offset: 0x28
		public static Func <>9__65_0; //Field offset: 0x30
		public static Func <>9__65_1; //Field offset: 0x38
		public static Func <>9__74_0; //Field offset: 0x40
		public static Func <>9__74_1; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal string <FindPresetParts>b__74_0(Item dictKey) { }

		internal int <FindPresetParts>b__74_1(Item dictValue) { }

		internal void <RemoveBuildHandler>b__62_0() { }

		internal void <RemoveBuildHandler>b__62_1() { }

		internal void <RenamePresetHandler>b__63_1() { }

		internal EquipmentBuildWrapper <UpdateBuildList>b__60_1(EquipmentBuild build) { }

		internal MongoID <UpdateBuildList>b__60_2(EquipmentBuild buildToOrder) { }

		internal string <UpdatePreview>b__65_0(Item x) { }

		internal int <UpdatePreview>b__65_1(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public string lastSelectedBuildId; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal bool <Show>b__0(EquipmentBuildWrapper build) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass60_0
	{
		public EquipmentBuildWrapper buildWrapper; //Field offset: 0x10
		public EquipmentBuildsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass60_0() { }

		internal void <UpdateBuildList>g__SubscribeOnEdit|6() { }

		internal void <UpdateBuildList>g__SubscribeOnRemove|5() { }

		internal void <UpdateBuildList>g__SubscribeOnSelect|4(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public EquipmentBuild equipmentBuild; //Field offset: 0x10

		public <>c__DisplayClass63_0() { }

		internal bool <RenamePresetHandler>b__0(EquipmentBuildWrapper item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_0
	{
		public EquipmentBuildsScreen <>4__this; //Field offset: 0x10
		public Dictionary notFoundDict; //Field offset: 0x18
		public Func <>9__3; //Field offset: 0x20
		public Func <>9__5; //Field offset: 0x28

		public <>c__DisplayClass65_0() { }

		internal void <UpdatePreview>b__2() { }

		internal bool <UpdatePreview>b__3(Item itemInsideSlot) { }

		internal bool <UpdatePreview>b__5(Item itemInsideSlot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_1
	{
		public Item itemInsideSlot; //Field offset: 0x10

		public <>c__DisplayClass65_1() { }

		internal bool <UpdatePreview>b__4(string notFoundItemId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass65_2
	{
		public Item itemInsideSlot; //Field offset: 0x10

		public <>c__DisplayClass65_2() { }

		internal bool <UpdatePreview>b__6(string notFoundItemId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public List outOfCollectionItems; //Field offset: 0x10
		public EquipmentBuildsScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass70_0() { }

		internal void <EquipBuild>b__1(bool contained) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_1
	{
		public Item notFoundItem; //Field offset: 0x10

		public <>c__DisplayClass70_1() { }

		internal bool <EquipBuild>b__2(Item item) { }

	}

	[CompilerGenerated]
	private struct <RemoveBuildHandler>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EquipmentBuildsScreen <>4__this; //Field offset: 0x20
		public EquipmentBuild equipmentBuild; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RenamePresetHandler>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EquipmentBuild equipmentBuild; //Field offset: 0x20
		public EquipmentBuildsScreen <>4__this; //Field offset: 0x28
		private <>c__DisplayClass63_0 <>8__1; //Field offset: 0x30
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x38
		private EditBuildNameWindowContext <renameContext>5__3; //Field offset: 0x40
		private Task <acceptResult>5__4; //Field offset: 0x48
		private string <newBuildName>5__5; //Field offset: 0x50
		private EquipmentBuild <foundBuild>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68
		private TaskAwaiter <>u__3; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendOperationsToBackend>d__75 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EquipmentBuildsScreen <>4__this; //Field offset: 0x20
		public IEnumerable results; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class EquipmentBuildsScreenController : EftScreenController
	{
		public readonly IEftSession Session; //Field offset: 0x58
		public readonly BackEndInventoryController InventoryController; //Field offset: 0x60
		public readonly IHealthController HealthController; //Field offset: 0x68
		public readonly InventoryEquipment EquipmentToApply; //Field offset: 0x70
		[CompilerGenerated]
		private string <LastSelectedBuildId>k__BackingField; //Field offset: 0x78
		[CompilerGenerated]
		private EEquipmentBuildType <LastEquipmentBuildType>k__BackingField; //Field offset: 0x80

		public private EEquipmentBuildType LastEquipmentBuildType
		{
			[CompilerGenerated]
			 get { } //Length: 7
			[CompilerGenerated]
			private set { } //Length: 7
		}

		public private string LastSelectedBuildId
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public EquipmentBuildsScreenController(IEftSession session, BackEndInventoryController inventoryController, IHealthController healthController, InventoryEquipment equipmentToApply) { }

		protected virtual void CloseAction(bool moveForward) { }

		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		[CompilerGenerated]
		public EEquipmentBuildType get_LastEquipmentBuildType() { }

		[CompilerGenerated]
		public string get_LastSelectedBuildId() { }

		public virtual EEftScreenType get_ScreenType() { }

		[CompilerGenerated]
		private void set_LastEquipmentBuildType(EEquipmentBuildType value) { }

		[CompilerGenerated]
		private void set_LastSelectedBuildId(string value) { }

	}

	private sealed class EquipmentBuildsTabController : SimpleTabController
	{
		private readonly EquipmentBuildsScreen _screen; //Field offset: 0x10
		private readonly EEquipmentBuildType _equipmentBuildType; //Field offset: 0x18

		public EquipmentBuildsTabController(EquipmentBuildsScreen screen, EEquipmentBuildType equipmentBuildType) { }

		public virtual void Show() { }

	}

	private sealed class EquipmentBuildWrapper : BuildWrapper
	{

		public EquipmentBuildWrapper(EquipmentBuild equipmentBuild) { }

	}

	public const string EQUIPMENT_BUILD_REPLACE_WARNING = "EquipmentBuild/ReplaceMessage"; //Field offset: 0x0
	public const string EQUIPMENT_BUILD_NAME_WINDOW_CAPTION = "EquipmentBuild/SetNameWindowCaption"; //Field offset: 0x0
	public const string EQUIPMENT_BUILD_NAME_WINDOW_PLACEHOLDER = "EquipmentBuild/SetNameWindowPlaceholder"; //Field offset: 0x0
	public const string EQUIPMENT_BUILD_SAVED_NOTIFICATION = "EquipmentBuilds/PresetSaved"; //Field offset: 0x0
	private const string EQUIPMENT_BUILD_DELETE_WARNING = "EquipmentBuild/RemoveMessage"; //Field offset: 0x0
	private const string EQUIPMENT_BUILD_RENAMED_NOTIFICATION = "EquipmentBuilds/PresetRenamed"; //Field offset: 0x0
	private const string EQUIPMENT_BUILD_REMOVED_NOTIFICATION = "EquipmentBuilds/PresetRemoved"; //Field offset: 0x0
	private readonly EquipmentSlot[] _equipmentTabSlots; //Field offset: 0xA0
	private readonly EquipmentSlot[] _containerTabSlots; //Field offset: 0xA8
	[SerializeField]
	private DefaultUIButton _backButton; //Field offset: 0xB0
	[SerializeField]
	private Button _alternativeBackButton; //Field offset: 0xB8
	[SerializeField]
	private TMP_InputField _searchInputField; //Field offset: 0xC0
	[SerializeField]
	private DefaultUIButton _equipButton; //Field offset: 0xC8
	[SerializeField]
	private DefaultUIButton _exchangeButton; //Field offset: 0xD0
	[SerializeField]
	private TextMeshProUGUI _buildName; //Field offset: 0xD8
	[SerializeField]
	private HealthParameterPanel _weight; //Field offset: 0xE0
	[SerializeField]
	private RectTransform _buildsListContainer; //Field offset: 0xE8
	[SerializeField]
	private EquipmentBuildListView _buildListViewTemplate; //Field offset: 0xF0
	[SerializeField]
	private EquipmentBuildGear _equipmentPanel; //Field offset: 0xF8
	[SerializeField]
	private ContainersPanel _containersPanel; //Field offset: 0x100
	[SerializeField]
	private PlayerModelView _playerModelView; //Field offset: 0x108
	[SerializeField]
	private XCoordRotation _rotator; //Field offset: 0x110
	[SerializeField]
	private DragTrigger _dragTrigger; //Field offset: 0x118
	[SerializeField]
	private Image _equipBuildIcon; //Field offset: 0x120
	[SerializeField]
	private Sprite _canEquip; //Field offset: 0x128
	[SerializeField]
	private Sprite _cantEquip; //Field offset: 0x130
	[Header("Build tabs")]
	[SerializeField]
	private Tab _standardBuildsTab; //Field offset: 0x138
	[SerializeField]
	private Tab _customBuildsTab; //Field offset: 0x140
	[Header("Equipment tabs")]
	[SerializeField]
	private TabWithValidationColors _slotsTab; //Field offset: 0x148
	[SerializeField]
	private TabWithValidationColors _containersTab; //Field offset: 0x150
	private IEftSession _session; //Field offset: 0x158
	private EquipmentBuildsStorage _buildStorage; //Field offset: 0x160
	private BackEndInventoryController _realInventoryController; //Field offset: 0x168
	private InventoryController _fakeInventoryController; //Field offset: 0x170
	private EquipmentBuild _currentBuild; //Field offset: 0x178
	private ItemUiContext _itemUiContext; //Field offset: 0x180
	private List _buildList; //Field offset: 0x188
	private readonly CompositeDisposable _buildListDisposable; //Field offset: 0x190
	private string _filter; //Field offset: 0x198
	private TabGroup _equipmentTabs; //Field offset: 0x1A0
	private EquipmentBuildItemContext _equipmentContext; //Field offset: 0x1A8
	private Profile _profile; //Field offset: 0x1B0
	private SkillManager _skills; //Field offset: 0x1B8
	private float _lowOverweight; //Field offset: 0x1C0
	private float _highOverweight; //Field offset: 0x1C4
	private bool _isElite; //Field offset: 0x1C8
	private AsyncViewList _views; //Field offset: 0x1D0
	private TabGroup _buildTypesTabGroup; //Field offset: 0x1D8
	private EEquipmentBuildType _currentBuildTabType; //Field offset: 0x1E0
	private Dictionary _buildTypesTabDictionary; //Field offset: 0x1E8
	private bool _isApplying; //Field offset: 0x1F0
	private InventoryEquipment _applyToEquipment; //Field offset: 0x1F8

	public EquipmentBuildsScreen() { }

	[CompilerGenerated]
	private void <Awake>b__55_0() { }

	[CompilerGenerated]
	private void <Awake>b__55_1() { }

	[CompilerGenerated]
	private void <Awake>b__55_2(string arg) { }

	[CompilerGenerated]
	private bool <CheckFilter>b__58_0(EquipmentBuildWrapper item) { }

	[CompilerGenerated]
	private void <EquipBuild>b__70_0() { }

	[CompilerGenerated]
	private void <ShowPreview>b__66_0() { }

	[CompilerGenerated]
	private void <ShowPreview>b__66_1() { }

	[CompilerGenerated]
	private bool <UpdateBuildList>b__60_0(EquipmentBuild build) { }

	[CompilerGenerated]
	private void <UpdateBuildList>b__60_3(EquipmentBuildWrapper equipmentBuildWrapper, EquipmentBuildListView view) { }

	private void ApplyBuild(EquipmentBuild build) { }

	[UsedImplicitly]
	private void Awake() { }

	private void CheckFilter() { }

	public virtual void Close() { }

	private void DragHandler(PointerEventData pointerData) { }

	private void EquipBuild() { }

	private void FindPresetParts(IReadOnlyCollection itemsToBuy) { }

	private void GetItemsToWorkWith(Inventory inventory, EquipmentBuild build, out CompoundItem applyFrom, out InventoryEquipment presetItem) { }

	private IEnumerable GetTransferIgnoreSlotsLists(EEquipmentBuildType buildType) { }

	private PlayerVisualRepresentation GetVisualEquipmentState() { }

	[AsyncStateMachine(typeof(<RemoveBuildHandler>d__62))]
	private Task RemoveBuildHandler(EquipmentBuild equipmentBuild) { }

	[AsyncStateMachine(typeof(<RenamePresetHandler>d__63))]
	private Task RenamePresetHandler(EquipmentBuild equipmentBuild) { }

	private void SelectBuildHandler(EquipmentBuild selectedBuild) { }

	[AsyncStateMachine(typeof(<SendOperationsToBackend>d__75))]
	private Task SendOperationsToBackend(IEnumerable results) { }

	private void SetCurrentBuild(EquipmentBuild equipmentBuild) { }

	public virtual void Show(EquipmentBuildsScreenController controller) { }

	private void Show(IEftSession session, BackEndInventoryController inventoryController, IHealthController healthController, InventoryEquipment equipmentToApply) { }

	private void ShowPreview(PlayerVisualRepresentation visualRepresentation) { }

	private void SwapEquipment() { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private bool TryApplyBuild(out List notFoundItems, out Error error) { }

	private void UpdateBuildList() { }

	private void UpdateBuildListActiveTab(EEquipmentBuildType buildType) { }

	private void UpdatePreview(IEnumerable notFoundItems) { }

}

