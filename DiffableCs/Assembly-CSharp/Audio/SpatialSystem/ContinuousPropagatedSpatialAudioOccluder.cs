namespace Audio.SpatialSystem;

public class ContinuousPropagatedSpatialAudioOccluder : SpatialAudioOccluder
{
	private readonly HashSet _processedSources; //Field offset: 0x70
	private AbstractSpatialAudioCalculator _propagationCalculator; //Field offset: 0x78
	private Vector3 _prevSourcePos; //Field offset: 0x80
	private Vector3 _prevListenerPos; //Field offset: 0x8C
	private bool _isPositionIdentical; //Field offset: 0x98
	private bool _forceUpdate; //Field offset: 0x99
	private bool _updateInProgress; //Field offset: 0x9A
	private Action _unsubscribeOnDestroy; //Field offset: 0xA0

	public ContinuousPropagatedSpatialAudioOccluder(SpatialAudioSystem spatialSystem, Transform listenerTransform, AbstractSpatialAudioCalculator propagationCalculator, AbstractLogger logger) { }

	private bool ComparePositions(Vector3 soundPos, Vector3 listenerPos) { }

	public virtual void Dispose() { }

	protected virtual void OnForceUpdate() { }

	protected virtual void OnLateUpdate() { }

	private void OnPortalStatusChanged(PortalDataUpdateEvent stateChangedEvent) { }

	protected virtual void OnUpdate() { }

	protected virtual void OnUpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

	public virtual void SetAudioSourceContainer(AudioSourceContainer sourceContainer) { }

}

