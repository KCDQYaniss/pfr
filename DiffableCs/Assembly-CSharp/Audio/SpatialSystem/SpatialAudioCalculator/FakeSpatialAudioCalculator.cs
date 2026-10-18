namespace Audio.SpatialSystem.SpatialAudioCalculator;

public class FakeSpatialAudioCalculator : AbstractSpatialAudioCalculator
{

	public FakeSpatialAudioCalculator(uint propagationDepth, SpatialAudioSystem audioSystem) { }

	public FakeSpatialAudioCalculator(AudioOcclusionSettings occlusionSettings, SpatialAudioSystem system) { }

	public virtual float GetScore() { }

}

