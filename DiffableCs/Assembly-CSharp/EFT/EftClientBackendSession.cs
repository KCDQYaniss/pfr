namespace EFT;

internal sealed class EftClientBackendSession : ClientBackendSession, IEftSession, IRepairController, IMatchmakerSession, IProfileSession, IBackendSession, IClientSession, ITradingSession, IImageLoader, ISocial, IQuestSession, ILocalizationLoader
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__81_0; //Field offset: 0x8
		public static Func <>9__81_1; //Field offset: 0x10
		public static Func <>9__81_2; //Field offset: 0x18
		public static Func <>9__82_0; //Field offset: 0x20
		public static Func <>9__90_1; //Field offset: 0x28
		public static Func <>9__90_0; //Field offset: 0x30
		public static Func <>9__132_0; //Field offset: 0x38
		public static Func <>9__132_1; //Field offset: 0x40
		public static Func <>9__132_2; //Field offset: 0x48
		public static Func <>9__132_3; //Field offset: 0x50
		public static Callback <>9__140_0; //Field offset: 0x58
		public static Func <>9__140_2; //Field offset: 0x60
		public static Callback <>9__157_0; //Field offset: 0x68
		public static Callback <>9__159_0; //Field offset: 0x70
		public static Callback <>9__165_0; //Field offset: 0x78
		public static Callback <>9__169_0; //Field offset: 0x80
		public static Func <>9__174_0; //Field offset: 0x88
		public static Func <>9__174_1; //Field offset: 0x90
		public static Func <>9__194_0; //Field offset: 0x98
		public static Func <>9__194_1; //Field offset: 0xA0
		public static Func <>9__195_0; //Field offset: 0xA8
		public static Func <>9__195_1; //Field offset: 0xB0
		public static Callback <>9__203_0; //Field offset: 0xB8
		public static Callback <>9__207_0; //Field offset: 0xC0

		private static <>c() { }

		public <>c() { }

		internal void <EFT.IQuestSession.AddQuestNote>b__203_0(IResult _) { }

		internal void <FinishCultistsProduction>b__159_0(IResult _) { }

		internal MongoID <GetCutscenesSubtitlesData>b__195_0(SubtitleDTO key) { }

		internal SubtitleParams[] <GetCutscenesSubtitlesData>b__195_1(SubtitleDTO value) { }

		internal void <GetExpansionsAccessData>b__207_0(Result _) { }

		internal int <GetFinals>b__82_0(Consequence elem) { }

		internal MongoID <GetTapesSubtitlesData>b__194_0(SubtitleDTO key) { }

		internal SubtitleParams[] <GetTapesSubtitlesData>b__194_1(SubtitleDTO value) { }

		internal ETraderServiceType <LocalRaidStarted>b__174_0(KeyValuePair serviceKvp) { }

		internal ServiceData <LocalRaidStarted>b__174_1(KeyValuePair serviceKvp) { }

		internal <>f__AnonymousType56 <RagfairPurchaseOffers>b__90_0(CommodityToPurchase x) { }

		internal <>f__AnonymousType12 <RagfairPurchaseOffers>b__90_1(ItemReference item) { }

		internal void <RefreshPings>b__140_0(Result _) { }

		internal GameServerPing <RefreshPings>b__140_2(GameServer server) { }

		internal MongoID <RequestBuilds>b__132_0(WeaponBuild x) { }

		internal WeaponBuild <RequestBuilds>b__132_1(WeaponBuild x) { }

		internal MongoID <RequestBuilds>b__132_2(EquipmentBuild x) { }

		internal EquipmentBuild <RequestBuilds>b__132_3(EquipmentBuild x) { }

		internal void <RestoreHealth>b__169_0(IResult _) { }

		internal Profile <SetProfiles>b__81_0(ProfileDescriptor descriptor) { }

		internal bool <SetProfiles>b__81_1(Profile value) { }

		internal bool <SetProfiles>b__81_2(Profile value) { }

		internal void <StartContinuousProduction>b__157_0(IResult _) { }

		internal void <ToggleArea>b__165_0(IResult _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass100_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public Profile profile; //Field offset: 0x18
		public TaskCompletionSource completionSource; //Field offset: 0x20

		public <>c__DisplayClass100_0() { }

		internal void <SetMainProfile>g__ApplyResult|0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass112_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public TaskCompletionSource completionSource; //Field offset: 0x18

		public <>c__DisplayClass112_0() { }

		internal void <GetSeasonalLeaguesRanks>g__ApplyResult|0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass113_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public TaskCompletionSource completionSource; //Field offset: 0x18

		public <>c__DisplayClass113_0() { }

		internal void <GetSeasonalLeaguesState>g__ApplyResult|0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass114_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public TaskCompletionSource completionSource; //Field offset: 0x18

		public <>c__DisplayClass114_0() { }

		internal void <GetSeasonalLeaderboardInfo>g__ApplyResult|0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass122_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10
		public EftClientBackendSession <>4__this; //Field offset: 0x18

		public <>c__DisplayClass122_0() { }

		internal void <GetWeatherAndTime>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass123_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public bool withCompleted; //Field offset: 0x18

		public <>c__DisplayClass123_0() { }

		internal Task <EFT.IQuestSession.RequestQuestsTemplates>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass137_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass137_0() { }

		internal void <FinishScavSession>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass139_0
	{
		public bool skipped; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass139_0() { }

		internal void <Co_CheckQueue>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass140_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public int sendPingResultInterval; //Field offset: 0x18
		public int pingServersInterval; //Field offset: 0x1C
		public Callback callback; //Field offset: 0x20

		public <>c__DisplayClass140_0() { }

		internal void <RefreshPings>b__1(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass152_0
	{
		public int value; //Field offset: 0x10

		public <>c__DisplayClass152_0() { }

		internal void <SetHideoutShootingRangeScore>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass153_0
	{
		public string schemeId; //Field offset: 0x10

		public <>c__DisplayClass153_0() { }

		internal void <StartSingleProduction>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass154_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass154_0() { }

		internal void <HideoutProductionCancel>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass163_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass163_0() { }

		internal void <StartImprovement>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass164_0
	{
		public Callback onComplete; //Field offset: 0x10

		public <>c__DisplayClass164_0() { }

		internal void <PutItemsInAreaSlots>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass166_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass166_0() { }

		internal void <TakeHideoutProduction>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass168_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass168_0() { }

		internal void <TakeItemsFromAreaSlotsAsync>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass172_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass172_0() { }

		internal void <GetGroupStatus>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass189_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass189_0() { }

		internal void <ObtainPrestige>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass190_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass190_0() { }

		internal void <ObtainFinalReward>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass197_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass197_0() { }

		internal void <MarkSurveyAsViewed>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass198_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass198_0() { }

		internal void <SendSurveyResult>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass74_0`1
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x0
		public Func request; //Field offset: 0x0
		public TaskCompletionSource completionSource; //Field offset: 0x0

		public <>c__DisplayClass74_0`1() { }

		internal void <RunProfileRequestLocked>g__ExecuteRequest|0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass92_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass92_0() { }

		internal void <GetCaptcha>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass93_0
	{
		public TaskCompletionSource taskSource; //Field offset: 0x10

		public <>c__DisplayClass93_0() { }

		internal void <ValidateCaptcha>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public EftClientBackendSession <>4__this; //Field offset: 0x10
		public long offerId; //Field offset: 0x18
		public Callback callback; //Field offset: 0x20

		public <>c__DisplayClass94_0() { }

		internal void <RagfairReportOffer>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass95_0
	{
		public TaskCompletionSource completionSource; //Field offset: 0x10

		public <>c__DisplayClass95_0() { }

		internal void <GetOffers>b__0(Result result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass99_0
	{
		public TaskCompletionSource source; //Field offset: 0x10

		public <>c__DisplayClass99_0() { }

		internal void <RedeemProfileRewards>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private struct <CheckVersion>d__170 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <Co_CheckQueue>d__139 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public Callback callback; //Field offset: 0x20
		private <>c__DisplayClass139_0 <>8__1; //Field offset: 0x28
		public EftClientBackendSession <>4__this; //Field offset: 0x30

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Co_CheckQueue>d__139(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <ConfirmSeasonalLeaguesRankEnd>d__115 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskCompletionSource <completionSource>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Destroy>d__204 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DownloadQuestTraderDialog>d__119 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID dialogId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EFT-IQuestSession-GetQuestsByCompletableItem>d__187 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID completableItemTemplateId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EFT-IQuestSession-RequestAchievementsGlobalProgress>d__186 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EFT-IQuestSession-RequestAchievementsTemplates>d__185 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public bool withCompleted; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EFT-IQuestSession-RequestQuestChains>d__124 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EstablishWSConnectionAsync>d__179 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private int <attempt>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <EstablishWSConnectionInternal>d__180 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private TaskAwaiter <>u__2; //Field offset: 0x30
		private TaskAwaiter <>u__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ExecuteProfileRequest>d__76`1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public TaskCompletionSource completionSource; //Field offset: 0x0
		public Func request; //Field offset: 0x0
		public EftClientBackendSession <>4__this; //Field offset: 0x0
		private TaskCompletionSource <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAreasQte>d__150 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetAreaTemplatesUnparsed>d__146 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetBaseTraderDialogs>d__193 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetCutscenesSubtitlesData>d__195 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetExpansionsAccessData>d__207 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public string body; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetExpansionsPlayerData>d__208 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFinalLocalization>d__83 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public string endingId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetFinals>d__82 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetHideoutCustomizationOffers>d__149 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetHideoutSettings>d__147 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetLevelSettings>d__120 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetProductionRecipes>d__148 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetProfiles>d__80 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetQuestTraderDialog>d__196 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID dialogId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetTapesSubtitlesData>d__194 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GetValidWSToken>d__182 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <IssueWSToken>d__177 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalRaidEnded>d__175 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SessionResult results; //Field offset: 0x20
		public EftClientBackendSession <>4__this; //Field offset: 0x28
		public LocalRaidSettings settings; //Field offset: 0x30
		public FlatItem[] lostInsuredItems; //Field offset: 0x38
		public Dictionary transferItems; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LocalRaidStarted>d__174 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public LocalRaidSettings settings; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ObtainFinalReward>d__190 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public string endingId; //Field offset: 0x28
		private <>c__DisplayClass190_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ObtainPrestige>d__189 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public PrestigeObtainData[] prestigeObtainData; //Field offset: 0x28
		private <>c__DisplayClass189_0 <>8__1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ObtainSeasonalReward>d__192 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID seasonalRewardConfigId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <Ping>d__141 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public int sendPingResultInterval; //Field offset: 0x28
		public int pingServersInterval; //Field offset: 0x2C
		public Callback callback; //Field offset: 0x30
		private Coroutine[] <>7__wrap1; //Field offset: 0x38
		private int <>7__wrap2; //Field offset: 0x40

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <Ping>d__141(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <PingCoroutine>d__142 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public int pingServersInterval; //Field offset: 0x28
		public int sendPingResultInterval; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <PingCoroutine>d__142(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <RemoveBuild>d__136 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID id; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestBuilds>d__132 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RequestSurvey>d__188 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ResendPings>d__144 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public int sendPingResultInterval; //Field offset: 0x28
		private int <pinging>5__2; //Field offset: 0x2C
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveEquipmentBuild>d__135 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID id; //Field offset: 0x28
		public string name; //Field offset: 0x40
		public string root; //Field offset: 0x48
		public FlatItem[] items; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveMagBuild>d__133 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MagPreset preset; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SaveWeaponBuild>d__134 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public MongoID id; //Field offset: 0x28
		public string name; //Field offset: 0x40
		public string root; //Field offset: 0x48
		public FlatItem[] items; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendQuestComplete>d__205 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public string questId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendQuestFail>d__206 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public string questId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SendTransactionSignRequest>d__209 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		public string transactionId; //Field offset: 0x28
		private TaskCompletionSource <completionSource>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <UpdatePings>d__143 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public GameServerPing server; //Field offset: 0x20
		public int timeout; //Field offset: 0x28
		public EftClientBackendSession <>4__this; //Field offset: 0x30
		public int sendPingResultInterval; //Field offset: 0x38
		private Ping <ping>5__2; //Field offset: 0x40
		private DateTime <dateTime>5__3; //Field offset: 0x48
		private TimeSpan <pingTimeout>5__4; //Field offset: 0x50

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <UpdatePings>d__143(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <WeatherRequest>d__121 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EftClientBackendSession <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum EProfileRequestPriority
	{
		Normal = 0,
		High = 1,
	}

	private sealed class PingLogger : AbstractLogger
	{

		public PingLogger() { }

	}

	private static int _serverIndex; //Field offset: 0x0
	private readonly PingLogger _pingLogger; //Field offset: 0x1C8
	private readonly HashSet _reportedOffers; //Field offset: 0x1D0
	private readonly object _profileRequestQueueLock; //Field offset: 0x1D8
	private readonly Queue _normalProfileRequests; //Field offset: 0x1E0
	private readonly Queue _highProfileRequests; //Field offset: 0x1E8
	private bool _profileRequestRunning; //Field offset: 0x1F0
	private string _wsAuthTokenB64; //Field offset: 0x1F8
	private string _wsSessionId; //Field offset: 0x200
	private Task _establishWSTask; //Field offset: 0x208
	[CompilerGenerated]
	private RepairController <RepairController>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private LocationSettings <LocationSettings>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	private FinalsResponse <FinalsResponse>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private float <ProfilesUpdateTime>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private ESeason <Season>k__BackingField; //Field offset: 0x22C
	[CompilerGenerated]
	private SeasonsSettings <SeasonsSettings>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	private WeatherNode <Weather>k__BackingField; //Field offset: 0x238
	[CompilerGenerated]
	private string <LocationTime>k__BackingField; //Field offset: 0x240
	[CompilerGenerated]
	private float <Acceleration>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	private readonly RagFair <RagFair>k__BackingField; //Field offset: 0x250
	[CompilerGenerated]
	private WeaponBuildsStorage <WeaponBuildsStorage>k__BackingField; //Field offset: 0x258
	[CompilerGenerated]
	private EquipmentBuildsStorage <EquipmentBuildsStorage>k__BackingField; //Field offset: 0x260
	[CompilerGenerated]
	private MagBuildsStorage <MagBuildsStorage>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	private Action OnLobbyPushNotificationReceived; //Field offset: 0x270
	[CompilerGenerated]
	private readonly SeasonRanksDataStorage <SeasonRankDataStorage>k__BackingField; //Field offset: 0x278

	public override event Action OnLobbyPushNotificationReceived
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private override float Acceleration
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private override EquipmentBuildsStorage EquipmentBuildsStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override FinalsResponse FinalsResponse
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override DateTime GetCurrentLocationTime
	{
		 get { } //Length: 397
	}

	public override bool IsLobbyConnectionEstablished
	{
		 get { } //Length: 39
	}

	public private override LocationSettings LocationSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override string LocationTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override MagBuildsStorage MagBuildsStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override float ProfilesUpdateTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public override RagFair RagFair
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override RepairController RepairController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override ESeason Season
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override SeasonRanksDataStorage SeasonRankDataStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override SeasonsSettings SeasonsSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override WeaponBuildsStorage WeaponBuildsStorage
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override WeatherNode Weather
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	internal EftClientBackendSession(HTTPTransportManager httpTransport, WsTransportManager wsTransport, BackendUrls backendUrls, LoginDataResponse loginData, BackendCache cache, GameModeDescriptor gameModeDescriptor) { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	private Task <EFT.IQuestSession.GetDailyQuests>b__125_0() { }

	[CompilerGenerated]
	private Task <EFT.IQuestSession.RequestQuestChains>b__124_0() { }

	[CompilerGenerated]
	private Task <LoadProfiles>b__79_0() { }

	[CompilerGenerated]
	public override void add_OnLobbyPushNotificationReceived(Action value) { }

	public override void CheckLoginQueue(Callback callback) { }

	[AsyncStateMachine(typeof(<CheckVersion>d__170))]
	public override Task CheckVersion() { }

	public override Task ClaimSeasonalLeaguesRankReward() { }

	[IteratorStateMachine(typeof(<Co_CheckQueue>d__139))]
	private IEnumerator Co_CheckQueue(Callback callback) { }

	public override Task CompleteUpgradeZone(int areaType) { }

	public override void ConfigureLobbyRelatedParameters(ClientSettingsConfig config) { }

	[AsyncStateMachine(typeof(<ConfirmSeasonalLeaguesRankEnd>d__115))]
	public override Task ConfirmSeasonalLeaguesRankEnd() { }

	[AsyncStateMachine(typeof(<Destroy>d__204))]
	public virtual Task Destroy() { }

	[AsyncStateMachine(typeof(<DownloadQuestTraderDialog>d__119))]
	public override Task DownloadQuestTraderDialog(MongoID dialogId) { }

	private override Task EFT.IQuestSession.AchievementComplete(string qid, bool removeExcessItems) { }

	private override void EFT.IQuestSession.AddQuestNote(string questId, MongoID conditionId, MongoID noteId) { }

	private override Task EFT.IQuestSession.GetDailyQuests() { }

	[AsyncStateMachine(typeof(<EFT-IQuestSession-GetQuestsByCompletableItem>d__187))]
	private override Task EFT.IQuestSession.GetQuestsByCompletableItem(MongoID completableItemTemplateId) { }

	private override Task EFT.IQuestSession.QuestAccept(string qid, bool isRepeatable) { }

	private override Task EFT.IQuestSession.QuestChange(string qid) { }

	private override Task EFT.IQuestSession.QuestFail(string qid) { }

	[AsyncStateMachine(typeof(<EFT-IQuestSession-RequestAchievementsGlobalProgress>d__186))]
	private override Task EFT.IQuestSession.RequestAchievementsGlobalProgress() { }

	[AsyncStateMachine(typeof(<EFT-IQuestSession-RequestAchievementsTemplates>d__185))]
	private override Task EFT.IQuestSession.RequestAchievementsTemplates(bool withCompleted) { }

	[AsyncStateMachine(typeof(<EFT-IQuestSession-RequestQuestChains>d__124))]
	private override Task EFT.IQuestSession.RequestQuestChains() { }

	private override Task EFT.IQuestSession.RequestQuestsTemplates(bool withCompleted) { }

	public override Task EstablishWSConnection() { }

	[AsyncStateMachine(typeof(<EstablishWSConnectionAsync>d__179))]
	private Task EstablishWSConnectionAsync() { }

	[AsyncStateMachine(typeof(<EstablishWSConnectionInternal>d__180))]
	private Task EstablishWSConnectionInternal() { }

	[AsyncStateMachine(typeof(<ExecuteProfileRequest>d__76`1))]
	private Task ExecuteProfileRequest(Func request, TaskCompletionSource completionSource) { }

	public override void FindById(long id, Callback callback) { }

	public override void FinishCultistsProduction(string schemeId) { }

	public override Task FinishScavSession() { }

	[CompilerGenerated]
	public override float get_Acceleration() { }

	[CompilerGenerated]
	public override EquipmentBuildsStorage get_EquipmentBuildsStorage() { }

	[CompilerGenerated]
	public override FinalsResponse get_FinalsResponse() { }

	public override DateTime get_GetCurrentLocationTime() { }

	public override bool get_IsLobbyConnectionEstablished() { }

	[CompilerGenerated]
	public override LocationSettings get_LocationSettings() { }

	[CompilerGenerated]
	public override string get_LocationTime() { }

	[CompilerGenerated]
	public override MagBuildsStorage get_MagBuildsStorage() { }

	[CompilerGenerated]
	public override float get_ProfilesUpdateTime() { }

	[CompilerGenerated]
	public override RagFair get_RagFair() { }

	[CompilerGenerated]
	public override RepairController get_RepairController() { }

	[CompilerGenerated]
	public override ESeason get_Season() { }

	[CompilerGenerated]
	public override SeasonRanksDataStorage get_SeasonRankDataStorage() { }

	[CompilerGenerated]
	public override SeasonsSettings get_SeasonsSettings() { }

	[CompilerGenerated]
	public override WeaponBuildsStorage get_WeaponBuildsStorage() { }

	[CompilerGenerated]
	public override WeatherNode get_Weather() { }

	[AsyncStateMachine(typeof(<GetAreasQte>d__150))]
	public override Task GetAreasQte() { }

	[AsyncStateMachine(typeof(<GetAreaTemplatesUnparsed>d__146))]
	public override Task GetAreaTemplatesUnparsed() { }

	[AsyncStateMachine(typeof(<GetBaseTraderDialogs>d__193))]
	public override Task GetBaseTraderDialogs() { }

	public override Task GetBattlePassData() { }

	public override Task GetCaptcha() { }

	[AsyncStateMachine(typeof(<GetCutscenesSubtitlesData>d__195))]
	public override Task GetCutscenesSubtitlesData() { }

	[AsyncStateMachine(typeof(<GetExpansionsAccessData>d__207))]
	public override Task GetExpansionsAccessData(string body) { }

	[AsyncStateMachine(typeof(<GetExpansionsPlayerData>d__208))]
	public override Task GetExpansionsPlayerData() { }

	[AsyncStateMachine(typeof(<GetFinalLocalization>d__83))]
	public override Task GetFinalLocalization(string endingId) { }

	[AsyncStateMachine(typeof(<GetFinals>d__82))]
	public override Task GetFinals() { }

	public virtual Task GetGlobalConfig() { }

	public override void GetGroupStatus(Callback callback) { }

	public override AreaInfo[] GetHideoutAreasInfo() { }

	[AsyncStateMachine(typeof(<GetHideoutCustomizationOffers>d__149))]
	public override Task GetHideoutCustomizationOffers() { }

	public override Dictionary GetHideoutImprovements() { }

	[AsyncStateMachine(typeof(<GetHideoutSettings>d__147))]
	public override Task GetHideoutSettings() { }

	public override int GetHideoutShootingRangeScore() { }

	[AsyncStateMachine(typeof(<GetLevelSettings>d__120))]
	public override Task GetLevelSettings() { }

	public override Task GetMainQuestSettings() { }

	public override void GetMarketPrices(string templateId, Callback callback) { }

	public override Task GetOffers(int page, int limit, int sortType, bool direction, int currency, int priceFrom, int priceTo, int quantityFrom, int quantityTo, int conditionFrom, int conditionTo, bool oneHourExpiration, bool removeBartering, int offerOwnerType, bool onlyFunctional, string handbookId, string linkedSearchId, string neededSearchId, Dictionary buildItems, int buildCount, bool updateOfferCount) { }

	public override string GetPhpSessionId() { }

	public override Task GetPrestigeSettings() { }

	[AsyncStateMachine(typeof(<GetProductionRecipes>d__148))]
	public override Task GetProductionRecipes() { }

	public virtual Profile GetProfileBySide(ESideType side) { }

	private Queue GetProfileRequestQueue(EProfileRequestPriority priority) { }

	[AsyncStateMachine(typeof(<GetProfiles>d__80))]
	public override Task GetProfiles() { }

	public override Task GetProfileVariables() { }

	public override Task GetQuestNoteTemplate() { }

	[AsyncStateMachine(typeof(<GetQuestTraderDialog>d__196))]
	public Task GetQuestTraderDialog(MongoID dialogId) { }

	private static string GetResponseHeader(Dictionary headers, string headerName) { }

	public override Task GetSeasonalLeaderboardInfo() { }

	public override Task GetSeasonalLeaguesRanks() { }

	public override Task GetSeasonalLeaguesState() { }

	public override Task GetSeasonalPerks() { }

	public override Task GetSeasonalRewards() { }

	public virtual string GetSessionId(bool isPet) { }

	[AsyncStateMachine(typeof(<GetTapesSubtitlesData>d__194))]
	public override Task GetTapesSubtitlesData() { }

	public override Task GetTraderSettings() { }

	[AsyncStateMachine(typeof(<GetValidWSToken>d__182))]
	public override Task GetValidWSToken() { }

	public override Task GetWeatherAndTime() { }

	private void HandleLobbyPushNotificationReceived(WsPushNotificationMessage message) { }

	public override Task HideoutProductionCancel(string recipeId) { }

	public override Task HideoutProductionReset(string recipeId) { }

	[AsyncStateMachine(typeof(<IssueWSToken>d__177))]
	public override Task IssueWSToken() { }

	private bool IsTokenExpired(string token) { }

	public override Task LoadGlobalConfig() { }

	private Task LoadProfiles(EProfileRequestPriority priority) { }

	public override Task LoadProfiles() { }

	[AsyncStateMachine(typeof(<LocalRaidEnded>d__175))]
	public override Task LocalRaidEnded(LocalRaidSettings settings, SessionResult results, FlatItem[] lostInsuredItems, Dictionary transferItems) { }

	[AsyncStateMachine(typeof(<LocalRaidStarted>d__174))]
	public override Task LocalRaidStarted(LocalRaidSettings settings) { }

	public override void MarkSurveyAsViewed(int surveyId) { }

	[AsyncStateMachine(typeof(<ObtainFinalReward>d__190))]
	public override Task ObtainFinalReward(string endingId) { }

	[AsyncStateMachine(typeof(<ObtainPrestige>d__189))]
	public override Task ObtainPrestige(PrestigeObtainData[] prestigeObtainData) { }

	[AsyncStateMachine(typeof(<ObtainSeasonalReward>d__192))]
	public override Task ObtainSeasonalReward(MongoID seasonalRewardConfigId) { }

	public override bool OfferAlreadyReported(long offerId) { }

	[IteratorStateMachine(typeof(<Ping>d__141))]
	private IEnumerator Ping(int sendPingResultInterval, int pingServersInterval, Callback callback) { }

	[IteratorStateMachine(typeof(<PingCoroutine>d__142))]
	private IEnumerator PingCoroutine(int sendPingResultInterval, int pingServersInterval) { }

	public override void PutItemsInAreaSlots(EAreaType areaType, Dictionary items, Callback onComplete) { }

	public override void RagfairAddOffer(bool sellInOnePiece, string[] items, BarterTemplate[] requirements, Callback callback) { }

	public override void RagfairGetPrices(Callback callback) { }

	public override Task RagfairPurchaseOffers(CommoditiesToPurchase commodities) { }

	public override void RagfairRemoveOffer(string offerId, Callback callback) { }

	public override void RagfairRenewOffer(string offerId, bool priority, int renewalTime, Callback callback) { }

	public override void RagfairReportOffer(long offerId, Callback callback) { }

	public override Task ReceiveCoopRaidSettings() { }

	public virtual Task RedeemProfileRewards(ChatMessageProfileEvent[] rewards) { }

	public override void RefreshPings(int sendPingResultInterval, int pingServersInterval, Callback callback = null) { }

	[CompilerGenerated]
	public override void remove_OnLobbyPushNotificationReceived(Action value) { }

	[AsyncStateMachine(typeof(<RemoveBuild>d__136))]
	public virtual Task RemoveBuild(MongoID id) { }

	public override Task RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItemId) { }

	[AsyncStateMachine(typeof(<RequestBuilds>d__132))]
	public virtual Task RequestBuilds() { }

	[AsyncStateMachine(typeof(<RequestSurvey>d__188))]
	public override Task RequestSurvey() { }

	[AsyncStateMachine(typeof(<ResendPings>d__144))]
	private Task ResendPings(int sendPingResultInterval) { }

	public override void RestoreHealth(HealthTreatmentData treatmentData, List cost, string traderId) { }

	private Task RunProfileRequestLocked(EProfileRequestPriority priority, Func request) { }

	private Task RunProfileRequestLocked(Func request) { }

	[AsyncStateMachine(typeof(<SaveEquipmentBuild>d__135))]
	public virtual Task SaveEquipmentBuild(MongoID id, string name, string root, FlatItem[] items) { }

	[AsyncStateMachine(typeof(<SaveMagBuild>d__133))]
	public virtual Task SaveMagBuild(MagPreset preset) { }

	[AsyncStateMachine(typeof(<SaveWeaponBuild>d__134))]
	public virtual Task SaveWeaponBuild(MongoID id, string name, string root, FlatItem[] items) { }

	private void ScheduleNextProfileRequest() { }

	[AsyncStateMachine(typeof(<SendQuestComplete>d__205))]
	public override Task SendQuestComplete(string questId) { }

	[AsyncStateMachine(typeof(<SendQuestFail>d__206))]
	public override Task SendQuestFail(string questId) { }

	public override Task SendRaidSettings(RaidSettings settings) { }

	public override void SendSurveyResult(SurveyAnswersData answerData) { }

	[AsyncStateMachine(typeof(<SendTransactionSignRequest>d__209))]
	public override Task SendTransactionSignRequest(string transactionId) { }

	[CompilerGenerated]
	private void set_Acceleration(float value) { }

	[CompilerGenerated]
	private void set_EquipmentBuildsStorage(EquipmentBuildsStorage value) { }

	[CompilerGenerated]
	private void set_FinalsResponse(FinalsResponse value) { }

	[CompilerGenerated]
	private void set_LocationSettings(LocationSettings value) { }

	[CompilerGenerated]
	private void set_LocationTime(string value) { }

	[CompilerGenerated]
	private void set_MagBuildsStorage(MagBuildsStorage value) { }

	[CompilerGenerated]
	private void set_ProfilesUpdateTime(float value) { }

	[CompilerGenerated]
	private void set_RepairController(RepairController value) { }

	[CompilerGenerated]
	private void set_Season(ESeason value) { }

	[CompilerGenerated]
	private void set_SeasonsSettings(SeasonsSettings value) { }

	[CompilerGenerated]
	private void set_WeaponBuildsStorage(WeaponBuildsStorage value) { }

	[CompilerGenerated]
	private void set_Weather(WeatherNode value) { }

	public override void SetDisplayedEnding(string endingId, Callback callback) { }

	public override void SetFavoriteItems(IEnumerable items, Callback callback = null) { }

	public override void SetHideoutCustomizationItem(MongoID offerId, Callback callback = null) { }

	public override void SetHideoutMannequinPose(Dictionary poses, Callback callback = null) { }

	public override void SetHideoutShootingRangeScore(int value) { }

	public override Task SetMainProfile(Profile profile) { }

	public override void SetProfiles(ProfileDescriptor[] profilesData) { }

	public override void StartContinuousProduction(string schemeId) { }

	public override Task StartCultistsProduction() { }

	public override void StartImprovement(string id, EAreaType areaType, IEnumerable items) { }

	public override Task StartScavCaseProduction(string schemeId, IEnumerable items, IEnumerable tools) { }

	public override void StartSingleProduction(string schemeId, IEnumerable items, IEnumerable tools) { }

	public override Task TakeHideoutProduction(string recipeId) { }

	public override void TakeItemsFromAreaSlots(EAreaType areaType, int[] slots, Callback callback) { }

	public override Task TakeItemsFromAreaSlotsAsync(EAreaType areaType, int[] slots) { }

	public override void ToggleArea(EAreaType areaType, bool enabled) { }

	public override Task Unpack(string targetItemId, string profileId) { }

	[IteratorStateMachine(typeof(<UpdatePings>d__143))]
	private IEnumerator UpdatePings(GameServerPing server, int timeout, int sendPingResultInterval) { }

	private void UpdateRepairs() { }

	private void UpdateTraders() { }

	public override Task UpgradeZone(int areaType, IEnumerable items) { }

	public override Task ValidateCaptcha(IEnumerable items, string captchaType) { }

	[AsyncStateMachine(typeof(<WeatherRequest>d__121))]
	public override Task WeatherRequest() { }

	public override void WorkoutEnded(IEnumerable results, string id, string aid, Callback callback) { }

}

