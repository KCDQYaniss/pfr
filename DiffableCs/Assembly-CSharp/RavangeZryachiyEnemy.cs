//Type is in global namespace

public class RavangeZryachiyEnemy : BaseLogicLayer
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public Vector3 posEnemy; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal bool <FindPlaceToTeleport>b__0(GroupPoint point) { }

		internal bool <FindPlaceToTeleport>b__1(GroupPoint point) { }

	}

	public const float DIST_TO_MISFIRE = 60; //Field offset: 0x0
	public const float DELTA_START_ATTACK = 18; //Field offset: 0x0
	public const float DELTA_HIT_ATTACK = 12; //Field offset: 0x0
	public const float DIST_TO_RUN_TO_ENEMY = 15; //Field offset: 0x0
	public const float DIST_TO_TELEPORT = 60; //Field offset: 0x0
	public const float PERFECT_DIST = 50; //Field offset: 0x0
	public const int BUFF_UPDATE_TIME = 5; //Field offset: 0x0
	private float _nextPossibleTimeFind; //Field offset: 0x90
	private float _startFindMelee; //Field offset: 0x94
	private Vector3 _lastCheck; //Field offset: 0x98
	private float _nextPossibleDoMisfire; //Field offset: 0xA4
	private readonly HashSet _appliedMisfire; //Field offset: 0xA8

	public RavangeZryachiyEnemy(BotOwner bot, int priority) { }

	private bool CanShootAfterRun() { }

	public virtual void Dispose() { }

	protected virtual AICoreActionEnd EndGoToCoverPoint() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndOneMeleeAttack() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	private void FindPlaceToTeleport() { }

	public virtual AICoreActionResult GetDecision() { }

	protected virtual void ManualUpdate() { }

	public virtual string Name() { }

	private bool PossibleDoMelee() { }

	public virtual bool ShallUseNow() { }

	private void TryDoMisfire() { }

}

