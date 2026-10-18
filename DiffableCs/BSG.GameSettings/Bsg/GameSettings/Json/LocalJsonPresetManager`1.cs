namespace Bsg.GameSettings.Json;

public sealed class LocalJsonPresetManager`1 : IPresetManager
{
	[CompilerGenerated]
	private struct <CreateNewPreset>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public LocalJsonPresetManager <>4__this; //Field offset: 0x0
		public string name; //Field offset: 0x0
		public T settingsGroup; //Field offset: 0x0
		private SettingsPreset <preset>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string EXTENSION = ".ini"; //Field offset: 0x0
	private List _presets; //Field offset: 0x0
	private readonly string _folderPath; //Field offset: 0x0
	private readonly BaseJsonSettingsProvider[] _fallbackProviders; //Field offset: 0x0
	private readonly IJsonSerializer _serializer; //Field offset: 0x0

	public override IReadOnlyList Presets
	{
		 get { } //Length: 5
	}

	public LocalJsonPresetManager`1(string folderPath, IJsonSerializer serializer, BaseJsonSettingsProvider[] fallbackProviders) { }

	[AsyncStateMachine(typeof(<CreateNewPreset>d__9))]
	public override Task CreateNewPreset(string name, T settingsGroup) { }

	private SettingsPreset CreatePreset(string path) { }

	private SettingsPreset CreatePreset(string path, string name) { }

	public override IReadOnlyList get_Presets() { }

	private string GetNameFromPath(string path) { }

	private string GetPathFromName(string name) { }

	public override Task RefreshPresetList() { }

	public override Task RemovePreset(SettingsPreset preset) { }

}

