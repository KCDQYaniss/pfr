namespace CommonAssets.Scripts.ArtilleryShelling.Client;

public class ArtilleryProjectileClient : MonoBehaviour
{
	private const float FLY_LERP_VALUE = 0.3; //Field offset: 0x0
	private const string MORTAR_EFFECT_NAME = "Artillery_mine"; //Field offset: 0x0
	public int id; //Field offset: 0x20
	public Action ExplosionEvent; //Field offset: 0x28
	private Vector3 _targetPosition; //Field offset: 0x30
	private bool _flyOn; //Field offset: 0x3C
	private ArtilleryProjectileExplosiveItem _explosiveItem; //Field offset: 0x40
	private bool _hasAuthority; //Field offset: 0x48

	private static IBallisticsCalculator Calculator
	{
		private get { } //Length: 93
	}

	public ArtilleryProjectileClient() { }

	public void Deinit() { }

	private void Explosion(ArtilleryProjectileExplosiveItem mineData, Vector3 explosionPosition, IBallisticsCalculator ballisticsCalculator) { }

	private void FlyProcess() { }

	private static IBallisticsCalculator get_Calculator() { }

	private DamageInfo GetDamageInfo() { }

	public void Init(int projectileId, bool hasAuthority) { }

	private void OnExplosion() { }

	public void SetExplosiveItemParams(ArtilleryProjectileExplosionParams explosiveParams) { }

	public void SyncProjectileState(ref ArtilleryProjectileSyncPacket packet) { }

	private void Update() { }

}

