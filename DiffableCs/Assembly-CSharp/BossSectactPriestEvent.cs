//Type is in global namespace

public class BossSectactPriestEvent : ABossLogic
{
	private readonly Dictionary _idOfGroupToHold; //Field offset: 0x20
	private readonly Dictionary _idOfPlace; //Field offset: 0x28
	private float _nextPossibleRefreshCountOfSummon; //Field offset: 0x30
	private bool isFightNow; //Field offset: 0x34

	private BotHalloweenEvent _botHalloween
	{
		private get { } //Length: 48
	}

	private Vector3 _centerVector
	{
		private get { } //Length: 193
	}

	private bool _isEventRaised
	{
		private get { } //Length: 57
	}

	private AIPlaceInfoHalloweenCircle _targetCircle
	{
		private get { } //Length: 59
	}

	public BossSectactPriestEvent(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	public virtual void BossLogicUpdate() { }

	private int Checkbot(int isHolder, IBotOwner bot, int placeIndex) { }

	public virtual void Dispose() { }

	private BotHalloweenEvent get__botHalloween() { }

	private Vector3 get__centerVector() { }

	private bool get__isEventRaised() { }

	private AIPlaceInfoHalloweenCircle get__targetCircle() { }

	public Vector3 GetPosition(int ownerId) { }

	public Vector3 GetSummonCenter() { }

	private void OnFollowerStatusChange(IBotOwner bot, FollowerStatusChange status) { }

	private void RefreshMemberToHold() { }

	public virtual void SetPatrolMode() { }

	public bool ShouldCast(int id) { }

	public void StartRitual() { }

	private int TargetSummonCoutn() { }

}

