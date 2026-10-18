//Type is in global namespace

public class BotAimingData : IBotAiming
{
	private const float MAX_ANGLE = 60; //Field offset: 0x0
	private const float OFFSET_DIST = 0.4; //Field offset: 0x0
	private const float SIT_HEIGHT = 0.9; //Field offset: 0x0
	private const float sqrMaxDist = 2.25; //Field offset: 0x0
	private const float STANDART_HEIGHT = 1.5; //Field offset: 0x0
	public bool CanChangePart; //Field offset: 0x10
	private bool _aimingOnWay; //Field offset: 0x11
	private float _curBetterAimTime; //Field offset: 0x14
	private float _diffBetweenTrg; //Field offset: 0x18
	private float _endAimTime; //Field offset: 0x1C
	private Vector3 _endLookDir; //Field offset: 0x20
	private Vector3 _endTargetPoint; //Field offset: 0x2C
	private bool _lastFrameMove; //Field offset: 0x38
	private float _lastFrameMoveDelta; //Field offset: 0x3C
	private Vector3 _lastlookDir; //Field offset: 0x40
	private float _lastOffsetCalcTime; //Field offset: 0x4C
	private Vector3 _lastRoot; //Field offset: 0x50
	private readonly BifacialTransform _myWeapon; //Field offset: 0x60
	private float _nextAimingDelay; //Field offset: 0x68
	private bool _nextShootRecalc; //Field offset: 0x6C
	private int _nextShotMissCount; //Field offset: 0x70
	private Vector3 _offsetStandart; //Field offset: 0x74
	private Vector3 _offsetBadShoots; //Field offset: 0x80
	private readonly BotOwner _owner; //Field offset: 0x90
	private float _hardAimRollTime; //Field offset: 0x98
	private bool _hardAimCachedRollResult; //Field offset: 0x9C
	private float _panicEndTime; //Field offset: 0xA0
	private readonly BotSettings _settings; //Field offset: 0xA8
	private int _shootWithNoRecalc; //Field offset: 0xB0
	private Vector3 _startLookDir; //Field offset: 0xB4
	private AimStatus _status; //Field offset: 0xC0
	private float _timeCoef; //Field offset: 0xC4
	private readonly AimingAffection affection; //Field offset: 0xC8
	private int changePartTimes; //Field offset: 0xD0
	private int _nextTriggersToRecalc; //Field offset: 0xD4
	private int _calculatedBadShoots; //Field offset: 0xD8
	private BotAimTarget _aimTarget; //Field offset: 0xDC
	[CompilerGenerated]
	private Action OnSettingsTarget; //Field offset: 0xF0
	[CompilerGenerated]
	private float <LastSpreadCount>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private float <LastAimTime>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private bool <HardAim>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private BotGlobalAimingSettings <AimingSettings>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private bool <AlwaysTurnOnLight>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private Vector3 <RealTargetPoint>k__BackingField; //Field offset: 0x114
	[CompilerGenerated]
	private float <LastDist2Target>k__BackingField; //Field offset: 0x120

	public override event Action OnSettingsTarget
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public BotGlobalAimingSettings AimingSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public BotAimTarget AimTarget
	{
		 get { } //Length: 23
	}

	public private override bool AlwaysTurnOnLight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override Vector3 EndTargetPoint
	{
		 get { } //Length: 19
		 set { } //Length: 22
	}

	public private override bool HardAim
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	private bool IsPanic
	{
		private get { } //Length: 93
	}

	public override bool IsReady
	{
		 get { } //Length: 11
	}

	public private float LastAimTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private override float LastDist2Target
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float LastSpreadCount
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private override Vector3 RealTargetPoint
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private AimStatus Status
	{
		 get { } //Length: 7
		private set { } //Length: 1055
	}

	public BotAimingData(BotOwner owner) { }

	public override void Activate() { }

	[CompilerGenerated]
	public override void add_OnSettingsTarget(Action value) { }

	private int CalcBadShootsCount(float dist) { }

	private Vector3 CalcTargetOffset(float dist, float angCoef, bool isInSmoke, float additionCoef = 1) { }

	private float CalcTimeShoot(float dist, float ang) { }

	private void CheckDistAndRecalc(BotAimTarget target) { }

	public override void DebugDraw() { }

	public override void Dispose() { }

	public override void DrawGizmosSelected() { }

	[CompilerGenerated]
	public BotGlobalAimingSettings get_AimingSettings() { }

	public BotAimTarget get_AimTarget() { }

	[CompilerGenerated]
	public override bool get_AlwaysTurnOnLight() { }

	public override Vector3 get_EndTargetPoint() { }

	[CompilerGenerated]
	public override bool get_HardAim() { }

	private bool get_IsPanic() { }

	public override bool get_IsReady() { }

	[CompilerGenerated]
	public float get_LastAimTime() { }

	[CompilerGenerated]
	public override float get_LastDist2Target() { }

	[CompilerGenerated]
	public float get_LastSpreadCount() { }

	[CompilerGenerated]
	public override Vector3 get_RealTargetPoint() { }

	public AimStatus get_Status() { }

	public float GetCurRadius() { }

	public override void GetHit(DamageInfo damageInfo) { }

	private float GetSpeadByDist(float dist) { }

	private bool HardAimChance() { }

	private bool IsShooting() { }

	private void LookTo(Vector3 dir) { }

	public override void LoseTarget() { }

	public override void ManualUpdate() { }

	public override void Move(float speed = 0) { }

	public override void NextShotMiss(int missCount) { }

	public override void NodeUpdate() { }

	public override void OnDrawGizmos() { }

	public void Panic() { }

	private void RecalcOffset(bool withTimeRecalc, bool isInSmoke) { }

	private void RecalcTarget(BotAimTarget target) { }

	[CompilerGenerated]
	public override void remove_OnSettingsTarget(Action value) { }

	public override void RotateX(float angToRotate) { }

	public override void RotateY(float deltaAngle) { }

	private float SDistHorizontal(Vector3 v) { }

	[CompilerGenerated]
	public void set_AimingSettings(BotGlobalAimingSettings value) { }

	[CompilerGenerated]
	private void set_AlwaysTurnOnLight(bool value) { }

	public void set_EndTargetPoint(Vector3 value) { }

	[CompilerGenerated]
	private void set_HardAim(bool value) { }

	[CompilerGenerated]
	private void set_LastAimTime(float value) { }

	[CompilerGenerated]
	private void set_LastDist2Target(float value) { }

	[CompilerGenerated]
	private void set_LastSpreadCount(float value) { }

	[CompilerGenerated]
	private void set_RealTargetPoint(Vector3 value) { }

	private void set_Status(AimStatus value) { }

	public override void SetNextAimingDelay(float nextAimingDelay) { }

	public override void SetTarget(BotAimTarget trg) { }

	public override void SetTracers(bool isTracers) { }

	public override void SetWeapon(Weapon weapon) { }

	public override void ShootDone(Weapon weapon) { }

	public virtual string ToString() { }

	public override void TriggerPressedDone() { }

	private void UpdateEndTargetPoint() { }

	private void UpdateLookDir() { }

	private void UpdateTarget(BotAimTarget target) { }

}

