//Type is in global namespace

public class WarnPlayerRequest
{
	private const float TIME_TO_SHOOT = 3; //Field offset: 0x0
	private const float TIME_TO_SHOW_AND_SAY = 3; //Field offset: 0x0
	private const int TRIGGER_DOWN_TO_COMPLETE = 3; //Field offset: 0x0
	private float _comeToPointTime; //Field offset: 0x10
	private float _nextUpdTimer; //Field offset: 0x14
	private float _sayTime; //Field offset: 0x18
	private float _sayTime2; //Field offset: 0x1C
	private int actionsDone; //Field offset: 0x20
	private int shootsDone; //Field offset: 0x24
	private Vector3 _cachedPointToShoot; //Field offset: 0x28
	private float _stayEndTime; //Field offset: 0x34
	private bool _isStopSays; //Field offset: 0x38
	private bool _isStopSays2; //Field offset: 0x39
	private EnemyInfo warnTargetEnemyInfo; //Field offset: 0x40
	private readonly float WARN_TARGET_VISION_CHECK_PERIOD; //Field offset: 0x48
	private readonly float SDIST_TO_POSSIBLE_START_WARNING; //Field offset: 0x4C
	private float _lastWarnTargetVisionCheck; //Field offset: 0x50
	private bool _cachedCheckLookToWarnTarget; //Field offset: 0x54
	private float _outDist; //Field offset: 0x58
	private float _nextCloseCheck; //Field offset: 0x5C
	private bool _isClose; //Field offset: 0x60
	private readonly PlayerWarnData _dataWarn; //Field offset: 0x68
	private int _preferableExecuter; //Field offset: 0x70
	private float _endPreferableExecuterPeriod; //Field offset: 0x74
	[CompilerGenerated]
	private readonly IPlayer <playerToWarn>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private StateWarnPlayer <StateWarnPlayer>k__BackingField; //Field offset: 0x80
	private bool CanExecuteByMyself; //Field offset: 0x84
	private bool EndIfCantExecute; //Field offset: 0x85
	private BotOwner Executor; //Field offset: 0x88
	private float _takenTime; //Field offset: 0x90

	public float EndTime
	{
		 get { } //Length: 17
	}

	public IPlayer playerToWarn
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StateWarnPlayer StateWarnPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public WarnPlayerRequest(BotOwner executor, IPlayer player, PlayerWarnData dataWarn) { }

	private void CachePointToShoot() { }

	public bool CanProceed() { }

	private bool CheckDistToBoss() { }

	public void Complete() { }

	public void Dispose() { }

	private float DistToWarning(BotOwner executor, IPlayer playerToWarn) { }

	private float DistToWarningBear(BotOwner executor, IPlayer playerToWarn) { }

	private float DistToWarningDelta(BotOwner executor, IPlayer playerToWarn) { }

	private float DistToWarningUsec(BotOwner executor, IPlayer playerToWarn) { }

	public float get_EndTime() { }

	[CompilerGenerated]
	public IPlayer get_playerToWarn() { }

	[CompilerGenerated]
	public StateWarnPlayer get_StateWarnPlayer() { }

	private bool IsDistTooFar() { }

	private bool IsPointEnoughFarAwayFromBoss(PatrolPoint point) { }

	public void NextState() { }

	private void OnTriggerPressed() { }

	public Vector3 PointToShoot() { }

	private void Randomize() { }

	private void ReactBotPlayer() { }

	private void SayMutterOrRoger(bool onlyRoger = false) { }

	[CompilerGenerated]
	public void set_StateWarnPlayer(StateWarnPlayer value) { }

	public void SetWarnStarted() { }

	public bool ShallEndStay() { }

	public bool ShouldWarnFromCurrentPosition() { }

	public bool UpdateSay(bool onlyRoger = false) { }

}

