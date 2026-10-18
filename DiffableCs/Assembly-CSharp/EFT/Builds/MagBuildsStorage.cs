namespace EFT.Builds;

public sealed class MagBuildsStorage
{
	[CompilerGenerated]
	private struct <DeletePreset>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MagBuildsStorage <>4__this; //Field offset: 0x20
		public MongoID presetId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <GetAvailableAmmo>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Ammo <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public MagBuildsStorage <>4__this; //Field offset: 0x28
		private string caliber; //Field offset: 0x30
		public string <>3__caliber; //Field offset: 0x38
		private Profile <profile>5__2; //Field offset: 0x40
		private IEnumerator <>7__wrap2; //Field offset: 0x48

		private override Ammo System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Ammo>.Current
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
		public <GetAvailableAmmo>d__16(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Ammo>.GetEnumerator() { }

		[DebuggerHidden]
		private override Ammo System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Ammo>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <SavePreset>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public bool rename; //Field offset: 0x20
		public MagBuildsStorage <>4__this; //Field offset: 0x28
		public MagPreset preset; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class PresetSourceError : Error
	{
		private readonly Item _item; //Field offset: 0x10

		public PresetSourceError(Item item) { }

		public virtual string ToString() { }

	}

	public const int MAX_PRESETS_COUNT = 30; //Field offset: 0x0
	public const int MAX_PRESETS_PER_CALIBER_COUNT = 5; //Field offset: 0x0
	private const string DEFAULT_PRESET_NAME = ""; //Field offset: 0x0
	public Action OnPresetAdded; //Field offset: 0x10
	public Action OnPresetRemoved; //Field offset: 0x18
	private readonly IEftSession _session; //Field offset: 0x20
	private readonly List _presets; //Field offset: 0x28
	private readonly IReadOnlyDictionary _ammoByTemplate; //Field offset: 0x30
	private readonly IReadOnlyDictionary _ammoByCaliber; //Field offset: 0x38
	private readonly HashSet _availableCalibers; //Field offset: 0x40

	public IEnumerable Presets
	{
		 get { } //Length: 5
	}

	public MagBuildsStorage(IEftSession session, List presets) { }

	public MagPreset CreateNewPreset() { }

	[AsyncStateMachine(typeof(<DeletePreset>d__23))]
	public Task DeletePreset(MongoID presetId) { }

	public IEnumerable get_Presets() { }

	public Ammo GetAmmoByTemplate(MongoID templateId) { }

	public AmmoTemplate GetAmmoTemplate(MongoID templateId) { }

	[IteratorStateMachine(typeof(<GetAvailableAmmo>d__16))]
	public IEnumerable GetAvailableAmmo(string caliber) { }

	public IEnumerable GetAvailableCalibers() { }

	public static string GetCaliberName(string caliber) { }

	public string GetDefaultPresetName() { }

	[AsyncStateMachine(typeof(<SavePreset>d__22))]
	public Task SavePreset(MagPreset preset, bool rename) { }

	public void SearchBuildOnRagfair(BuildItemSearchValue buildSearch) { }

	public bool TryFindPresetById(MongoID id, out MagPreset preset) { }

	public bool TryFindPresetByName(string name, out MagPreset preset) { }

	public static Option TryFindPresetSource(Item selectedItem) { }

}

