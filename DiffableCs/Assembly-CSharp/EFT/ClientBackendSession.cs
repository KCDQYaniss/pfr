namespace EFT;

internal abstract class ClientBackendSession : Backend, ITradingSession, IImageLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__49_0; //Field offset: 0x8
		public static Callback <>9__54_0; //Field offset: 0x10
		public static Func <>9__147_0; //Field offset: 0x18
		public static Func <>9__149_0; //Field offset: 0x20
		public static Func <>9__151_0; //Field offset: 0x28
		public static Func <>9__157_0; //Field offset: 0x30
		public static Callback <>9__168_0; //Field offset: 0x38
		public static Callback <>9__169_0; //Field offset: 0x40
		public static Callback <>9__171_0; //Field offset: 0x48
		public static Callback <>9__172_0; //Field offset: 0x50
		public static Func <>9__174_0; //Field offset: 0x58
		public static Func <>9__175_0; //Field offset: 0x60
		public static Callback <>9__193_2; //Field offset: 0x68
		public static Callback <>9__196_0; //Field offset: 0x70
		public static Callback <>9__199_0; //Field offset: 0x78
		public static Callback <>9__207_0; //Field offset: 0x80
		public static Func <>9__214_0; //Field offset: 0x88
		public static Func <>9__214_1; //Field offset: 0x90
		public static Func <>9__214_2; //Field offset: 0x98
		public static Callback <>9__231_1; //Field offset: 0xA0
		public static Callback <>9__256_0; //Field offset: 0xA8
		public static Callback <>9__257_0; //Field offset: 0xB0
		public static Callback <>9__271_0; //Field offset: 0xB8
		public static Callback <>9__280_0; //Field offset: 0xC0
		public static Func <>9__300_0; //Field offset: 0xC8

		private static <>c() { }

		public <>c() { }

		internal void <AwaitMatching>b__231_1(IResult _) { }

		internal void <CancelMatchmaking>b__193_2(IResult result) { }

		internal void <ChatGetDialogList>b__257_0(Result _) { }

		internal <>f__AnonymousType12 <ConfirmPurchase>b__174_0(TradingItemReference item) { }

		internal <>f__AnonymousType14 <ConfirmSell>b__175_0(TradingItemReference item) { }

		internal bool <get_DisplayableTraders>b__147_0(Trader trader) { }

		internal bool <get_Insurers>b__149_0(Trader trader) { }

		internal bool <get_Medic>b__157_0(Trader trader) { }

		internal bool <get_Repairers>b__151_0(Trader trader) { }

		internal void <GetFriendsList>b__271_0(Result _) { }

		internal void <GetMetricsConfig>b__207_0(Result _) { }

		internal void <GetOtherPlayerProfile>b__256_0(Result _) { }

		internal void <GetSupplyData>b__168_0(Result _) { }

		internal void <GetTraderAssortment>b__169_0(Result _) { }

		internal bool <GetTutorialProfile>b__300_0(Profile x) { }

		internal void <InternalLoadLootContainerData>b__171_0(Result _) { }

		internal void <InternalLoadLootContainerData>b__172_0(Result _) { }

		internal int <LoadBots>b__214_0(CountTypeBotWave x) { }

		internal int <LoadBots>b__214_1(CountTypeBotWave x) { }

		internal Profile <LoadBots>b__214_2(ProfileDescriptor descriptor) { }

		internal void <ParseMatchingAbortResult>b__199_0(IResult _) { }

		internal void <ParseMatchingResult>b__196_0(IResult _) { }

		internal void <SendCommands>b__54_0(Result _) { }

		internal void <SendOperationQueued>b__49_0(Callback operationCallback) { }

		internal void <SyncPlatformFriends>b__280_0(Result _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass167_0
	{
		public string traderId; //Field offset: 0x10

		public <>c__DisplayClass167_0() { }

		internal bool <EFT.Trading.ITradingSession.GetTrader>b__0(Trader trader) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass181_0
	{
		public TaskCompletionSource taskCompletionSource; //Field offset: 0x10

		public <>c__DisplayClass181_0() { }

		internal void <CreateProfile>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass189_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x10
		public bool isPet; //Field offset: 0x18

		public <>c__DisplayClass189_0() { }

		internal void <SendRefreshRequest>b__0(Result result) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass192_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x0
		public bool isPet; //Field offset: 0x8

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass193_0
	{
		private struct <<CancelMatchmaking>g__CheckProfileStatus|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass193_0 <>4__this; //Field offset: 0x20
			private TaskAwaiter <>u__1; //Field offset: 0x28

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public ClientBackendSession <>4__this; //Field offset: 0x10
		public bool isPet; //Field offset: 0x18

		public <>c__DisplayClass193_0() { }

		[AsyncStateMachine(typeof(<<CancelMatchmaking>g__CheckProfileStatus|1>d))]
		internal Task <CancelMatchmaking>g__CheckProfileStatus|1() { }

		internal bool <CancelMatchmaking>g__IsFinished|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass200_0
	{
		public Profile profile; //Field offset: 0x10

		public <>c__DisplayClass200_0() { }

		internal bool <GetProfileStatus>b__0(ProfileStatus status) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass220_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass220_0() { }

		internal void <ApplyCustomization>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass222_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x10
		public string profileId; //Field offset: 0x18
		public string nick; //Field offset: 0x20
		public Callback callback; //Field offset: 0x28
		public Func <>9__1; //Field offset: 0x30

		public <>c__DisplayClass222_0() { }

		internal void <ChangeNickname>b__0(Result status) { }

		internal bool <ChangeNickname>b__1(Profile value) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass227_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass227_0() { }

		internal void <StartMatching>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass230_0
	{
		public TaskCompletionSource source; //Field offset: 0x10
		public ClientBackendSession <>4__this; //Field offset: 0x18
		public bool isPet; //Field offset: 0x20

		public <>c__DisplayClass230_0() { }

		internal void <CancelGameSearching>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass231_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x10
		public bool isPet; //Field offset: 0x18
		public Callback callback; //Field offset: 0x20
		public TaskCompletionSource taskSource; //Field offset: 0x28

		public <>c__DisplayClass231_0() { }

		internal void <AwaitMatching>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass252_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x10
		public string id; //Field offset: 0x18
		public EReportType reportType; //Field offset: 0x20
		public Callback callback; //Field offset: 0x28

		public <>c__DisplayClass252_0() { }

		internal void <SendReport>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass255_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass255_0() { }

		internal void <GetChatServers>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass47_0
	{
		public QueuedCommand queuedOperation; //Field offset: 0x10
		public ClientBackendSession <>4__this; //Field offset: 0x18

		public <>c__DisplayClass47_0() { }

		internal void <ReadWaitingQueue>b__0(IResult executeResult) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public ClientBackendSession <>4__this; //Field offset: 0x10
		public TaskCompletionSource taskSource; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal void <FlushOperationQueue>g__FlushingHandler|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public object[] commandsToSend; //Field offset: 0x10

		public <>c__DisplayClass55_0() { }

		internal bool <SendCallback>b__0(InventoryWarning warning) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass97_0
	{
		public Profile profile; //Field offset: 0x10

		public <>c__DisplayClass97_0() { }

		internal bool <get_ActivePetStatus>b__0(ProfileStatus status) { }

	}

	[CompilerGenerated]
	private struct <CancelMatchmaking>d__193 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public bool isPet; //Field offset: 0x28
		private <>c__DisplayClass193_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private YieldAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChatDeleteAllMessages>d__285 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public string dialogId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ChatGetDialogList>d__257 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public int limit; //Field offset: 0x28
		public int offset; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DeleteDialog>d__286 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public string dialogId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Destroy>d__302 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadTexture2D>d__218 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		private Result <result>5__2; //Field offset: 0x28
		private UnityWebRequest <uwr>5__3; //Field offset: 0x40
		private YieldAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FlushOperationQueue>d__48 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private <>c__DisplayClass48_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAllCustomizations>d__212 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public Dictionary returnInCaseOfCache; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAvailableCustomizationsStorage>d__213 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFriendsList>d__271 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLocalization>d__185 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public string locale; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetMetricsConfig>d__207 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTutorialProfile>d__300 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBots>d__214 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public List conditions; //Field offset: 0x20
		public ClientBackendSession <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTexture>d__219 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTextureMain>d__216 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public string url; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadTextureWithCache>d__217 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string url; //Field offset: 0x20
		public string baseUrl; //Field offset: 0x28
		private string <diskPath>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendCommands>d__54 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		private object[] <commandsToSend>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendExitMatchRequestTask>d__203 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public Callback callback; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartMatching>d__227 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public bool isPet; //Field offset: 0x28
		public string locationId; //Field offset: 0x30
		public EDateTime dateTime; //Field offset: 0x38
		public string keyId; //Field offset: 0x40
		public Action estimateTimeSetter; //Field offset: 0x48
		private <>c__DisplayClass227_0 <>8__1; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SyncPlatformFriends>d__280 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public ELinkedPlatform platform; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryWaitForAppropriateStatus>d__191 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public bool isPet; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForAppropriateStatus>d__192 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public bool isPet; //Field offset: 0x28
		private <>c__DisplayClass192_0 <>8__1; //Field offset: 0x30
		private int <timeOutAccumulator>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForProfileStatus>d__187 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientBackendSession <>4__this; //Field offset: 0x20
		public bool isPet; //Field offset: 0x28
		public EProfileStatus interruptStatus; //Field offset: 0x2C
		public EProfileStatus status; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class BackendQueueLogger : AbstractLogger
	{

		public BackendQueueLogger() { }

	}

	private sealed class ClientProfileSettingsRequest
	{
		[JsonProperty("squadInviteRestriction")]
		public Nullable SquadInviteRestriction; //Field offset: 0x10
		[JsonProperty("memberCategory")]
		public Nullable MemberCategory; //Field offset: 0x14
		[JsonProperty("prestigeGameMode", NullValueHandling = NullValueHandling::Ignore (1))]
		public string PrestigeGameMode; //Field offset: 0x20

		public ClientProfileSettingsRequest() { }

	}

	private sealed class ImmediateCommand : OperationWithCallback
	{
		public Callback Callback; //Field offset: 0x18

		public ImmediateCommand() { }

	}

	private sealed class InventoryWarning : IInventoryWarning
	{
		private struct IncorrectClientPriceData
		{
			private const string INCORRECT_CLIENT_PRICE = "Trading/IncorrectClientPrice{0}{1}"; //Field offset: 0x0
			[CompilerGenerated]
			private string <TraderCurrencyId>k__BackingField; //Field offset: 0x0
			[CompilerGenerated]
			private int <RequestedCount>k__BackingField; //Field offset: 0x8
			[CompilerGenerated]
			private int <ActualCount>k__BackingField; //Field offset: 0xC

			[JsonProperty("actualCount")]
			public private int ActualCount
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 4
				[CompilerGenerated]
				private set { } //Length: 4
			}

			public string LocalizedMessage
			{
				 get { } //Length: 735
			}

			[JsonProperty("requestedCount")]
			public private int RequestedCount
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 4
				[CompilerGenerated]
				private set { } //Length: 4
			}

			[JsonProperty("traderCurrency")]
			public private string TraderCurrencyId
			{
				[CompilerGenerated]
				[IsReadOnly]
				 get { } //Length: 4
				[CompilerGenerated]
				private set { } //Length: 82
			}

			[CompilerGenerated]
			[IsReadOnly]
			public int get_ActualCount() { }

			public string get_LocalizedMessage() { }

			[CompilerGenerated]
			[IsReadOnly]
			public int get_RequestedCount() { }

			[CompilerGenerated]
			[IsReadOnly]
			public string get_TraderCurrencyId() { }

			[CompilerGenerated]
			private void set_ActualCount(int value) { }

			[CompilerGenerated]
			private void set_RequestedCount(int value) { }

			[CompilerGenerated]
			private void set_TraderCurrencyId(string value) { }

		}

		private struct InsufficientNumberOfItemsData
		{
			[JsonProperty("itemId")]
			public string ItemId; //Field offset: 0x0
			[JsonProperty("requestedCount")]
			public int RequestedCount; //Field offset: 0x8
			[JsonProperty("actualCount")]
			public int ActualCount; //Field offset: 0xC

			public string LocalizedMessage
			{
				 get { } //Length: 409
			}

			public string get_LocalizedMessage() { }

		}

		[CompilerGenerated]
		private int <RequestIndex>k__BackingField; //Field offset: 0x10
		[CompilerGenerated]
		private string <ErrorMessage>k__BackingField; //Field offset: 0x18
		[CompilerGenerated]
		private string <ErrorCode>k__BackingField; //Field offset: 0x20
		[JsonProperty("data")]
		private UnparsedData _data; //Field offset: 0x28

		private override int EFT.IInventoryWarning.ErrorCode
		{
			private get { } //Length: 213
		}

		[JsonProperty("code")]
		public private string ErrorCode
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		[JsonProperty("errmsg")]
		public private string ErrorMessage
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		[JsonProperty("msg")]
		private string Message
		{
			private set { } //Length: 82
		}

		[JsonProperty("index")]
		public private int RequestIndex
		{
			[CompilerGenerated]
			 get { } //Length: 164
			[CompilerGenerated]
			private set { } //Length: 4
		}

		public InventoryWarning() { }

		private override int EFT.IInventoryWarning.get_ErrorCode() { }

		[CompilerGenerated]
		public string get_ErrorCode() { }

		[CompilerGenerated]
		public string get_ErrorMessage() { }

		[CompilerGenerated]
		public int get_RequestIndex() { }

		[CompilerGenerated]
		private void set_ErrorCode(string value) { }

		[CompilerGenerated]
		private void set_ErrorMessage(string value) { }

		private void set_Message(string value) { }

		[CompilerGenerated]
		private void set_RequestIndex(int value) { }

		public IResult ToResult() { }

		public override bool TryGetMessage(out string header, out string description) { }

	}

	internal class OperationWithCallback
	{
		public object Operation; //Field offset: 0x10

		public OperationWithCallback() { }

		public virtual string ToString() { }

	}

	internal sealed class ProfileDTO
	{
		[JsonProperty("profile")]
		public ProfileDescriptor profile; //Field offset: 0x10

		public ProfileDTO() { }

	}

	private sealed class QueueData
	{
		[JsonProperty("profileChanges")]
		public Dictionary ProfileChanges; //Field offset: 0x10
		[JsonProperty("warnings")]
		public InventoryWarning[] InventoryWarnings; //Field offset: 0x18

		public QueueData() { }

	}

	private sealed class QueuedCommand : OperationWithCallback
	{
		public Callback Callback; //Field offset: 0x18
		public Action Execute; //Field offset: 0x20

		public QueuedCommand() { }

	}

	private const string INSUFFICIENT_NUMBER_IN_STOCK = "Trading/InsufficientNumberOfItemsInStock{}{}"; //Field offset: 0x0
	private const string BASE_INVENTORY_ERROR_TEXT = "Error: Inventory queue failed on the following commands"; //Field offset: 0x0
	private const string PURCHASE_ITEM_IS_OUT_OF_STOCK = "Item is out of stock"; //Field offset: 0x0
	private const string OFFER_NOT_FOUND_WARNING = "Request error: 1503 - Offer not found 1503"; //Field offset: 0x0
	private const string EXAMINATION_FAILED_WARNING = "Warnings/Inventory/ExaminationFailed"; //Field offset: 0x0
	private const string PRICE_CHANGED_WARNING = "Price changed error"; //Field offset: 0x0
	private const string NOT_ENOUGH_SPACE_IN_STASH = "Warnings/Inventory/NotEnoughSpaceInStash"; //Field offset: 0x0
	[CompilerGenerated]
	private Action InventoryErrorHappened; //Field offset: 0x58
	[CompilerGenerated]
	private Action InventoryWarningHappened; //Field offset: 0x60
	[CompilerGenerated]
	private Action _onFlushingChanged; //Field offset: 0x68
	private float _lastSentTime; //Field offset: 0x70
	private readonly BackendQueueLogger _queueLogger; //Field offset: 0x78
	private readonly Queue _incomingOperations; //Field offset: 0x80
	private OperationWithCallback _waitingOperation; //Field offset: 0x88
	private readonly List _unsentCommands; //Field offset: 0x90
	private TaskCompletionSource _flushingJobCompletionSource; //Field offset: 0x98
	private ICaptchaHandler _captchaHandler; //Field offset: 0xA0
	private readonly Dictionary _profileUpdaters; //Field offset: 0xA8
	protected SemaphoreSlim _itemsMovingSemaphore; //Field offset: 0xB0
	[CompilerGenerated]
	private Action <ExamineRequestFailed>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private bool <IsFlushing>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private EOperationQueueStatus <QueueStatus>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	private Action OnSessionError; //Field offset: 0xC8
	protected BackendUrls _backendUrls; //Field offset: 0xD0
	protected DateTime _startingDateTime; //Field offset: 0xD8
	private Task _waitForStatusChanged; //Field offset: 0xE0
	private CancellationTokenSource _keepAliveCTS; //Field offset: 0xE8
	protected int _pinging; //Field offset: 0xF0
	private readonly Dictionary _reportedProfiles; //Field offset: 0xF8
	private Callback _refreshCallback; //Field offset: 0x100
	private Callback _matchStartCallback; //Field offset: 0x108
	protected Callback _matchAbortCallback; //Field offset: 0x110
	private bool _matchingCancelingByButtonInProcess; //Field offset: 0x118
	protected readonly List _traders; //Field offset: 0x120
	[CompilerGenerated]
	private readonly GameModeDescriptor <GameModeDescriptor>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private readonly BindableEvent <QueueStatusChanged>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private Profile[] <AllProfiles>k__BackingField; //Field offset: 0x138
	private Profile _profile; //Field offset: 0x140
	[CompilerGenerated]
	private CountersCollection <OverallAccountStats>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private ProfileStatus[] <AllProfileStatus>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private GlobalConfigurationResponse <BackEndConfig>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private readonly SocialNetwork <SocialNetwork>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private ChatServerState[] <ChatServers>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private readonly ELinkedPlatform[] <LinkedPlatforms>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private GameServerPing[] <GameServers>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private bool <LimitedServersAvailability>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private PlayerVisualRepresentation <LastPlayerState>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private ProfileStats <LastPlayerStats>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private long <TotalInGameTime>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private bool <ReportAvailable>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private Dictionary <PurchasedGames>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private bool <IsGameSynced>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private InsuranceCompany <InsuranceCompany>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private LocationSettings <LocationSettings>k__BackingField; //Field offset: 0x1C0

	private event Action _onFlushingChanged
	{
		[CompilerGenerated]
		private add { } //Length: 235
		[CompilerGenerated]
		private remove { } //Length: 235
	}

	public override event Action InventoryErrorHappened
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action InventoryWarningHappened
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnSessionError
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override ProfileStatus ActivePetStatus
	{
		 get { } //Length: 325
	}

	public override ProfileStatus ActiveProfileStatus
	{
		 get { } //Length: 190
	}

	public override Profile[] AllProfiles
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override ProfileStatus[] AllProfileStatus
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override GlobalConfigurationResponse BackEndConfig
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override ChatServerState[] ChatServers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IEnumerable DisplayableTraders
	{
		 get { } //Length: 355
	}

	public override Action ExamineRequestFailed
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override EGameMode GameMode
	{
		 get { } //Length: 29
	}

	public override GameModeDescriptor GameModeDescriptor
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override GameServerPing[] GameServers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override InsuranceCompany InsuranceCompany
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IEnumerable Insurers
	{
		 get { } //Length: 355
	}

	public override bool IsFlushing
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsGameSynced
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override PlayerVisualRepresentation LastPlayerState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override ProfileStats LastPlayerStats
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override bool LimitedServersAvailability
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override ELinkedPlatform[] LinkedPlatforms
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public LocationSettings LocationSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Trader Medic
	{
		 get { } //Length: 355
	}

	public override CountersCollection OverallAccountStats
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Profile Profile
	{
		 get { } //Length: 8
		 set { } //Length: 302
	}

	public override Profile ProfileOfPet
	{
		 get { } //Length: 190
	}

	public override Dictionary PurchasedGames
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override EOperationQueueStatus QueueStatus
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override BindableEvent QueueStatusChanged
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override IEnumerable Repairers
	{
		 get { } //Length: 355
	}

	public override bool ReportAvailable
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override SocialNetwork SocialNetwork
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override long TotalInGameTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public override IEnumerable Traders
	{
		 get { } //Length: 8
	}

	protected ClientBackendSession(HTTPTransportManager httpTransport, WsTransportManager wsTransport, LoginDataResponse loginData, GameModeDescriptor gameModeDescriptor, BackendCache cache = null) { }

	[CompilerGenerated]
	private bool <get_ActiveProfileStatus>b__159_0(ProfileStatus status) { }

	[CompilerGenerated]
	private bool <get_ProfileOfPet>b__161_0(Profile p) { }

	[CompilerGenerated]
	private bool <WaitForAppropriateStatus>g__IsFinished|192_0(ref <>c__DisplayClass192_0 unnamed_param_0) { }

	public override void AbortMatching(bool isPet, Callback callback, bool ignoreCallbacks = false) { }

	public void AbortQueue() { }

	public override Task AcceptAllFriendRequests() { }

	public override void AcceptFriendRequest(string profileId, Callback callback) { }

	public override void AcceptGroupInvite(string requestId, Callback callback) { }

	[CompilerGenerated]
	private void add__onFlushingChanged(Action value) { }

	[CompilerGenerated]
	public override void add_InventoryErrorHappened(Action value) { }

	[CompilerGenerated]
	public override void add_InventoryWarningHappened(Action value) { }

	[CompilerGenerated]
	public override void add_OnSessionError(Action value) { }

	public override void AddNotificationToHandle(string notificationType, Action action) { }

	private void AddReportedProfile(string aId, EReportType reportType) { }

	public override void AllAttachmentsFromDialog(string dialogId, Callback callback) { }

	public override Task ApplyCustomization(IEnumerable customizations) { }

	private void ApplyProfileChanges(Result queueResult) { }

	public override Task ArenaManagerItemsTransfer(ArenaEftTransferItem[] items, string traderId, int transferTax) { }

	protected Task AwaitMatching(string url, bool isPet, object parameters, Nullable retries, Callback callback) { }

	public override void BuyCustomizationWear(string offer, IEnumerable items, Callback onFinished) { }

	public override Task CancelAllInvites() { }

	public override Task CancelFriendRequest(string profileId) { }

	public override Task CancelGameSearching(bool isPet) { }

	public override void CancelInvite(string requestId, Callback callback) { }

	[AsyncStateMachine(typeof(<CancelMatchmaking>d__193))]
	private Task CancelMatchmaking(bool isPet) { }

	public override void ChangeNickname(string profileId, string nick, Callback callback) { }

	private void ChangeProfilesStatuses(bool isPet, Result result) { }

	public override void ChangeProfileStatus(ProfileStatus status) { }

	public override void ChatCreateGroupDialog(string chatName, string[] groupMembers, Callback callback) { }

	[AsyncStateMachine(typeof(<ChatDeleteAllMessages>d__285))]
	public override Task ChatDeleteAllMessages(string dialogId) { }

	public override void ChatDeleteMessage(string dialogId, string messageId, Callback callback) { }

	[AsyncStateMachine(typeof(<ChatGetDialogList>d__257))]
	public override Task ChatGetDialogList(int limit, int offset) { }

	public override void ChatGetDialogMessages(string id, int type, int limit, double time, Callback callback) { }

	public override void ChatReadDialogues(string[] dialogs, Callback callback) { }

	public override void ChatSendMessage(string id, int type, string text, string replyTo, Callback callback) { }

	public override void ClearProfileUpdaters() { }

	public override Task ConfirmPurchase(string traderId, string itemId, int count, int schemeId, TradingItemReference[] items) { }

	public override void ConfirmSell(string traderId, TradingItemReference[] items, int price, Callback onFinished) { }

	public override void CreateNotifierChannel(Callback callback) { }

	public override Task CreateProfile(EPlayerSide profileSide, string profileNickname, string headId, string voiceId, IReadOnlyCollection selectedPerkIds) { }

	public override void DeclineFriendRequest(string profileId, Callback callback) { }

	public override void DeclineGroupInvite(string requestId, Callback callback) { }

	[AsyncStateMachine(typeof(<DeleteDialog>d__286))]
	public override Task DeleteDialog(string dialogId) { }

	[AsyncStateMachine(typeof(<Destroy>d__302))]
	public override Task Destroy() { }

	public override void DisbandRaidGroup(Callback callback) { }

	[AsyncStateMachine(typeof(<DownloadTexture2D>d__218))]
	private static Task DownloadTexture2D(string url) { }

	private override Trader EFT.Trading.ITradingSession.GetTrader(string traderId) { }

	public override Task ExitFromMatchmakerGroupMenu() { }

	public override void FindAccountByNickname(string nickname, Callback callback) { }

	[AsyncStateMachine(typeof(<FlushOperationQueue>d__48))]
	public override Task FlushOperationQueue() { }

	public override ProfileStatus get_ActivePetStatus() { }

	public override ProfileStatus get_ActiveProfileStatus() { }

	[CompilerGenerated]
	public override Profile[] get_AllProfiles() { }

	[CompilerGenerated]
	public override ProfileStatus[] get_AllProfileStatus() { }

	[CompilerGenerated]
	public override GlobalConfigurationResponse get_BackEndConfig() { }

	[CompilerGenerated]
	public override ChatServerState[] get_ChatServers() { }

	public override IEnumerable get_DisplayableTraders() { }

	[CompilerGenerated]
	public override Action get_ExamineRequestFailed() { }

	public override EGameMode get_GameMode() { }

	[CompilerGenerated]
	public override GameModeDescriptor get_GameModeDescriptor() { }

	[CompilerGenerated]
	public override GameServerPing[] get_GameServers() { }

	[CompilerGenerated]
	public override InsuranceCompany get_InsuranceCompany() { }

	public override IEnumerable get_Insurers() { }

	[CompilerGenerated]
	public override bool get_IsFlushing() { }

	[CompilerGenerated]
	public override bool get_IsGameSynced() { }

	[CompilerGenerated]
	public override PlayerVisualRepresentation get_LastPlayerState() { }

	[CompilerGenerated]
	public override ProfileStats get_LastPlayerStats() { }

	[CompilerGenerated]
	public override bool get_LimitedServersAvailability() { }

	[CompilerGenerated]
	public override ELinkedPlatform[] get_LinkedPlatforms() { }

	[CompilerGenerated]
	public LocationSettings get_LocationSettings() { }

	public override Trader get_Medic() { }

	[CompilerGenerated]
	public override CountersCollection get_OverallAccountStats() { }

	public override Profile get_Profile() { }

	public override Profile get_ProfileOfPet() { }

	[CompilerGenerated]
	public override Dictionary get_PurchasedGames() { }

	[CompilerGenerated]
	public override EOperationQueueStatus get_QueueStatus() { }

	[CompilerGenerated]
	public override BindableEvent get_QueueStatusChanged() { }

	public override IEnumerable get_Repairers() { }

	[CompilerGenerated]
	public override bool get_ReportAvailable() { }

	[CompilerGenerated]
	public override SocialNetwork get_SocialNetwork() { }

	[CompilerGenerated]
	public override long get_TotalInGameTime() { }

	public override IEnumerable get_Traders() { }

	[AsyncStateMachine(typeof(<GetAllCustomizations>d__212))]
	public override Task GetAllCustomizations(Dictionary returnInCaseOfCache = null) { }

	[AsyncStateMachine(typeof(<GetAvailableCustomizationsStorage>d__213))]
	public override Task GetAvailableCustomizationsStorage() { }

	public override void GetChatServers(string versionId, Callback callback) { }

	public override Task GetClientSettingsConfig() { }

	public override void GetDialogInformation(string dialogId, Callback callback) { }

	[AsyncStateMachine(typeof(<GetFriendsList>d__271))]
	public override Task GetFriendsList() { }

	public abstract Task GetGlobalConfig() { }

	public override void GetInsurancePrice(string[] traderId, string[] itemIds, Callback callback) { }

	[AsyncStateMachine(typeof(<GetLocalization>d__185))]
	private Task GetLocalization(string locale) { }

	private Task GetMainMenuLocalization(string locale) { }

	private bool GetMatchingAbortResult() { }

	private bool GetMatchingAbortResult(bool isPet) { }

	[AsyncStateMachine(typeof(<GetMetricsConfig>d__207))]
	public override Task GetMetricsConfig() { }

	public override void GetOffers(string traderId, string side, Callback onFinished) { }

	public override Task GetOtherPlayerProfile(string accountId) { }

	public abstract Profile GetProfileBySide(ESideType side) { }

	public override ProfileStatus GetProfileStatus(bool isPet) { }

	public override void GetRaidReadyStatus(object readyStatusParams, Callback callback) { }

	public override Task GetReservedNickname() { }

	public abstract string GetSessionId(bool isPet) { }

	public override Task GetSupplyData(string traderId) { }

	public override Task GetTemplates(ItemTemplates returnInCaseOfCache) { }

	public override Task GetTraderAssortment(string traderId) { }

	public override Task GetTutorialInfo(bool skipTutorial = false) { }

	[AsyncStateMachine(typeof(<GetTutorialProfile>d__300))]
	public override Task GetTutorialProfile() { }

	public override void InsureItems(string[] items, string traderId, Callback callback) { }

	private Task InternalLoadLootContainerData() { }

	private Task InternalLoadLootContainerData(string containerId) { }

	public override void InviteToDialogue(string dialogId, string[] uid, Callback callback) { }

	public override Task IsMatchingAvailable() { }

	public override void LeaveChatDialogue(string dialogId, Callback callback) { }

	public override Task LeaveMatchmakerGroup() { }

	[AsyncStateMachine(typeof(<LoadBots>d__214))]
	public override Task LoadBots(List conditions) { }

	public override Task LoadLocale(string locale = null) { }

	public Task LoadLootContainerData(string containerId) { }

	public override Task LoadMainMenuLocale(string locale = null) { }

	[AsyncStateMachine(typeof(<LoadTexture>d__219))]
	protected static Task LoadTexture(string url) { }

	[AsyncStateMachine(typeof(<LoadTextureMain>d__216))]
	public override Task LoadTextureMain(string url) { }

	[AsyncStateMachine(typeof(<LoadTextureWithCache>d__217))]
	private Task LoadTextureWithCache(string baseUrl, string url) { }

	public override Task Logout() { }

	public override void MutePlayer(string uid, Callback callback) { }

	private void OnHttpTransportErrorHandled(ERequestErrorHandlingResult handlingResult) { }

	protected override void OnSessionErrorHandler(EBackendErrorCode errorCode, string errorMessage) { }

	private bool ParseMatchingAbortResult() { }

	private bool ParseMatchingResult(bool isPet) { }

	public override void PinDialog(string dialogId, Callback callback) { }

	public override void PinFriend(string friendId, Callback callback) { }

	public override bool PlayerAlreadyReported(string accountId, EReportType reportType) { }

	private void RaiseBindEvents(Result queueResult = null) { }

	public override void ReadEncyclopedia(string[] ids, Callback callback) { }

	private void ReadWaitingQueue() { }

	public abstract Task RedeemProfileRewards(ChatMessageProfileEvent[] rewards) { }

	public override void RefreshProfileStatuses(bool isPet, Callback callback = null) { }

	public override void RegisterCaptchaHandler(ICaptchaHandler captchaHandler) { }

	public override void RegisterProfileUpdater(string profileId, IProfileUpdatesHandler profileUpdater) { }

	[CompilerGenerated]
	private void remove__onFlushingChanged(Action value) { }

	[CompilerGenerated]
	public override void remove_InventoryErrorHappened(Action value) { }

	[CompilerGenerated]
	public override void remove_InventoryWarningHappened(Action value) { }

	[CompilerGenerated]
	public override void remove_OnSessionError(Action value) { }

	public abstract Task RemoveBuild(MongoID id) { }

	public override void RemoveFromDialogue(string dialogId, string uid, Callback callback) { }

	public override void RemoveFromFriendsList(string id, Callback callback) { }

	public override void RemovePlayerFromGroup(string profileAid, Callback callback) { }

	private void RemoveReportFromProfile(string aId, EReportType reportType) { }

	public override Task RepairItemsByTrader(string traderId, RepairItem repairItem) { }

	public override void ReportNickname(string aId, Callback callback) { }

	public abstract Task RequestBuilds() { }

	public override Task RequestCaptcha() { }

	public override Task RequestHandbookInfo(HandbookInfo returnInCaseOfCache = null) { }

	public abstract Task SaveEquipmentBuild(MongoID id, string name, string root, FlatItem[] items) { }

	public abstract Task SaveMagBuild(MagPreset preset) { }

	public abstract Task SaveWeaponBuild(MongoID id, string name, string root, FlatItem[] items) { }

	public override Task SellAllFromSavage(string playerId, string petId) { }

	private void SendCallback(object[] commandsToSend, Result result) { }

	public override void SendClientProfileSettings(Nullable groupInvitesRestrict, Nullable selectedIcon, Callback callback, Nullable prestigeGameMode = null) { }

	[AsyncStateMachine(typeof(<SendCommands>d__54))]
	private Task SendCommands() { }

	public override Task SendDisconnectEvent(string profileId, string clientHost, string serverHost) { }

	private void SendExitMatchRequest(Callback callback, bool isCallbackEmpty = false) { }

	[AsyncStateMachine(typeof(<SendExitMatchRequestTask>d__203))]
	private Task SendExitMatchRequestTask(Callback callback) { }

	public override void SendFriendRequest(string id, Callback callback) { }

	public override void SendGroupInvite(string accountId, bool inLobby, Callback callback) { }

	public override void SendLoadMetrics(int onlineAffiliation, int metricsType, int metricsValue, string locationName, bool isPMC) { }

	public override Task SendMetrics(ClientMetrics metrics) { }

	public override Task SendMetricsJson(string output, string error) { }

	protected void SendOperationQueued(object operation, Callback callback) { }

	public override void SendOperationQueued(object operation, Action execute, Callback callback) { }

	public override void SendOperationRightNow(object operation, Callback callback) { }

	private void SendRefreshRequest(bool isPet) { }

	public override void SendReport(EReportType reportType, string id, Callback callback) { }

	[CompilerGenerated]
	protected void set_AllProfiles(Profile[] value) { }

	[CompilerGenerated]
	private void set_AllProfileStatus(ProfileStatus[] value) { }

	[CompilerGenerated]
	private void set_BackEndConfig(GlobalConfigurationResponse value) { }

	[CompilerGenerated]
	private void set_ChatServers(ChatServerState[] value) { }

	[CompilerGenerated]
	public override void set_ExamineRequestFailed(Action value) { }

	[CompilerGenerated]
	protected void set_GameServers(GameServerPing[] value) { }

	[CompilerGenerated]
	private void set_InsuranceCompany(InsuranceCompany value) { }

	[CompilerGenerated]
	public override void set_IsFlushing(bool value) { }

	[CompilerGenerated]
	protected void set_IsGameSynced(bool value) { }

	[CompilerGenerated]
	public override void set_LastPlayerState(PlayerVisualRepresentation value) { }

	[CompilerGenerated]
	public override void set_LastPlayerStats(ProfileStats value) { }

	[CompilerGenerated]
	private void set_LimitedServersAvailability(bool value) { }

	[CompilerGenerated]
	protected void set_LocationSettings(LocationSettings value) { }

	[CompilerGenerated]
	protected void set_OverallAccountStats(CountersCollection value) { }

	protected void set_Profile(Profile value) { }

	[CompilerGenerated]
	protected void set_PurchasedGames(Dictionary value) { }

	[CompilerGenerated]
	public override void set_QueueStatus(EOperationQueueStatus value) { }

	[CompilerGenerated]
	protected void set_ReportAvailable(bool value) { }

	[CompilerGenerated]
	protected void set_TotalInGameTime(long value) { }

	public override void SetBotSettings(GlobalConfigurationResponse backEndSettings) { }

	public override void SetNotReadyReadyStatus(Callback callback) { }

	public override void SetReadyRaidStatus(Callback callback) { }

	public override Task StartGameGroupLeader(string groupId, bool isPet) { }

	public override Task StartGameGroupPlayer(string groupId, bool isPet) { }

	public override void StartKeepAliveCoroutine(int keepAliveInterval, bool keepAliveStaticInterval) { }

	public override Task StartLookingForGroup() { }

	[AsyncStateMachine(typeof(<StartMatching>d__227))]
	public override Task StartMatching(string locationId, bool isPet = false, EDateTime dateTime = 0, string keyId = "", Action estimateTimeSetter = null) { }

	public override void StopKeepAlive() { }

	public override Task StopLookingForGroup() { }

	[AsyncStateMachine(typeof(<SyncPlatformFriends>d__280))]
	public override Task SyncPlatformFriends(ELinkedPlatform platform) { }

	public override void TransferChatLeadership(string dialogId, string uid, Callback callback) { }

	public override void TransferGroupLeadership(string profileAid, Callback callback) { }

	public override void TrySendCommands() { }

	[AsyncStateMachine(typeof(<TryWaitForAppropriateStatus>d__191))]
	private Task TryWaitForAppropriateStatus(bool isPet) { }

	public override void UnmutePlayer(string uid, Callback callback) { }

	public override void UnpinDialog(string dialogId, Callback callback) { }

	public override void UnpinFriend(string friendId, Callback callback) { }

	public override void ValidateNickname(string profileNickname, Callback callback) { }

	[AsyncStateMachine(typeof(<WaitForAppropriateStatus>d__192))]
	private Task WaitForAppropriateStatus(bool isPet) { }

	[AsyncStateMachine(typeof(<WaitForProfileStatus>d__187))]
	public override Task WaitForProfileStatus(EProfileStatus status, EProfileStatus interruptStatus, bool isPet) { }

}

