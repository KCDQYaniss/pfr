//Type is in global namespace

public class FollowerCloseCoverBossWithStop : FollowerCloseCoverBoss
{
	private const float CHANCE_TO_STAY_100 = 50; //Field offset: 0x0
	private const float DIST_CLOSE_TO_TAGET = 5; //Field offset: 0x0
	private const float PERIOD_CHECK_STOP_SEC = 33; //Field offset: 0x0
	private const float PERIOD_STAY = 3; //Field offset: 0x0
	private float deltaDistDestBoss; //Field offset: 0x90
	private float sdistToStartEndend; //Field offset: 0x94
	private float sdistToStartRun; //Field offset: 0x98
	private float _nextChecWannaStop; //Field offset: 0x9C
	private float _nextChecWannaRun; //Field offset: 0xA0
	private bool _isStay; //Field offset: 0xA4
	private bool _shallRun; //Field offset: 0xA5

	public FollowerCloseCoverBossWithStop(BotOwner owner) { }

	public virtual void Activate() { }

	private void CheckWannaRun() { }

	private void LookWhileStop() { }

	private void RefreshLookDir() { }

	public virtual void Update() { }

}

