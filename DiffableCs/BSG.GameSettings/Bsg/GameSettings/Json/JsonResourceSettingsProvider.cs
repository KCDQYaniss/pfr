namespace Bsg.GameSettings.Json;

public sealed class JsonResourceSettingsProvider : BaseJsonSettingsProvider
{
	[CompilerGenerated]
	private struct <LoadJson>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public JsonResourceSettingsProvider <>4__this; //Field offset: 0x20
		private ResourceRequest <operation>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly string _textAssetName; //Field offset: 0x20
	private TextAsset _textAsset; //Field offset: 0x28

	public JsonResourceSettingsProvider(string textAssetName, IJsonSerializer serializer, BaseJsonSettingsProvider[] fallbackProviders) { }

	[AsyncStateMachine(typeof(<LoadJson>d__3))]
	protected virtual Task LoadJson() { }

	protected virtual Task SaveJson(JObject json) { }

	public virtual string ToString() { }

}

