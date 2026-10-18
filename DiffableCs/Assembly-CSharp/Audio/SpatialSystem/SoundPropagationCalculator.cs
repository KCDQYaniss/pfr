namespace Audio.SpatialSystem;

public sealed class SoundPropagationCalculator : AbstractSpatialAudioCalculator
{
	private const int MIN_PROPAGATION_EFFECT = 0; //Field offset: 0x0
	private const int MAX_PROPAGATION_EFFECT = 1; //Field offset: 0x0
	private const float MIN_VECTOR_MAGNITUDE = 0.05; //Field offset: 0x0
	private readonly Dictionary _portalClosestPointNodes; //Field offset: 0x20
	private readonly List _routeNodes; //Field offset: 0x28
	private readonly uint _maxPropagationDepths; //Field offset: 0x30
	private float _currentLowestCost; //Field offset: 0x34

	public SoundPropagationCalculator(uint maxPropagationDepths, SpatialAudioSystem audioSystem) { }

	public virtual float CalculateScore(Vector3 listenerPosition, AudioSourceContainer sourceContainer) { }

	private Vector3 ClampPointInBounds(Vector3 point, Collider portalCollider) { }

	private void GetRouteCostAndDistance(out float cost, out float distance) { }

	public virtual float GetScore() { }

	private void UpdatePortalClosestPoints(Vector3 listenerPosition, Vector3 sourcePosition, BaseSpatialAudioPortal portal) { }

	private void UpdateRouteNodes(Vector3 sourcePosition, Vector3 listenerPosition, BaseSpatialAudioPortal[] portals) { }

}

