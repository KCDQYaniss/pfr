//Type is in global namespace

public class BossZryachiy : ABossLogic
{
	public const int MAX_RESPAWNS = 3; //Field offset: 0x0
	private const float MAX_GRENADE_LAUNCHER = 600; //Field offset: 0x0
	private AIPlaceInfo _controllbalePlace; //Field offset: 0x20
	private HashSet _personsWithCard; //Field offset: 0x28
	private int _respawnedSupports; //Field offset: 0x30
	private readonly HashSet _firstAttackers; //Field offset: 0x38
	private float _nextPeriodCheck; //Field offset: 0x40
	private readonly float BOSS_ZRYACHIY_ADD_TO_ENEMY_SQRT; //Field offset: 0x44
	[CompilerGenerated]
	private bool <IsManyEnemy>k__BackingField; //Field offset: 0x48

	public private bool IsManyEnemy
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BossZryachiy(BotOwner owner, BotBoss bossLogic) { }

	[CompilerGenerated]
	private void <BossLogicUpdate>g__CheckIsEnemyClose|16_0(IPlayer info, BotOwner closestBot) { }

	[CompilerGenerated]
	private bool <RefreshAllEnemiesAtZone>b__29_0(Player player) { }

	[CompilerGenerated]
	private void <TryRespawnHelp>b__26_0() { }

	public virtual void Activate() { }

	private void AddEnemiesWithGroup(DamageInfo damageinfo) { }

	public void AddEnemy(IPlayer person) { }

	public virtual void BossLogicUpdate() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public bool get_IsManyEnemy() { }

	public bool HaveHitFrom(IPlayer player) { }

	private void KillSmb(Player player, IPlayer lastaggressor, DamageInfo damageinfo, EBodyPart part) { }

	public void MarkEnemyAsFirstAttacker(int personId) { }

	private void OnBeenKilledByAggressor(Player player, IPlayer lastaggressor, DamageInfo damageinfo, EBodyPart part) { }

	private void OnBeingHit(DamageInfo damageinfo, Player victim) { }

	private void OnFollowerBeenKilledByAggressor(Player player, IPlayer lastaggressor, DamageInfo damageinfo, EBodyPart part) { }

	private void OnFollowerGetHit(DamageInfo damage, EBodyPart part, float val) { }

	private void OnFollowerStatusChange(IBotOwner follower, FollowerStatusChange st) { }

	private void OnGetHit(DamageInfo damage, EBodyPart arg2, float arg3) { }

	private void OnPlayerEnter(Player obj) { }

	private void OnPlayerExit(Player obj) { }

	private void OnSoundPlayed(IPlayer player, Vector3 position, float power, AISoundType type) { }

	private void RefreshAllEnemiesAtZone() { }

	[CompilerGenerated]
	private void set_IsManyEnemy(bool value) { }

	public virtual void SetPatrolMode() { }

	private void SubscribeToHit(IBotOwner follower) { }

	private void TryRespawnHelp() { }

}

