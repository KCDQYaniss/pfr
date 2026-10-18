//Type is in global namespace

public class BotStationaryWeaponData : BotData
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass70_0
	{
		public BotStationaryWeaponData <>4__this; //Field offset: 0x10
		public FirearmController fireArms; //Field offset: 0x18
		public bool isInSpawn; //Field offset: 0x20

		public <>c__DisplayClass70_0() { }

		internal void <OnHandsControllerChanged>g__OnReady|0(FirearmController controller) { }

	}

	private const float SQR_DIST_LIMIT_FROM_OPERATOR_POSITION = 0.040000003; //Field offset: 0x0
	private const float MAX_STATIONARY_SDIST = 22500; //Field offset: 0x0
	private const float AFTER_DROP_SEARCH_DELAY = 15; //Field offset: 0x0
	private const float SIMPLE_SEARCH_DELAY = 3; //Field offset: 0x0
	private AIStationaryController _curStationaryWeapons; //Field offset: 0x18
	private ITimer _stationaryBlockVisionTimer; //Field offset: 0x20
	private float _lastSpottedTime; //Field offset: 0x28
	private float _nextPosibleSearchTime; //Field offset: 0x2C
	private float _nextPosibleStartUseTime; //Field offset: 0x30
	private float _sitTime; //Field offset: 0x34
	private float _comeCloseTime; //Field offset: 0x38
	private float _shallEndShootFromCover; //Field offset: 0x3C
	private float _cosToLeave; //Field offset: 0x40
	private int _spottedTimes; //Field offset: 0x44
	private float _dropTime; //Field offset: 0x48
	[CompilerGenerated]
	private bool <WantToTake>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <Taken>k__BackingField; //Field offset: 0x4D
	[CompilerGenerated]
	private bool <CanLeave>k__BackingField; //Field offset: 0x4E
	[CompilerGenerated]
	private StationaryWeaponLink <CurLink>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <IsInSpawnState>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private float <LastDistToWeapon>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private Action OnLinkedWeaponChange; //Field offset: 0x60

	public event Action OnLinkedWeaponChange
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool CanLeave
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private StationaryWeaponLink CurLink
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool HaveLink
	{
		 get { } //Length: 203
	}

	public private bool IsInSpawnState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float LastDistToWeapon
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private bool Taken
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool WantToTake
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotStationaryWeaponData(BotOwner owner) { }

	[CompilerGenerated]
	private void <Take>b__56_0() { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnLinkedWeaponChange(Action value) { }

	private bool CantShootToCurrentEnemy() { }

	public bool CheckAmmonProcess() { }

	public bool CheckeEnemyOutOfSector(EnemyInfo enemy) { }

	public bool CheckEndShootFromStationary() { }

	public bool CheckIsCloseToTarget() { }

	public StationaryWeaponLink CheckWantTakeStationary(float maxRadius, bool igoneEnemy = false, float delatAfterDeathPeriod = -1, bool needStraightShoot = false) { }

	public float CurDistToLeave() { }

	public float DeltaSitTime() { }

	public void Dispose() { }

	public void DropCurWeapon(bool withDelay, bool withLeavingAsPlayer = true) { }

	[CompilerGenerated]
	public bool get_CanLeave() { }

	[CompilerGenerated]
	public StationaryWeaponLink get_CurLink() { }

	public bool get_HaveLink() { }

	[CompilerGenerated]
	public bool get_IsInSpawnState() { }

	[CompilerGenerated]
	public float get_LastDistToWeapon() { }

	[CompilerGenerated]
	public bool get_Taken() { }

	[CompilerGenerated]
	public bool get_WantToTake() { }

	public string GetAmmoInfo() { }

	public Nullable GetCurrentDecision() { }

	private void ImplementStationary(FirearmController fireArms) { }

	public bool IsClose() { }

	private bool IsDistanceGoodToTake(float magnitude, StationaryWeaponLink stationary) { }

	public bool IsEnemyAtSector(StationaryWeaponLink stationary) { }

	public bool IsEnemyAtSector(StationaryWeaponLink stationary, Vector3 pos) { }

	public bool IsPointAtSector(Vector3 point) { }

	private bool IsSpotted() { }

	public bool LeaveCauseNoAmmo() { }

	private void OnHandsControllerChanged(AbstractHandsController arg1, AbstractHandsController arg2) { }

	[CompilerGenerated]
	public void remove_OnLinkedWeaponChange(Action value) { }

	[CompilerGenerated]
	private void set_CanLeave(bool value) { }

	[CompilerGenerated]
	private void set_CurLink(StationaryWeaponLink value) { }

	[CompilerGenerated]
	private void set_IsInSpawnState(bool value) { }

	[CompilerGenerated]
	private void set_LastDistToWeapon(float value) { }

	[CompilerGenerated]
	private void set_Taken(bool value) { }

	[CompilerGenerated]
	private void set_WantToTake(bool value) { }

	private void SetCurLink(StationaryWeaponLink link) { }

	public void SetTargetStationary(StationaryWeaponLink link) { }

	public bool ShallEndShootFromCurrent() { }

	public void Spotted() { }

	public void StartMove() { }

	public void Take() { }

	public bool TryFindClosests(Vector3 pos, bool withSetTarget, out StationaryWeaponLink closest) { }

}

