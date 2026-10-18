namespace Audio.SpatialSystem;

public abstract class AbstractSpatialAudioCalculator : ISpatialAudioCalculator, IDisposable
{
	protected const float MAX_OCCLUSION_SCORE = 1; //Field offset: 0x0
	protected const float MIN_OCCLUSION_SCORE = 0; //Field offset: 0x0
	protected readonly SpatialAudioSystem _audioSystem; //Field offset: 0x10
	private bool _isDisposed; //Field offset: 0x18
	[CompilerGenerated]
	private bool <ScoreUpdated>k__BackingField; //Field offset: 0x19

	public override bool ScoreUpdated
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected AbstractSpatialAudioCalculator(SpatialAudioSystem audioSystem) { }

	public override float CalculateScore(Vector3 listenerPosition, AudioSourceContainer sourceContainer) { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	[CompilerGenerated]
	public override bool get_ScoreUpdated() { }

	public abstract float GetScore() { }

	public void ManualLateUpdate() { }

	public void ManualUpdate(AudioSourceContainer sourceContainer, Vector3 listenerPosition, bool forceUpdate = false) { }

	protected override void OnDispose() { }

	protected override void OnLateUpdate() { }

	protected override void OnReset() { }

	protected override void OnUpdate(AudioSourceContainer sourceContainer, Vector3 listenerPosition, bool forceUpdate = false) { }

	protected override void OnWarmUp() { }

	public void Reset() { }

	[CompilerGenerated]
	protected override void set_ScoreUpdated(bool value) { }

	public void WarmUp() { }

}

