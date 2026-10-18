namespace EFT.UI.Settings;

public abstract class SettingsTab : UIInputNode
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0`1
	{
		public SettingsTab <>4__this; //Field offset: 0x0
		public T instance; //Field offset: 0x0

		public <>c__DisplayClass17_0`1() { }

		internal void <CreateControl>b__0() { }

	}

	[CompilerGenerated]
	private Action OnLoadingInProgress; //Field offset: 0x80
	private List _createdControls; //Field offset: 0x88
	[CompilerGenerated]
	private bool <IsInitialized>k__BackingField; //Field offset: 0x90

	public event Action OnLoadingInProgress
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected private bool IsInitialized
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsSelected
	{
		 set { } //Length: 251
	}

	protected SettingsTab() { }

	[CompilerGenerated]
	public void add_OnLoadingInProgress(Action value) { }

	private void CleanupCreatedControls() { }

	public virtual void Close() { }

	protected T CreateControl(T prefab, Transform parent) { }

	[CompilerGenerated]
	protected bool get_IsInitialized() { }

	protected override void OnFirstSelect() { }

	protected override void OnSelect() { }

	private void OnTabSelected() { }

	[CompilerGenerated]
	public void remove_OnLoadingInProgress(Action value) { }

	private void ResetInitialization() { }

	[CompilerGenerated]
	private void set_IsInitialized(bool value) { }

	public void set_IsSelected(bool value) { }

	protected void SetLoadingStatus(bool inProgress) { }

	protected virtual ECursorResult ShouldLockCursor() { }

	public abstract Task TakeSettingsFrom(SettingsManager settingsManager) { }

	protected virtual void TranslateAxes(ref float[] axes) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

}

