namespace EFT.InventoryLogic;

public class BackEndInventoryController : InventoryController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_1; //Field offset: 0x8
		public static Func <>9__10_2; //Field offset: 0x10
		public static Callback <>9__14_0; //Field offset: 0x18
		public static Callback <>9__15_0; //Field offset: 0x20
		public static Callback <>9__16_0; //Field offset: 0x28
		public static Func <>9__18_0; //Field offset: 0x30
		public static Action <>9__18_5; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal string <.ctor>b__10_1(RestrictionInRaid restriction) { }

		internal int <.ctor>b__10_2(RestrictionInRaid restriction) { }

		internal void <Eat>b__16_0(IResult error) { }

		internal bool <Execute>b__18_0(BaseInventoryCommand com) { }

		internal void <Execute>b__18_5(Callback callback) { }

		internal void <Heal>b__15_0(IResult error) { }

		internal void <StudyItem>b__14_0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		private struct <<Execute>g__ExecuteAsync|3>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass18_0 <>4__this; //Field offset: 0x20
			public Callback cb; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public int callbackCount; //Field offset: 0x10
		public IResult mainResult; //Field offset: 0x18
		public int commandCount; //Field offset: 0x20
		public Callback networkCallback; //Field offset: 0x28
		public Task executeTask; //Field offset: 0x30
		public BackEndInventoryController <>4__this; //Field offset: 0x38
		public AbstractOperation operation; //Field offset: 0x40
		public Callback <>9__4; //Field offset: 0x48

		public <>c__DisplayClass18_0() { }

		internal void <Execute>b__4(IResult result) { }

		internal void <Execute>g__BaseExecute|2(Callback cb) { }

		[AsyncStateMachine(typeof(<<Execute>g__ExecuteAsync|3>d))]
		internal Task <Execute>g__ExecuteAsync|3(Callback cb) { }

		internal void <Execute>g__MainCallback|1(IResult result) { }

	}

	internal sealed class FullItemLocation
	{
		public string parentItem; //Field offset: 0x10
		public string container; //Field offset: 0x18
		public LocationInGrid location; //Field offset: 0x20

		public FullItemLocation() { }

	}

	internal sealed class FullItemLocationSerializer : ISerializer
	{
		[JsonProperty("id")]
		public string Id; //Field offset: 0x10
		[JsonProperty("container")]
		public string Container; //Field offset: 0x18
		[JsonProperty(NullValueHandling = NullValueHandling::Ignore (1))]
		public LocationInGrid location; //Field offset: 0x20

		public FullItemLocationSerializer() { }

		public override FullItemLocation Deserialize() { }

		public override object Serialize(FullItemLocation t) { }

	}

	private readonly Profile _clientProfile; //Field offset: 0x170
	private readonly IClientSession _backendSession; //Field offset: 0x178
	private readonly string _mainProfileId; //Field offset: 0x180
	private readonly Dictionary _restrictionsInLobby; //Field offset: 0x188
	private readonly BackendIdGenerator _idGenerator; //Field offset: 0x190
	private DialogProgressInventoryCommand _dialogProgressCommand; //Field offset: 0x198

	protected virtual MongoID NextId
	{
		 get { } //Length: 310
	}

	protected BackEndInventoryController(IClientSession backendSession, Profile profile, string mainProfileId) { }

	[CompilerGenerated]
	private void <.ctor>b__10_0(MongoID item) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0(AbstractOperation operation, Callback callback) { }

	[CompilerGenerated]
	internal static bool <IsRecorderEnable>g__IsHideoutRecorderEnable|25_0() { }

	public virtual bool CheckedChamber(Weapon weapon) { }

	public virtual void CollectCompletableItem(CompletableItem completable) { }

	public virtual AbstractOperation ConvertOperationResultToOperation(IOperationResult operationResult) { }

	public void Eat(Item item, int count) { }

	internal virtual void Execute(AbstractOperation operation, Callback networkCallback) { }

	public virtual GridItemAddress FindQuestGridToPickUp(Item item) { }

	private void Forget(MongoID itemId) { }

	protected virtual MongoID get_NextId() { }

	public virtual void GetTraderServicesDataFromServer(string traderId) { }

	public void Heal(Item item, EBodyPart bodyPart, int count) { }

	public virtual bool IsAllowedToSort(CompoundItem item) { }

	protected virtual bool IsLimitedAtAddress(string templateId, ItemAddress address, out int limit) { }

	public virtual IResult IsRecorderEnable() { }

	public virtual void PlayTape(TapeItem tape, RecorderItem recorder = null) { }

	protected virtual void RollBack() { }

	public virtual StudyItemBaseOperation StudyItem(CompletableItem item, RecorderItem recorder) { }

}

