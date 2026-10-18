namespace Audio.SpatialSystem;

public sealed class CombinedSpatialAudioOccluder : SpatialAudioOccluder
{
	private readonly AudioOcclusionSettings _settings; //Field offset: 0x70
	private float _smoothedPropagationEffect; //Field offset: 0x78
	private float _smoothedObstructionEffect; //Field offset: 0x7C
	private bool _lastPropagationActive; //Field offset: 0x80
	private bool _lastIsPropagationActive; //Field offset: 0x81
	private float _lastPropagationEffect; //Field offset: 0x84
	private float _lastObstructionEffect; //Field offset: 0x88
	private readonly HashSet _processedSources; //Field offset: 0x90
	private AbstractSpatialAudioCalculator _obstructionCalculator; //Field offset: 0x98
	private AbstractSpatialAudioCalculator _propagationCalculator; //Field offset: 0xA0
	private readonly SpatialAudioSystem _audioSystem; //Field offset: 0xA8
	private bool _forceUpdate; //Field offset: 0xB0
	private bool _scoreReady; //Field offset: 0xB1
	private Action _unsubscribeOnDestroy; //Field offset: 0xB8

	public CombinedSpatialAudioOccluder(SpatialAudioSystem spatialSystem, Transform listenerTransform, AudioOcclusionSettings occlusionSettings, AbstractSpatialAudioCalculator obstructionCalculator, AbstractSpatialAudioCalculator propagationCalculator, AbstractLogger logger) { }

	public virtual void ApplyCurrentOcclusionToSource(BetterSource source, bool snapFilters = true) { }

	public virtual void Dispose() { }

	private void GetRawScores(out float rawPropagation, out float rawObstruction) { }

	protected virtual void OnForceUpdate() { }

	protected virtual void OnLateUpdate() { }

	private void OnPortalStatusChanged(PortalDataUpdateEvent stateChangedEvent) { }

	protected virtual void OnUpdate() { }

	protected virtual void OnUpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

	public virtual void SetAudioSourceContainer(AudioSourceContainer sourceContainer) { }

	private void SmoothEffects(bool instant) { }

}

