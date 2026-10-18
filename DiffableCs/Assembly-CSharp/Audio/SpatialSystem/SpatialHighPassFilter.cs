namespace Audio.SpatialSystem;

[RequireComponent(typeof(AudioHighPassFilter))]
public class SpatialHighPassFilter : AudioFilter
{
	private const float MIN_CUTOFF_FREQUENCY = 10; //Field offset: 0x0
	private const float LERP_MULTIPLIER = 10; //Field offset: 0x0
	private const float LEVEL_THRESHOLD = 1; //Field offset: 0x0
	[SerializeField]
	private AudioHighPassFilter _filter; //Field offset: 0x28
	private float _newFilterFreq; //Field offset: 0x30
	private AnimationCurve _filterCurve; //Field offset: 0x38
	private float _maxCutoffFrequency; //Field offset: 0x40
	[CompilerGenerated]
	private float <CutoffFrequency>k__BackingField; //Field offset: 0x44

	public private float CutoffFrequency
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public SpatialHighPassFilter() { }

	protected virtual void CalculateFrequency(float time) { }

	private bool CanUpdate() { }

	[CompilerGenerated]
	public float get_CutoffFrequency() { }

	protected virtual void OnAwake() { }

	public virtual void ResetFilter() { }

	[CompilerGenerated]
	private void set_CutoffFrequency(float value) { }

	public virtual void SetActive(bool active) { }

	public void SetFilterCurve(AnimationCurve filterCurve) { }

	public virtual void SetFilterParams(float value, bool applyImmediately = false, ESoundOcclusionType occlusionType = 3) { }

	public void SetMaxCutoffFrequency(float frequency) { }

	public virtual void SetResonance(float value) { }

}

