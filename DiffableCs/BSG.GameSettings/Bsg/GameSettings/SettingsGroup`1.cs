namespace Bsg.GameSettings;

public abstract class SettingsGroup`1
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0`1
	{
		public Func preProcessor; //Field offset: 0x0

		public <>c__DisplayClass11_0`1() { }

		internal Task <RegisterState>b__0(TType value) { }

	}

	private readonly List _settings; //Field offset: 0x0

	protected SettingsGroup`1() { }

	[Conditional("DEBUG")]
	private void CheckCompatibility(TThisGroup other) { }

	[NotNull]
	public abstract TThisGroup Clone() { }

	public void ForceApply() { }

	public IList GetSettingsList() { }

	public bool HasSameSettings(TThisGroup other) { }

	protected TSetting Register(TSetting setting) { }

	protected GameSetting Register(GameSetting setting) { }

	protected GameSetting RegisterEquatable(string key, TType defaultValue = null, Func preProcessor = null) { }

	protected GameSetting RegisterEquatable(string key, TType defaultValue, Func preProcessor) { }

	protected ListGameSetting RegisterList(string key, CopyItem copyItem = null, EqualityCheck equalityCheck = null, Func preProcessor = null) { }

	protected GameSetting RegisterState(string key, TType defaultValue = null, Func preProcessor = null) { }

	protected GameSetting RegisterState(string key, TType defaultValue, Func preProcessor) { }

	public void TakeSettingsFrom(TThisGroup other) { }

	public bool TryForceApplyDiff(TThisGroup other) { }

}

