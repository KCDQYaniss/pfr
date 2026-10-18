//Type is in global namespace

public class PatrollingData : BotData
{
	public BotPointControl PointControl; //Field offset: 0x18
	public PatrolPathControl PatrolPathControl; //Field offset: 0x20
	public BotMoveByReservWay MoveByReservWay; //Field offset: 0x28
	public IBotOwner _lastFriend; //Field offset: 0x30
	private float _nextFriendSearch; //Field offset: 0x38
	private float _nextTalk; //Field offset: 0x3C
	private float _nextTimeCanRecalc; //Field offset: 0x40
	private PatrolStatus _status; //Field offset: 0x44
	private PatrolStatus _prevStatus; //Field offset: 0x48
	private float _comeTime; //Field offset: 0x4C
	private float _reservChoosedTime; //Field offset: 0x50
	private bool _needUpdateNextPoint; //Field offset: 0x54
	private PatrolLootPointsData _lootData; //Field offset: 0x58
	private PatrolExfiltrationPointsData _exfiltrationData; //Field offset: 0x60
	private IPatrolMove PatrolMove; //Field offset: 0x68
	private IPatrolLook PatrolLook; //Field offset: 0x70
	private BotObserveData _botObserveData; //Field offset: 0x78
	private readonly List _suspetionPlaces; //Field offset: 0x80
	private float _recheckPeriod; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnPatrolPointCome; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnStatusChanged; //Field offset: 0x98
	[CompilerGenerated]
	private readonly float <SpeedPatrol>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private bool <IsActivated>k__BackingField; //Field offset: 0xA4
	[CompilerGenerated]
	private Vector3 <CurTargetPoint>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private PatrolPointChooserBasic <PointChooser>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private float <ComeToPointTime>k__BackingField; //Field offset: 0xC0
	private bool _isMethodsInited; //Field offset: 0xC4

	public event Action OnPatrolPointCome
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnStatusChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private float ComeToPointTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public override PatrolPointContainer CurPatrolPoint
	{
		 get { } //Length: 27
	}

	public private Vector3 CurTargetPoint
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public PatrolExfiltrationPointsData ExfiltrationData
	{
		 get { } //Length: 5
	}

	public private bool IsActivated
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public PatrolLootPointsData LootData
	{
		 get { } //Length: 5
	}

	public private PatrolPointChooserBasic PointChooser
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float SpeedPatrol
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public private PatrolStatus Status
	{
		 get { } //Length: 4
		private set { } //Length: 234
	}

	public PatrolWay Way
	{
		 get { } //Length: 15
	}

	public PatrollingData(BotOwner owner) { }

	[CompilerGenerated]
	private void <ComeToPoint>b__67_0() { }

	[CompilerGenerated]
	private void <ComeToPoint>b__67_1() { }

	[CompilerGenerated]
	private void <ComeToPoint>b__67_2() { }

	[CompilerGenerated]
	private void <ComeToPoint>b__67_3() { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnPatrolPointCome(Action value) { }

	[CompilerGenerated]
	public void add_OnStatusChanged(Action value) { }

	private void BossGoNextPoint() { }

	public void ComeToPoint() { }

	public static PatrollingData Create(BotOwner owner) { }

	public void Disable() { }

	public void Dispose() { }

	public void DrawGizomsSelectedFromBot() { }

	public void FindNextPoint(bool withSetting, bool withoutNext, PatrolPointFilterDelegate pointFilter = null) { }

	[CompilerGenerated]
	public float get_ComeToPointTime() { }

	public override PatrolPointContainer get_CurPatrolPoint() { }

	[CompilerGenerated]
	public Vector3 get_CurTargetPoint() { }

	public PatrolExfiltrationPointsData get_ExfiltrationData() { }

	[CompilerGenerated]
	public bool get_IsActivated() { }

	public PatrolLootPointsData get_LootData() { }

	[CompilerGenerated]
	public PatrolPointChooserBasic get_PointChooser() { }

	[CompilerGenerated]
	public float get_SpeedPatrol() { }

	public PatrolStatus get_Status() { }

	public PatrolWay get_Way() { }

	public static PatrolPointChooserBasic GetPointChooser(BotOwner bot, PatrolMode mode, IGetProfileData data = null) { }

	public void GoToPoint() { }

	private Vector3 LastTargetPoint() { }

	private void LookToFriend() { }

	public void ManualUpdate(bool canLookAround) { }

	public void MoveUpdate() { }

	private void OnPeaceChange(bool obj) { }

	public void Pause() { }

	protected void PointSetted(PatrolPointContainer point, int index) { }

	public void RefreshStatus() { }

	[CompilerGenerated]
	public void remove_OnPatrolPointCome(Action value) { }

	[CompilerGenerated]
	public void remove_OnStatusChanged(Action value) { }

	public void ReserveGoNextPoint() { }

	[CompilerGenerated]
	private void set_ComeToPointTime(float value) { }

	[CompilerGenerated]
	private void set_CurTargetPoint(Vector3 value) { }

	[CompilerGenerated]
	private void set_IsActivated(bool value) { }

	[CompilerGenerated]
	private void set_PointChooser(PatrolPointChooserBasic value) { }

	private void set_Status(PatrolStatus value) { }

	public void SetMode(PatrolMode mode, PatrolPointChooserBasic pointChooser) { }

	public void SetTargetMoveSpeed() { }

	public void StopAndLookToPoint(Vector3 sPoint) { }

	public void TryToTalk(bool bigDelay) { }

	public void Unpause() { }

	public void UpdateObserveWay() { }

	private void UpdateTimerRecheckStay() { }

	private void WayChanged() { }

}

