//Type is in global namespace

public class ShotEffector : IEffector
{
	internal class RecoilShotVal
	{
		public ComponentType FromAxis; //Field offset: 0x10
		public Target ProcessType; //Field offset: 0x14
		public ComponentType ToAxis; //Field offset: 0x18
		public float IntensityMultiplicator; //Field offset: 0x1C
		private IRecoilShotEffect _recoilShotEffectTarget; //Field offset: 0x20
		private int _component; //Field offset: 0x28
		private int _from; //Field offset: 0x2C

		public RecoilShotVal() { }

		public void Initialize(IRecoilShotEffect recoilShotEffect) { }

		public void Process(Vector3 rnd) { }

	}

	private const float RECOIL_SUPPRESSION_FACTOR = 0.1; //Field offset: 0x0
	public RecoilPipelineType RecoilPipeline; //Field offset: 0x10
	public OldRecoilShotEffect OldShotRecoil; //Field offset: 0x18
	public NewRecoilShotEffect NewShotRecoil; //Field offset: 0x20
	private IRecoilShotEffect _currentRecoilEffect; //Field offset: 0x28
	private FirearmController _firearmController; //Field offset: 0x30
	private IWeapon _weapon; //Field offset: 0x38
	private Weapon _mainWeaponInHands; //Field offset: 0x40
	private AimingConfiguration _aimingConfig; //Field offset: 0x48
	private WeaponBuffsInfo _buffs; //Field offset: 0x50
	private int _pose; //Field offset: 0x58

	private AimingConfiguration AimingConfig
	{
		private get { } //Length: 160
	}

	public IRecoilShotEffect CurrentRecoilEffect
	{
		 get { } //Length: 279
		 set { } //Length: 82
	}

	public int Pose
	{
		 get { } //Length: 4
		 set { } //Length: 457
	}

	public ShotEffector() { }

	public void CalculateRecoilParameters() { }

	public float ConvertFromTaxanomy(float f) { }

	public override string DebugOutput() { }

	private AimingConfiguration get_AimingConfig() { }

	public IRecoilShotEffect get_CurrentRecoilEffect() { }

	public int get_Pose() { }

	public override void Initialize(PlayerSpring playerSpring) { }

	public void OnWeaponParametersChanged() { }

	public override void Process(float str = 1) { }

	private float RecoilDelta() { }

	public void set_CurrentRecoilEffect(IRecoilShotEffect value) { }

	public void set_Pose(int value) { }

	public void SetNewRecoilMode() { }

	public void SetOldRecoilMode() { }

	internal void SubscribeToWeapon(IWeapon activeWeapon, WeaponBuffsInfo buffInfo, Weapon mainWeaponInHands, FirearmController firearms) { }

}

