//Type is in global namespace

public class BotScatteringData : BotData
{
	private float _curScatering; //Field offset: 0x18
	private bool _isTracers; //Field offset: 0x1C
	private bool nextFrameNoScattering; //Field offset: 0x1D
	private bool nextFrameSlowSpeed; //Field offset: 0x1E
	private bool upSpeed; //Field offset: 0x1F
	private bool _isLegDamage; //Field offset: 0x20
	private bool _moving; //Field offset: 0x21
	private BotSettingsInGameModif _handDamage; //Field offset: 0x28
	[CompilerGenerated]
	private float <YRecoil>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private bool <IsMinScattering>k__BackingField; //Field offset: 0x34

	public float CurScatering
	{
		 get { } //Length: 6
		 set { } //Length: 284
	}

	public private bool IsMinScattering
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float YRecoil
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public BotScatteringData(BotOwner owner) { }

	public void Activate() { }

	public void BotMove(float dist) { }

	public void Dispose() { }

	public void DrawGizmosSelected() { }

	public float get_CurScatering() { }

	[CompilerGenerated]
	public bool get_IsMinScattering() { }

	[CompilerGenerated]
	public float get_YRecoil() { }

	public void GetHit(DamageInfo dmgInfo) { }

	public void Lay(bool b) { }

	public void ManualUpdate(bool hardAim) { }

	private void OnNoDamagedParts() { }

	public void PoseChange(float f) { }

	private void Rotate(float angToRotate) { }

	public void RotateX(float angToRotate) { }

	public void RotateY(float angToRotate) { }

	public void set_CurScatering(float value) { }

	[CompilerGenerated]
	private void set_IsMinScattering(bool value) { }

	[CompilerGenerated]
	private void set_YRecoil(float value) { }

	public void SetTracers(bool isTracers) { }

	public void ShootDone(Weapon weapon) { }

}

