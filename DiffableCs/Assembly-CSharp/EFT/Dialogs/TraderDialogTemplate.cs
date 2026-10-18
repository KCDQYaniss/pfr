namespace EFT.Dialogs;

[JsonObject(MemberSerialization::OptIn (1))]
public sealed class TraderDialogTemplate
{
	[CompilerGenerated]
	private struct <DownloadDialogImages>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TraderDialogTemplate <>4__this; //Field offset: 0x20
		public IImageLoader imagesLoader; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[JsonProperty("Id")]
	public readonly MongoID Id; //Field offset: 0x10
	[JsonProperty("MainVariable")]
	public readonly MongoID MainVariable; //Field offset: 0x28
	[JsonProperty("Trader")]
	public readonly MongoID MainTrader; //Field offset: 0x40
	[JsonProperty("SubTraders")]
	public readonly IReadOnlyList SubTraders; //Field offset: 0x58
	[JsonProperty("IsStart")]
	public readonly bool CanBeFirstDialog; //Field offset: 0x60
	[JsonProperty("Lines")]
	public readonly IReadOnlyList Lines; //Field offset: 0x68
	[JsonProperty("StartPoints")]
	public readonly IReadOnlyDictionary StartPoints; //Field offset: 0x70
	[JsonProperty("localization")]
	public readonly IReadOnlyDictionary LocalizationDictionary; //Field offset: 0x78

	[JsonConstructor]
	public TraderDialogTemplate(MongoID id, MongoID mainVariable, MongoID mainTrader, IReadOnlyList subTraders, IReadOnlyList lines, Dictionary localization, Dictionary startPoints = null, bool canBeFirstDialog = true) { }

	[AsyncStateMachine(typeof(<DownloadDialogImages>d__12))]
	public Task DownloadDialogImages(IImageLoader imagesLoader) { }

	public int GetStartVariableValue(MongoID startPoint) { }

	public bool HasTraderId(MongoID traderId) { }

	private void SetupLocalization(IReadOnlyDictionary localizationDictionary) { }

}

