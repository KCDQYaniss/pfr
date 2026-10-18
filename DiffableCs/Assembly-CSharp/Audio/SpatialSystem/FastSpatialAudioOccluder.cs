namespace Audio.SpatialSystem;

public class FastSpatialAudioOccluder : SpatialAudioOccluder
{
	private readonly AbstractSpatialAudioCalculator _obstructionCalculator; //Field offset: 0x70

	public FastSpatialAudioOccluder(SpatialAudioSystem audioSystem, Transform listenerTransform, AbstractSpatialAudioCalculator obstructionCalculator, AbstractLogger logger) { }

	public virtual void Dispose() { }

	protected virtual void OnUpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

}

