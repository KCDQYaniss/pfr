//Type is in global namespace

public class BotsMinotaurLabirint
{
	public const string EVENT_FOR_KILLA = "EVENT_FOR_KILLA"; //Field offset: 0x0
	public const float SEEN_TOO_LONG_TIME_AGO = 10; //Field offset: 0x0
	private BotOwner _bot; //Field offset: 0x10
	private bool _isInited; //Field offset: 0x18
	private bool _isBossDeath; //Field offset: 0x19
	private Nullable _controlPosition; //Field offset: 0x1C
	private float _nextSendInfo; //Field offset: 0x2C
	private float _nextSendToBossInfo; //Field offset: 0x30
	private BotsController _bots; //Field offset: 0x38
	private Dictionary _lastEnemySeenByHelpers; //Field offset: 0x40

	public Nullable ControlPosition
	{
		 get { } //Length: 11
	}

	public BotsMinotaurLabirint() { }

	public void Dispose() { }

	public Nullable get_ControlPosition() { }

	public void Init(BotOwner bot, BotsController bots) { }

	public bool IsHelpersSeen(int enemyId, float period = 2) { }

	private void OnBotAdd(BotOwner obj) { }

	private void OnBotRemove(BotOwner obj) { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	private void OnReportToBoss(IPlayer enemy, Vector3 enemypos, Vector3 weaponrootlast, EEnemyPartVisibleType isvisibleonlybysense, BotOwner reporter) { }

	private void OnReportToHelpers(IPlayer enemy, Vector3 enemypos, Vector3 weaponrootlast, EEnemyPartVisibleType isvisibleonlybysense, BotOwner reporter) { }

	public void ReportInfo(IPlayer enemyPerson, BotOwner reporter) { }

	public void TagillaDeath(BotOwner obj) { }

}

