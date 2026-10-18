//Type is in global namespace

public class BossPartisanLayersStrategy : BaseBrain
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__15_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__15_0() { }

	}

	private const int ENEMY_LOGIC = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int TARGET_LOGIC_MANY = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int PUT_MINES = 6; //Field offset: 0x0
	private const int PERSUIT_ENEMY = 7; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private const int MANY = 14; //Field offset: 0x0
	private const int PUT_MINES_ALL = 17; //Field offset: 0x0
	private const int HOLD_OR_COVER_LAYER = 18; //Field offset: 0x0
	private const int TARGET_ZERO_SAVAGE = 16; //Field offset: 0x0
	private const int TARGET_GOTO_SAVAGE = 15; //Field offset: 0x0
	private float _lastChange; //Field offset: 0x58
	private PatrolStayAtPositionLayer _patrolLogic; //Field offset: 0x60

	public BossPartisanLayersStrategy(BotOwner owner) { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	private void OnExitTriggerVisited() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	public virtual string ShortName() { }

}

