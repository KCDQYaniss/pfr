namespace EFT.UI.Builds;

[UsedImplicitly]
public sealed class MagPresetsListView : UIElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public MagPresetsListView <>4__this; //Field offset: 0x10
		public MagPresetWrapper wrapper; //Field offset: 0x18

		public <>c__DisplayClass25_0() { }

		internal void <PresetAddedHandler>b__0() { }

		internal void <PresetAddedHandler>b__1() { }

		internal void <PresetAddedHandler>g__SubscribeOnSelect|2(bool selected) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public MagPreset preset; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <TryGetWrapper>b__0(MagPresetWrapper existingWrapper) { }

	}

	private sealed class MagPresetWrapper : BuildWrapper
	{
		public readonly CompositeDisposable Disposable; //Field offset: 0x40
		[CompilerGenerated]
		private MagPresetView <View>k__BackingField; //Field offset: 0x48

		public private MagPresetView View
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public MagPresetWrapper(MagBuildsStorage storage, MagPreset preset, MagPresetView view) { }

		public void Dispose(ICollection viewPool) { }

		[CompilerGenerated]
		public MagPresetView get_View() { }

		[CompilerGenerated]
		private void set_View(MagPresetView value) { }

	}

	[SerializeField]
	private ValidationInputField _searchField; //Field offset: 0x70
	[SerializeField]
	private MagPresetView _presetViewTemplate; //Field offset: 0x78
	[SerializeField]
	private RectTransform _container; //Field offset: 0x80
	[SerializeField]
	private TMP_Text _presetCountField; //Field offset: 0x88
	[SerializeField]
	private TMP_Text _presetMaxCountField; //Field offset: 0x90
	private readonly BindableEvent _onSelected; //Field offset: 0x98
	private readonly BindableEvent _onDelete; //Field offset: 0xA0
	private readonly BindableEvent _onRename; //Field offset: 0xA8
	private MagBuildsStorage _storage; //Field offset: 0xB0
	private List _presets; //Field offset: 0xB8
	private List _presetViewsPool; //Field offset: 0xC0
	private Nullable _currentPresetId; //Field offset: 0xC8

	public IBindableEvent OnDelete
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnRename
	{
		 get { } //Length: 8
	}

	public IBindableEvent OnSelected
	{
		 get { } //Length: 8
	}

	public MagPresetsListView() { }

	[CompilerGenerated]
	private void <Show>b__19_0() { }

	public virtual void Close() { }

	public IBindableEvent get_OnDelete() { }

	public IBindableEvent get_OnRename() { }

	public IBindableEvent get_OnSelected() { }

	private void PresetAddedHandler(MagPreset preset) { }

	private void PresetRemovedHandler(MagPreset preset) { }

	private void RemovePresetClickHandler(MagPresetWrapper presetWrapper) { }

	private void RenamePresetHandler(MagPresetWrapper presetWrapper) { }

	private void SearchHandler(string text) { }

	private void SelectPresetHandler(MagPresetWrapper presetWrapper) { }

	public void SetPresetAsSelected(MagPreset preset) { }

	public void Show(MagBuildsStorage storage, Nullable currentPresetId) { }

	private bool TryGetWrapper(MagPreset preset, out MagPresetWrapper wrapper) { }

	private void UpdatePresetsCount() { }

}

