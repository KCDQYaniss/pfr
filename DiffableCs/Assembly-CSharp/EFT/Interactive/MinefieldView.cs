namespace EFT.Interactive;

public sealed class MinefieldView : MonoBehaviour
{
	private const float RAYCAST_LENGTH = 3; //Field offset: 0x0
	[SerializeField]
	private Minefield _minefield; //Field offset: 0x20
	[SerializeField]
	private string _effectName; //Field offset: 0x28
	[SerializeField]
	private float _cameraShakeRange; //Field offset: 0x30
	[SerializeField]
	private Vector3 _explosionLocalPosition; //Field offset: 0x34
	[SerializeField]
	private bool _raycastToTheGround; //Field offset: 0x40
	[SerializeField]
	private LayerMask _raycastMask; //Field offset: 0x44

	public MinefieldView() { }

	private static void ApplyMinefieldHitReaction(IPlayer zonePlayer, Vector3 explosionPosition) { }

	private void Awake() { }

	private void MinefieldOnPlayerShotEvent(IObserverToPlayerBridge player, BorderZone zone, float arg3, bool willHit) { }

	private void OnDestroy() { }

}

