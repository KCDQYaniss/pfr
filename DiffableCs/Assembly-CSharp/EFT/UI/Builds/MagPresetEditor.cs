namespace EFT.UI.Builds;

[UsedImplicitly]
public sealed class MagPresetEditor : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__39_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <ValidateLoop>b__39_0(MagPresetItem item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public AmmoPresetView ammoView; //Field offset: 0x10
		public MagPresetEditor <>4__this; //Field offset: 0x18

		public <>c__DisplayClass26_0() { }

		internal void <Show>b__0(MagPresetItem presetItem) { }

		internal void <Show>b__1() { }

		internal void <Show>b__2() { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__GetCaliberName; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <GetAvailableAmmo>d__43 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MagPresetEditor <>4__this; //Field offset: 0x28
		private string <caliber>5__2; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x38

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetAvailableAmmo>d__43(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const string MAG_PRESET_CALIBER_NOT_SELECTED = "MagPreset/CaliberNotSelected"; //Field offset: 0x0
	private const string MAG_PRESET_EMPTY_LOOP_WARNING_TOOLTIP = "UI/MagPreset/EmptyLoop"; //Field offset: 0x0
	private const string MAG_PRESET_LOOP_TOOLTIP = "UI/MagPreset/LoopAmmo"; //Field offset: 0x0
	private readonly BindableEvent _onPresetUpdate; //Field offset: 0x70
	private readonly BindableEvent _onCaliberSelected; //Field offset: 0x78
	[SerializeField]
	private TMP_InputField _presetNameInput; //Field offset: 0x80
	[SerializeField]
	private CanvasGroup _presetNameCanvasGroup; //Field offset: 0x88
	[SerializeField]
	private BaseDropDownBox _caliberSelector; //Field offset: 0x90
	[SerializeField]
	private HoverTooltipArea _loopTooltip; //Field offset: 0x98
	[SerializeField]
	private AmmoPresetView[] _ammoViews; //Field offset: 0xA0
	[SerializeField]
	private CompositionGroup _topGroup; //Field offset: 0xA8
	[SerializeField]
	private CompositionGroup _loopGroup; //Field offset: 0xC0
	[SerializeField]
	private CompositionGroup _bottomGroup; //Field offset: 0xD8
	private MagBuildsStorage _storage; //Field offset: 0xF0
	private MagPreset _currentPreset; //Field offset: 0xF8
	private ItemFilter[] _filters; //Field offset: 0x100
	private IEnumerable _calibers; //Field offset: 0x108
	private readonly CompositeDisposable _presetDisposable; //Field offset: 0x110

	public IBindableEvent OnCaliberSelected
	{
		 get { } //Length: 5
	}

	public IBindableEvent OnPresetUpdate
	{
		 get { } //Length: 5
	}

	public MagPreset Preset
	{
		 get { } //Length: 8
	}

	public string PresetName
	{
		 get { } //Length: 33
	}

	public MagPresetEditor() { }

	[CompilerGenerated]
	private void <CompositionChangeHandler>g__PositionViews|38_0(int fromIndex, int toIndex, CompositionGroup group) { }

	[CompilerGenerated]
	private void <SetPreset>b__27_0() { }

	[CompilerGenerated]
	private void <Show>b__26_3(MagPresetItem presetItem) { }

	private void CaliberDropdownChangeHandler(int caliberIndex) { }

	public virtual void Close() { }

	private void CompositionChangeHandler() { }

	public IBindableEvent get_OnCaliberSelected() { }

	public IBindableEvent get_OnPresetUpdate() { }

	public MagPreset get_Preset() { }

	public string get_PresetName() { }

	[IteratorStateMachine(typeof(<GetAvailableAmmo>d__43))]
	private IEnumerable GetAvailableAmmo() { }

	private static string GetCaliberName(string caliber) { }

	private void ItemCountHandler() { }

	private void ItemMoveDownHandler(AmmoPresetView view) { }

	private void ItemMoveUpHandler(AmmoPresetView view) { }

	private void ItemSelectionHandler(AmmoPresetView view, MagPresetItem presetItem) { }

	private void PresetCaliberChangeHandler() { }

	private void PresetItemChangeHandler(int itemIndex) { }

	private void PresetNameChangeHandler() { }

	private void PresetNameInputHandler(string newName) { }

	public void SetFilters(ItemFilter[] filters) { }

	public void SetNewCaliber(string caliber) { }

	public void SetPreset(MagPreset preset) { }

	public void Show(MagBuildsStorage storage) { }

	private void SwapItems(int index1, int index2) { }

	private void UpdateButtonsState() { }

	private void ValidateLoop() { }

}

