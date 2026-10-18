//Type is in global namespace

public class BotPlayerFollowData : BotData
{
	private Vector3 _offset; //Field offset: 0x18
	private Vector3 _lastPlayerConnectionPlace; //Field offset: 0x24
	private float _lastPlayerConnectionTime; //Field offset: 0x30
	private float _setSprintTime; //Field offset: 0x34
	private float _nextRefreshGoTo; //Field offset: 0x38
	private IPlayer _toFollow; //Field offset: 0x40
	private bool _sprintNow; //Field offset: 0x48
	private readonly float SDIST_NOT_TO_FOLLOW; //Field offset: 0x4C
	private readonly float SDIST_CHECK; //Field offset: 0x50
	private readonly float SDIST_SPRINT; //Field offset: 0x54
	private readonly float PERIOD_CHECK; //Field offset: 0x58
	[CompilerGenerated]
	private bool <HaveFound>k__BackingField; //Field offset: 0x5C

	public string FollowGroupId
	{
		 get { } //Length: 78
	}

	public private bool HaveFound
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool HaveToFollow
	{
		 get { } //Length: 9
	}

	public BotPlayerFollowData(BotOwner owner) { }

	public void Dispose() { }

	public string get_FollowGroupId() { }

	[CompilerGenerated]
	public bool get_HaveFound() { }

	public bool get_HaveToFollow() { }

	public bool IsEnoughtDist() { }

	public bool IsFollower(IPlayer player) { }

	private void OnAddEnemyInfo(IPlayer person) { }

	private void OnGetHit(DamageInfo damageInfo, EBodyPart eBodyPart, float val) { }

	private void OnMasterDie(EDamageType obj) { }

	private void OnPlayerRemove(Player person) { }

	[CompilerGenerated]
	private void set_HaveFound(bool value) { }

	public void SetToFollow(IPlayer player) { }

	private void SprintControl() { }

	private void UnFollowPlayer(IPlayer person) { }

	private void UnSubscribe() { }

	public void UpdateFromNode() { }

}

