//Type is in global namespace

public class BotTargeting : BotData, IBotAiming
{
	public bool _alwaysTurnOnLight; //Field offset: 0x18
	private float _goodScattering; //Field offset: 0x1C
	private bool _isBadDist; //Field offset: 0x20
	private bool _isTooClose; //Field offset: 0x21
	private bool _aimingOnWay; //Field offset: 0x22
	private Vector3 _dirToRealTargetNorm; //Field offset: 0x24
	private BotSettingsInGameModif _ammoCaution; //Field offset: 0x30
	private IFirearmHandsController _handsController; //Field offset: 0x38
	private AimStatus _aimStatus; //Field offset: 0x40
	private float _time; //Field offset: 0x44
	private bool _revers; //Field offset: 0x48
	[CompilerGenerated]
	private Action OnSettingsTarget; //Field offset: 0x50
	[CompilerGenerated]
	private bool <HardAim>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Vector3 <From>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private float <SinDist>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Vector3 <To>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private Vector3 <TargetToLook>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly BotScatteringData <ScatteringData>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Vector3 <RealTargetPoint>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private float <LastDist2Target>k__BackingField; //Field offset: 0x9C

	public override event Action OnSettingsTarget
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override bool AlwaysTurnOnLight
	{
		 get { } //Length: 5
	}

	public override Vector3 EndTargetPoint
	{
		 get { } //Length: 22
	}

	public private Vector3 From
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public private override bool HardAim
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override bool IsReady
	{
		 get { } //Length: 70
	}

	public private override float LastDist2Target
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

	public BotScatteringData ScatteringData
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private float SinDist
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private Vector3 TargetToLook
	{
		[CompilerGenerated]
		 get { } //Length: 22
		[CompilerGenerated]
		private set { } //Length: 19
	}

	public private Vector3 To
	{
		[CompilerGenerated]
		 get { } //Length: 19
		[CompilerGenerated]
		private set { } //Length: 16
	}

	public BotTargeting(BotOwner owner) { }

	public override void Activate() { }

	[CompilerGenerated]
	public override void add_OnSettingsTarget(Action value) { }

	private void CheckHardAim() { }

	public override void DebugDraw() { }

	public override void Dispose() { }

	public override void DrawGizmosSelected() { }

	public override bool get_AlwaysTurnOnLight() { }

	public override Vector3 get_EndTargetPoint() { }

	[CompilerGenerated]
	public Vector3 get_From() { }

	[CompilerGenerated]
	public override bool get_HardAim() { }

	public override bool get_IsReady() { }

	[CompilerGenerated]
	public override float get_LastDist2Target() { }

	[CompilerGenerated]
	public override Vector3 get_RealTargetPoint() { }

	[CompilerGenerated]
	public BotScatteringData get_ScatteringData() { }

	[CompilerGenerated]
	public float get_SinDist() { }

	[CompilerGenerated]
	public Vector3 get_TargetToLook() { }

	[CompilerGenerated]
	public Vector3 get_To() { }

	public override void GetHit(DamageInfo damageInfo) { }

	private float GoodScattering(float dist) { }

	private void LookTo(Vector3 dir) { }

	public override void LoseTarget() { }

	public override void ManualUpdate() { }

	public override void Move(float delta = 0) { }

	private void MoveTarget(Vector3 trg, Vector3 center) { }

	public override void NextShotMiss(int missCount) { }

	public override void NodeUpdate() { }

	public override void OnDrawGizmos() { }

	private void OnLay(bool obj) { }

	private void OnPoseChange(float obj) { }

	private void OnTriggerPressed() { }

	private float PriorityScatter(float cur, float min, float max, float lowVal, float hightVal) { }

	[CompilerGenerated]
	public override void remove_OnSettingsTarget(Action value) { }

	public override void RotateX(float angToRotate) { }

	public override void RotateY(float deltaAngle) { }

	[CompilerGenerated]
	private void set_From(Vector3 value) { }

	[CompilerGenerated]
	private void set_HardAim(bool value) { }

	[CompilerGenerated]
	private void set_LastDist2Target(float value) { }

	[CompilerGenerated]
	private void set_RealTargetPoint(Vector3 value) { }

	[CompilerGenerated]
	private void set_SinDist(float value) { }

	[CompilerGenerated]
	private void set_TargetToLook(Vector3 value) { }

	[CompilerGenerated]
	private void set_To(Vector3 value) { }

	public override void SetNextAimingDelay(float nextAimingDelay) { }

	public override void SetTarget(BotAimTarget trg) { }

	public override void SetTracers(bool isTracers) { }

	public override void SetWeapon(Weapon weapon) { }

	public override void ShootDone(Weapon weapon) { }

	public override void TriggerPressedDone() { }

	private void UpdateLerp() { }

}

