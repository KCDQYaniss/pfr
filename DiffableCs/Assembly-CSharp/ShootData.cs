//Type is in global namespace

public class ShootData
{
	private readonly BotOwner _owner; //Field offset: 0x10
	private readonly Player _player; //Field offset: 0x18
	private float nextFingerUpTime; //Field offset: 0x20
	private float timeFingerDown; //Field offset: 0x24
	private readonly float _triggersTimeToRun; //Field offset: 0x28
	private float _triggersDownBetweenStops; //Field offset: 0x2C
	private float nextFingerDownCan; //Field offset: 0x30
	private readonly RecoilData _recoilData; //Field offset: 0x38
	private readonly GameWorld _gameWorld; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnTriggerPressed; //Field offset: 0x48
	private Vector3 _weaponRootOffset; //Field offset: 0x50
	private float _nextLongWaitBegin; //Field offset: 0x5C
	[CompilerGenerated]
	private float <LastTriggerPressd>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <Shooting>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private bool <CanShootByState>k__BackingField; //Field offset: 0x65

	public event Action OnTriggerPressed
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	private BotGlobalAimingSettings _settings
	{
		private get { } //Length: 45
	}

	public private bool CanShootByState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float LastTriggerPressd
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public IFirearmHandsController ShootController
	{
		 get { } //Length: 39
	}

	public private bool Shooting
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Vector3 WeaponRootOffset
	{
		 get { } //Length: 19
	}

	public ShootData(BotOwner owner, RecoilData recoilData) { }

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnTriggerPressed(Action value) { }

	public void BlockFor(float period) { }

	public bool CheckFriendlyFire(Vector3 from, Vector3 to) { }

	public void Dispose() { }

	public void EndShoot() { }

	private BotGlobalAimingSettings get__settings() { }

	[CompilerGenerated]
	public bool get_CanShootByState() { }

	[CompilerGenerated]
	public float get_LastTriggerPressd() { }

	public IFirearmHandsController get_ShootController() { }

	[CompilerGenerated]
	public bool get_Shooting() { }

	public Vector3 get_WeaponRootOffset() { }

	[CanBeNull]
	private Player GetHittedPlayer(Vector3 weaponRootPos, Vector3 aimTo) { }

	[CanBeNull]
	private Player GetPlayerByCollider(Collider collider) { }

	public bool IsManySHootsOnAttack() { }

	public void ManualUpdate() { }

	public void NullShootsBetween() { }

	private void OnMoveStateChanged(EPlayerState previousstate, EPlayerState nextstate) { }

	private void RecacheOffset() { }

	private void RecoilCheck() { }

	[CompilerGenerated]
	public void remove_OnTriggerPressed(Action value) { }

	[CompilerGenerated]
	private void set_CanShootByState(bool value) { }

	[CompilerGenerated]
	private void set_LastTriggerPressd(float value) { }

	[CompilerGenerated]
	private void set_Shooting(bool value) { }

	public void SetCanShootByState(bool state) { }

	public bool Shoot() { }

	public void ShootDoneWeapon() { }

	private void UpdNextFingerDown() { }

	private void UpdNextFingerUp() { }

}

