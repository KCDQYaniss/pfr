//Type is in global namespace

public class TerminalWavesController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8
		public static Func <>9__25_2; //Field offset: 0x10
		public static Func <>9__27_0; //Field offset: 0x18
		public static Func <>9__27_1; //Field offset: 0x20
		public static Func <>9__27_2; //Field offset: 0x28
		public static Func <>9__27_3; //Field offset: 0x30
		public static Func <>9__27_4; //Field offset: 0x38
		public static Func <>9__27_5; //Field offset: 0x40
		public static Func <>9__27_6; //Field offset: 0x48

		private static <>c() { }

		public <>c() { }

		internal bool <Init>b__25_0(AIPlaceInfo x) { }

		internal bool <Init>b__25_2(BotZone x) { }

		internal bool <PrintLogsBotsCount>b__27_0(BotOwner b) { }

		internal Nullable <PrintLogsBotsCount>b__27_1(BotOwner b) { }

		internal bool <PrintLogsBotsCount>b__27_2(Nullable t) { }

		internal WildSpawnType <PrintLogsBotsCount>b__27_3(Nullable t) { }

		internal WildSpawnType <PrintLogsBotsCount>b__27_4(IGrouping g) { }

		internal int <PrintLogsBotsCount>b__27_5(IGrouping g) { }

		internal string <PrintLogsBotsCount>b__27_6(KeyValuePair k) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass25_0
	{
		public TerminalWavesController <>4__this; //Field offset: 0x10
		public AIPlaceTerminalWavesController info; //Field offset: 0x18
		public BotsController botsController; //Field offset: 0x20

		public <>c__DisplayClass25_0() { }

		internal void <Init>g__OnSpawnerSetted|1(BotSpawner obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public bool isOpen; //Field offset: 0x10
		public BotOwner bot; //Field offset: 0x18

		public <>c__DisplayClass31_0() { }

		internal void <ActivateBots>g__OnSetStrategy|0(BaseBrain obj) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public BotOwner bot; //Field offset: 0x10
		public TerminalWavesController <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal void <CheckAndSetBotStateWithBotState>g__OnBotStateChange|0(EBotState obj) { }

		internal void <CheckAndSetBotStateWithBotState>g__OnSetStrategy|1(BaseBrain obj) { }

	}

	[CompilerGenerated]
	private struct <BlockAndBanishZone>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TerminalWavesController <>4__this; //Field offset: 0x20
		public BotZone banishZone; //Field offset: 0x28
		public BotZone zoneToMigrate; //Field offset: 0x30
		private bool <haveUnMigrated>5__2; //Field offset: 0x38
		private Enumerator <>7__wrap2; //Field offset: 0x40
		private BotOwner <bot>5__4; //Field offset: 0x58
		private YieldAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <DoMigration>d__39 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TerminalWavesController <>4__this; //Field offset: 0x20
		private int <i>5__2; //Field offset: 0x28
		private Enumerator <>7__wrap2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string TERMINAL_LOCATION = "Terminal"; //Field offset: 0x0
	private Dictionary _migrationZones; //Field offset: 0x10
	private Dictionary _percentToStay; //Field offset: 0x18
	private Dictionary _mimimumCountToStay; //Field offset: 0x20
	private Dictionary _zoneByBots; //Field offset: 0x28
	private Dictionary _remainBots; //Field offset: 0x30
	private Dictionary _blockOnStart; //Field offset: 0x38
	private Dictionary _keyToUnlockStage; //Field offset: 0x40
	private Dictionary _killed; //Field offset: 0x48
	private int _curStage; //Field offset: 0x50
	private List _allWaves; //Field offset: 0x58
	private BotsController _botsController; //Field offset: 0x60
	private bool _migrationProcess; //Field offset: 0x68
	private List _blockBots; //Field offset: 0x70
	private int _migratedCount; //Field offset: 0x78
	private int _unMigratedCount; //Field offset: 0x7C
	private int _maxStage; //Field offset: 0x80
	private int _isKilledByPlayer; //Field offset: 0x84
	private int _isKilledByAI; //Field offset: 0x88
	private int _minute; //Field offset: 0x8C
	private bool _cutSceneProcess; //Field offset: 0x90
	private TermianlNewSpawnController _newSpawnController; //Field offset: 0x98
	private AIPeriodAction _actToMigrate; //Field offset: 0xA0
	private AIPeriodAction _logsPrint; //Field offset: 0xA8
	private Action _unsubscribeAction; //Field offset: 0xB0

	public TerminalWavesController() { }

	private void ActivateBots(BotOwner bot) { }

	[AsyncStateMachine(typeof(<BlockAndBanishZone>d__41))]
	private Task BlockAndBanishZone(BotZone banishZone, BotZone zoneToMigrate) { }

	private void BotActiveState(CutSceneChangeBotState obj) { }

	private int CalcBotsAtStage(int curStage) { }

	private void CheckAndSetBotStateWithBotState(BotOwner bot) { }

	private void CheckBotToLock(BotOwner bot) { }

	public void Dispose() { }

	[AsyncStateMachine(typeof(<DoMigration>d__39))]
	private Task DoMigration() { }

	private void EventCheck(string key) { }

	public void Init(BotsController botsController, BotsForceAttackEvent forceAttack) { }

	public bool IsAtBlockedZone(BotOwner owner) { }

	private void LogInfoOnAdd(BotOwner botOwner) { }

	public void ManualUpdate() { }

	private bool MigrateBotsTo(BotOwner bot, BotZone zoneToMigrate) { }

	private void OnBotAdd(BotOwner obj) { }

	private void OnBotRemove(BotOwner obj) { }

	private void OnEvent(string obj) { }

	private void OnInteractObject(string doorid, Vector3 position) { }

	private void PeriodMigration() { }

	private void PrintLogsBotsCount() { }

	public void SetStage(int nextStage) { }

	private bool ShouldProcessBot(BotOwner owner) { }

}

