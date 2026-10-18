//Type is in global namespace

public class InfectedLayersStrategy : BaseBrain
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public InfectedLayersStrategy <>4__this; //Field offset: 0x10
		public IEnumerable allPlayers; //Field offset: 0x18
		public float sDistTooClose; //Field offset: 0x20
		public Vector3 point; //Field offset: 0x24

		public <>c__DisplayClass14_0() { }

		internal bool <TeleportBotNearToTarget>b__0(Player x) { }

		internal bool <TeleportBotNearToTarget>g__IsGoodPoint|1(GroupPoint pointToCheck) { }

	}

	private const int ATTACK_LOGIC = 1; //Field offset: 0x0
	private const int TARGET_LOGIC = 2; //Field offset: 0x0
	private const int PATROL_LOGIC = 3; //Field offset: 0x0
	private const int WAIT_LOGIC = 5; //Field offset: 0x0
	private const int FIGHT_REQUEST = 6; //Field offset: 0x0
	private const int PATROL_REQUEST = 7; //Field offset: 0x0
	private BotHalloweenEventPursuit _activePursuit; //Field offset: 0x58
	private InfectedAttackLayer _attackLayer; //Field offset: 0x60
	private EZombieMode zombieModeByDifficulty; //Field offset: 0x68
	private InfectedTargetLayer _infectedTargetLayer; //Field offset: 0x70

	public EZombieMode CurrentZombieMode
	{
		 get { } //Length: 29
	}

	public InfectedLayersStrategy(BotOwner owner) { }

	private void Call(Vector3 positionToCheck, float callRadiusSqr, BotHalloweenEventPursuit activePursuit) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public EZombieMode get_CurrentZombieMode() { }

	public static EZombieMode GetZombieModeByDifficulty(BotDifficulty difficulty) { }

	public virtual void ManualUpdate() { }

	public void SetCanAttack(bool canAttack) { }

	public virtual string ShortName() { }

	private void TeleportBotNearToTarget(Vector3 point) { }

}

