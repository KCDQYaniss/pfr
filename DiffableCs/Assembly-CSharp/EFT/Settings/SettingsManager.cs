namespace EFT.Settings;

public sealed class SettingsManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0`1
	{
		public GameSetting setting; //Field offset: 0x0
		public SettingsManager <>4__this; //Field offset: 0x0
		public string description; //Field offset: 0x0

		public <>c__DisplayClass17_0`1() { }

		internal void <AddSettingToConsole>b__1(T v) { }

		internal void <AddSettingToConsole>g__AddCommand|0(string key) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static PostLoadDelegate <0>__MergeControlWithDefault; //Field offset: 0x0
		public static Action <1>__Quit; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <InstantiateSingleton>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		private SettingsManager <settingsManager>5__2; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SettingsManager <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class SettingsWithController`2 : SettingsWithProvider
	{
		[CompilerGenerated]
		private struct <Load>d__2 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public SettingsWithController <>4__this; //Field offset: 0x0
			public ISettingsProvider defaultProvider; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[NotNull]
		public readonly TController Controller; //Field offset: 0x0

		public SettingsWithController`2(ISettingsProvider provider, TController controller, PostLoadDelegate postLoadAction = null) { }

		[CompilerGenerated]
		[DebuggerHidden]
		private Task <>n__0(ISettingsProvider defaultProvider) { }

		[AsyncStateMachine(typeof(<Load>d__2))]
		public virtual Task Load(ISettingsProvider defaultProvider = null) { }

	}

	internal class SettingsWithProvider`1
	{
		[CompilerGenerated]
		private struct <Load>d__8 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public ISettingsProvider defaultProvider; //Field offset: 0x0
			public SettingsWithProvider <>4__this; //Field offset: 0x0
			private bool <needSave>5__2; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0
			private bool <>7__wrap2; //Field offset: 0x0
			private TaskAwaiter <>u__2; //Field offset: 0x0
			private TaskAwaiter <>u__3; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <Save>d__9 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public SettingsWithProvider <>4__this; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private struct <TakeSettingsFrom>d__6 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
			public SettingsWithProvider <>4__this; //Field offset: 0x0
			public T otherGroup; //Field offset: 0x0
			private TaskAwaiter <>u__1; //Field offset: 0x0

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CanBeNull]
		internal sealed class PostLoadDelegate : MulticastDelegate
		{

			public PostLoadDelegate(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(SettingsWithProvider loadedSettings, AsyncCallback callback, object object) { }

			public override Task EndInvoke(IAsyncResult result) { }

			public override Task Invoke(SettingsWithProvider loadedSettings) { }

		}

		public readonly T Settings; //Field offset: 0x0
		public readonly T Default; //Field offset: 0x0
		private readonly ISettingsProvider _provider; //Field offset: 0x0
		private readonly PostLoadDelegate _postLoadAction; //Field offset: 0x0

		public SettingsWithProvider`1(ISettingsProvider provider, ISettingsGroupFactory groupFactory, PostLoadDelegate postLoadAction = null) { }

		[AsyncStateMachine(typeof(<Load>d__8))]
		public override Task Load(ISettingsProvider defaultProvider = null) { }

		public static T op_Implicit(SettingsWithProvider settingsWithProvider) { }

		public Task RevertToDefault() { }

		[AsyncStateMachine(typeof(<Save>d__9))]
		public Task Save() { }

		[AsyncStateMachine(typeof(<TakeSettingsFrom>d__6))]
		public Task TakeSettingsFrom(T otherGroup) { }

	}

	private static readonly string OldSettingsFolderPath; //Field offset: 0x0
	private static readonly string SettingsFolderPath; //Field offset: 0x8
	private static readonly SimpleJsonSerializer _simpleJsonSerializer; //Field offset: 0x10
	public readonly SettingsWithController Game; //Field offset: 0x10
	public readonly SettingsWithController Sound; //Field offset: 0x18
	public readonly SettingsWithProvider PostFx; //Field offset: 0x20
	public readonly SettingsWithController Graphics; //Field offset: 0x28
	public readonly SettingsWithController Control; //Field offset: 0x30
	private readonly List _registeredCommands; //Field offset: 0x38
	private readonly JsonResourceSettingsProvider _defaultResourceProvider; //Field offset: 0x40

	private static SettingsManager() { }

	private SettingsManager() { }

	private void AddBoolSettingToConsole(GameSetting setting, string description = null, string additionalKey = null) { }

	private void AddEnumSettingToConsole(GameSetting setting, string description = null, string additionalKey = null) { }

	private void AddFloatSettingToConsole(GameSetting setting, string description = null, string additionalKey = null) { }

	private void AddSettingToConsole(GameSetting setting, string description = null, string additionalKey = null) { }

	private static ISettingsProvider BuildFileProvider(string name, BaseJsonSettingsProvider[] fallbackProviders, IJsonSerializer jsonSerializer = null) { }

	public static void ClearSettings() { }

	[AsyncStateMachine(typeof(<InstantiateSingleton>d__20))]
	public static Task InstantiateSingleton() { }

	[AsyncStateMachine(typeof(<Load>d__12))]
	private Task Load() { }

	private static Task MergeControlWithDefault(SettingsWithProvider loadedSettings) { }

	private void PrintRegisteredCommands() { }

}

