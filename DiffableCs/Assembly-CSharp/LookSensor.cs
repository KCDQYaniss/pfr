//Type is in global namespace

public class LookSensor : IAITaskUpdatable
{
	public readonly float VISIBLE_ANGLE; //Field offset: 0x10
	public readonly float VISIBLE_ANGLE_LIGHT; //Field offset: 0x14
	public readonly float VISIBLE_ANGLE_NIGHTVISION; //Field offset: 0x18
	private readonly BotOwner _botOwner; //Field offset: 0x20
	private readonly BifacialTransform _weaponRootTransform; //Field offset: 0x28
	private readonly BifacialTransform _ownerTransform; //Field offset: 0x30
	private Vector3 _weaponRootPoint; //Field offset: 0x38
	private LookSensorShootPosition _lookSensorShootPosition; //Field offset: 0x48
	public Vector3 HeadPoint; //Field offset: 0x50
	private float _updateTimer; //Field offset: 0x5C
	private int _lookCount; //Field offset: 0x60
	private readonly AnimationCurve _visionCurve; //Field offset: 0x68
	private bool _isTaskCompleted; //Field offset: 0x70
	private readonly BotSettings _botSettings; //Field offset: 0x78
	private float _weaponShootDistMaxSqr; //Field offset: 0x80
	private float _preferedFireDist; //Field offset: 0x84
	private float _nextUpdateVisibleDist; //Field offset: 0x88
	private bool _isBossOrFollower; //Field offset: 0x8C
	private float _taskMaxWaitPeriod; //Field offset: 0x90
	private readonly List _cacheToLookEnemyInfos; //Field offset: 0x98
	private float _timeAddTask; //Field offset: 0xA0
	private bool _canLookThroughGrassBySettings; //Field offset: 0xA4
	private readonly LookAllData _checkEnemiesLookAllData; //Field offset: 0xA8
	private bool _lookingThroughGrassTemporary; //Field offset: 0xB0
	private float _endLookingThroughGrassTemporary; //Field offset: 0xB4
	[CompilerGenerated]
	private LayerMask <Mask>k__BackingField; //Field offset: 0xB8
	private AITaskManager _taskManager; //Field offset: 0xC0
	[CompilerGenerated]
	private float <MaxShootDist>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private float <VisibleDist>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private float <ClearVisibleDist>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private int <HourServer>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private bool <CurLookThroughGrass>k__BackingField; //Field offset: 0xD8
	public bool ShootFromEyes; //Field offset: 0xD9
	private bool _isFullSectorView; //Field offset: 0xDA
	private readonly Collider[] _lookObstaclesBuffer; //Field offset: 0xE0

	public private float ClearVisibleDist
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private bool CurLookThroughGrass
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public int HourServer
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public bool IsFullSectorView
	{
		 get { } //Length: 8
	}

	public private LayerMask Mask
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private float MaxShootDist
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float PreferedShootDist
	{
		 get { } //Length: 35
	}

	public Vector3 ShootStartPos
	{
		 get { } //Length: 70
	}

	public private float VisibleDist
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public LookSensor(BotOwner botOwner) { }

	public void Activate() { }

	private void CalcVisibleDistance() { }

	public void CheckAllEnemies(LookAllData lookAll, float deltaTime) { }

	public bool CheckLookSimple(IPlayer from, IPlayer to) { }

	public void Dispose() { }

	public void DrawGizmosSelected() { }

	public bool EnoughDistToShoot(out bool canRunNoAmmo) { }

	[CompilerGenerated]
	public float get_ClearVisibleDist() { }

	[CompilerGenerated]
	public bool get_CurLookThroughGrass() { }

	[CompilerGenerated]
	public int get_HourServer() { }

	public bool get_IsFullSectorView() { }

	[CompilerGenerated]
	public LayerMask get_Mask() { }

	[CompilerGenerated]
	public float get_MaxShootDist() { }

	public float get_PreferedShootDist() { }

	public Vector3 get_ShootStartPos() { }

	[CompilerGenerated]
	public float get_VisibleDist() { }

	private float GetFogDensity() { }

	private float GetRainIntensity() { }

	public bool HardToSeeFor(EnemyInfo enemy) { }

	private override void IAITaskUpdatable.AIPeriodicUpdate(float deltaTime) { }

	public void Init() { }

	public bool IsPointInVisibleSector(Vector3 position) { }

	public void ManualUpdate() { }

	private void OnGetHit(DamageInfo arg1, EBodyPart arg2, float arg3) { }

	[CompilerGenerated]
	private void set_ClearVisibleDist(float value) { }

	[CompilerGenerated]
	private void set_CurLookThroughGrass(bool value) { }

	[CompilerGenerated]
	public void set_HourServer(int value) { }

	[CompilerGenerated]
	private void set_Mask(LayerMask value) { }

	[CompilerGenerated]
	private void set_MaxShootDist(float value) { }

	[CompilerGenerated]
	private void set_VisibleDist(float value) { }

	private void SetLookThroughGrass(bool val) { }

	public void UpdateGroupsValue(BotsGroup botsGroup) { }

	private void UpdateLook(float deltaTime) { }

	public void UpdateZoneValue(BotZone botZone) { }

	private float WeatherVisibilityK(float rainMaxInfluenceK, float fogMaxInfluenceK) { }

	public float WeatherVisibilityK(float rainMaxInfluenceK, float fogMaxInfluenceK, float enemyDistance, Vector3 directionToEnemy, out float rainK, out float fogK) { }

}

