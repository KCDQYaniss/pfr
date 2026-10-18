namespace EFT.RocketLauncher;

public class RocketProjectile : MonoBehaviour
{
	private IPlayer _owner; //Field offset: 0x20
	private Rocket _ammo; //Field offset: 0x28
	private Weapon _weapon; //Field offset: 0x30
	private RocketSettings _settings; //Field offset: 0x38
	private ExplosionModel _explosionModel; //Field offset: 0x40
	private BackblastModel _backBlastModel; //Field offset: 0x48
	private ArmingModel _armingModel; //Field offset: 0x50
	private Shot _rocketShot; //Field offset: 0x58
	private RocketSoundPlayer _soundPlayer; //Field offset: 0x60
	private bool _isLaunched; //Field offset: 0x68
	private IEnumerator _explosionCoroutine; //Field offset: 0x70
	private Coroutine _coneBlastCoroutine; //Field offset: 0x78
	[CompilerGenerated]
	private string <ProfileId>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private RocketLauncher <SourceWeapon>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnExplosionStartEvent; //Field offset: 0x90
	private IBallisticsCalculator _ballisticCalculator; //Field offset: 0x98

	public event Action OnExplosionStartEvent
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private string ProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RocketSettings RocketSettings
	{
		 get { } //Length: 5
	}

	public private RocketLauncher SourceWeapon
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public RocketProjectile() { }

	[CompilerGenerated]
	public void add_OnExplosionStartEvent(Action value) { }

	private float CalculateDmgByVelocityAndBodyPart(BodyPartCollider bodyPart, Shot shot) { }

	private Vector3 CalculatePositionForEpicenter() { }

	private bool CheckPlayer() { }

	private void CreateShot() { }

	private void Explosion() { }

	[CompilerGenerated]
	public string get_ProfileId() { }

	public RocketSettings get_RocketSettings() { }

	[CompilerGenerated]
	public RocketLauncher get_SourceWeapon() { }

	public void Initialize(RocketSettings settings, IPlayer owner, Ammo ammo, Weapon weapon, Transform smokeport = null) { }

	public void Launch() { }

	protected void OnDestroy() { }

	private void OnExplosionCompleated() { }

	private void ProceedDamage(BodyPartCollider bodyPart, IPlayer player, Shot shot) { }

	[CompilerGenerated]
	public void remove_OnExplosionStartEvent(Action value) { }

	private void RocketTick() { }

	[CompilerGenerated]
	private void set_ProfileId(string value) { }

	[CompilerGenerated]
	private void set_SourceWeapon(RocketLauncher value) { }

	private void SetVisibleModel(bool visible) { }

	private void Subscribe() { }

	private bool TryGlassCollision() { }

	private void TryVehicleCollision() { }

	private void Unsubscribe() { }

	private void Update() { }

}

