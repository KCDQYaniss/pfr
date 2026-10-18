//Type is in global namespace

public class SectantPriestLayersStrategy : StrategyLayersWithCorePositions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <.ctor>b__16_0() { }

	}

	private const float CHEAT_VISION_DIST = 30; //Field offset: 0x0
	private const int SUICIDE = 1; //Field offset: 0x0
	private const int PATROL_LOGIC = 2; //Field offset: 0x0
	private const int TARGET_LOGIC = 3; //Field offset: 0x0
	private const int RUN_HIDE = 4; //Field offset: 0x0
	private const int GRENADE_DANGER = 5; //Field offset: 0x0
	private const int LEAVE_LAYER = 7; //Field offset: 0x0
	private const int WARNS_LAYER = 11; //Field offset: 0x0
	private const int MALFUNCTION_LAYER = 12; //Field offset: 0x0
	private float _nextCheckIsInside; //Field offset: 0x58
	private bool _isInside; //Field offset: 0x5C
	private readonly PatrolStayAtPositionLayer _patrolLogic; //Field offset: 0x60
	private readonly HideAndSuicideLayer _hideAndSuicide; //Field offset: 0x68
	private readonly RunAndHideFightLayer _runAndHide; //Field offset: 0x70
	private readonly LeaveMapLayer _leave; //Field offset: 0x78
	private float _nextCheckTime; //Field offset: 0x80

	public SectantPriestLayersStrategy(BotOwner owner) { }

	private void CheckEnemiesWithCheatVision() { }

	protected void CheckIsInside() { }

	public virtual void Dispose() { }

	protected virtual BotEventsPriority EventsPriority() { }

	public virtual void ManualUpdate() { }

	private void OnFollowerStatusChange(IBotOwner arg1, FollowerStatusChange arg2) { }

	public virtual void SetCorePosition(Vector3 pos) { }

	public virtual string ShortName() { }

	private void TryChangeToSuicide() { }

}

