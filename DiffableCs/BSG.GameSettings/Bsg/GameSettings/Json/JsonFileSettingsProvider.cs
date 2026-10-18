namespace Bsg.GameSettings.Json;

public sealed class JsonFileSettingsProvider : BaseJsonSettingsProvider
{
	[CompilerGenerated]
	private struct <LoadJson>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public JsonFileSettingsProvider <>4__this; //Field offset: 0x20
		private StreamReader <reader>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveJson>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public JsonFileSettingsProvider <>4__this; //Field offset: 0x20
		public JObject json; //Field offset: 0x28
		private StreamWriter <writer>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly string _path; //Field offset: 0x20

	public JsonFileSettingsProvider(string path, IJsonSerializer serializer, BaseJsonSettingsProvider[] fallbackProviders) { }

	[AsyncStateMachine(typeof(<LoadJson>d__2))]
	protected virtual Task LoadJson() { }

	public void MakeCopy(string postfix) { }

	[AsyncStateMachine(typeof(<SaveJson>d__3))]
	protected virtual Task SaveJson(JObject json) { }

	public virtual string ToString() { }

}

