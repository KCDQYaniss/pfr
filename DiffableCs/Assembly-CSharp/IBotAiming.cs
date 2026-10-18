//Type is in global namespace

public interface IBotAiming
{

	public event Action OnSettingsTarget
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool AlwaysTurnOnLight
	{
		 get { } //Length: 0
	}

	public Vector3 EndTargetPoint
	{
		 get { } //Length: 0
	}

	public bool HardAim
	{
		 get { } //Length: 0
	}

	public bool IsReady
	{
		 get { } //Length: 0
	}

	public float LastDist2Target
	{
		 get { } //Length: 0
	}

	public Vector3 RealTargetPoint
	{
		 get { } //Length: 0
	}

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnSettingsTarget(Action value) { }

	public void DebugDraw() { }

	public void Dispose() { }

	public void DrawGizmosSelected() { }

	public bool get_AlwaysTurnOnLight() { }

	public Vector3 get_EndTargetPoint() { }

	public bool get_HardAim() { }

	public bool get_IsReady() { }

	public float get_LastDist2Target() { }

	public Vector3 get_RealTargetPoint() { }

	public void GetHit(DamageInfo damageInfo) { }

	public void LoseTarget() { }

	public void ManualUpdate() { }

	public void Move(float delta = 0) { }

	public void NextShotMiss(int missCount) { }

	public void NodeUpdate() { }

	public void OnDrawGizmos() { }

	[CompilerGenerated]
	public void remove_OnSettingsTarget(Action value) { }

	public void RotateX(float angToRotate) { }

	public void RotateY(float deltaAngle) { }

	public void SetNextAimingDelay(float nextAimingDelay) { }

	public void SetTarget(BotAimTarget trg) { }

	public void SetTracers(bool isTracers) { }

	public void SetWeapon(Weapon weapon) { }

	public void ShootDone(Weapon weapon) { }

	public void TriggerPressedDone() { }

}

