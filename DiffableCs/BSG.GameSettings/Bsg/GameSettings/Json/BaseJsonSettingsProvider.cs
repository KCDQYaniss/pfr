namespace Bsg.GameSettings.Json;

public abstract class BaseJsonSettingsProvider : ISettingsProvider
{
	[CompilerGenerated]
	private struct <GetFromFallback>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BaseJsonSettingsProvider <>4__this; //Field offset: 0x20
		private BaseJsonSettingsProvider[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Load>d__3`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseJsonSettingsProvider <>4__this; //Field offset: 0x0
		public T settingsGroup; //Field offset: 0x0
		private bool <success>5__2; //Field offset: 0x0
		private T <item>5__3; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Save>d__4`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public BaseJsonSettingsProvider <>4__this; //Field offset: 0x0
		public T settingsGroup; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal interface IJsonSerializer
	{

		[NotNull]
		public T Populate(JObject json, T item, out bool needReSave) { }

		[NotNull]
		public JObject PrepareToSave(T item) { }

	}

	private readonly IJsonSerializer _serializer; //Field offset: 0x10
	private readonly BaseJsonSettingsProvider[] _fallbackProviders; //Field offset: 0x18

	protected BaseJsonSettingsProvider(IJsonSerializer serializer, BaseJsonSettingsProvider[] fallbackProviders) { }

	[AsyncStateMachine(typeof(<GetFromFallback>d__7))]
	private Task GetFromFallback() { }

	[AsyncStateMachine(typeof(<Load>d__3`1))]
	public override Task Load(T settingsGroup) { }

	protected abstract Task LoadJson() { }

	[AsyncStateMachine(typeof(<Save>d__4`1))]
	public override Task Save(T settingsGroup) { }

	protected abstract Task SaveJson(JObject json) { }

}

