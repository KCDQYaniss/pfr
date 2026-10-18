//Type is in global namespace

public class ZryachiyEnemyInfo : EnemyInfo
{
	private const float ANY_ATTACK_AFTER_COME_SEC = 12; //Field offset: 0x0
	public bool CloseZone; //Field offset: 0x110
	private readonly HashSet _current; //Field offset: 0x118
	private bool _isPermanentVision; //Field offset: 0x120
	private bool _getHitFromThis; //Field offset: 0x121
	private float _firstTimeComeToAttack; //Field offset: 0x124
	private bool _firstTimeComeToAttackSetted; //Field offset: 0x128
	private bool _attackPossible; //Field offset: 0x129
	private float _comeToAttackPossible; //Field offset: 0x12C

	public virtual bool CanShoot
	{
		 get { } //Length: 26
	}

	protected virtual bool CheckPartCanShootOnlyIfVisible
	{
		 get { } //Length: 3
	}

	private bool IsTraceLog
	{
		private get { } //Length: 45
	}

	public virtual bool IsVisible
	{
		 get { } //Length: 19
	}

	public virtual EEnemyPartVisibleType VisibleType
	{
		 get { } //Length: 18
	}

	public ZryachiyEnemyInfo(BotsGroup botsGroup, IPlayer enemy, BotOwner owner, BotGroupEnemyInfo groupInfo) { }

	public bool CanShootCauseTime() { }

	public virtual void Dispose() { }

	public virtual bool get_CanShoot() { }

	protected virtual bool get_CheckPartCanShootOnlyIfVisible() { }

	private bool get_IsTraceLog() { }

	public virtual bool get_IsVisible() { }

	public virtual EEnemyPartVisibleType get_VisibleType() { }

	public virtual string GetDebugInfo() { }

	private void MarkEnemy(IBotOwner bot) { }

	private void OnComeToPlace(AIPlaceInfo place) { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	private void OnLeavePlace(AIPlaceInfo place) { }

	private void RecheckSet(HashSet current) { }

	public void SetGetHitFrom() { }

	public bool SpendedAtAttackZone(float period) { }

	private void StartCheckPlaces() { }

}

