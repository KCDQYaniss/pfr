namespace EFT;

public sealed class DumbStatisticsManager : IStatisticsManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public DumbStatisticsManager <>4__this; //Field offset: 0x10
		public Item item; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal void <OnGrabLoot>b__0(Item itemInternal, bool b) { }

	}

	[CompilerGenerated]
	private Action OnUniqueLoot; //Field offset: 0x10
	private Player _player; //Field offset: 0x18
	private readonly HashSet _lootedItemsIds; //Field offset: 0x20
	private DateTime _startTime; //Field offset: 0x28

	public override event Action OnUniqueLoot
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public override TimeSpan CurrentSessionLength
	{
		 get { } //Length: 3
	}

	public DumbStatisticsManager() { }

	[CompilerGenerated]
	public override void add_OnUniqueLoot(Action value) { }

	public override void AddDoorExperience(bool breached) { }

	public override void BeginStatisticsSession() { }

	public override void EndStatisticsSession(ExitStatus exitStatus, float pastTime) { }

	public override TimeSpan get_CurrentSessionLength() { }

	public override void Init(Player player) { }

	public override void OnEnemyDamage(DamageInfo damage, EBodyPart bodyPart, string playerProfileId, EPlayerSide playerSide, WildSpawnType role, string groupId, float fullHealth, bool isHeavyDamage, float distance, int hour, List targetEquipment, HealthEffects enemyEffects, List zoneIds) { }

	public override void OnEnemyKill(DamageInfo damage, EDamageType lethalDamageType, EBodyPart bodyPart, EPlayerSide playerSide, WildSpawnType role, string playerAccountId, string playerProfileId, string playerName, string groupId, int level, int killExp, float distance, int hour, List targetEquipment, HealthEffects enemyEffects, List zoneIds, bool isFriendly, bool isAI) { }

	public override void OnGrabLoot(Item item) { }

	public override void OnGroupMemberConnected(Inventory inventory) { }

	public override void OnInteractWithLootContainer(Item item) { }

	public override void OnShot(Weapon weapon, Ammo ammo) { }

	[CompilerGenerated]
	public override void remove_OnUniqueLoot(Action value) { }

}

