//Type is in global namespace

public class BossKolontayLayersStrategy : BaseBrain
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public IBotOwner mem; //Field offset: 0x10

		public <>c__DisplayClass13_0() { }

		internal void <AllTrySay>b__0() { }

	}

	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int ENEMY_LOGIC_SOLO = 7; //Field offset: 0x0
	private const int ENEMY_LOGIC_PROTECT = 8; //Field offset: 0x0
	private const int ENEMY_NOT_MY_HOUSE = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const float ENEMY_TO_DISTANCE_TO_STOP_MELEE = 5; //Field offset: 0x0
	private BossKolontaySoloFight _soloFightLayer; //Field offset: 0x58
	private BossKolontayFightLayer _fightLayer; //Field offset: 0x60

	public BossKolontayLayersStrategy(BotOwner owner) { }

	private void AllTrySay() { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	private void OnBeingHit(DamageInfo damageInfo, EBodyPart bodyPart, float damageReducedByArmor) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnTryHit(BotOwner obj) { }

	public virtual string ShortName() { }

}

