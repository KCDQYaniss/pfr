namespace Audio.SpatialSystem;

public sealed class ContinuousSpatialAudioOccluder : SpatialAudioOccluder
{
	private readonly HashSet _processedSources; //Field offset: 0x70
	private AbstractSpatialAudioCalculator _obstructionCalculator; //Field offset: 0x78
	private AbstractSpatialAudioCalculator _propagationCalculator; //Field offset: 0x80
	private Vector3 _prevSourcePos; //Field offset: 0x88
	private Vector3 _prevListenerPos; //Field offset: 0x94
	private bool _isPositionIdentical; //Field offset: 0xA0
	private bool _forceUpdate; //Field offset: 0xA1
	private bool _updateInProgress; //Field offset: 0xA2
	private Action _unsubscribeOnDestroy; //Field offset: 0xA8

	public ContinuousSpatialAudioOccluder(SpatialAudioSystem spatialSystem, Transform listenerTransform, AbstractSpatialAudioCalculator obstructionCalculator, AbstractSpatialAudioCalculator propagationCalculator, AbstractLogger logger) { }

	private bool ComparePositions(Vector3 soundPos, Vector3 listenerPos) { }

	public virtual void Dispose() { }

	protected virtual void OnForceUpdate() { }

	protected virtual void OnLateUpdate() { }

	private void OnPortalStatusChanged(PortalDataUpdateEvent stateChangedEvent) { }

	protected virtual void OnUpdate() { }

	protected virtual void OnUpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

	public virtual void SetAudioSourceContainer(AudioSourceContainer sourceContainer) { }

}

