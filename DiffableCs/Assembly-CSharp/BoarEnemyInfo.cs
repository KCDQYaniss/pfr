//Type is in global namespace

public class BoarEnemyInfo : EnemyInfo
{
	private readonly HashSet _current; //Field offset: 0x110
	private bool _isPermanentVision; //Field offset: 0x118

	public bool CanAttack
	{
		 get { } //Length: 8
	}

	private bool IsTraceLog
	{
		private get { } //Length: 45
	}

	public virtual EEnemyPartVisibleType VisibleType
	{
		 get { } //Length: 18
	}

	public BoarEnemyInfo(BotsGroup botsGroup, IPlayer enemy, BotOwner owner, BotGroupEnemyInfo groupInfo) { }

	public virtual void Dispose() { }

	public bool get_CanAttack() { }

	private bool get_IsTraceLog() { }

	public virtual EEnemyPartVisibleType get_VisibleType() { }

	public virtual string GetDebugInfo() { }

	private void OnComeToPlace(AIPlaceInfo place) { }

	private void OnLeavePlace(AIPlaceInfo place) { }

	private void RecheckSet(HashSet current) { }

	private void StartCheckPlaces() { }

}

