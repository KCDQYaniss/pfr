//Type is in global namespace

public class PushAndSuppressAssaultLayer : WithCutDistLayer
{
	private float _lastSuppress; //Field offset: 0xA8
	private bool _withSupperss; //Field offset: 0xAC
	private float DIST_TO_ATTACK; //Field offset: 0xB0

	private float HIDE_DIST
	{
		private get { } //Length: 58
	}

	private float PUSH_ENEMY_DIST
	{
		private get { } //Length: 58
	}

	public PushAndSuppressAssaultLayer(BotOwner bot, int priority, float attackDist = 20) { }

	protected virtual AICoreActionEnd EndAttackMovingFlank() { }

	protected virtual AICoreActionEnd EndHoldPosition() { }

	protected virtual AICoreActionEnd EndRunToCover() { }

	protected virtual AICoreActionEnd EndRunToEnemy() { }

	protected virtual AICoreActionEnd EndShootFromPlace() { }

	protected virtual AICoreActionEnd EndSuppressFire() { }

	public virtual CustomNavigationPoint FindPoint(CoverSearchData data, Func p, bool checkCurrent) { }

	private float get_HIDE_DIST() { }

	private float get_PUSH_ENEMY_DIST() { }

	public virtual AICoreActionResult GetDecision() { }

	public virtual string Name() { }

	public virtual bool ShallUseNow() { }

}

