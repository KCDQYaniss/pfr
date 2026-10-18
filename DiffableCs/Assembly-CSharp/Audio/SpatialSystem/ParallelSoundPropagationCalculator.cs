namespace Audio.SpatialSystem;

public sealed class ParallelSoundPropagationCalculator : AbstractSpatialAudioCalculator
{
	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x20
	private float _qualityFactor; //Field offset: 0x28
	private float _propagationScore; //Field offset: 0x2C
	private uint _prevRoomPairID; //Field offset: 0x30
	private bool _isPositionChanged; //Field offset: 0x34
	private bool _isForceUpdateRequested; //Field offset: 0x35
	private readonly PositionChangeChecker _positionChangeChecker; //Field offset: 0x38
	private bool _earlyOutThisFrame; //Field offset: 0x40
	private float _maxCompressionQualityFactor; //Field offset: 0x44
	private SoundPropagationJobScheduler _propagationJobScheduler; //Field offset: 0x48

	public JobHandle LastHandle
	{
		 get { } //Length: 36
	}

	public ParallelSoundPropagationCalculator(SpatialAudioSystem system) { }

	public JobHandle get_LastHandle() { }

	public virtual float GetScore() { }

	protected virtual void OnDispose() { }

	protected virtual void OnLateUpdate() { }

	protected virtual void OnReset() { }

	protected virtual void OnUpdate(AudioSourceContainer sourceContainer, Vector3 listenerPosition, bool forceUpdate = false) { }

	protected virtual void OnWarmUp() { }

	private void SetImmediateScore(float score) { }

}

