namespace Audio.SpatialSystem;

public sealed class FastSoundObstructionCalculator : SoundObstructionCalculator
{
	private float _obstructionEffect; //Field offset: 0x28

	public FastSoundObstructionCalculator(SpatialAudioSystem audioSystem) { }

	public virtual float CalculateScore(Vector3 listenerPosition, AudioSourceContainer sourceContainer) { }

	public virtual float GetScore() { }

	private float ObstructionCast(Vector3 origin, Vector3 end) { }

	protected virtual void OnDispose() { }

}

