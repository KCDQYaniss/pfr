namespace Audio.SpatialSystem;

public abstract class AudioFilter : MonoBehaviour, IManualUpdated
{
	[CompilerGenerated]
	private float <FilterLevel>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; //Field offset: 0x24
	protected bool _isActive; //Field offset: 0x25

	public float FilterLevel
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	protected private bool Initialized
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected AudioFilter() { }

	private void Awake() { }

	protected abstract void CalculateFrequency(float dt) { }

	protected override void Disable() { }

	protected override void Enable() { }

	[CompilerGenerated]
	public float get_FilterLevel() { }

	[CompilerGenerated]
	protected bool get_Initialized() { }

	public override void ManualUpdate() { }

	protected override void OnAwake() { }

	public override void OnDestroy() { }

	public abstract void ResetFilter() { }

	[CompilerGenerated]
	protected void set_FilterLevel(float value) { }

	[CompilerGenerated]
	private void set_Initialized(bool value) { }

	public override void SetActive(bool active) { }

	public abstract void SetFilterParams(float value, bool applyImmediately = false, ESoundOcclusionType occlusionType = 3) { }

	public abstract void SetResonance(float value) { }

	protected override void Subscribe() { }

	protected override void Unsubscribe() { }

}

