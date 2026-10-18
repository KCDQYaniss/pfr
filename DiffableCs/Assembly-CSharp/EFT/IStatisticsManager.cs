namespace EFT;

public interface IStatisticsManager
{

	public event Action OnUniqueLoot
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public TimeSpan CurrentSessionLength
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnUniqueLoot(Action value) { }

	public void AddDoorExperience(bool breached) { }

	public void BeginStatisticsSession() { }

	public void EndStatisticsSession(ExitStatus exitStatus, float pastTime) { }

	public TimeSpan get_CurrentSessionLength() { }

	public void Init(Player player) { }

	public void OnEnemyDamage(DamageInfo damage, EBodyPart bodyPart, string playerProfileId, EPlayerSide playerSide, WildSpawnType role, string groupId, float fullHealth, bool isHeavyDamage, float distance, int hour, List targetEquipment, HealthEffects enemyEffects, List zoneIds) { }

	public void OnEnemyKill(DamageInfo damage, EDamageType lethalDamageType, EBodyPart bodyPart, EPlayerSide playerSide, WildSpawnType role, string playerAccountId, string playerProfileId, string playerName, string groupId, int level, int killExp, float distance, int hour, List targetEquipment, HealthEffects enemyEffects, List zoneIds, bool isFriendly, bool isAI) { }

	public void OnGrabLoot(Item item) { }

	public void OnGroupMemberConnected(Inventory inventory) { }

	public void OnInteractWithLootContainer(Item item) { }

	public void OnShot(Weapon weapon, Ammo ammo) { }

	[CompilerGenerated]
	public void remove_OnUniqueLoot(Action value) { }

}

