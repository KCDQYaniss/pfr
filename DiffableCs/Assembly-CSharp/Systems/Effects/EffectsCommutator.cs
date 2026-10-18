namespace Systems.Effects;

public class EffectsCommutator : MonoBehaviour
{
	private const int HAMMER_HIT_BODY = 3; //Field offset: 0x0
	private const int HAMMER_HIT = 4; //Field offset: 0x0
	[SerializeField]
	private Vector2 _minMaxBleedingSpawnDelta; //Field offset: 0x20
	private Effect[] _effects; //Field offset: 0x28
	private List _hitPointsOfFrame; //Field offset: 0x30
	private readonly List _playerBleedingDecalTimes; //Field offset: 0x38

	public EffectsCommutator() { }

	private static void CheckEnvironmentHitAfterBodyHit(Shot fragment) { }

	private bool IsHitPointAlreadyProcessed(Vector3 hitPoint) { }

	private void LateUpdate() { }

	public void PlayerMeshesHit(List renderers, Vector3 point, Vector3 direction) { }

	public void PlayHitEffect(Shot info, PlayerHitInfo playerHitInfo) { }

	public void PlayKnifeHitEffect(DamageInfo info) { }

	public void PlayKnifeHitEffect(BallisticCollider collider, Vector3 hitPoint, Vector3 hitNormal, Knife knife) { }

	public void StartBleedingForPlayer(IPlayer player) { }

	public void StopBleedingForPlayer(IPlayer player) { }

	private void Update() { }

	public void UpdatePlayersBleedings() { }

}

