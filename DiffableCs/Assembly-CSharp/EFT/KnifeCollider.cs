namespace EFT;

public class KnifeCollider : MonoBehaviour
{
	public BoxCollider Collider; //Field offset: 0x20
	public Vector3 CastDirection; //Field offset: 0x28
	public RaycastHit[] hits; //Field offset: 0x38
	public Action OnHit; //Field offset: 0x40
	public float MaxDistance; //Field offset: 0x48
	internal BaseKnifeController Knife; //Field offset: 0x50
	internal Player Owner; //Field offset: 0x58
	public int _hitMask; //Field offset: 0x60
	public int _spiritMask; //Field offset: 0x64
	private Collider[] _hitColliders; //Field offset: 0x68
	private bool _drawDebug; //Field offset: 0x70
	private Vector3 _drawDebugCenter; //Field offset: 0x74
	private Vector3 _drawDebugSize; //Field offset: 0x80
	private Quaternion _drawDebugRotation; //Field offset: 0x8C
	private HashSet _affectedPlayers; //Field offset: 0xA0
	private Vector3 _colliderScaleMultiplier; //Field offset: 0xA8
	public Func GetPlayerOrientation; //Field offset: 0xB8
	public Func GetPlayerBones; //Field offset: 0xC0
	public bool isInfectedPlayer; //Field offset: 0xC8
	private HashSet _hittedColliders; //Field offset: 0xD0
	[Header("Server setting")]
	[SerializeField]
	private float _weaponRootExtension; //Field offset: 0xD8

	public KnifeCollider() { }

	private bool AllCollidersNotYours(Collider hitCollider) { }

	public void Awake() { }

	private void DoSlice(Vector3 startPoint, Vector3 direction, Vector3 castSize) { }

	private PlayerSpirit FindVictimSpirit(Vector3 startPoint, Vector3 direction, Vector3 castSize) { }

	private float GetMaxAvailableDistance(Vector3 startPoint, Vector3 direction, float maxDistance) { }

	private void HitPlayerBodyParts(Vector3 startPoint, Vector3 direction, Player victimPlayer, Vector3 castSize) { }

	public void ManualUpdate() { }

	private void ManualUpdateClient() { }

	private void ManualUpdateServerAI() { }

	private void OnDrawGizmos() { }

	public void OnFire() { }

	public void OnFireEnd() { }

	private int Overlap(Vector3 startPoint, Vector3 direction, int mask, Collider[] colliders, Vector3 castSize) { }

	public void SetBotParameters(Vector3 colliderScaleMultiplier) { }

	private void SyncVictimBodyParts(PlayerSpirit victimSpirit) { }

}

