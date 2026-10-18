namespace Audio.SpatialSystem;

public interface ISpatialAudioOccluder
{

	public void Dispose() { }

	public void SetAudioSourceContainer(AudioSourceContainer sourceContainer) { }

	public void UpdateOcclusionEffects(AudioSourceContainer sourceContainer, EOcclusionApply apply) { }

}

