namespace Audio.SpatialSystem;

public sealed class SoundOcclusionProcessor : IDisposable
{
	private const float CHECK_DISTANCE_SQR_OFFSET = 25; //Field offset: 0x0
	private readonly SpatialAudioOccluder _occluder; //Field offset: 0x10
	private readonly AudioSourceContainer _audioSourceContainer; //Field offset: 0x18
	private readonly Transform _listenerTransform; //Field offset: 0x20
	private readonly AudioSourcePriorityCalculator _priorityCalculator; //Field offset: 0x28
	private bool _isDisposed; //Field offset: 0x30
	private bool _occlusionUpdatesPaused; //Field offset: 0x31
	[CompilerGenerated]
	private EAudioSourcePriority <Priority>k__BackingField; //Field offset: 0x32
	[CompilerGenerated]
	private int <FramesToSkip>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private int <SkippedFrames>k__BackingField; //Field offset: 0x38

	public AudioSourceContainer AudioContainer
	{
		 get { } //Length: 5
	}

	public private int FramesToSkip
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsValid
	{
		 get { } //Length: 106
	}

	public IAudioOccluded Occluder
	{
		 get { } //Length: 5
	}

	public private EAudioSourcePriority Priority
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public int SkippedFrames
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public SoundOcclusionProcessor(AudioSourcePriorityCalculator priorityCalculator, AudioSourceContainer sourceContainer, Transform listenerTransform, AbstractLogger logger) { }

	private void ApplySkipInterval() { }

	public override void Dispose() { }

	protected virtual void Finalize() { }

	public void ForceUpdate() { }

	public AudioSourceContainer get_AudioContainer() { }

	[CompilerGenerated]
	public int get_FramesToSkip() { }

	public bool get_IsValid() { }

	public IAudioOccluded get_Occluder() { }

	[CompilerGenerated]
	public EAudioSourcePriority get_Priority() { }

	[CompilerGenerated]
	public int get_SkippedFrames() { }

	public void ManualLateUpdate() { }

	public void ManualUpdate() { }

	private void OnContainerEmpty(int containerID) { }

	private void OnSourceAdded(BetterSource source) { }

	private void OnSourceRemoved() { }

	public void PauseOcclusionUpdates(bool paused) { }

	[CompilerGenerated]
	private void set_FramesToSkip(int value) { }

	[CompilerGenerated]
	private void set_Priority(EAudioSourcePriority value) { }

	[CompilerGenerated]
	public void set_SkippedFrames(int value) { }

	public void SnapSource(BetterSource source) { }

	private void Subscribe() { }

	private void Unsubscribe() { }

	public void UpdateOcclusionEffects(EOcclusionApply apply = 0) { }

	public void UpdatePriority() { }

}

