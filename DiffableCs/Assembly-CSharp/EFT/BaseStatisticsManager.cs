namespace EFT;

public abstract class BaseStatisticsManager : HealthStatisticsManager, IStatisticsManager
{
	[CompilerGenerated]
	private sealed class <Co_CalculateExperience>d__28 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public BaseStatisticsManager <>4__this; //Field offset: 0x20

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
		public <Co_CalculateExperience>d__28(int <>1__state) { }

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

	private const int HEALTH_EXP_SHOW_VALUE = 10; //Field offset: 0x0
	private const float CALL_DELAY = 1; //Field offset: 0x0
	private const string BEAR_GROUP = "Bear"; //Field offset: 0x0
	private const string USEC_GROUP = "Usec"; //Field offset: 0x0
	private const string ANY_PMC_GROUP = "AnyPmc"; //Field offset: 0x0
	private const string SCAV_GROUP = "Savage"; //Field offset: 0x0
	private const string ANY_GROUP = "Any"; //Field offset: 0x0
	private const string ENEMY_GROUP = "Enemy"; //Field offset: 0x0
	private const string BOT_GROUP = "Bot"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnUniqueLoot; //Field offset: 0x58
	protected Player Player; //Field offset: 0x60
	private readonly HashSet _lootedItemsIds; //Field offset: 0x68
	private readonly HashSet _foundItemsIds; //Field offset: 0x70
	private int _lastReachedFireIndex; //Field offset: 0x78
	private float _totalHealValue; //Field offset: 0x7C
	private float _totalEnergyValue; //Field offset: 0x80
	private float _totalHydrationValue; //Field offset: 0x84
	private DateTime _startTime; //Field offset: 0x88
	private int _lootingExp; //Field offset: 0x90
	private int _searchingExp; //Field offset: 0x94
	protected Coroutine _calculateExpCoroutine; //Field offset: 0x98
	protected Dictionary _stackableObjectsStartCount; //Field offset: 0xA0
	protected Action _unsubFromStatisticsEvents; //Field offset: 0xA8

	public override event Action OnUniqueLoot
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override TimeSpan CurrentSessionLength
	{
		 get { } //Length: 146
	}

	protected BaseStatisticsManager() { }

	[CompilerGenerated]
	public override void add_OnUniqueLoot(Action value) { }

	public override void AddDoorExperience(bool breached) { }

	public override void AddSide(List side, EPlayerSide playerSide, string playerProfileId) { }

	protected void AddTriggerExperience(string id, int experience) { }

	public virtual void BeginStatisticsSession() { }

	[IteratorStateMachine(typeof(<Co_CalculateExperience>d__28))]
	private IEnumerator Co_CalculateExperience() { }

	public override void EndStatisticsSession(ExitStatus exitStatus, float pastTime) { }

	protected void FillOverallCounters() { }

	public static void ForeachItems(Item item, Action action, bool grab = false) { }

	public override TimeSpan get_CurrentSessionLength() { }

	private Dictionary GetStackableObjectsCount() { }

	public override void Init(Player player) { }

	protected override bool IsNeedWriteLootExperience() { }

	private void MarkItemsAsFoundedAndLooted(Inventory inventory) { }

	protected override void OnDeath(Player player, IPlayer lastAggressor, DamageInfo damage, EBodyPart part) { }

	public override void OnEnemyDamage(DamageInfo damage, EBodyPart bodyPart, string playerProfileId, EPlayerSide playerSide, WildSpawnType role, string groupId, float fullHealth, bool isHeavyDamage, float distance, int hour, List targetEquipment, HealthEffects enemyEffects, List zoneIds) { }

	public override void OnEnemyKill(DamageInfo damage, EDamageType lethalDamageType, EBodyPart bodyPart, EPlayerSide playerSide, WildSpawnType role, string playerAccountId, string playerProfileId, string playerName, string groupId, int level, int killExp, float distance, int hour, List targetEquipment, HealthEffects enemyEffects, List zoneIds, bool isFriendly, bool isAI) { }

	public override void OnGrabLoot(Item item) { }

	public override void OnGroupMemberConnected(Inventory inventory) { }

	public override void OnInteractWithLootContainer(Item item) { }

	protected void OnItemFound(Item item) { }

	private void OnLootItem(Item item, bool grab) { }

	public override void OnShot(Weapon weapon, Ammo ammo) { }

	private void OnShotCheckRSP(Weapon weapon, Ammo ammo) { }

	[CompilerGenerated]
	public override void remove_OnUniqueLoot(Action value) { }

	private void ShowLootingNotification(int exp, bool grab) { }

}

