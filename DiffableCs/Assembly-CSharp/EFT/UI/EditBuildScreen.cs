namespace EFT.UI;

[UsedImplicitly]
public sealed class EditBuildScreen : ItemObserveScreen
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction <>9__59_2; //Field offset: 0x8
		public static Func <>9__62_0; //Field offset: 0x10
		public static Func <>9__62_1; //Field offset: 0x18
		public static Action <>9__66_1; //Field offset: 0x20
		public static Action <>9__67_2; //Field offset: 0x28
		public static Action <>9__69_0; //Field offset: 0x30
		public static Func <>9__70_0; //Field offset: 0x38
		public static Func <>9__71_0; //Field offset: 0x40
		public static Func <>9__71_1; //Field offset: 0x48
		public static Action <>9__73_1; //Field offset: 0x50

		private static <>c() { }

		public <>c() { }

		internal void <Awake>b__59_2() { }

		internal bool <CreateBuildManipulation>b__62_0(Mod item) { }

		internal Mod <CreateBuildManipulation>b__62_1(Mod playerItem) { }

		internal void <CreateNewBuild>b__66_1() { }

		internal void <DeleteButtonHandler>b__73_1() { }

		internal MongoID <FindBuildParts>b__70_0(Item y) { }

		internal Item <GetItemsInBuild>b__71_0(Slot slot) { }

		internal bool <GetItemsInBuild>b__71_1(Item x) { }

		internal void <OpenBuild>b__67_2() { }

		internal void <SaveAsBuild>b__69_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public bool inProgress; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal void <Show>b__5(Transform _, ModdingScreenSlotView view) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public WeaponBuild build; //Field offset: 0x10
		public EditBuildScreen <>4__this; //Field offset: 0x18

		public <>c__DisplayClass67_0() { }

		internal void <OpenBuild>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public Dictionary buildItems; //Field offset: 0x10
		public Func <>9__1; //Field offset: 0x18

		public <>c__DisplayClass70_0() { }

		internal bool <FindBuildParts>b__1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_1
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass70_1() { }

		internal bool <FindBuildParts>b__2(MongoID z) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass73_0
	{
		private struct <<DeleteButtonHandler>g__DeleteBuildHandler|2>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass73_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public EditBuildScreen <>4__this; //Field offset: 0x10
		public MongoID buildId; //Field offset: 0x18

		public <>c__DisplayClass73_0() { }

		internal void <DeleteButtonHandler>b__0() { }

		[AsyncStateMachine(typeof(<<DeleteButtonHandler>g__DeleteBuildHandler|2>d))]
		internal Task <DeleteButtonHandler>g__DeleteBuildHandler|2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass76_0
	{
		public EditBuildScreen <>4__this; //Field offset: 0x10
		public List alreadyInstalledMods; //Field offset: 0x18

		public <>c__DisplayClass76_0() { }

		internal void <TryToAssembleBuild>b__0() { }

		internal void <TryToAssembleBuild>b__1(bool arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass84_0
	{
		public Item newItem; //Field offset: 0x10

		public <>c__DisplayClass84_0() { }

		internal bool <UpdateItem>b__0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass88_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass88_0() { }

		internal void <TryCloseScreen>b__0() { }

		internal void <TryCloseScreen>b__1() { }

	}

	[CompilerGenerated]
	private struct <PerformAssemble>d__77 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EditBuildScreen <>4__this; //Field offset: 0x20
		public IEnumerable alreadyInstalledMods; //Field offset: 0x28
		private Weapon <buildWeapon>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveAsBuild>d__69 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EditBuildScreen <>4__this; //Field offset: 0x20
		public bool asNewBuild; //Field offset: 0x28
		private MongoID <nextBuildId>5__2; //Field offset: 0x30
		private string <newBuildName>5__3; //Field offset: 0x48
		private WeaponBuild <newBuild>5__4; //Field offset: 0x50
		private Task <acceptResult>5__5; //Field offset: 0x58
		private WeaponBuild <foundBuild>5__6; //Field offset: 0x60
		private TaskAwaiter <>u__1; //Field offset: 0x68
		private TaskAwaiter <>u__2; //Field offset: 0x70
		private TaskAwaiter <>u__3; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class EditBuildScreenController : EftScreenController
	{
		[CompilerGenerated]
		private struct <CloseScreenInterruption>d__17 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public EditBuildScreenController <>4__this; //Field offset: 0x20
			public bool moveForward; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public readonly InventoryController InventoryController; //Field offset: 0x58
		public readonly IEftSession Session; //Field offset: 0x60
		private bool _queuePreviousScreen; //Field offset: 0x68
		private Item _item; //Field offset: 0x70
		public Item BuildItem; //Field offset: 0x78

		protected virtual EStateSwitcher EnvironmentOverlay
		{
			 get { } //Length: 6
		}

		public Item Item
		{
			 get { } //Length: 5
			 set { } //Length: 94
		}

		public Profile Profile
		{
			 get { } //Length: 75
		}

		protected virtual bool QueuePreviousScreen
		{
			 get { } //Length: 5
		}

		public virtual EEftScreenType ScreenType
		{
			 get { } //Length: 6
		}

		public EditBuildScreenController(Item item, InventoryController inventoryController, IEftSession session) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(bool moveForward) { }

		[AsyncStateMachine(typeof(<CloseScreenInterruption>d__17))]
		protected virtual Task CloseScreenInterruption(bool moveForward) { }

		protected virtual EStateSwitcher get_EnvironmentOverlay() { }

		public Item get_Item() { }

		public Profile get_Profile() { }

		protected virtual bool get_QueuePreviousScreen() { }

		public virtual EEftScreenType get_ScreenType() { }

		public void set_Item(Item value) { }

	}

	private const string REPLACE_WEAPON_BUILD_WARNING = "Build with the same name will be replaced. Continue?"; //Field offset: 0x0
	private const string DELETE_WEAPON_BUILD_WARNING = "Are you sure you want to delete this build?"; //Field offset: 0x0
	private const string WEAPON_BUILD_NAME_WINDOW_CAPTION = "WeaponBuild/SetNameWindowCaption"; //Field offset: 0x0
	private const string WEAPON_BUILD_NAME_WINDOW_PLACEHOLDER = "WeaponBuild/SetNameWindowPlaceholder"; //Field offset: 0x0
	private const string DISCARD_CHANGES_WARNING = "Are you sure you want to discard your changes?"; //Field offset: 0x0
	private const string WEAPON_HAS_BEEN_BUILT = "Weapon has been built"; //Field offset: 0x0
	[SerializeField]
	private Toggle _onlyAvailableToggle; //Field offset: 0x180
	[SerializeField]
	private Button _newBuildButton; //Field offset: 0x188
	[SerializeField]
	private Button _openBuildButton; //Field offset: 0x190
	[SerializeField]
	private HoverTooltipArea _saveAsHoverArea; //Field offset: 0x198
	[SerializeField]
	private Button _saveAsBuildButton; //Field offset: 0x1A0
	[SerializeField]
	private CanvasGroup _selectItemHoverArea; //Field offset: 0x1A8
	[SerializeField]
	private Button _selectItemButton; //Field offset: 0x1B0
	[SerializeField]
	private CanvasGroup _findPartsHoverArea; //Field offset: 0x1B8
	[SerializeField]
	private Button _findPartsButton; //Field offset: 0x1C0
	[SerializeField]
	private Button _publishButton; //Field offset: 0x1C8
	[SerializeField]
	private Button _deleteBuildButton; //Field offset: 0x1D0
	[SerializeField]
	private CanvasGroup _deleteCanvasGroup; //Field offset: 0x1D8
	[SerializeField]
	private ButtonWithHint _saveButton; //Field offset: 0x1E0
	[SerializeField]
	private HoverTooltipArea _saveHoverArea; //Field offset: 0x1E8
	[SerializeField]
	private ButtonWithHint _assembleButton; //Field offset: 0x1F0
	[SerializeField]
	private HoverTooltipArea _assembleHoverArea; //Field offset: 0x1F8
	[SerializeField]
	private ValidationInputField _buildName; //Field offset: 0x200
	[SerializeField]
	private GameObject _itemReadyToAssemble; //Field offset: 0x208
	[SerializeField]
	private Button _itemReadyToAssembleButton; //Field offset: 0x210
	[SerializeField]
	private OpenBuildWindow _openBuildWindow; //Field offset: 0x218
	[SerializeField]
	private SelectWeaponBodyWindow _selectWeaponBodyWindow; //Field offset: 0x220
	private readonly BindableState _itemChanged; //Field offset: 0x228
	private readonly BindableState _anyMissingParts; //Field offset: 0x230
	private readonly BindableState _canDelete; //Field offset: 0x238
	private readonly BindableState _savingInProgress; //Field offset: 0x240
	private readonly BindableState _assemblingInProgress; //Field offset: 0x248
	private readonly BindableState _assemblingAvailable; //Field offset: 0x250
	[CanBeNull]
	private Item _itemBody; //Field offset: 0x258
	private ItemFactory _itemFactory; //Field offset: 0x260
	private RagFair _ragfair; //Field offset: 0x268
	private Handbook _handbook; //Field offset: 0x270
	private WeaponBuildsStorage _buildsStorage; //Field offset: 0x278
	[CanBeNull]
	private WeaponBuild _selectedBuild; //Field offset: 0x280
	private ItemController _allItemsFakeController; //Field offset: 0x288
	private EditBuildManipulation _useAllManipulation; //Field offset: 0x290
	private DropdownManipulation _useAvailableManipulation; //Field offset: 0x298
	private IEftSession _session; //Field offset: 0x2A0
	private List _playerItems; //Field offset: 0x2A8
	private Item[] _acceptableWeaponBodies; //Field offset: 0x2B0
	private ItemAddress _weaponUnlimitedContainer; //Field offset: 0x2B8
	private Profile _profile; //Field offset: 0x2C0
	private EditBuildNameWindowContext _buildNameWindowContext; //Field offset: 0x2C8

	private string AssembleHoverErrorText
	{
		private get { } //Length: 136
	}

	private IBindable DisplayAssembleButton
	{
		private get { } //Length: 171
	}

	private IBindable DisplaySaveButton
	{
		private get { } //Length: 405
	}

	private ItemFactory ItemFactory
	{
		private get { } //Length: 154
	}

	private string SaveHoverErrorText
	{
		private get { } //Length: 514
	}

	public EditBuildScreen() { }

	[CompilerGenerated]
	private void <Awake>b__59_0() { }

	[CompilerGenerated]
	private void <Awake>b__59_1() { }

	[CompilerGenerated]
	private void <Awake>b__59_3() { }

	[CompilerGenerated]
	private void <Awake>b__59_4(bool arg) { }

	[CompilerGenerated]
	private void <CreateNewBuild>b__66_0() { }

	[CompilerGenerated]
	private bool <get_DisplayAssembleButton>b__58_0(bool isAssembling, bool isAssemblingAvailable) { }

	[CompilerGenerated]
	private bool <get_DisplaySaveButton>b__56_0(bool changed, bool missingParts, bool isSaving) { }

	[CompilerGenerated]
	private bool <GetMissingBuildItems>b__72_0(Item x) { }

	[CompilerGenerated]
	private void <OpenBuild>b__67_0(WeaponBuild build) { }

	[CompilerGenerated]
	private void <OpenSelectBodyWindow>b__75_0(Weapon selectedWeapon) { }

	[CompilerGenerated]
	private bool <PerformAssemble>b__77_0() { }

	[CompilerGenerated]
	private void <Show>b__61_0(bool arg) { }

	[CompilerGenerated]
	private void <Show>b__61_1(bool arg) { }

	[CompilerGenerated]
	private void <Show>b__61_2(bool arg) { }

	[CompilerGenerated]
	private void <Show>b__61_3(bool anyMissing) { }

	[CompilerGenerated]
	private void <Show>b__61_4(bool inProgress) { }

	private void AddOrRemoveFromItem() { }

	protected virtual void Awake() { }

	protected virtual void CheckForVitalParts() { }

	public virtual void Close() { }

	protected virtual DropdownManipulation CreateBuildManipulation() { }

	private ItemController CreateFakeController(IEnumerable items) { }

	private void CreateNewBuild() { }

	private void DeleteButtonHandler() { }

	private void FindBuildParts(bool onlyContained, List alreadyInstalledMods) { }

	private string get_AssembleHoverErrorText() { }

	private IBindable get_DisplayAssembleButton() { }

	private IBindable get_DisplaySaveButton() { }

	private ItemFactory get_ItemFactory() { }

	private string get_SaveHoverErrorText() { }

	private List GetItemsInBuild() { }

	private List GetMissingBuildItems(List alreadyInstalledMods) { }

	private bool IsAcceptableItem(Item itemToCheck) { }

	private bool IsAcceptableMod(Item itemToCheck) { }

	private void OpenBuild(WeaponBuild build) { }

	private void OpenBuild() { }

	private void OpenSelectBodyWindow(bool force) { }

	private void OpenSelectBodyWindow() { }

	[AsyncStateMachine(typeof(<PerformAssemble>d__77))]
	private Task PerformAssemble(IEnumerable alreadyInstalledMods) { }

	[AsyncStateMachine(typeof(<SaveAsBuild>d__69))]
	private Task SaveAsBuild(bool asNewBuild = true) { }

	private void SetItemReadyToAssembleActive(bool readyToAssemble, bool noMissingMods = false) { }

	private void SetSelectedBuild(WeaponBuild build) { }

	private void Show(Item itemBody, Item buildItem, InventoryController inventoryController, IEftSession session) { }

	public virtual void Show(EditBuildScreenController controller) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	private Task TryCloseScreen() { }

	private void TryShowMessage(bool autoAccept, string message, Action acceptAction, Action cancelAction = null) { }

	private void TryToAssembleBuild() { }

	protected virtual void UpdateItem(Item newItem) { }

	private void UpdateItemBody(Item newBody) { }

	private void UpdateManipulationItems() { }

	protected virtual void WeaponUpdate() { }

}

