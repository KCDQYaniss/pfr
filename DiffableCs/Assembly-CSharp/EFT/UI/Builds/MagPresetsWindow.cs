namespace EFT.UI.Builds;

[UsedImplicitly]
public sealed class MagPresetsWindow : Window, ISelectionContext
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__46_0; //Field offset: 0x8
		public static Action <>9__46_1; //Field offset: 0x10
		public static Func <>9__47_0; //Field offset: 0x18
		public static Func <>9__58_0; //Field offset: 0x20
		public static Func <>9__58_1; //Field offset: 0x28
		public static Action <>9__59_0; //Field offset: 0x30
		public static Action <>9__59_1; //Field offset: 0x38
		public static Action <>9__61_1; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal string <BuyPresetParts>b__58_0(KeyValuePair itemData) { }

		internal int <BuyPresetParts>b__58_1(KeyValuePair itemData) { }

		internal bool <CaliberSelectHandler>b__47_0(MagPresetItem item) { }

		internal void <RemovePresetHandler>b__59_0() { }

		internal void <RemovePresetHandler>b__59_1() { }

		internal void <ShowDiscardChangesWarning>b__46_0() { }

		internal void <ShowDiscardChangesWarning>b__46_1() { }

		internal void <TrySavePreset>b__61_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public MagPresetsWindow <>4__this; //Field offset: 0x10
		public InventoryController controller; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <Show>b__0(MagPreset preset) { }

		internal void <Show>b__1(MagPreset preset) { }

		internal void <Show>b__2(MagPreset preset) { }

		internal void <Show>b__3(string caliber) { }

		internal void <Show>b__4() { }

		internal void <Show>b__5() { }

		internal void <Show>b__6() { }

		internal void <Show>b__7() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public MagPreset preset; //Field offset: 0x10
		public MagPreset conflictingPreset; //Field offset: 0x18

		public <>c__DisplayClass56_0() { }

		internal bool <UpdateButtonsState>b__0(MagPreset foundPreset) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass57_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass57_0() { }

		internal void <LoadMagClickHandler>b__0() { }

		internal void <LoadMagClickHandler>b__1(bool contained) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public MagPreset preset; //Field offset: 0x10

		public <>c__DisplayClass61_0() { }

		internal bool <TrySavePreset>b__0(MagPreset oldPreset) { }

	}

	[CompilerGenerated]
	private struct <CaliberSelectHandler>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPresetsWindow <>4__this; //Field offset: 0x20
		public string caliber; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ItemSelectionHandler>d__50 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPresetsWindow <>4__this; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadMagClickHandler>d__57 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPresetsWindow <>4__this; //Field offset: 0x20
		private MagPreset <preset>5__2; //Field offset: 0x28
		private IReadOnlyDictionary <missingItems>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private IDisposable <>7__wrap3; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RemovePresetHandler>d__59 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPreset preset; //Field offset: 0x20
		public MagPresetsWindow <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RenamePresetHandler>d__62 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPreset preset; //Field offset: 0x20
		public MagPresetsWindow <>4__this; //Field offset: 0x28
		private EditBuildNameWindowContext <renameContext>5__2; //Field offset: 0x30
		private Task <acceptResult>5__3; //Field offset: 0x38
		private string <newName>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SavePresetHandler>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPresetsWindow <>4__this; //Field offset: 0x20
		public MagPreset preset; //Field offset: 0x28
		private IDisposable <>7__wrap1; //Field offset: 0x30
		private MagPreset <previousBackup>5__3; //Field offset: 0x38
		private Task <saveTask>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SelectAmmo>d__53 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPresetsWindow <>4__this; //Field offset: 0x20
		public Ammo selectedAmmo; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SelectPresetHandler>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPresetsWindow <>4__this; //Field offset: 0x20
		public bool forced; //Field offset: 0x28
		public MagPreset preset; //Field offset: 0x30
		private MagPreset <currentPreset>5__2; //Field offset: 0x38
		private Task <dialogTask>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TrySavePreset>d__61 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagPreset preset; //Field offset: 0x20
		public MagPresetsWindow <>4__this; //Field offset: 0x28
		public bool rename; //Field offset: 0x30
		private <>c__DisplayClass61_0 <>8__1; //Field offset: 0x38
		private MagPreset <conflictingPreset>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct CompositionGroup
	{
		[SerializeField]
		[UsedImplicitly]
		public GameObject View; //Field offset: 0x0
		[SerializeField]
		[UsedImplicitly]
		public RectTransform Container; //Field offset: 0x8
		[SerializeField]
		[UsedImplicitly]
		public GameObject Blocker; //Field offset: 0x10

	}

	private const string MAG_PRESET_SAVED_NOTIFICATION = "MagPreset/PresetSaved{0}"; //Field offset: 0x0
	private const string MAG_PRESET_DISCARD_CHANGES_WARNING_DESCRIPTION = "MagPreset/DiscardCahangesDescription"; //Field offset: 0x0
	private const string MAG_PRESET_HAS_MISSING_ITEMS = "MagPreset/HasMissingItems"; //Field offset: 0x0
	private const string MAG_PRESET_REPLACE_WARNING = "MagPreset/ReplaceMessage"; //Field offset: 0x0
	private const string MAG_PRESET_NAME_WINDOW_CAPTION = "MagPreset/SetNameWindowCaption"; //Field offset: 0x0
	private const string MAG_PRESET_NAME_WINDOW_PLACEHOLDER = "MagPreset/SetNameWindowPlaceholder"; //Field offset: 0x0
	private const string MAG_PRESET_DELETE_CAPTION = "MagPreset/RemoveCaption"; //Field offset: 0x0
	private const string MAG_PRESET_DELETE_WARNING = "MagPreset/RemoveMessage{0}"; //Field offset: 0x0
	private const string MAG_PRESET_NO_MAGS_SELECTED_TOOLTIP = "MagPreset/Tooltip/NoMagsSelected"; //Field offset: 0x0
	private const string MAG_PRESET_DELETED_NOTIFICATION = "MagPreset/PresetRemoved{0}"; //Field offset: 0x0
	private const string MAG_PRESET_RENAMED_NOTIFICATION = "MagPreset/PresetRenamed{0}"; //Field offset: 0x0
	private const string MAG_PRESET_INCOMPATIBLE_AMMO_TOOLTIP = "MagPreset/Tooltip/IncompatibleAmmo"; //Field offset: 0x0
	private const string MAG_PRESET_EMPTY_LOOP_TOOLTIP = "MagPreset/Tooltip/LoopAmmoRequired"; //Field offset: 0x0
	private const string MAG_PRESET_TOTAL_LIMIT_REACHED_TOOLTIP = "MagPreset/Tooltip/TotalLimitReached"; //Field offset: 0x0
	private const string MAG_PRESET_CALIBER_LIMIT_REACHED_TOOLTIP = "MagPreset/Tooltip/CaliberLimitReached"; //Field offset: 0x0
	private const string MAG_PRESET_NO_CHANGES_TOOLTIP = "MagPreset/Tooltip/HasNoChanges"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0xB8
	[SerializeField]
	private MagPresetsListView _presetsList; //Field offset: 0xC0
	[SerializeField]
	private GameObject _presetsContainer; //Field offset: 0xC8
	[SerializeField]
	private MagPresetEditor _presetEditor; //Field offset: 0xD0
	[SerializeField]
	private EntityIcon _magPreview; //Field offset: 0xD8
	[SerializeField]
	private GameObject _emptyIcon; //Field offset: 0xE0
	[SerializeField]
	private DefaultUiButtonNewStyle _saveButton; //Field offset: 0xE8
	[SerializeField]
	private DefaultUiButtonNewStyle _loadMagButton; //Field offset: 0xF0
	[SerializeField]
	private DefaultUiButtonNewStyle _showListButton; //Field offset: 0xF8
	[SerializeField]
	private DefaultUiButtonNewStyle _hideListButton; //Field offset: 0x100
	[SerializeField]
	private CanvasGroup _canvasGroup; //Field offset: 0x108
	private List _selectedMags; //Field offset: 0x110
	private List _removedMags; //Field offset: 0x118
	private Ammo _selectedAmmo; //Field offset: 0x120
	private MagPreset _defaultPreset; //Field offset: 0x128
	private InventoryController _controller; //Field offset: 0x130
	private MagBuildsStorage _storage; //Field offset: 0x138
	private MagPreset _presetBackup; //Field offset: 0x140
	private bool _presetListVisibility; //Field offset: 0x148
	private Task _discardChangesTask; //Field offset: 0x150
	private bool _loadingInProgress; //Field offset: 0x158

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public MagPresetsWindow() { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	private void AddMagazine(Magazine magazine) { }

	private void BuyPresetParts(string presetName, IReadOnlyDictionary itemsToBuy) { }

	[AsyncStateMachine(typeof(<CaliberSelectHandler>d__47))]
	private Task CaliberSelectHandler(string caliber) { }

	private void ClearMags() { }

	protected virtual Task CloseInterruption() { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	private void ItemAddHandler(AddItemEventArgs eventArgs) { }

	private void ItemRemoveHandler(RemoveItemEventArgs eventArgs) { }

	[AsyncStateMachine(typeof(<ItemSelectionHandler>d__50))]
	private Task ItemSelectionHandler(Item item) { }

	[AsyncStateMachine(typeof(<LoadMagClickHandler>d__57))]
	private Task LoadMagClickHandler() { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	private void RemoveMagazine(Magazine magazine, bool updateHighlight) { }

	[AsyncStateMachine(typeof(<RemovePresetHandler>d__59))]
	private Task RemovePresetHandler(MagPreset preset) { }

	[AsyncStateMachine(typeof(<RenamePresetHandler>d__62))]
	private Task RenamePresetHandler(MagPreset preset) { }

	private void SaveClickHandler() { }

	[AsyncStateMachine(typeof(<SavePresetHandler>d__49))]
	private Task SavePresetHandler(MagPreset preset) { }

	[AsyncStateMachine(typeof(<SelectAmmo>d__53))]
	private Task SelectAmmo(Ammo selectedAmmo) { }

	[AsyncStateMachine(typeof(<SelectPresetHandler>d__45))]
	private Task SelectPresetHandler(MagPreset preset, bool forced = false) { }

	private void SetItemSelectedStatus(Item item, bool selected) { }

	private void SetPresetListVisibility(bool visible) { }

	public DialogWindowContext Show(InventorySelectableItemContext itemContext, Nullable presetId, MagBuildsStorage storage, InventoryController controller) { }

	private Task ShowDiscardChangesWarning() { }

	[AsyncStateMachine(typeof(<TrySavePreset>d__61))]
	private Task TrySavePreset(MagPreset preset, bool rename) { }

	private void UpdateButtonsState() { }

	private void UpdateDefaultPreset() { }

	private void UpdateLoadButton() { }

}

