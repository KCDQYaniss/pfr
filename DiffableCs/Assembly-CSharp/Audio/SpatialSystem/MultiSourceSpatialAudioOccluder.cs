namespace Audio.SpatialSystem;

public class MultiSourceSpatialAudioOccluder : SpatialAudioOccluder
{
	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x70
	private readonly Dictionary _activePropagationCalculatorsByContID; //Field offset: 0x78
	private readonly Dictionary _activeTransmissionCalculatorsByContID; //Field offset: 0x80
	private readonly Dictionary _activeContainersByID; //Field offset: 0x88
	private readonly Dictionary _updatedContainersByID; //Field offset: 0x90
	private readonly List _containersToRemove; //Field offset: 0x98

	public MultiSourceSpatialAudioOccluder(SpatialAudioSystem audioSystem, Transform listenerTransform, AbstractLogger logger) { }

	protected virtual void ApplyOcclusionToSource(BetterSource source, bool snapFilters = false) { }

	public virtual void Dispose() { }

	private ESoundOcclusionType GetTargetOcclusionType(AudioSourceContainer container) { }

	protected virtual void OnLateUpdate() { }

	protected virtual void OnUpdate() { }

	protected virtual void OnUpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

	private void ProcessPendingRemovals() { }

	public virtual void SetAudioSourceContainer(AudioSourceContainer sourceContainer) { }

}

