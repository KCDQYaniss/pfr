namespace Audio.SpatialSystem;

[RequireComponent(typeof(AudioLowPassFilter))]
public sealed class SpatialLowPassFilter : AudioFilter
{
	private const float LERP_MULTIPLIER = 10; //Field offset: 0x0
	private const float LEVEL_THRESHOLD = 10; //Field offset: 0x0
	private const float DEFAULT_FREQUENCY = 22000; //Field offset: 0x0
	[SerializeField]
	private AudioLowPassFilter _filter; //Field offset: 0x28
	private float _maxFrequency; //Field offset: 0x30
	private float _lowerFrequency; //Field offset: 0x34
	private AnimationCurve _obstructionFilterCurve; //Field offset: 0x38
	private AnimationCurve _propagationFilterCurve; //Field offset: 0x40
	private AnimationCurve _currentCurve; //Field offset: 0x48
	private float _newFilterFreq; //Field offset: 0x50
	[CompilerGenerated]
	private float <CutoffFrequency>k__BackingField; //Field offset: 0x54

	public private float CutoffFrequency
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public SpatialLowPassFilter() { }

	protected virtual void CalculateFrequency(float time) { }

	private bool CanUpdate() { }

	[CompilerGenerated]
	public float get_CutoffFrequency() { }

	protected virtual void OnAwake() { }

	public virtual void ResetFilter() { }

	[CompilerGenerated]
	private void set_CutoffFrequency(float value) { }

	public virtual void SetActive(bool active) { }

	public virtual void SetFilterParams(float value, bool applyImmediately = false, ESoundOcclusionType occlusionType = 3) { }

	public void SetHighestFrequency(float frequency) { }

	public void SetLowerFrequency(float frequency) { }

	public void SetOcclusionCurves(AnimationCurve obstructionCurve, AnimationCurve propagationCurve) { }

	public virtual void SetResonance(float value) { }

}

