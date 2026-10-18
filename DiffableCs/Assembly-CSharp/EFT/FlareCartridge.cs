namespace EFT;

public class FlareCartridge : Throwable
{
	private const float TIME_TO_END_FLARE = 3; //Field offset: 0x0
	private const float MIN_COLLISION_THRESHOLD = 0.2; //Field offset: 0x0
	private static PhysicMaterial _physicMaterial; //Field offset: 0x0
	private const float TRAVEL_THROUGH_GLASS_THRESHOLD = 0.5; //Field offset: 0x0
	private const float DISTANCE_FOR_SYNC_PLAYERS = 10; //Field offset: 0x0
	private readonly Vector3 BlindingParameters; //Field offset: 0x80
	private FlareColorType _flareColorType; //Field offset: 0x8C
	private FlareCartridgeSettings _flareCartridgeSettings; //Field offset: 0x90
	private GameObject _flareEffectPrefab; //Field offset: 0x98
	private IPlayer _player; //Field offset: 0xA0
	private Ammo _flareAmmo; //Field offset: 0xA8
	private Weapon _weapon; //Field offset: 0xB0
	private CapsuleCollider _collisionCollider; //Field offset: 0xB8
	private SphereCollider _triggerCollider; //Field offset: 0xC0
	private bool _flareStarted; //Field offset: 0xC8
	private bool _flareStoped; //Field offset: 0xC9
	private bool _eventInvoked; //Field offset: 0xCA
	private float _startTime; //Field offset: 0xCC
	private Vector3 _playerPosOnStart; //Field offset: 0xD0
	private GameObject _projectileAmmo; //Field offset: 0xE0
	private float _succesfullHeight; //Field offset: 0xE8
	private float _startHeight; //Field offset: 0xEC
	private bool _succesfullShot; //Field offset: 0xF0
	private bool _dragDroppedAfterCollision; //Field offset: 0xF1

	public virtual bool HasNetData
	{
		 get { } //Length: 3
	}

	public virtual int Id
	{
		 get { } //Length: 288
	}

	private static PhysicMaterial LootPhysicMaterial
	{
		private get { } //Length: 1033
	}

	public FlareCartridge() { }

	private void AddCollisionCollider() { }

	private float CalculateDmgByVelocityAndBodyPart(BodyPartCollider bodyPart, RaycastHit hit) { }

	private void CastOnPlayerCollisionForSyncPosition() { }

	private bool ContactWithPlayer(Collider other, out bool contactWithOwnerPlayer) { }

	private void DestroyFlare() { }

	public virtual bool get_HasNetData() { }

	public virtual int get_Id() { }

	private static PhysicMaterial get_LootPhysicMaterial() { }

	private int GetId() { }

	private bool GlassCollision(Collision collision) { }

	public void Init(FlareCartridgeSettings flareCartridgeSettings, IPlayer player, Ammo flareCartridge, Weapon weapon) { }

	public void Launch() { }

	private void OnCollisionEnter(Collision collision) { }

	public virtual void OnCollisionHandler() { }

	private void ProceedDamage(BodyPartCollider bodyPart, IPlayer player, RaycastHit hit) { }

	private void StartFlare() { }

	private void Update() { }

}

