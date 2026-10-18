namespace Bsg.GameSettings;

public abstract class BaseSettingsController`1 : ISettingsGroupFactory, IDisposable
{
	protected T Group; //Field offset: 0x0
	protected bool PreviewMode; //Field offset: 0x0
	[CompilerGenerated]
	private bool <IsFirstBind>k__BackingField; //Field offset: 0x0
	private readonly List _disposableActions; //Field offset: 0x0

	public bool IsBound
	{
		 get { } //Length: 9
	}

	protected private bool IsFirstBind
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected BaseSettingsController`1() { }

	private void AddDisposable(Action action) { }

	protected void Bind(GameSetting gameSetting, Action handler) { }

	public void BindTo(T settingsGroup, bool previewMode = false) { }

	protected abstract void CreateBindings() { }

	public override void Dispose() { }

	public bool get_IsBound() { }

	[CompilerGenerated]
	protected bool get_IsFirstBind() { }

	[CompilerGenerated]
	private void set_IsFirstBind(bool value) { }

	public abstract T SettingsGroupFactory() { }

	protected void Subscribe(GameSetting gameSetting, Action handler) { }

}

