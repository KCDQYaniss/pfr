namespace EFT;

public class CorpseRagdollTestApplication : AbstractApplication
{
	[SerializeField]
	private GameObject _corpsePrefab; //Field offset: 0x30
	[SerializeField]
	private GameObject _weaponPrefab; //Field offset: 0x38
	private List _corpses; //Field offset: 0x40
	[SerializeField]
	private Vector3 _velocity; //Field offset: 0x48
	[SerializeField]
	private float _maxDepenetrationVelocity; //Field offset: 0x54
	[SerializeField]
	private CollisionDetectionMode _collisionDetectionMode; //Field offset: 0x58
	[SerializeField]
	private bool _keepRigidbody; //Field offset: 0x5C
	[SerializeField]
	private bool _putToSleep; //Field offset: 0x5D
	[SerializeField]
	private bool _dropWeapon; //Field offset: 0x5E
	[SerializeField]
	private bool _weaponFixedHinge; //Field offset: 0x5F

	protected virtual EUpdateQueue PlayerUpdateQueue
	{
		 get { } //Length: 3
	}

	public CorpseRagdollTestApplication() { }

	protected virtual LogConfiguration CreateLogConfiguration() { }

	public void DropAll() { }

	protected virtual EUpdateQueue get_PlayerUpdateQueue() { }

	private void LateUpdate() { }

	public void ResetAVGSimulationDeltaTime() { }

	public void SpawnCorpse(int count = 1) { }

}

