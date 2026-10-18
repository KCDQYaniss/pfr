namespace EFT;

public class BotMemory
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass121_0
	{
		public BotMemory <>4__this; //Field offset: 0x10
		public IPlayer enemy; //Field offset: 0x18

		public <>c__DisplayClass121_0() { }

		internal void <AddEnemyInfo>b__0(EDamageType health) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass128_0
	{
		public BotMemory <>4__this; //Field offset: 0x10
		public DamageInfo damageInfo; //Field offset: 0x18

		public <>c__DisplayClass128_0() { }

		internal void <GetHit>b__0() { }

	}

	public const float SDIST_TO_AFFECT_CLOSE_ENEMY = 625; //Field offset: 0x0
	public const float SDIST_CLOSE_COVER = 1.6; //Field offset: 0x0
	public PlaceForCheck CurrentPlaceForCheck; //Field offset: 0x10
	public DangerData DangerData; //Field offset: 0x18
	public BotCurrentCoverInfo BotCurrentCoverInfo; //Field offset: 0x20
	public Vector3 ActivatedPos; //Field offset: 0x28
	public BotObserveData botObserveData; //Field offset: 0x38
	public BotGoalTarget GoalTarget; //Field offset: 0x40
	private readonly BotsGroup _botsGroup; //Field offset: 0x48
	private readonly BotOwner _owner; //Field offset: 0x50
	private bool _isInCover; //Field offset: 0x58
	private EnemyInfo _goalEnemy; //Field offset: 0x60
	private PlaceForCheck _goalTarget; //Field offset: 0x68
	private float _lastTimeLoseVisionEnemy; //Field offset: 0x70
	private float _damageEndTime; //Field offset: 0x74
	private float _nextCheckPeace; //Field offset: 0x78
	private float _getInCoverPeriod; //Field offset: 0x7C
	private readonly bool _modeChanging; //Field offset: 0x80
	private BotSettingsInGameModif _peaceModeModif; //Field offset: 0x88
	private float _lastUnderFireTimeEnd; //Field offset: 0x90
	private float _resistAmbushTime; //Field offset: 0x94
	[CompilerGenerated]
	private Action OnAddEnemyInfo; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnGoalEnemyChanged; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnInCoverChange; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnPeaceChange; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnSpottedByHit; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnBulletNear; //Field offset: 0xC0
	public float nextTryMoveToEnemyLogTime; //Field offset: 0xC8
	[CompilerGenerated]
	private BotDamageData <LastDamageData>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private float <ComeToCoverTime>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private float <LastTimeHit>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private Vector3 <LastHitPos>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private int <LastAgressorId>k__BackingField; //Field offset: 0xEC
	[CompilerGenerated]
	private float <EnemySetTime>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <ShallRunIfNoAmmo>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	private EnemyInfo <LastEnemy>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private float <LastEnemyTimeSeen>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private bool <IsPeace>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private bool <AttackImmediately>k__BackingField; //Field offset: 0x105
	[CompilerGenerated]
	private float <UnderFireTime>k__BackingField; //Field offset: 0x108

	public event Action OnAddEnemyInfo
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnBulletNear
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnGoalEnemyChanged
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnInCoverChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnPeaceChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnSpottedByHit
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public private bool AttackImmediately
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private float ComeToCoverTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public CustomNavigationPoint CurCustomCoverPoint
	{
		 get { } //Length: 27
	}

	public private float EnemySetTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public EnemyInfo GoalEnemy
	{
		 get { } //Length: 5
		 set { } //Length: 1508
	}

	public bool HaveEnemy
	{
		 get { } //Length: 9
	}

	public bool HaveGoal
	{
		 get { } //Length: 45
	}

	public bool IsDamaged
	{
		 get { } //Length: 90
	}

	public private bool IsInCover
	{
		 get { } //Length: 41
		private set { } //Length: 604
	}

	public private bool IsPeace
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsUnderFire
	{
		 get { } //Length: 93
	}

	public private int LastAgressorId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private BotDamageData LastDamageData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool LastDamageDataActive
	{
		 get { } //Length: 235
	}

	public private EnemyInfo LastEnemy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float LastEnemyTimeSeen
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private Vector3 LastHitPos
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private float LastTimeHit
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float LeaveCoverTime
	{
		 get { } //Length: 28
	}

	public bool ShallChangeCoverToFindEnemy
	{
		 get { } //Length: 132
	}

	public private bool ShallRunIfNoAmmo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private float UnderFireTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public BotMemory(BotOwner owner, BotsGroup botsGroup) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnAddEnemyInfo(Action value) { }

	[CompilerGenerated]
	public void add_OnBulletNear(Action value) { }

	[CompilerGenerated]
	public void add_OnGoalEnemyChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnInCoverChange(Action value) { }

	[CompilerGenerated]
	public void add_OnPeaceChange(Action value) { }

	[CompilerGenerated]
	public void add_OnSpottedByHit(Action value) { }

	public void AddEnemyInfo(IPlayer enemy, BotGroupEnemyInfo groupInfo, bool onActivation) { }

	public void BodyFound(DeadBody body) { }

	private void ChangeTo(bool toChange) { }

	private void CheckAttackImmediately() { }

	private void CheckIsInCover() { }

	public void CheckIsInCover2() { }

	public void CheckIsPeace() { }

	private void ComeToPlace() { }

	public bool ComeToPoint() { }

	public void DeleteInfoAboutEnemy(IPlayer gamePerson) { }

	public void Dispose() { }

	private void EffectStartedEvent(IHealthEffect obj) { }

	[CompilerGenerated]
	public bool get_AttackImmediately() { }

	[CompilerGenerated]
	public float get_ComeToCoverTime() { }

	public CustomNavigationPoint get_CurCustomCoverPoint() { }

	[CompilerGenerated]
	public float get_EnemySetTime() { }

	public EnemyInfo get_GoalEnemy() { }

	public bool get_HaveEnemy() { }

	public bool get_HaveGoal() { }

	public bool get_IsDamaged() { }

	public bool get_IsInCover() { }

	[CompilerGenerated]
	public bool get_IsPeace() { }

	public bool get_IsUnderFire() { }

	[CompilerGenerated]
	public int get_LastAgressorId() { }

	[CompilerGenerated]
	public BotDamageData get_LastDamageData() { }

	public bool get_LastDamageDataActive() { }

	[CompilerGenerated]
	public EnemyInfo get_LastEnemy() { }

	[CompilerGenerated]
	public float get_LastEnemyTimeSeen() { }

	[CompilerGenerated]
	public Vector3 get_LastHitPos() { }

	[CompilerGenerated]
	public float get_LastTimeHit() { }

	public float get_LeaveCoverTime() { }

	public bool get_ShallChangeCoverToFindEnemy() { }

	[CompilerGenerated]
	public bool get_ShallRunIfNoAmmo() { }

	[CompilerGenerated]
	public float get_UnderFireTime() { }

	public void GetHit(DamageInfo damageInfo) { }

	private void GetHitInner(DamageInfo damageInfo) { }

	private void GoalTargetBeingHitAction(DamageInfo damageInfo, EBodyPart eBodyPart, float val) { }

	public bool IsHit(float period) { }

	public bool LastEnemyVisionOld(float delta) { }

	public void LoseVisionCurrentEnemy() { }

	public void ManualUpdate(float deltaTime) { }

	public string MessageInfo(bool withN = true) { }

	private void PeriodCheckPeace() { }

	[CompilerGenerated]
	public void remove_OnAddEnemyInfo(Action value) { }

	[CompilerGenerated]
	public void remove_OnBulletNear(Action value) { }

	[CompilerGenerated]
	public void remove_OnGoalEnemyChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnInCoverChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnPeaceChange(Action value) { }

	[CompilerGenerated]
	public void remove_OnSpottedByHit(Action value) { }

	public void RemovePlaceForCheck(List list) { }

	private void ReportAboutEnemyToAll() { }

	[CompilerGenerated]
	private void set_AttackImmediately(bool value) { }

	[CompilerGenerated]
	private void set_ComeToCoverTime(float value) { }

	[CompilerGenerated]
	private void set_EnemySetTime(float value) { }

	public void set_GoalEnemy(EnemyInfo value) { }

	private void set_IsInCover(bool value) { }

	[CompilerGenerated]
	private void set_IsPeace(bool value) { }

	[CompilerGenerated]
	private void set_LastAgressorId(int value) { }

	[CompilerGenerated]
	private void set_LastDamageData(BotDamageData value) { }

	[CompilerGenerated]
	private void set_LastEnemy(EnemyInfo value) { }

	[CompilerGenerated]
	private void set_LastEnemyTimeSeen(float value) { }

	[CompilerGenerated]
	private void set_LastHitPos(Vector3 value) { }

	[CompilerGenerated]
	private void set_LastTimeHit(float value) { }

	[CompilerGenerated]
	private void set_ShallRunIfNoAmmo(bool value) { }

	[CompilerGenerated]
	private void set_UnderFireTime(float value) { }

	public void SetCoverPoints(CustomNavigationPoint value, string debugdata = "") { }

	public void SetLastTimeSeeEnemy() { }

	public void SetPanicPoint(PlaceForCheck placeForCheck, bool realDanger) { }

	public void SetUnderFire(IPlayer source) { }

	public void Spotted(bool byHit, Nullable from = null, Nullable secToBeSpotted = null) { }

	public void TryGetInCoverSay() { }

	public void UseDogFightOut() { }

}

